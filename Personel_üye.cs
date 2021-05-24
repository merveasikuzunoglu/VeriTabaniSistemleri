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
    public partial class Personel_üye : Form
    {
        public Personel_üye()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Personel(PersonelAd,PersonelSoyad,PersonelNo) values (@p1,@p2,@p3)", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtPersonel.Text);
            
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Üyelik İşleminiz Tamamlanmıştır.Personel Numaranızla Giriş Yapabilirsiniz..", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);










        }
    }
}
