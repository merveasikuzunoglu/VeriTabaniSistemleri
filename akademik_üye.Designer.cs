namespace girisler
{
    partial class akademik_üye
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
            this.txtAkno = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbÜniversite = new System.Windows.Forms.ComboBox();
            this.cmbFakülte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(459, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "Üye Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAkno
            // 
            this.txtAkno.BackColor = System.Drawing.Color.Ivory;
            this.txtAkno.Location = new System.Drawing.Point(317, 154);
            this.txtAkno.Name = "txtAkno";
            this.txtAkno.Size = new System.Drawing.Size(256, 20);
            this.txtAkno.TabIndex = 23;
            this.txtAkno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Ivory;
            this.txtSoyad.Location = new System.Drawing.Point(317, 114);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(256, 20);
            this.txtSoyad.TabIndex = 22;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Ivory;
            this.txtAd.Location = new System.Drawing.Point(317, 74);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(256, 20);
            this.txtAd.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(231, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(79, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Akademisyen Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Akademik Personel Üyelik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(259, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(43, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Görev Yaptığınız Üniversite:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(63, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Görev Yaptığınız Fakülte:";
            // 
            // cmbÜniversite
            // 
            this.cmbÜniversite.BackColor = System.Drawing.Color.Ivory;
            this.cmbÜniversite.FormattingEnabled = true;
            this.cmbÜniversite.Items.AddRange(new object[] {
            "Acıbadem Üniversitesi",
            "Bahçeşehir Üniversitesi",
            "Boğaziçi Üniversitesi",
            "İstanbul Arel Üniversitesi",
            "İstanbul Sabahattin Zaim Üniversitesi",
            "İstanbul Üniversitesi",
            "İstanbul Fatih Sultan Mehmet Üniversitesi",
            "Üsküdar Üniversitesi"});
            this.cmbÜniversite.Location = new System.Drawing.Point(317, 193);
            this.cmbÜniversite.Name = "cmbÜniversite";
            this.cmbÜniversite.Size = new System.Drawing.Size(256, 21);
            this.cmbÜniversite.TabIndex = 29;
            this.cmbÜniversite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbFakülte
            // 
            this.cmbFakülte.BackColor = System.Drawing.Color.Ivory;
            this.cmbFakülte.FormattingEnabled = true;
            this.cmbFakülte.Items.AddRange(new object[] {
            "Tıp Fakültesi",
            "Mühendislik ve Doğa Bilimleri Fakültesi",
            "İnsan ve Toplum Bilimleri Fakültesi",
            "Hukuk Fakültesi",
            "İşletme ve Yönetim Bilimleri Fakültesi"});
            this.cmbFakülte.Location = new System.Drawing.Point(317, 239);
            this.cmbFakülte.Name = "cmbFakülte";
            this.cmbFakülte.Size = new System.Drawing.Size(256, 21);
            this.cmbFakülte.TabIndex = 30;
            // 
            // akademik_üye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(666, 441);
            this.Controls.Add(this.cmbFakülte);
            this.Controls.Add(this.cmbÜniversite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAkno);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "akademik_üye";
            this.Text = "Akademik Personel Üyelik";
            this.Load += new System.EventHandler(this.akademik_üye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAkno;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbÜniversite;
        private System.Windows.Forms.ComboBox cmbFakülte;
    }
}