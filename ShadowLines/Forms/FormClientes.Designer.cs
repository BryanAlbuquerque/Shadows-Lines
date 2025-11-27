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
            this.btnVoltar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDevendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.customBackgroundPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customBackgroundPanel1
            // 
            this.customBackgroundPanel1.Controls.Add(this.btnVoltar);
            this.customBackgroundPanel1.Controls.Add(this.menuStrip1);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.customBackgroundPanel1.Controls.Add(this.guna2PictureBox1);
            this.customBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel1.Name = "customBackgroundPanel1";
            this.customBackgroundPanel1.Size = new System.Drawing.Size(973, 545);
            this.customBackgroundPanel1.TabIndex = 2;
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
            this.btnVoltar.Location = new System.Drawing.Point(856, 5);
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
            this.clientesToolStripMenuItem,
            this.dadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(569, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(164, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.alterarDadosToolStripMenuItem,
            this.excluirClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // alterarDadosToolStripMenuItem
            // 
            this.alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            this.alterarDadosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            this.alterarDadosToolStripMenuItem.Click += new System.EventHandler(this.alterarDadosToolStripMenuItem_Click);
            // 
            // excluirClienteToolStripMenuItem
            // 
            this.excluirClienteToolStripMenuItem.Name = "excluirClienteToolStripMenuItem";
            this.excluirClienteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.excluirClienteToolStripMenuItem.Text = "Excluir Cliente";
            this.excluirClienteToolStripMenuItem.Click += new System.EventHandler(this.excluirClienteToolStripMenuItem_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarClientesToolStripMenuItem,
            this.clientesDevendoToolStripMenuItem,
            this.clientesToolStripMenuItem1});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // visualizarClientesToolStripMenuItem
            // 
            this.visualizarClientesToolStripMenuItem.Name = "visualizarClientesToolStripMenuItem";
            this.visualizarClientesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.visualizarClientesToolStripMenuItem.Text = "Clientes";
            this.visualizarClientesToolStripMenuItem.Click += new System.EventHandler(this.visualizarClientesToolStripMenuItem_Click);
            // 
            // clientesDevendoToolStripMenuItem
            // 
            this.clientesDevendoToolStripMenuItem.Name = "clientesDevendoToolStripMenuItem";
            this.clientesDevendoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.clientesDevendoToolStripMenuItem.Text = "Clientes Devendo";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.clientesToolStripMenuItem1.Text = "Total Gastos";
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
            this.ClientSize = new System.Drawing.Size(973, 545);
            this.Controls.Add(this.customBackgroundPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.customBackgroundPanel1.ResumeLayout(false);
            this.customBackgroundPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem excluirClienteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDevendoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2GradientButton btnVoltar;
    }
}