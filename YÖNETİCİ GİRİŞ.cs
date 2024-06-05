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
    public partial class YÖNETİCİ_GİRİŞ : Form
    {
        public YÖNETİCİ_GİRİŞ()
        {
            InitializeComponent();
        }
        sqlbaglantı bg = new sqlbaglantı();
        private void btnGİRİŞ_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From yönetici1 Where yöneticiTC=@p1 and yöneticiŞİFRE=@p2", bg.baglantı());
            komut.Parameters.AddWithValue("@p1", maskTCKİMLİKNO.Text);
            komut.Parameters.AddWithValue("@p2", txtŞİFRE.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                yönetici_panel yönet1 = new yönetici_panel();
                yönet1.Show();
                this.Hide();
              
                
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre ");
            }
            bg.baglantı().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void YÖNETİCİ_GİRİŞ_Load(object sender, EventArgs e)
        {

        }
    }
}
