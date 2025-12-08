namespace ShadowLines.Forms
{
    partial class FormAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendamento));
            this.lblPagamento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCliente = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtData = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblFuncionario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxServicos = new System.Windows.Forms.ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.labelData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPagamento
            // 
            this.lblPagamento.BackColor = System.Drawing.Color.Transparent;
            this.lblPagamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(55, 274);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(150, 20);
            this.lblPagamento.TabIndex = 78;
            this.lblPagamento.Text = "Status Pagamento";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderColor = System.Drawing.Color.DimGray;
            this.txtStatus.BorderRadius = 5;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(92, 296);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.PlaceholderText = "Pendente ou Pago";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(290, 36);
            this.txtStatus.TabIndex = 73;
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
            this.txtValor.Location = new System.Drawing.Point(92, 199);
            this.txtValor.Name = "txtValor";
            this.txtValor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.PlaceholderText = "";
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(290, 36);
            this.txtValor.TabIndex = 80;
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(55, 177);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 20);
            this.lblValor.TabIndex = 77;
            this.lblValor.Text = "Valor";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(92, 104);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(133, 20);
            this.lblCliente.TabIndex = 75;
            this.lblCliente.Text = "Nome do Cliente";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(475, 274);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(181, 20);
            this.lblData.TabIndex = 79;
            this.lblData.Text = "Data do Agendamento";
            // 
            // txtData
            // 
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
            this.txtData.Location = new System.Drawing.Point(515, 296);
            this.txtData.Name = "txtData";
            this.txtData.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtData.PlaceholderText = "";
            this.txtData.SelectedText = "";
            this.txtData.Size = new System.Drawing.Size(344, 36);
            this.txtData.TabIndex = 81;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(143, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 34);
            this.lblTitulo.TabIndex = 82;
            this.lblTitulo.Text = "Agendamento Clientes";
            // 
            // btnAgendar
            // 
            this.btnAgendar.BorderRadius = 5;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgendar.FillColor = System.Drawing.Color.Black;
            this.btnAgendar.FillColor2 = System.Drawing.Color.Navy;
            this.btnAgendar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(0, 391);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(904, 37);
            this.btnAgendar.TabIndex = 70;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(516, 191);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(148, 20);
            this.lblFuncionario.TabIndex = 76;
            this.lblFuncionario.Text = "Nome Funcionario";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(222, 12);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(381, 42);
            this.guna2HtmlLabel5.TabIndex = 92;
            this.guna2HtmlLabel5.Text = "_____________________";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(9, -3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 96);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 94;
            this.guna2PictureBox1.TabStop = false;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(92, 126);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(290, 21);
            this.comboBoxCliente.TabIndex = 95;
            this.comboBoxCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCliente_KeyPress);
            // 
            // comboBoxServicos
            // 
            this.comboBoxServicos.FormattingEnabled = true;
            this.comboBoxServicos.ItemHeight = 13;
            this.comboBoxServicos.Location = new System.Drawing.Point(515, 126);
            this.comboBoxServicos.MaximumSize = new System.Drawing.Size(1000, 0);
            this.comboBoxServicos.Name = "comboBoxServicos";
            this.comboBoxServicos.Size = new System.Drawing.Size(344, 21);
            this.comboBoxServicos.TabIndex = 96;
            this.comboBoxServicos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxServicos_SelectionChangeCommitted);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(515, 104);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(73, 20);
            this.guna2HtmlLabel1.TabIndex = 97;
            this.guna2HtmlLabel1.Text = "Serviços";
            // 
            // comboBoxFuncionarios
            // 
            this.comboBoxFuncionarios.FormattingEnabled = true;
            this.comboBoxFuncionarios.ItemHeight = 13;
            this.comboBoxFuncionarios.Location = new System.Drawing.Point(515, 214);
            this.comboBoxFuncionarios.MaximumSize = new System.Drawing.Size(1000, 0);
            this.comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            this.comboBoxFuncionarios.Size = new System.Drawing.Size(344, 21);
            this.comboBoxFuncionarios.TabIndex = 98;
            // 
            // labelData
            // 
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(9, 365);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(81, 20);
            this.labelData.TabIndex = 99;
            this.labelData.Text = "Data Hoje";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 36;
            this.iconPictureBox2.Location = new System.Drawing.Point(472, 199);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(42, 36);
            this.iconPictureBox2.TabIndex = 182;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 36;
            this.iconPictureBox1.Location = new System.Drawing.Point(53, 111);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 36);
            this.iconPictureBox1.TabIndex = 183;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 36;
            this.iconPictureBox3.Location = new System.Drawing.Point(472, 111);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(42, 36);
            this.iconPictureBox3.TabIndex = 184;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 36;
            this.iconPictureBox6.Location = new System.Drawing.Point(472, 296);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(42, 36);
            this.iconPictureBox6.TabIndex = 185;
            this.iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 36;
            this.iconPictureBox4.Location = new System.Drawing.Point(53, 199);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(37, 36);
            this.iconPictureBox4.TabIndex = 186;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 36;
            this.iconPictureBox5.Location = new System.Drawing.Point(48, 296);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(42, 36);
            this.iconPictureBox5.TabIndex = 187;
            this.iconPictureBox5.TabStop = false;
            // 
            // FormAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 428);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox6);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.comboBoxFuncionarios);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxServicos);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.FormAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPagamento;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblData;
        private Guna.UI2.WinForms.Guna2TextBox txtData;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgendar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFuncionario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxServicos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ComboBox comboBoxFuncionarios;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelData;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}