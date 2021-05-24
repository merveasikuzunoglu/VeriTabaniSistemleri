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
    public partial class o_islemler : Form
    {
        public o_islemler()
        {
            InitializeComponent();
        }

        public string ogrNo;
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            o_kitap_islem ki = new o_kitap_islem();
            ki.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            o_oda_bilgisi oo = new o_oda_bilgisi();
            oo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            o_dergi_islem od = new o_dergi_islem();
            od.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o_makale_islem om = new o_makale_islem();
            om.Show();
        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void o_islemler_Load(object sender, EventArgs e)
        {
            lblNo.Text = ogrNo;
            SqlCommand command = new SqlCommand("Select ÖğrenciAd,ÖğrenciSoyad From Öğrenci where ÖğrenciNo=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", lblNo.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text= dr[0].ToString() + " " + dr[1].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            girisler g = new girisler();
            g.Show();
            this.Hide();
        }
    }
}
