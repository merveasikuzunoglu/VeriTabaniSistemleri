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
    public partial class ogrenci_üye : Form
    {
        public ogrenci_üye()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Öğrenci(ÖğrenciAd,ÖğrenciSoyad,ÖğrenciNo,Üniversite_Ö,Fakülte_Ö,Bölüm_Ö) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtÖğno.Text);
            command.Parameters.AddWithValue("@p4", cmbÜni.Text);
            command.Parameters.AddWithValue("@p5", cmbFakülte.Text);
            command.Parameters.AddWithValue("@p6", cmbBölüm.Text);

            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Üyelik İşleminiz Tamamlanmıştır.Öğrenci Numaranızla Giriş Yapabilirsiniz..", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrenci_giris oü = new ogrenci_giris();
            this.Hide();
            oü.Show();

        }       
    }
}
