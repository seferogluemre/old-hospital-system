using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
namespace Hastane_Sistemi2
{
    public partial class hasta_giriş : Form
    {
        public hasta_giriş()
        {
            InitializeComponent();
        }


        sqlbaglantı bgl = new sqlbaglantı();
        private void btnGİRİŞ_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From hastalar1 Where hastaTC=@p1 and hastaŞİFRE=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", maskTCKİMLİKNO.Text);
            komut.Parameters.AddWithValue("@p2", txtŞİFRE.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hasta_detay hstdt = new hasta_detay();
                hstdt.tc = maskTCKİMLİKNO.Text;
                MessageBox.Show("HOŞGELDİNİZ");
                hstdt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre ");
            }
            bgl.baglantı().Close();

            

        }

        private void txtŞİFRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void hasta_giriş_Load(object sender, EventArgs e)
        {

        }

        private void linkÜYEOL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hasta_kayıt hst = new hasta_kayıt();
            hst.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (checkBox1.Checked == true)
                {
                    txtŞİFRE.PasswordChar = '*';
                }
                else
                {
                    txtŞİFRE.PasswordChar = '\0';
                }
            }
        }
    }
}
