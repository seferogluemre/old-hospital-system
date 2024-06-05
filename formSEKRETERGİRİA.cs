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
    public partial class formSEKRETERGİRİA : Form
    {
        public formSEKRETERGİRİA()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
       
        private void buttongiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From sekreterler1 where sekreterTC=@p1 and sekreterŞİFRE=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", MSKTCNO.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                formSEKRETERDETAY sek1 = new formSEKRETERDETAY();
                sek1.tcnumara = MSKTCNO.Text;
                MessageBox.Show("HOŞGELDİNİZ");
                sek1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            bgl.baglantı().Close();
           
        }

        private void formSEKRETERGİRİA_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i <= 15; i++)
            {
                if (checkBox1.Checked==true)
                {
                    txtSifre.PasswordChar = '*';
                }
                else
                {
                    txtSifre.PasswordChar = '\0';
                }
            }
        }
    }
}
