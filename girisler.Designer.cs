namespace girisler
{
    partial class girisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisler));
            this.btnAkademi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAkademi
            // 
            this.btnAkademi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAkademi.BackgroundImage")));
            this.btnAkademi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAkademi.Location = new System.Drawing.Point(83, 148);
            this.btnAkademi.Name = "btnAkademi";
            this.btnAkademi.Size = new System.Drawing.Size(176, 153);
            this.btnAkademi.TabIndex = 1;
            this.btnAkademi.UseVisualStyleBackColor = true;
            this.btnAkademi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(347, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 153);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(609, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 153);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(238, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kütüphane Sistemi Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Akademik Personel Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(355, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Giriş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(627, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğrenci Giriş";
            // 
            // girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(851, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAkademi);
            this.Name = "girisler";
            this.Text = "Kütüphane Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAkademi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

