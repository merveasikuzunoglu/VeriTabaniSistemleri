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
    public partial class p_oda_islemleri : Form
    {
        public p_oda_islemleri()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Personel_Oda(OdaNo,Gün,TeslimSaat,ÖğrenciNo) values (@p1,@p2,@p3,@p4)", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells["OdaNo"].Value.ToString());
            command.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@p3", txtSaat.Text);
            command.Parameters.AddWithValue("@p4", txtNumara.Text);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {

            }
            MessageBox.Show("İşlem Tamamlanmıştır.", "Grup oda İşlemi", MessageBoxButtons.OK);
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From OdaBilgileri", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            bgl.baglanti().Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string deger3= dataGridView1.CurrentRow.Cells["OdaNo"].Value.ToString();
        }
    }
}
