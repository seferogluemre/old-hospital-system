using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hastane_Sistemi2
{
    class sqlbaglantı
    {
        public SqlConnection baglantı()
        {
            SqlConnection baglan = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=hastaneyönetim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
