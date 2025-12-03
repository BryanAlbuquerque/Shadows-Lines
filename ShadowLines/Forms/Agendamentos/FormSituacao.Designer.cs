namespace ShadowLines.Forms
{
    partial class FormSituacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSituacao));
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblServico = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblClient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitulo2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(81, 167);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(266, 21);
            this.comboBoxClientes.TabIndex = 116;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 96);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 115;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelData
            // 
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(13, 241);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(81, 20);
            this.labelData.TabIndex = 113;
            this.labelData.Text = "Data Hoje";
            // 
            // lblServico
            // 
            this.lblServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServico.BackColor = System.Drawing.Color.Transparent;
            this.lblServico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(440, 145);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(74, 20);
            this.lblServico.TabIndex = 109;
            this.lblServico.Text = "Situação";
            // 
            // lblClient
            // 
            this.lblClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(84, 145);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(109, 20);
            this.lblClient.TabIndex = 108;
            this.lblClient.Text = "Nome Cliente";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.BorderRadius = 5;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlterar.FillColor = System.Drawing.Color.Navy;
            this.btnAlterar.FillColor2 = System.Drawing.Color.Black;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(616, 233);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(161, 33);
            this.btnAlterar.TabIndex = 112;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo2.Location = new System.Drawing.Point(176, 12);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(444, 34);
            this.lblTitulo2.TabIndex = 111;
            this.lblTitulo2.Text = "Alterar Situação do agendamento";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(249, 32);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(381, 42);
            this.guna2HtmlLabel5.TabIndex = 114;
            this.guna2HtmlLabel5.Text = "_____________________";
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "Finalizado",
            "Em Aberto",
            "Cancelado"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(440, 167);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(266, 21);
            this.comboBoxSituacao.TabIndex = 121;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 36;
            this.iconPictureBox1.Location = new System.Drawing.Point(44, 151);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 36);
            this.iconPictureBox1.TabIndex = 184;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 36;
            this.iconPictureBox5.Location = new System.Drawing.Point(402, 153);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(37, 36);
            this.iconPictureBox5.TabIndex = 186;
            this.iconPictureBox5.TabStop = false;
            // 
            // FormSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 273);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.comboBoxSituacao);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSituacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Situação";
            this.Load += new System.EventHandler(this.FormSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelData;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServico;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnAlterar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}