namespace ShadowLines.Forms.Clientes
{
    partial class FormGerarBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarBoleto));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customBackgroundPanel1 = new CustomBackgroundPanel();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblData = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateTimerDataRecente = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimerDataAntiga = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnGerarBoleto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.customBackgroundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 514);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(168, 20);
            this.txtCliente.TabIndex = 124;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(216, 514);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(209, 20);
            this.txtData.TabIndex = 125;
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(470, 514);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(181, 20);
            this.txtServico.TabIndex = 126;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(688, 514);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(168, 20);
            this.txtValor.TabIndex = 127;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 488);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(59, 20);
            this.guna2HtmlLabel3.TabIndex = 128;
            this.guna2HtmlLabel3.Text = "Cliente";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(216, 488);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(181, 20);
            this.guna2HtmlLabel4.TabIndex = 129;
            this.guna2HtmlLabel4.Text = "Data do Agendamento";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(470, 488);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(64, 20);
            this.guna2HtmlLabel5.TabIndex = 130;
            this.guna2HtmlLabel5.Text = "Serviço";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(688, 488);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(45, 20);
            this.guna2HtmlLabel6.TabIndex = 131;
            this.guna2HtmlLabel6.Text = "Valor";
            // 
            // customBackgroundPanel1
            // 
            this.customBackgroundPanel1.Controls.Add(this.btnVoltar);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel7);
            this.customBackgroundPanel1.Controls.Add(this.guna2PictureBox1);
            this.customBackgroundPanel1.Controls.Add(this.txtSituacao);
            this.customBackgroundPanel1.Controls.Add(this.btnLocalizar);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.customBackgroundPanel1.Controls.Add(this.lblData);
            this.customBackgroundPanel1.Controls.Add(this.DateTimerDataRecente);
            this.customBackgroundPanel1.Controls.Add(this.DateTimerDataAntiga);
            this.customBackgroundPanel1.Controls.Add(this.txtBuscar);
            this.customBackgroundPanel1.Controls.Add(this.btnBuscar);
            this.customBackgroundPanel1.Controls.Add(this.btnGerarBoleto);
            this.customBackgroundPanel1.Controls.Add(this.sfDataGrid);
            this.customBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel1.Name = "customBackgroundPanel1";
            this.customBackgroundPanel1.Size = new System.Drawing.Size(1080, 641);
            this.customBackgroundPanel1.TabIndex = 133;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BorderRadius = 10;
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
            this.btnVoltar.Location = new System.Drawing.Point(998, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(79, 34);
            this.btnVoltar.TabIndex = 164;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(889, 488);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(74, 20);
            this.guna2HtmlLabel7.TabIndex = 135;
            this.guna2HtmlLabel7.Text = "Situação";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 29);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 96);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 163;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(889, 514);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(168, 20);
            this.txtSituacao.TabIndex = 134;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizar.BorderRadius = 15;
            this.btnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocalizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocalizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocalizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocalizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocalizar.FillColor = System.Drawing.Color.Black;
            this.btnLocalizar.FillColor2 = System.Drawing.Color.Navy;
            this.btnLocalizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.Color.White;
            this.btnLocalizar.Location = new System.Drawing.Point(750, 89);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(106, 34);
            this.btnLocalizar.TabIndex = 133;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(182, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(340, 26);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Selecionar um intervalo de datas:";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(14, 609);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(81, 20);
            this.lblData.TabIndex = 132;
            this.lblData.Text = "Data Hoje";
            // 
            // DateTimerDataRecente
            // 
            this.DateTimerDataRecente.Checked = true;
            this.DateTimerDataRecente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DateTimerDataRecente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimerDataRecente.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimerDataRecente.Location = new System.Drawing.Point(470, 89);
            this.DateTimerDataRecente.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimerDataRecente.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimerDataRecente.Name = "DateTimerDataRecente";
            this.DateTimerDataRecente.Size = new System.Drawing.Size(252, 36);
            this.DateTimerDataRecente.TabIndex = 1;
            this.DateTimerDataRecente.Value = new System.DateTime(2026, 1, 14, 17, 34, 36, 203);
            // 
            // DateTimerDataAntiga
            // 
            this.DateTimerDataAntiga.Checked = true;
            this.DateTimerDataAntiga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DateTimerDataAntiga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimerDataAntiga.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimerDataAntiga.Location = new System.Drawing.Point(182, 89);
            this.DateTimerDataAntiga.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimerDataAntiga.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimerDataAntiga.Name = "DateTimerDataAntiga";
            this.DateTimerDataAntiga.Size = new System.Drawing.Size(252, 36);
            this.DateTimerDataAntiga.TabIndex = 0;
            this.DateTimerDataAntiga.Value = new System.DateTime(2026, 1, 14, 17, 34, 36, 203);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(78, 187);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(467, 20);
            this.txtBuscar.TabIndex = 117;
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
            this.btnBuscar.Location = new System.Drawing.Point(551, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 25);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGerarBoleto
            // 
            this.btnGerarBoleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarBoleto.BackColor = System.Drawing.Color.Transparent;
            this.btnGerarBoleto.BorderRadius = 15;
            this.btnGerarBoleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarBoleto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerarBoleto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerarBoleto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerarBoleto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerarBoleto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerarBoleto.FillColor = System.Drawing.Color.Black;
            this.btnGerarBoleto.FillColor2 = System.Drawing.Color.Navy;
            this.btnGerarBoleto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarBoleto.ForeColor = System.Drawing.Color.White;
            this.btnGerarBoleto.Location = new System.Drawing.Point(932, 576);
            this.btnGerarBoleto.Name = "btnGerarBoleto";
            this.btnGerarBoleto.Size = new System.Drawing.Size(136, 34);
            this.btnGerarBoleto.TabIndex = 119;
            this.btnGerarBoleto.Text = "Gerar Boleto";
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.Location = new System.Drawing.Point(21, 213);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.Size = new System.Drawing.Size(819, 269);
            this.sfDataGrid.TabIndex = 3;
            this.sfDataGrid.Text = "sfDataGrid";
            this.sfDataGrid.SelectionChanged += new Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventHandler(this.sfDataGrid_SelectionChanged);
            // 
            // FormGerarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 641);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.customBackgroundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormGerarBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGerarBoleto";
            this.Load += new System.EventHandler(this.FormGerarBoleto_Load);
            this.customBackgroundPanel1.ResumeLayout(false);
            this.customBackgroundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimerDataAntiga;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimerDataRecente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2GradientButton btnGerarBoleto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox txtValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblData;
        private CustomBackgroundPanel customBackgroundPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private System.Windows.Forms.TextBox txtSituacao;
        private Guna.UI2.WinForms.Guna2GradientButton btnLocalizar;
        private Guna.UI2.WinForms.Guna2GradientButton btnVoltar;
    }
}