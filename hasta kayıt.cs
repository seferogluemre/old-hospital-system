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
    public partial class hasta_kayıt : Form
    {
        public hasta_kayıt()
        {
            InitializeComponent();
        }
        
        private void hasta_kayıt_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void btnHastaKAYIT_Click(object sender, EventArgs e)
        {
            if (textID.Text=="" || txtAD.Text=="" || txtSOYAD.Text=="" || mskTC.Text=="")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into hastalar1 (hastaID,hastaAD,hastaSOYAD,hastaTC,hastaTELNO,hastaŞİFRE,hastaCİNS) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", textID.Text);
                komut.Parameters.AddWithValue("@p2", txtAD.Text);
                komut.Parameters.AddWithValue("@p3", txtSOYAD.Text);
                komut.Parameters.AddWithValue("@p4", mskTC.Text);
                komut.Parameters.AddWithValue("@p5", mskTEL.Text);
                komut.Parameters.AddWithValue("@p6", txtŞİFRE.Text);
                komut.Parameters.AddWithValue("@p7", cmbCİNSİYET.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("KAYDINIZ GERÇEKLEŞMİŞTİR ŞİFRENİZ : " + txtŞİFRE.Text, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        
        }
    }
}
