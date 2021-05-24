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
    public partial class Personel_giris : Form
    {
        public Personel_giris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personel_üye pü = new Personel_üye();
            pü.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Personel where PersonelAd=@p1 and PersonelSoyad=@p2 and PersonelNo=@p3", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtPerNo.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                p_islemler pi = new p_islemler();
                pi.PersonelNo = txtPerNo.Text;
                pi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Bilgilerde Hata Var..", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();

        }

        private void Personel_giris_Load(object sender, EventArgs e)
        {

        }
    }
}
