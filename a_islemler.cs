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
    public partial class a_islemler : Form
    {
        public a_islemler()
        {
            InitializeComponent();
        }
        public string AkademisyenNo;
        sqlbaglanti bgl = new sqlbaglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            a_makale_islem mk = new a_makale_islem();
            mk.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a_kitap_islem ak = new a_kitap_islem();
            ak.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a_dergi_islem ad = new a_dergi_islem();
            ad.Show();
        }

        private void a_islemler_Load(object sender, EventArgs e)
        {   lblNo.Text=AkademisyenNo;
            
            SqlCommand command = new SqlCommand("Select AkademisyenAd,AkademisyenSoyad From AkademikPersonel where AkademisyenNo=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", lblNo.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text  = dr[0].ToString()+" "+dr[1].ToString();
                
            }
            bgl.baglanti().Close();

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            girisler g = new girisler();
            g.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
