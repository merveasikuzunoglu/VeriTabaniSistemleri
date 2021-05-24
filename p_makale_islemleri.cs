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
    public partial class p_makale_islemleri : Form
    {
        public p_makale_islemleri()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Personel_Makale(MakaleNo,AlışTarihi,TeslimTarihi,Numara) values (@p1,@p2,@p3,@p4)", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells["MakaleNo"].Value.ToString());
            command.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@p3", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@p4", txtNumara.Text);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {

            }
            MessageBox.Show("İşlem Tamamlanmıştır.", "Makale İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Makale", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string deger2 = dataGridView1.CurrentRow.Cells["MakaleNo"].Value.ToString();
        }
    }
}
