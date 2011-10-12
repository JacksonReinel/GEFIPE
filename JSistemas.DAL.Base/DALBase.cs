using System.Data.SqlClient;
using System;
using System.Data;

namespace JSistemas.DAL.Base
{
    public class DALBase
    {
        private static SqlConnection _conexao;
        private SqlTransaction _transacao;

        protected SqlConnection Conexao
        {
            get
            {
                if (_conexao == null)
                { _conexao = this.GerarConexao(); }
                return _conexao;
            }
            set { _conexao = value; }
        }

        private SqlConnection GerarConexao()
        {
            SqlConnectionStringBuilder conf = new SqlConnectionStringBuilder();
            conf.DataSource = "note-jackson,1433";
            conf.UserID = "sa";
            conf.Password = "cidadao";
            conf.InitialCatalog = "JSISTEMAS";

            return new SqlConnection(conf.ConnectionString);
        }

        public SqlCommand GerarComando(String sql)
        {
            SqlCommand cmd = this.Conexao.CreateCommand();
            cmd.CommandText = sql;
            return cmd;
        }

        public void ExecutarComando(String sql)
        { this.ExecutarComando(this.GerarComando(sql)); }

        protected SqlDataReader AbrirComando(SqlCommand cmd)
        {
            this.Conectar();
            SqlDataReader leitor = cmd.ExecuteReader();
            if (leitor != null && !leitor.IsClosed && !leitor.HasRows)
            {
                leitor.Close();
                leitor = null;
            }
            return leitor;
        }

        public void ExecutarComando(SqlCommand cmd)
        {
            this.Conectar();
            cmd.Transaction = this._transacao;
            cmd.ExecuteNonQuery();
        }

        private void Conectar()
        {
            if (this.Conexao.State != ConnectionState.Open)
            { this.Conexao.Open(); }
        }

        public void AdicionarParametro(SqlCommand cmd, String nome, Object valor)
        { cmd.Parameters.AddWithValue(nome, valor); }

        public void DesfazerTransacao()
        {
            if (this._transacao != null && this._transacao.Connection != null)
            { this._transacao.Rollback(); }
        }

        public void EncerrarTransacao()
        {
            if (this._transacao != null && this._transacao.Connection != null)
            { this._transacao.Commit(); }
        }

        public void IniciarTransacao()
        {
            this.Conectar();
            if (this._transacao == null || this._transacao.Connection == null)
            { this._transacao = this.Conexao.BeginTransaction(); }
        }

        public void Desconectar()
        {
            if (this.Conexao.State != ConnectionState.Closed)
            { this.Conexao.Close(); }
        }
    }
}
