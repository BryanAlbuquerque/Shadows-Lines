namespace ShadowLines.Forms
{
    partial class FormNivelAcesso1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNivelAcesso1));
            this.customBackgroundPanel1 = new CustomBackgroundPanel();
            this.iconButtonAtualizar = new FontAwesome.Sharp.IconButton();
            this.btnDesconectar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customBackgroundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customBackgroundPanel1
            // 
            this.customBackgroundPanel1.Controls.Add(this.iconButtonAtualizar);
            this.customBackgroundPanel1.Controls.Add(this.btnDesconectar);
            this.customBackgroundPanel1.Controls.Add(this.guna2PictureBox1);
            this.customBackgroundPanel1.Controls.Add(this.lblUsuario);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.customBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel1.Name = "customBackgroundPanel1";
            this.customBackgroundPanel1.Size = new System.Drawing.Size(1077, 664);
            this.customBackgroundPanel1.TabIndex = 84;
            // 
            // iconButtonAtualizar
            // 
            this.iconButtonAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAtualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAtualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.iconButtonAtualizar.IconColor = System.Drawing.Color.Black;
            this.iconButtonAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAtualizar.IconSize = 35;
            this.iconButtonAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAtualizar.Location = new System.Drawing.Point(646, 263);
            this.iconButtonAtualizar.Name = "iconButtonAtualizar";
            this.iconButtonAtualizar.Size = new System.Drawing.Size(118, 38);
            this.iconButtonAtualizar.TabIndex = 86;
            this.iconButtonAtualizar.Text = "Atualizar";
            this.iconButtonAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAtualizar.UseVisualStyleBackColor = true;
            this.iconButtonAtualizar.Click += new System.EventHandler(this.iconButtonAtualizar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesconectar.BorderRadius = 5;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesconectar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesconectar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesconectar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesconectar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesconectar.FillColor = System.Drawing.Color.Black;
            this.btnDesconectar.FillColor2 = System.Drawing.Color.Navy;
            this.btnDesconectar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.Color.White;
            this.btnDesconectar.Location = new System.Drawing.Point(933, 12);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(132, 32);
            this.btnDesconectar.TabIndex = 84;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 20);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(137, 133);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 83;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Blue;
            this.lblUsuario.Location = new System.Drawing.Point(193, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(115, 35);
            this.lblUsuario.TabIndex = 82;
            this.lblUsuario.Text = "Usuario";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(267, 33);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(381, 42);
            this.guna2HtmlLabel5.TabIndex = 81;
            this.guna2HtmlLabel5.Text = "_____________________";
            // 
            // FormNivelAcesso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 664);
            this.Controls.Add(this.customBackgroundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormNivelAcesso1";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNivelAcesso0_Load);
            this.customBackgroundPanel1.ResumeLayout(false);
            this.customBackgroundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private CustomBackgroundPanel customBackgroundPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDesconectar;
        private FontAwesome.Sharp.IconButton iconButtonAtualizar;
    }
}