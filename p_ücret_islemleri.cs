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
    public partial class p_ücret_islemleri : Form
    {
        public p_ücret_islemleri()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            DataTable dt = new DataTable();
            
            SqlDataAdapter da = new SqlDataAdapter("Select * From Ücretİşlem_Kaynak where Numara=" +txtNumara.Text, bgl.baglanti());
            
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            da.Dispose();
            bgl.baglanti().Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DergiFiyat", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            
        }

        private void p_ücret_islemleri_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz Tamamlanmıştır", "Dergi Ücret İşlemi", MessageBoxButtons.OK);
            p_islemler pi = new p_islemler();
            pi.Show();
            this.Hide();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Ücretİşlem_Kaynak where KaynaktürNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTür.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
