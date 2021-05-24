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
    public partial class a_kitap_islem : Form
    {
        public a_kitap_islem()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();
        public string AkademisyenNo;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Kitap_Akademisyen_1 where AkademisyenNo= "+txtNumara.Text, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
            bgl.baglanti().Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       DataTable dt = new DataTable();
       SqlDataAdapter da = new SqlDataAdapter("Select * From Kitap_Akademisyen2 where AkademisyenNo= "+txtNumara.Text, bgl.baglanti());
            
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            da.Dispose();
            bgl.baglanti().Close();
        }

        private void a_kitap_islem_Load(object sender, EventArgs e)
        {
           

        }
    }
}
