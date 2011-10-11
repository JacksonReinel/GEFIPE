using System;
using JSistemas.DAL.Base;
using JSistemas.DAO.Hortalica;
using System.Data.SqlClient;

namespace JSistemas.DAL.Hortalica
{
    public class DALProduto : DALBase
    {
        public void Gravar(DAOProduto produto)
        {
            SqlCommand cmd;

            if (produto.Id == Guid.Empty)
            {
                produto.Id = Guid.NewGuid();
                cmd = base.GerarComando(SQL_INSERT);
            }
            else
            { cmd = base.GerarComando(SQL_UPDATE); }

            base.AdicionarParametro(cmd, "@ID", produto.Id);
            base.AdicionarParametro(cmd, "@NOME", produto.Nome);
            base.AdicionarParametro(cmd, "@PRECO", produto.Preco);

            try
            {
                base.IniciarTransacao();
                base.ExecutarComando(cmd);
                base.EncerrarTransacao();
            }
            catch (Exception ex)
            {
                base.DesfazerTransacao();
                throw new Exception("DALProduto.Gravar" + Environment.NewLine + ex.Message);
            }
            finally
            { base.Desconectar(); }

        }

        const String SQL_INSERT = "INSERT INTO PRODUTO (PRODUTO_ID, PRODUTO_NOME, PRODUTO_PRECO) VALUES (@ID, @NOME, @PRECO)";
        const String SQL_UPDATE = "UPDATE PRODUTO SET PRODUTO_NOME = @NOME, PRODUTO_PRECO = @PRECO WHERE PRODUTO_ID = @ID";
    }
}
