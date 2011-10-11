namespace JSistemas.UIL.Base.Cadastro
{
    partial class CadastroBase
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
            this.components = new System.ComponentModel.Container();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelInferiorEsquerdo = new System.Windows.Forms.Panel();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTopoBase = new System.Windows.Forms.Panel();
            this.labelTopoStatus = new System.Windows.Forms.Label();
            this.botaoOpcoesBase = new System.Windows.Forms.Button();
            this.menuOpcoesBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelTitulos = new System.Windows.Forms.Panel();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.panelInferior.SuspendLayout();
            this.panelInferiorEsquerdo.SuspendLayout();
            this.panelTopoBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.lblID);
            this.panelInferior.Controls.Add(this.panel2);
            this.panelInferior.Controls.Add(this.lblInfo);
            this.panelInferior.Controls.Add(this.panelInferiorEsquerdo);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 237);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(594, 55);
            this.panelInferior.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.Info;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblID.Location = new System.Drawing.Point(260, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(334, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Novo Registro";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 55);
            this.panel2.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(259, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(335, 55);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // panelInferiorEsquerdo
            // 
            this.panelInferiorEsquerdo.Controls.Add(this.botaoExcluir);
            this.panelInferiorEsquerdo.Controls.Add(this.label2);
            this.panelInferiorEsquerdo.Controls.Add(this.botaoCancelar);
            this.panelInferiorEsquerdo.Controls.Add(this.label1);
            this.panelInferiorEsquerdo.Controls.Add(this.botaoGravar);
            this.panelInferiorEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInferiorEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelInferiorEsquerdo.Name = "panelInferiorEsquerdo";
            this.panelInferiorEsquerdo.Padding = new System.Windows.Forms.Padding(6);
            this.panelInferiorEsquerdo.Size = new System.Drawing.Size(259, 55);
            this.panelInferiorEsquerdo.TabIndex = 0;
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoExcluir.Location = new System.Drawing.Point(176, 6);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 43);
            this.botaoExcluir.TabIndex = 3;
            this.botaoExcluir.Text = "&Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(166, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 43);
            this.label2.TabIndex = 5;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoCancelar.Location = new System.Drawing.Point(91, 6);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 43);
            this.botaoCancelar.TabIndex = 2;
            this.botaoCancelar.Text = "&Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 43);
            this.label1.TabIndex = 4;
            // 
            // botaoGravar
            // 
            this.botaoGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoGravar.Location = new System.Drawing.Point(6, 6);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 43);
            this.botaoGravar.TabIndex = 1;
            this.botaoGravar.Text = "&Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 1);
            this.panel1.TabIndex = 1;
            // 
            // panelTopoBase
            // 
            this.panelTopoBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopoBase.Controls.Add(this.labelTopoStatus);
            this.panelTopoBase.Controls.Add(this.botaoOpcoesBase);
            this.panelTopoBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopoBase.Location = new System.Drawing.Point(0, 0);
            this.panelTopoBase.Name = "panelTopoBase";
            this.panelTopoBase.Size = new System.Drawing.Size(594, 32);
            this.panelTopoBase.TabIndex = 2;
            // 
            // labelTopoStatus
            // 
            this.labelTopoStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTopoStatus.Location = new System.Drawing.Point(32, 0);
            this.labelTopoStatus.Name = "labelTopoStatus";
            this.labelTopoStatus.Size = new System.Drawing.Size(560, 30);
            this.labelTopoStatus.TabIndex = 1;
            this.labelTopoStatus.Text = "...";
            this.labelTopoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botaoOpcoesBase
            // 
            this.botaoOpcoesBase.ContextMenuStrip = this.menuOpcoesBase;
            this.botaoOpcoesBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoOpcoesBase.Image = global::JSistemas.UIL.Base.Properties.Resources.setting_tools;
            this.botaoOpcoesBase.Location = new System.Drawing.Point(0, 0);
            this.botaoOpcoesBase.Name = "botaoOpcoesBase";
            this.botaoOpcoesBase.Size = new System.Drawing.Size(32, 30);
            this.botaoOpcoesBase.TabIndex = 0;
            this.botaoOpcoesBase.UseVisualStyleBackColor = true;
            this.botaoOpcoesBase.Click += new System.EventHandler(this.botaoOpcoesBase_Click);
            // 
            // menuOpcoesBase
            // 
            this.menuOpcoesBase.Name = "menuOpcoesBase";
            this.menuOpcoesBase.Size = new System.Drawing.Size(61, 4);
            // 
            // panelTitulos
            // 
            this.panelTitulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTitulos.Location = new System.Drawing.Point(0, 32);
            this.panelTitulos.Name = "panelTitulos";
            this.panelTitulos.Padding = new System.Windows.Forms.Padding(0, 9, 9, 0);
            this.panelTitulos.Size = new System.Drawing.Size(109, 204);
            this.panelTitulos.TabIndex = 3;
            // 
            // panelCampos
            // 
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(109, 32);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Padding = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.panelCampos.Size = new System.Drawing.Size(485, 204);
            this.panelCampos.TabIndex = 4;
            // 
            // CadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 292);
            this.Controls.Add(this.panelCampos);
            this.Controls.Add(this.panelTitulos);
            this.Controls.Add(this.panelTopoBase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "CadastroBase";
            this.ShowInTaskbar = false;
            this.Text = "CadastroBase";
            this.panelInferior.ResumeLayout(false);
            this.panelInferiorEsquerdo.ResumeLayout(false);
            this.panelTopoBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelInferiorEsquerdo;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTopoBase;
        private System.Windows.Forms.Button botaoOpcoesBase;
        private System.Windows.Forms.Label labelTopoStatus;
        protected System.Windows.Forms.Panel panelTitulos;
        protected System.Windows.Forms.Panel panelCampos;
        protected System.Windows.Forms.ContextMenuStrip menuOpcoesBase;
    }
}