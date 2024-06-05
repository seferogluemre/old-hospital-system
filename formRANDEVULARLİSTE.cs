using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hastane_Sistemi2
{
    public partial class formRANDEVULARLİSTE : Form
    {
        public formRANDEVULARLİSTE()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void formRANDEVULARLİSTE_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from randevular1 where randevuDURUM=0", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
