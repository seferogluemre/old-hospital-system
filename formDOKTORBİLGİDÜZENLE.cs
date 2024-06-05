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
    public partial class formDOKTORBİLGİDÜZENLE : Form
    {
        public formDOKTORBİLGİDÜZENLE()
        {
            InitializeComponent();
        }
        sqlbaglantı bg = new sqlbaglantı();
        public string tCno;
        private void formDOKTORBİLGİDÜZENLE_Load(object sender, EventArgs e)
        {
            mskTC.Text = tCno;

            SqlCommand komut = new SqlCommand("Select * From doktorlar1 where doktorTC=@P1", bg.baglantı());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAD.Text = dr[1].ToString();
                txtSOYAD.Text = dr[2].ToString();
                cmbBranş.Text = dr[3].ToString();
                txtŞİFRE.Text = dr[5].ToString();

            }
            bg.baglantı().Close();
        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {

            SqlCommand komt = new SqlCommand("Update doktorlar1 set doktorAD=@P1,doktorSOYAD=@P2,doktorBRANŞ=@P3,doktorŞİFRE=@P4 where doktorTC=@P5", bg.baglantı());
            komt.Parameters.AddWithValue("@P1", txtAD.Text);
            komt.Parameters.AddWithValue("@P2", txtSOYAD.Text);
            komt.Parameters.AddWithValue("@P3", cmbBranş.Text);
            komt.Parameters.AddWithValue("@P4", txtŞİFRE.Text);
            komt.Parameters.AddWithValue("@P5", mskTC.Text);
            komt.ExecuteNonQuery();
            bg.baglantı().Close();
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
