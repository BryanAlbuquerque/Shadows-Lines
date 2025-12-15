namespace ShadowLines.Forms
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.customBackgroundPanel1 = new CustomBackgroundPanel();
            this.sfDataGridPanelPendentes = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.sfDataGridPanel = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesPagamentoPendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fianceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarBoletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.customBackgroundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPanelPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPanel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customBackgroundPanel1
            // 
            this.customBackgroundPanel1.Controls.Add(this.sfDataGridPanelPendentes);
            this.customBackgroundPanel1.Controls.Add(this.btnExcluir);
            this.customBackgroundPanel1.Controls.Add(this.btnAlterar);
            this.customBackgroundPanel1.Controls.Add(this.btnCadastrar);
            this.customBackgroundPanel1.Controls.Add(this.btnBuscar);
            this.customBackgroundPanel1.Controls.Add(this.txtBuscar);
            this.customBackgroundPanel1.Controls.Add(this.sfDataGridPanel);
            this.customBackgroundPanel1.Controls.Add(this.btnVoltar);
            this.customBackgroundPanel1.Controls.Add(this.menuStrip1);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.customBackgroundPanel1.Controls.Add(this.guna2PictureBox1);
            this.customBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel1.Name = "customBackgroundPanel1";
            this.customBackgroundPanel1.Size = new System.Drawing.Size(1112, 630);
            this.customBackgroundPanel1.TabIndex = 2;
            // 
            // sfDataGridPanelPendentes
            // 
            this.sfDataGridPanelPendentes.AccessibleName = "Table";
            this.sfDataGridPanelPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGridPanelPendentes.Location = new System.Drawing.Point(67, 176);
            this.sfDataGridPanelPendentes.Name = "sfDataGridPanelPendentes";
            this.sfDataGridPanelPendentes.Size = new System.Drawing.Size(1040, 379);
            this.sfDataGridPanelPendentes.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sfDataGridPanelPendentes.TabIndex = 120;
            this.sfDataGridPanelPendentes.Text = "sfDataGrid1";
            this.sfDataGridPanelPendentes.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BorderRadius = 10;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluir.FillColor = System.Drawing.Color.Black;
            this.btnExcluir.FillColor2 = System.Drawing.Color.Navy;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(732, 151);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 23);
            this.btnExcluir.TabIndex = 119;
            this.btnExcluir.Text = "Excluir Cliente";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BorderRadius = 10;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlterar.FillColor = System.Drawing.Color.Black;
            this.btnAlterar.FillColor2 = System.Drawing.Color.Navy;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(850, 151);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(139, 23);
            this.btnAlterar.TabIndex = 118;
            this.btnAlterar.Text = "Alterar Dados";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BorderRadius = 10;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.FillColor = System.Drawing.Color.Black;
            this.btnCadastrar.FillColor2 = System.Drawing.Color.Navy;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(995, 151);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 22);
            this.btnCadastrar.TabIndex = 117;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Navy;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(631, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 23);
            this.btnBuscar.TabIndex = 116;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(118, 153);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(507, 20);
            this.txtBuscar.TabIndex = 115;
            // 
            // sfDataGridPanel
            // 
            this.sfDataGridPanel.AccessibleName = "Table";
            this.sfDataGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGridPanel.Location = new System.Drawing.Point(67, 176);
            this.sfDataGridPanel.Name = "sfDataGridPanel";
            this.sfDataGridPanel.Size = new System.Drawing.Size(1040, 379);
            this.sfDataGridPanel.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sfDataGridPanel.TabIndex = 114;
            this.sfDataGridPanel.Text = "sfDataGrid1";
            this.sfDataGridPanel.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BorderRadius = 15;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.Black;
            this.btnVoltar.FillColor2 = System.Drawing.Color.Navy;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(995, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 34);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.fianceiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(253, 76);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarClientesToolStripMenuItem,
            this.clientesPagamentoPendenteToolStripMenuItem});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // visualizarClientesToolStripMenuItem
            // 
            this.visualizarClientesToolStripMenuItem.Name = "visualizarClientesToolStripMenuItem";
            this.visualizarClientesToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.visualizarClientesToolStripMenuItem.Text = "Dados dos clientes";
            this.visualizarClientesToolStripMenuItem.Click += new System.EventHandler(this.visualizarClientesToolStripMenuItem_Click);
            // 
            // clientesPagamentoPendenteToolStripMenuItem
            // 
            this.clientesPagamentoPendenteToolStripMenuItem.Name = "clientesPagamentoPendenteToolStripMenuItem";
            this.clientesPagamentoPendenteToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.clientesPagamentoPendenteToolStripMenuItem.Text = "Clientes com pagamento pendente";
            this.clientesPagamentoPendenteToolStripMenuItem.Click += new System.EventHandler(this.clientesPagamentoPendenteToolStripMenuItem_Click);
            // 
            // fianceiroToolStripMenuItem
            // 
            this.fianceiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrançaToolStripMenuItem,
            this.gerarBoletoToolStripMenuItem});
            this.fianceiroToolStripMenuItem.Name = "fianceiroToolStripMenuItem";
            this.fianceiroToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.fianceiroToolStripMenuItem.Text = "Pagamentos";
            // 
            // cobrançaToolStripMenuItem
            // 
            this.cobrançaToolStripMenuItem.Name = "cobrançaToolStripMenuItem";
            this.cobrançaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cobrançaToolStripMenuItem.Text = "Cobrança";
            this.cobrançaToolStripMenuItem.Click += new System.EventHandler(this.cobrançaToolStripMenuItem_Click);
            // 
            // gerarBoletoToolStripMenuItem
            // 
            this.gerarBoletoToolStripMenuItem.Name = "gerarBoletoToolStripMenuItem";
            this.gerarBoletoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gerarBoletoToolStripMenuItem.Text = "Gerar boleto";
            this.gerarBoletoToolStripMenuItem.Click += new System.EventHandler(this.gerarBoletoToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(202, 14);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(267, 39);
            this.guna2HtmlLabel4.TabIndex = 112;
            this.guna2HtmlLabel4.Text = "Shadows & Lines";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(253, 38);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(498, 35);
            this.guna2HtmlLabel1.TabIndex = 113;
            this.guna2HtmlLabel1.Text = "_________________________________";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(52, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(144, 133);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 111;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1112, 630);
            this.Controls.Add(this.customBackgroundPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.customBackgroundPanel1.ResumeLayout(false);
            this.customBackgroundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPanelPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridPanel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomBackgroundPanel customBackgroundPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarClientesToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton btnVoltar;
        private System.Windows.Forms.ToolStripMenuItem fianceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesPagamentoPendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarBoletoToolStripMenuItem;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridPanel;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2GradientButton btnCadastrar;
        private Guna.UI2.WinForms.Guna2GradientButton btnExcluir;
        private Guna.UI2.WinForms.Guna2GradientButton btnAlterar;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridPanelPendentes;
    }
}