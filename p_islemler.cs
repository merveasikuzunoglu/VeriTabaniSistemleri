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
    public partial class p_islemler : Form
    {
        public p_islemler()
        {
            InitializeComponent();
        }
        public string PersonelNo;
        sqlbaglanti bgl = new sqlbaglanti();

        private void button5_Click(object sender, EventArgs e)
        {
            p_kitap_islem pk = new p_kitap_islem();
            pk.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p_dergi_islemleri pd = new p_dergi_islemleri();
            pd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_makale_islemleri mi = new p_makale_islemleri();
            mi.Show();
        }

        private void p_islemler_Load(object sender, EventArgs e)
        {
            lblPersonelNo.Text = PersonelNo;

            SqlCommand command = new SqlCommand("Select PersonelAd,PersonelSoyad From Personel where PersonelNo=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", lblPersonelNo.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString() + " " + dr[1].ToString();

            }
            bgl.baglanti().Close();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            p_oda_islemleri po = new p_oda_islemleri();
            po.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p_raf_bilgisi pr = new p_raf_bilgisi();
            pr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p_ücret_islemleri pü = new p_ücret_islemleri();
            pü.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            girisler g = new girisler();
            g.Show();
            this.Hide();
        }
    }
}
