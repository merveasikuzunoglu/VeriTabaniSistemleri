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
    public partial class o_makale_islem : Form
    {
        public o_makale_islem()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Makale_Öğrenci1 where ÖğrenciNo="+txtNumara.Text, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Makale_Öğrenci2 where ÖğrenciNo="+txtNumara.Text, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            da.Dispose();
            bgl.baglanti().Close();
        }
    }
}
