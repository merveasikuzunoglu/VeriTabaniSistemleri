using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace girisler
{
    public partial class ogrenci_giris : Form
    {
        public ogrenci_giris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrenci_üye oü = new ogrenci_üye();
            oü.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Öğrenci where ÖğrenciAd=@p1 and ÖğrenciSoyad=@p2 and ÖğrenciNo=@p3", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtÖğrencino.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                o_islemler oi = new o_islemler();
                oi.ogrNo = txtÖğrencino.Text;
                oi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Bilgilerde Hata Var..", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();






        }

        private void ogrenci_giris_Load(object sender, EventArgs e)
        {

        }
    }
}
