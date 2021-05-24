using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace girisler
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=PC\\SS17;Initial Catalog=kütüphane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
