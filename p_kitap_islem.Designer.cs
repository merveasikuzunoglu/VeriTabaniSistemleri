namespace girisler
{
    partial class p_kitap_islem
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
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(720, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 61;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(355, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 36);
            this.label5.TabIndex = 60;
            this.label5.Text = "Kitap İşlemleri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Beige;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(594, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 42);
            this.button2.TabIndex = 59;
            this.button2.Text = "İşlemi Tamamla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(317, 446);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 58;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 404);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.Ivory;
            this.txtNumara.Location = new System.Drawing.Point(434, 75);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(265, 20);
            this.txtNumara.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(125, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Son Teslim Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(184, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Alış Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(104, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Öğrenci veya Akademisyen Numarası:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 264);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // p_kitap_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(891, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "p_kitap_islem";
            this.Text = "p_kitap_islem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}