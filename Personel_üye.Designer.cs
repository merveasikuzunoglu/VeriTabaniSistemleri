namespace girisler
{
    partial class Personel_üye
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(335, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 42);
            this.button1.TabIndex = 38;
            this.button1.Text = "Üye Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPersonel
            // 
            this.txtPersonel.BackColor = System.Drawing.Color.Ivory;
            this.txtPersonel.Location = new System.Drawing.Point(221, 172);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(256, 20);
            this.txtPersonel.TabIndex = 37;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Ivory;
            this.txtSoyad.Location = new System.Drawing.Point(221, 132);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(256, 20);
            this.txtSoyad.TabIndex = 36;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Ivory;
            this.txtAd.Location = new System.Drawing.Point(221, 92);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(256, 20);
            this.txtAd.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(135, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Personel Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "Personel Üyelik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(163, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ad:";
            // 
            // Personel_üye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(555, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPersonel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Personel_üye";
            this.Text = "Personel Üye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPersonel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}