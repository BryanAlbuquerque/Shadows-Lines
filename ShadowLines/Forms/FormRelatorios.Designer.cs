namespace ShadowLines.Forms
{
    partial class FormRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorios));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.customBackgroundPanel1 = new CustomBackgroundPanel();
            this.customBackgroundPanel2 = new CustomBackgroundPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.customBackgroundPanel1.SuspendLayout();
            this.customBackgroundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(382, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Semanal";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione os dados que deseja gerar no relátorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo do relatorio";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(500, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Mensal";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(620, 118);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Anual";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // customBackgroundPanel1
            // 
            this.customBackgroundPanel1.Controls.Add(this.customBackgroundPanel2);
            this.customBackgroundPanel1.Controls.Add(this.checkBox4);
            this.customBackgroundPanel1.Controls.Add(this.checkBox3);
            this.customBackgroundPanel1.Controls.Add(this.label1);
            this.customBackgroundPanel1.Controls.Add(this.checkBox2);
            this.customBackgroundPanel1.Controls.Add(this.checkBox1);
            this.customBackgroundPanel1.Controls.Add(this.label2);
            this.customBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel1.Name = "customBackgroundPanel1";
            this.customBackgroundPanel1.Size = new System.Drawing.Size(1027, 640);
            this.customBackgroundPanel1.TabIndex = 5;
            // 
            // customBackgroundPanel2
            // 
            this.customBackgroundPanel2.Controls.Add(this.label3);
            this.customBackgroundPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackgroundPanel2.Location = new System.Drawing.Point(0, 0);
            this.customBackgroundPanel2.Name = "customBackgroundPanel2";
            this.customBackgroundPanel2.Size = new System.Drawing.Size(1027, 640);
            this.customBackgroundPanel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione os dados que deseja gerar no relátorios";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(382, 165);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Valor";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 640);
            this.Controls.Add(this.customBackgroundPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.customBackgroundPanel1.ResumeLayout(false);
            this.customBackgroundPanel1.PerformLayout();
            this.customBackgroundPanel2.ResumeLayout(false);
            this.customBackgroundPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private CustomBackgroundPanel customBackgroundPanel1;
        private CustomBackgroundPanel customBackgroundPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}