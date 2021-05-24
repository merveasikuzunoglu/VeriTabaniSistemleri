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
    public partial class akademik_giris : Form
    {
        public akademik_giris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            akademik_üye aü = new akademik_üye();
            aü.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From AkademikPersonel where AkademisyenAd=@p1 and AkademisyenSoyad=@p2 and AkademisyenNo=@p3", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtAkno.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                a_islemler ai = new a_islemler();
                ai.AkademisyenNo = txtAkno.Text;
                ai.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Bilgilerde Hata Var..","Giriş",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void akademik_giris_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
