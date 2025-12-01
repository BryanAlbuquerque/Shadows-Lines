namespace ShadowLines.Forms.FormsMenu2
{
    partial class FormAgendamento2
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
            this.customBackgroundPanel1 = new CustomBackgroundPanel();
            this.lbss = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customBackgroundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customBackgroundPanel1
            // 
            this.customBackgroundPanel1.Controls.Add(this.lbss);
            this.customBackgroundPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.customBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel1.Name = "customBackgroundPanel1";
            this.customBackgroundPanel1.Size = new System.Drawing.Size(927, 564);
            this.customBackgroundPanel1.TabIndex = 0;
            // 
            // lbss
            // 
            this.lbss.BackColor = System.Drawing.Color.White;
            this.lbss.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbss.ForeColor = System.Drawing.Color.Blue;
            this.lbss.Location = new System.Drawing.Point(196, 12);
            this.lbss.Name = "lbss";
            this.lbss.Size = new System.Drawing.Size(451, 35);
            this.lbss.TabIndex = 81;
            this.lbss.Text = "Shadow & Lines Agendamentos";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(301, 21);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(381, 42);
            this.guna2HtmlLabel5.TabIndex = 80;
            this.guna2HtmlLabel5.Text = "_____________________";
            // 
            // FormAgendamento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 564);
            this.Controls.Add(this.customBackgroundPanel1);
            this.IsMdiContainer = true;
            this.Name = "FormAgendamento2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgendamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.customBackgroundPanel1.ResumeLayout(false);
            this.customBackgroundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBackgroundPanel customBackgroundPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbss;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}