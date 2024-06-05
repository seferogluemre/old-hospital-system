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
    public partial class frmHASTABLGDÜZENLE : Form
    {
        public frmHASTABLGDÜZENLE()
        {
            InitializeComponent();
        }
        public string Tcno;

        sqlbaglantı bgl = new sqlbaglantı();
        private void frmHASTABLGDÜZENLE_Load(object sender, EventArgs e)
        {
            MSKTCNO.Text = Tcno;
            SqlCommand komut = new SqlCommand("Select * From hastalar1 where hastaTC=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", MSKTCNO.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textAD.Text = dr[1].ToString();
                textSOYAD.Text = dr[2].ToString();
                MSKTELNO.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbBoxCins.Text = dr[6].ToString();
            }
            bgl.baglantı().Close();
            
        }
        
        private void butonDÜZENLEBİLGİ_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update hastalar1 set hastaAD=@p1,hastaSOYAD=@p2,hastaTELNO=@p3,hastaŞİFRE=@p4,hastaCİNS=@p5 where hastaTC=@p6", bgl.baglantı());
            komut2.Parameters.AddWithValue("@p1", textAD.Text);
            komut2.Parameters.AddWithValue("@p2", textSOYAD.Text);
            komut2.Parameters.AddWithValue("@p3", MSKTELNO.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbBoxCins.Text);
            komut2.Parameters.AddWithValue("@p6", MSKTCNO.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

      
    }
}
