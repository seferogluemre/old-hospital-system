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
    public partial class frmHASTAGNCLBİLGİ : Form
    {
        public frmHASTAGNCLBİLGİ()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=hastaneyönetim;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            
            
            
        }

        private void frmHASTAGNCLBİLGİ_Load(object sender, EventArgs e)
        {

        }
    }
}
