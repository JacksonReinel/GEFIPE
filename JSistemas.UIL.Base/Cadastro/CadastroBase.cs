using System;
using System.Drawing;
using JSistemas.BLL.Base;
using System.Windows.Forms;

namespace JSistemas.UIL.Base.Cadastro
{
    public partial class CadastroBase : UILBase
    {
        protected String MensagemErro
        {
            set
            {
                this.lblInfo.Text = value;
                this.lblInfo.ForeColor = Color.Red;
            }
        }

        protected String MensagemInfo
        {
            set
            {
                this.lblInfo.Text = value;
                this.lblInfo.ForeColor = Color.Blue;
            }
        }

        protected Guid FId { set { this.lblID.Text = value.ToString().ToUpper(); } }

        public CadastroBase()
        { InitializeComponent(); }

        private void botaoGravar_Click(object sender, System.EventArgs e)
        { this.GravarBase(); }

        #region Base

        private void ExibirMensagemErro(Exception ex)
        {
            if (ex is NotImplementedException)
            { this.MensagemErro = "Método não implementado" + Environment.NewLine + ex.Message; }
            else { this.MensagemErro = ex.Message; }
        }

        private void GravarBase()
        {
            try
            {
                this.LerFormularioBase();
                this.Gravar();
                this.CarregarFormularioBase();
            }
            catch (Exception ex)
            { this.ExibirMensagemErro(ex); }
        }

        private void CarregarFormularioBase()
        { this.CarregarFormulario(); }


        private void LerFormularioBase()
        { this.LerFormulario(); }

        #endregion

        protected virtual void LerFormulario()
        { throw new NotImplementedException("LerFormulario"); }

        protected virtual void CarregarFormulario()
        { throw new NotImplementedException("CarregarFormulario"); }

        protected virtual void Gravar()
        { throw new NotImplementedException("Gravar"); }

        private void lblID_Click(object sender, EventArgs e)
        {
            if (this.lblID.Text != String.Empty)
            { Clipboard.SetText(this.lblID.Text); }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            if (this.lblInfo.Text != String.Empty)
            { Clipboard.SetText(this.lblInfo.Text); }
        }
    }
}
