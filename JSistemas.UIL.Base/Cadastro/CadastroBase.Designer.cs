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
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInferiorEsquerdo = new System.Windows.Forms.Panel();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTopoBase = new System.Windows.Forms.Panel();
            this.labelTopoStatusBase = new System.Windows.Forms.Label();
            this.botaoOpcoesBase = new System.Windows.Forms.Button();
            this.menuOpcoesBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpcoesExcluirBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panelTitulos = new System.Windows.Forms.Panel();
            this.tituloIdentificador = new System.Windows.Forms.Label();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.colGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.panelInferior.SuspendLayout();
            this.panelInferiorEsquerdo.SuspendLayout();
            this.panelTopoBase.SuspendLayout();
            this.menuOpcoesBase.SuspendLayout();
            this.panelTitulos.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.lblInfo);
            this.panelInferior.Controls.Add(this.panel2);
            this.panelInferior.Controls.Add(this.panelInferiorEsquerdo);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 236);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(594, 56);
            this.panelInferior.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(260, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(334, 56);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "F4 - Atualizar Consulta";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 56);
            this.panel2.TabIndex = 7;
            // 
            // panelInferiorEsquerdo
            // 
            this.panelInferiorEsquerdo.Controls.Add(this.botaoCancelar);
            this.panelInferiorEsquerdo.Controls.Add(this.label1);
            this.panelInferiorEsquerdo.Controls.Add(this.botaoGravar);
            this.panelInferiorEsquerdo.Controls.Add(this.label2);
            this.panelInferiorEsquerdo.Controls.Add(this.botaoNovo);
            this.panelInferiorEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInferiorEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelInferiorEsquerdo.Name = "panelInferiorEsquerdo";
            this.panelInferiorEsquerdo.Padding = new System.Windows.Forms.Padding(6);
            this.panelInferiorEsquerdo.Size = new System.Drawing.Size(259, 56);
            this.panelInferiorEsquerdo.TabIndex = 0;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoCancelar.Enabled = false;
            this.botaoCancelar.Image = global::JSistemas.UIL.Base.Properties.Resources.cancel;
            this.botaoCancelar.Location = new System.Drawing.Point(176, 6);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 44);
            this.botaoCancelar.TabIndex = 2;
            this.botaoCancelar.Text = "&Cancelar";
            this.botaoCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(166, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 44);
            this.label1.TabIndex = 4;
            // 
            // botaoGravar
            // 
            this.botaoGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoGravar.Enabled = false;
            this.botaoGravar.Image = global::JSistemas.UIL.Base.Properties.Resources.accept;
            this.botaoGravar.Location = new System.Drawing.Point(91, 6);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 44);
            this.botaoGravar.TabIndex = 1;
            this.botaoGravar.Text = "&Gravar";
            this.botaoGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 44);
            this.label2.TabIndex = 5;
            // 
            // botaoNovo
            // 
            this.botaoNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoNovo.Image = global::JSistemas.UIL.Base.Properties.Resources.add;
            this.botaoNovo.Location = new System.Drawing.Point(6, 6);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(75, 44);
            this.botaoNovo.TabIndex = 3;
            this.botaoNovo.Text = "&Novo";
            this.botaoNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 1);
            this.panel1.TabIndex = 1;
            // 
            // panelTopoBase
            // 
            this.panelTopoBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopoBase.Controls.Add(this.labelTopoStatusBase);
            this.panelTopoBase.Controls.Add(this.botaoOpcoesBase);
            this.panelTopoBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopoBase.Location = new System.Drawing.Point(0, 0);
            this.panelTopoBase.Name = "panelTopoBase";
            this.panelTopoBase.Size = new System.Drawing.Size(594, 32);
            this.panelTopoBase.TabIndex = 2;
            // 
            // labelTopoStatusBase
            // 
            this.labelTopoStatusBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTopoStatusBase.Location = new System.Drawing.Point(32, 0);
            this.labelTopoStatusBase.Name = "labelTopoStatusBase";
            this.labelTopoStatusBase.Size = new System.Drawing.Size(560, 30);
            this.labelTopoStatusBase.TabIndex = 1;
            this.labelTopoStatusBase.Text = "Novo Registro";
            this.labelTopoStatusBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTopoStatusBase.Click += new System.EventHandler(this.labelTopoStatus_Click);
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
            this.menuOpcoesBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcoesExcluirBase,
            this.toolStripSeparator1});
            this.menuOpcoesBase.Name = "menuOpcoesBase";
            this.menuOpcoesBase.Size = new System.Drawing.Size(109, 32);
            // 
            // miOpcoesExcluirBase
            // 
            this.miOpcoesExcluirBase.Enabled = false;
            this.miOpcoesExcluirBase.Image = global::JSistemas.UIL.Base.Properties.Resources.delete;
            this.miOpcoesExcluirBase.Name = "miOpcoesExcluirBase";
            this.miOpcoesExcluirBase.Size = new System.Drawing.Size(108, 22);
            this.miOpcoesExcluirBase.Text = "Excluir";
            this.miOpcoesExcluirBase.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // panelTitulos
            // 
            this.panelTitulos.Controls.Add(this.tituloIdentificador);
            this.panelTitulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTitulos.Location = new System.Drawing.Point(3, 3);
            this.panelTitulos.Name = "panelTitulos";
            this.panelTitulos.Padding = new System.Windows.Forms.Padding(0, 9, 9, 0);
            this.panelTitulos.Size = new System.Drawing.Size(109, 155);
            this.panelTitulos.TabIndex = 3;
            // 
            // tituloIdentificador
            // 
            this.tituloIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloIdentificador.AutoSize = true;
            this.tituloIdentificador.Location = new System.Drawing.Point(32, 9);
            this.tituloIdentificador.Margin = new System.Windows.Forms.Padding(9);
            this.tituloIdentificador.Name = "tituloIdentificador";
            this.tituloIdentificador.Size = new System.Drawing.Size(65, 13);
            this.tituloIdentificador.TabIndex = 0;
            this.tituloIdentificador.Text = "Identificador";
            // 
            // panelCampos
            // 
            this.panelCampos.BackColor = System.Drawing.SystemColors.Control;
            this.panelCampos.Controls.Add(this.lblID);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(112, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Padding = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.panelCampos.Size = new System.Drawing.Size(469, 155);
            this.panelCampos.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 2;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 32);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 203);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabConsulta
            // 
            this.tabConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabConsulta.Controls.Add(this.gridConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 36);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(586, 163);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            this.tabConsulta.Enter += new System.EventHandler(this.tabConsulta_Enter);
            // 
            // gridConsulta
            // 
            this.gridConsulta.AllowUserToAddRows = false;
            this.gridConsulta.AllowUserToDeleteRows = false;
            this.gridConsulta.AllowUserToResizeRows = false;
            this.gridConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGUID});
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(3, 3);
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.ReadOnly = true;
            this.gridConsulta.RowHeadersVisible = false;
            this.gridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConsulta.Size = new System.Drawing.Size(578, 155);
            this.gridConsulta.TabIndex = 0;
            // 
            // colGUID
            // 
            this.colGUID.HeaderText = "Identificador";
            this.colGUID.Name = "colGUID";
            this.colGUID.ReadOnly = true;
            this.colGUID.Visible = false;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCadastro.Controls.Add(this.panelCampos);
            this.tabCadastro.Controls.Add(this.panelTitulos);
            this.tabCadastro.Location = new System.Drawing.Point(4, 36);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(586, 163);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            this.tabCadastro.Enter += new System.EventHandler(this.tabCadastro_Enter);
            // 
            // CadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 292);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTopoBase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "CadastroBase";
            this.ShowInTaskbar = false;
            this.Text = "CadastroBase";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroBase_KeyDown);
            this.panelInferior.ResumeLayout(false);
            this.panelInferiorEsquerdo.ResumeLayout(false);
            this.panelTopoBase.ResumeLayout(false);
            this.menuOpcoesBase.ResumeLayout(false);
            this.panelTitulos.ResumeLayout(false);
            this.panelTitulos.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelInferiorEsquerdo;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTopoBase;
        private System.Windows.Forms.Button botaoOpcoesBase;
        private System.Windows.Forms.Label labelTopoStatusBase;
        protected System.Windows.Forms.Panel panelTitulos;
        protected System.Windows.Forms.Panel panelCampos;
        protected System.Windows.Forms.ContextMenuStrip menuOpcoesBase;
        private System.Windows.Forms.ToolStripMenuItem miOpcoesExcluirBase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.Label lblID;
        protected System.Windows.Forms.Label tituloIdentificador;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tabConsulta;
        protected System.Windows.Forms.TabPage tabCadastro;
        protected System.Windows.Forms.DataGridViewTextBoxColumn colGUID;
        protected System.Windows.Forms.DataGridView gridConsulta;
    }
}