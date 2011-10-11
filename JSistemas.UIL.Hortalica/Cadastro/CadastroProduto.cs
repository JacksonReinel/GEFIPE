using JSistemas.UIL.Base.Cadastro;
using JSistemas.DAO.Hortalica;
using System;
using JSistemas.BLL.Hortalica;

namespace JSistemas.UIL.Hortalica.Cadastro
{
    public partial class CadastroProduto : CadastroBase
    {
        private DAOProduto _produto;
        private DAOProduto Produto
        {
            get
            {
                if (this._produto == null)
                { this._produto = new DAOProduto(); }
                return _produto;
            }
        }

        public CadastroProduto()
        { InitializeComponent(); }

        private String FNome
        {
            get { return this.txtNome.Text.ToUpper(); }
            set { this.txtNome.Text = value; }
        }

        private Decimal FPreco
        {
            get
            {
                try
                { return Convert.ToDecimal(this.txtPreco.Text); }
                catch
                { throw new Exception("O Preço Unitário não é válido!"); }
            }
            set { this.txtPreco.Text = value.ToString("0.00"); }
        }

        protected override void LerFormulario()
        {
            this.Produto.Nome = this.FNome;
            this.Produto.Preco = this.FPreco;
        }

        protected override void CarregarFormulario()
        {
            this.FNome = this.Produto.Nome;
            this.FPreco = this.Produto.Preco;
            this.FId = this.Produto.Id;
        }

        protected override void Gravar()
        { BLLHortalica.Produto.Gravar(this.Produto); }
    }
}
