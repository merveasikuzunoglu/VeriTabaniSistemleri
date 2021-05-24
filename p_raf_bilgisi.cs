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
    public partial class p_raf_bilgisi : Form
    {
        public p_raf_bilgisi()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz Tamamlanmıştır..","Raf Bilgisi",MessageBoxButtons.OK);
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From RafBilgisi_Kitap ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            }

            else if (textBox1.Text == "2")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From RafBilgisi_Dergi ", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }

            else if (textBox1.Text == "3")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From RafBilgisi_Makale ", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }







        }
    }
}
