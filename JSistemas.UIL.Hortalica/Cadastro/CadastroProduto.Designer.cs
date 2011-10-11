namespace JSistemas.UIL.Hortalica.Cadastro
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitulos.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulos
            // 
            this.panelTitulos.Controls.Add(this.lblNome);
            this.panelTitulos.Controls.Add(this.lblPrecoUnitario);
            this.panelTitulos.Size = new System.Drawing.Size(132, 135);
            this.panelTitulos.Controls.SetChildIndex(this.tituloIdentificador, 0);
            this.panelTitulos.Controls.SetChildIndex(this.lblPrecoUnitario, 0);
            this.panelTitulos.Controls.SetChildIndex(this.lblNome, 0);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.txtNome);
            this.panelCampos.Controls.Add(this.txtPreco);
            this.panelCampos.Location = new System.Drawing.Point(135, 3);
            this.panelCampos.Size = new System.Drawing.Size(446, 135);
            this.panelCampos.Controls.SetChildIndex(this.lblID, 0);
            this.panelCampos.Controls.SetChildIndex(this.txtPreco, 0);
            this.panelCampos.Controls.SetChildIndex(this.txtNome, 0);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tituloIdentificador
            // 
            this.tituloIdentificador.Location = new System.Drawing.Point(55, 9);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 34);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 60);
            this.txtPreco.MaxLength = 18;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(46, 63);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(74, 13);
            this.lblPrecoUnitario.TabIndex = 5;
            this.lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(85, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.testeToolStripMenuItem1.Text = "Teste";
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(594, 272);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produto";
            this.panelTitulos.ResumeLayout(false);
            this.panelTitulos.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;

    }
}
