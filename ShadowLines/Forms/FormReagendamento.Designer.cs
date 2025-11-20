namespace ShadowLines.Forms
{
    partial class FormReagendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReagendamento));
            this.txtData = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMudarData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblClient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReagendar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitulo2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxServicos = new System.Windows.Forms.ComboBox();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BorderColor = System.Drawing.Color.DimGray;
            this.txtData.BorderRadius = 5;
            this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData.DefaultText = "";
            this.txtData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtData.ForeColor = System.Drawing.Color.Black;
            this.txtData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.Location = new System.Drawing.Point(33, 199);
            this.txtData.Name = "txtData";
            this.txtData.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtData.PlaceholderText = "";
            this.txtData.SelectedText = "";
            this.txtData.Size = new System.Drawing.Size(246, 30);
            this.txtData.TabIndex = 75;
            // 
            // lblMudarData
            // 
            this.lblMudarData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMudarData.BackColor = System.Drawing.Color.Transparent;
            this.lblMudarData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMudarData.Location = new System.Drawing.Point(33, 180);
            this.lblMudarData.Name = "lblMudarData";
            this.lblMudarData.Size = new System.Drawing.Size(41, 20);
            this.lblMudarData.TabIndex = 74;
            this.lblMudarData.Text = "Data ";
            // 
            // lblClient
            // 
            this.lblClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(33, 113);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(104, 20);
            this.lblClient.TabIndex = 73;
            this.lblClient.Text = "ID do Cliente";
            // 
            // btnReagendar
            // 
            this.btnReagendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReagendar.BorderRadius = 5;
            this.btnReagendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReagendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReagendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReagendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReagendar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReagendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReagendar.FillColor = System.Drawing.Color.Navy;
            this.btnReagendar.FillColor2 = System.Drawing.Color.Black;
            this.btnReagendar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReagendar.ForeColor = System.Drawing.Color.White;
            this.btnReagendar.Location = new System.Drawing.Point(457, 267);
            this.btnReagendar.Name = "btnReagendar";
            this.btnReagendar.Size = new System.Drawing.Size(161, 34);
            this.btnReagendar.TabIndex = 77;
            this.btnReagendar.Text = "Reagendar";
            this.btnReagendar.Click += new System.EventHandler(this.btnReagendar_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(145, 12);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(270, 34);
            this.lblTitulo2.TabIndex = 76;
            this.lblTitulo2.Text = "Reagendar Horarios";
            // 
            // labelData
            // 
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(12, 281);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(81, 20);
            this.labelData.TabIndex = 100;
            this.labelData.Text = "Data Hoje";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 96);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 102;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(189, 24);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(381, 42);
            this.guna2HtmlLabel5.TabIndex = 101;
            this.guna2HtmlLabel5.Text = "_____________________";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(33, 135);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(266, 21);
            this.comboBoxCliente.TabIndex = 103;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(329, 113);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(73, 20);
            this.guna2HtmlLabel1.TabIndex = 105;
            this.guna2HtmlLabel1.Text = "Serviços";
            // 
            // comboBoxServicos
            // 
            this.comboBoxServicos.FormattingEnabled = true;
            this.comboBoxServicos.ItemHeight = 13;
            this.comboBoxServicos.Location = new System.Drawing.Point(329, 135);
            this.comboBoxServicos.MaximumSize = new System.Drawing.Size(1000, 0);
            this.comboBoxServicos.Name = "comboBoxServicos";
            this.comboBoxServicos.Size = new System.Drawing.Size(271, 21);
            this.comboBoxServicos.TabIndex = 104;
            this.comboBoxServicos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxServicos_SelectionChangeCommitted);
            // 
            // txtValor
            // 
            this.txtValor.BorderColor = System.Drawing.Color.DimGray;
            this.txtValor.BorderRadius = 5;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Location = new System.Drawing.Point(324, 200);
            this.txtValor.Name = "txtValor";
            this.txtValor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.PlaceholderText = "";
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(276, 29);
            this.txtValor.TabIndex = 107;
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(324, 174);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 20);
            this.lblValor.TabIndex = 106;
            this.lblValor.Text = "Valor";
            // 
            // FormReagendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 313);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxServicos);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblMudarData);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnReagendar);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Name = "FormReagendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reagendamento";
            this.Load += new System.EventHandler(this.FormReagendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtData;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMudarData;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnReagendar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo2;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelData;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ComboBox comboBoxServicos;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValor;
    }
}