namespace girisler
{
    partial class akademik_giris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAkno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(95, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Akademik Personel Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(95, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Akademisyen Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(95, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Ivory;
            this.txtAd.Location = new System.Drawing.Point(186, 103);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(276, 20);
            this.txtAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Ivory;
            this.txtSoyad.Location = new System.Drawing.Point(186, 153);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(276, 20);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtAkno
            // 
            this.txtAkno.BackColor = System.Drawing.Color.Ivory;
            this.txtAkno.Location = new System.Drawing.Point(317, 206);
            this.txtAkno.Name = "txtAkno";
            this.txtAkno.Size = new System.Drawing.Size(145, 20);
            this.txtAkno.TabIndex = 13;
            this.txtAkno.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(215, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(468, 357);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 21);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(362, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Üye Değil Misiniz?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // akademik_giris
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(573, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAkno);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "akademik_giris";
            this.Text = "Akademik Personel Giriş";
            this.Load += new System.EventHandler(this.akademik_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAkno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}