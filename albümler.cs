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
    public partial class albümler : Form
    {
        public albümler()
        {
            InitializeComponent();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımızda hak1 = new hakkımızda();
            hak1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void albümler_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            Process.Start("file:///C:/Users/yunus/OneDrive/Masa%C3%BCst%C3%BC/WEB%20TASARIM/slider.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=30; i++)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }

        private void wEBSİTEMİZToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                wEBSİTEMİZToolStripMenuItem.BackColor = Color.White;
            }
        }

        private void wEBSİTEMİZToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                wEBSİTEMİZToolStripMenuItem.BackColor = Color.CadetBlue;
            }
        }

        private void wEBSİTEMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sitemize hoşgeldiniz");
            Process.Start("https://www.kizilaysaglik.com.tr/hastanelerimiz/turk-kizilay-ticaret-borsasi-konya-hastanesi/");
        }
    }
}
