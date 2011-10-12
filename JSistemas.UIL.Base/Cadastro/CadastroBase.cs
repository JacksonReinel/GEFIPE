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
                Application.DoEvents();
            }
        }

        protected String MensagemInfo
        {
            set
            {
                this.lblInfo.Text = value;
                this.lblInfo.ForeColor = Color.Blue;
                Application.DoEvents();
            }
        }

        protected String MensagemStatus
        {
            set
            {
                this.labelTopoStatusBase.Text = value;
                Application.DoEvents();
            }
        }

        protected Guid FId
        {
            get
            {
                if (this.lblID.Text.Trim() == String.Empty)
                    return Guid.Empty;
                else
                    return Guid.Parse(this.lblID.Text);
            }
            set { this.lblID.Text = value.ToString().ToUpper(); }
        }

        public CadastroBase()
        {
            InitializeComponent();
            this.gridConsulta.AutoGenerateColumns = false;
            this.RealizarPesquisa();
        }

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
                this.MensagemInfo = "Gravando, aguarde...";
                this.LerFormularioBase();
                this.Gravar();
                this.CarregarFormularioBase();
                this.miOpcoesExcluirBase.Enabled = this.FId != Guid.Empty;
                this.MensagemInfo = "Gravado com sucesso!";
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
            if (String.Concat(this.lblInfo.Text, this.labelTopoStatusBase.Text).Trim() != String.Empty)
            {
                Clipboard.SetText(String.Concat(
                  this.labelTopoStatusBase.Text.ToUpper(),
                  "\r\n",
                  "\r\n",
                  this.lblInfo.Text).Trim());
            }
        }

        private void botaoOpcoesBase_Click(object sender, EventArgs e)
        { menuOpcoesBase.Show(this.botaoOpcoesBase, 16, 16); }

        private void labelTopoStatus_Click(object sender, EventArgs e)
        {

        }

        private void tabConsulta_Enter(object sender, EventArgs e)
        {
            this.botaoGravar.Enabled = false;
            this.botaoCancelar.Enabled = false;
            this.miOpcoesExcluirBase.Enabled = this.FId != Guid.Empty;
            this.MensagemStatus = "Consulta";
            this.MensagemInfo = "F4 - Atualizar Consulta";
        }

        private void tabCadastro_Enter(object sender, EventArgs e)
        {
            this.MensagemStatus = "Cadastro";
            this.MensagemInfo = String.Empty;
            this.botaoGravar.Enabled = true;
            this.botaoCancelar.Enabled = true;
            this.miOpcoesExcluirBase.Enabled = this.FId != Guid.Empty;
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            this.NovoBase();
        }

        private void NovoBase()
        {
            try
            {
                this.MensagemStatus = "Novo Registro";
                this.MensagemInfo = String.Empty;
                tabControl1.SelectedTab = tabCadastro;
                this.Novo();
                this.CarregarFormulario();
            }
            catch (Exception ex)
            { this.MensagemErro = ex.Message; }
        }

        protected virtual void Novo()
        { throw new NotImplementedException("Novo não implementado"); }

        protected virtual void FocusControlePadrao() { }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        { this.ExcluirBase(); }

        private void ExcluirBase()
        {
            try
            {
                this.MensagemStatus = "Excluindo registro";
                DialogResult resposta = MessageBox.Show(
                    "Confirmação exclusão desse registro?",
                    "Confirmação do usuário",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (resposta != DialogResult.Yes)
                { return; }
                this.Excluir();
                this.NovoBase();
                this.MensagemInfo = "Excluido com sucesso!";
            }
            catch (Exception ex)
            { this.MensagemErro = ex.Message; }
        }

        protected virtual void Excluir()
        { throw new NotImplementedException("Excluir não implementado!"); }

        private void CadastroBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { this.Close(); }
            else if (e.KeyCode == Keys.F4 && tabControl1.SelectedTab == tabConsulta)
            { this.RealizarPesquisaBase(); }
            else if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.F5)
            { this.NovoBase(); }
            else if (e.KeyCode == Keys.F2)
            { tabControl1.SelectedTab = tabConsulta; }
            else if (e.KeyCode == Keys.F3)
            { tabControl1.SelectedTab = tabCadastro; }
        }

        private void RealizarPesquisaBase()
        {
            try
            {
                this.MensagemStatus = "Consulta";
                this.MensagemInfo = "Consultando...";
                this.RealizarPesquisa();
                this.MensagemInfo = "Consulta Concluida!\r\nF4 - Atualiza Consulta";
            }
            catch (Exception ex)
            { this.MensagemErro = ex.Message; }
        }

        protected virtual void RealizarPesquisa() { }

        protected DataGridViewTextBoxColumn AdicionarColuna(String campo, String titulo = "")
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = campo;
            col.HeaderText = titulo;
            this.gridConsulta.Columns.Add(col);
            return col;
        }
    }
}
