using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hastane_Sistemi2
{
    public partial class yönetici_panel : Form
    {
        public yönetici_panel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aktf_randevular aktf = new aktf_randevular();
            aktf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bekleyen_hastalar bek1 = new bekleyen_hastalar();
            bek1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hasta_kayıt kyt = new hasta_kayıt();
            kyt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İLETİŞİM ilet1 = new İLETİŞİM();
            ilet1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formDOKTORPANELİSEK doktor = new formDOKTORPANELİSEK();
            doktor.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kizilaysaglik.com.tr/hastanelerimiz/turk-kizilay-ticaret-borsasi-konya-hastanesi/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 fr2 = new Form1();
            fr2.Show();
            this.Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                panel1.BackColor = Color.Silver;
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                panel1.BackColor = Color.LightSeaGreen;
            }
        }

        private void yönetici_panel_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.kizilaysaglik.com.tr/hastanelerimiz/konya-kizilay-hastanesi/");
        }
    }
}
