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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            doktor_giriş_form drgiriş1 = new doktor_giriş_form();
            drgiriş1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasta_giriş hstgiriş1 = new hasta_giriş();
            hstgiriş1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formSEKRETERGİRİA sekgiriş = new formSEKRETERGİRİA();
            sekgiriş.Show();
            this.Hide(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hasta_kayıt kyt1 = new hasta_kayıt();
            kyt1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İLETİŞİM ilet2 = new İLETİŞİM();
            ilet2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hakkımızda hk1 = new hakkımızda();
            hk1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Çıkış istediginize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (tepki==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            YÖNETİCİ_GİRİŞ girş = new YÖNETİCİ_GİRİŞ();
            girş.Show();
            this.Hide();

        }
    }
}
