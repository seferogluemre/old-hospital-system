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
    public partial class doktor_giriş_form : Form
    {
        public doktor_giriş_form()
        {
            InitializeComponent();
        }
        sqlbaglantı bg = new sqlbaglantı();
        private void btnGİRİŞ_Click(object sender, EventArgs e)
        {
            
        }
        private void btnGİRİŞ_Click_1(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("Select * from doktorlar1 where doktorTC=@p1 and doktorŞİFRE=@p2", bg.baglantı());
            km.Parameters.AddWithValue("@p1", maskTCKİMLİKNO.Text);
            km.Parameters.AddWithValue("@p2", txtŞİFRE.Text);
            SqlDataReader dr = km.ExecuteReader();
            if (dr.Read())
            {
                doktor_detay_form dr2 = new doktor_detay_form();
                dr2.TC1 = maskTCKİMLİKNO.Text;
                MessageBox.Show("HOŞGELDİNİZ");
                dr2.Show();
              
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre","uyarı");
            }
            bg.baglantı().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
