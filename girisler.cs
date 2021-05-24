using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisler
{
    public partial class girisler : Form
    {
        public girisler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            akademik_giris ag = new akademik_giris();
            ag.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel_giris pg = new Personel_giris();
            pg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci_giris og = new ogrenci_giris();
            og.Show();
            this.Hide();
        }
    }
}
