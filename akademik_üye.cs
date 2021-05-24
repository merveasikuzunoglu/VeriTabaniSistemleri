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
    public partial class akademik_üye : Form
    {
        public akademik_üye()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into AkademikPersonel(AkademisyenAd,AkademisyenSoyad,AkademisyenNo,ÜniversiteA,FakülteA) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            
            command.Parameters.AddWithValue("@p1",txtAd.Text);
            command.Parameters.AddWithValue("@p2",txtSoyad.Text);
            command.Parameters.AddWithValue("@p3",txtAkno.Text);
            command.Parameters.AddWithValue("@p4",cmbÜniversite.Text );
            command.Parameters.AddWithValue("@p5",cmbFakülte.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Üyelik İşleminiz Tamamlanmıştır.Akademisyen Numaranızla Giriş Yapabilirsiniz..","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);




        }

        private void akademik_üye_Load(object sender, EventArgs e)
        {

        }
    }
}
