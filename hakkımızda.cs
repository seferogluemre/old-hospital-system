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
    public partial class hakkımızda : Form
    {
        public hakkımızda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.MistyRose;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control;
        }

        private void hASTAGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            hasta_giriş grş = new hasta_giriş();
            grş.Show();
            
            this.Hide();
        }

        private void sEKRETERGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSEKRETERGİRİA skr = new formSEKRETERGİRİA();
            skr.Show();
            this.Hide();
        }

        private void dOKTORGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doktor_giriş_form dktr = new doktor_giriş_form();
            dktr.Show();
            this.Hide();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            hakkımızda hk3 = new hakkımızda();
            hk3.BackColor = Color.LightCyan;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            hakkımızda hkm1 = new hakkımızda();
            hkm1.BackColor = SystemColors.Control;
        }

        private void hakkımızda_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                pictureBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                pictureBox1.Visible = false;
                panel1.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Hastanemize kaydınız varmı?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (tepki==DialogResult.Yes)
            {
                hasta_giriş grş5 = new hasta_giriş();
                grş5.Show();
                this.Hide();

            }
            else
            {
                DialogResult tepki2 = new DialogResult();
                tepki2 = MessageBox.Show("Üye olmak istermisiniz", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tepki2==DialogResult.Yes)
                {
                    hasta_kayıt kayıt = new hasta_kayıt();
                    kayıt.Show();
                    kayıt.StartPosition = FormStartPosition.WindowsDefaultLocation;
                }
                else
                {
                    hakkımızda h = new hakkımızda();
                    h.Show();
                }
            }
        }

        private void aLBÜMLERİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            albümler albm1 = new albümler();
            albm1.Show();

        }

        private void aLBÜMLERİMİZToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                aLBÜMLERİMİZToolStripMenuItem.BackColor = Color.White;
            }
        }

        private void aLBÜMLERİMİZToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                aLBÜMLERİMİZToolStripMenuItem.BackColor = Color.CadetBlue;
            }
        }

        private void wEBSİTEMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kizilaysaglik.com.tr/hastanelerimiz/turk-kizilay-ticaret-borsasi-konya-hastanesi/");
            
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
    }
}
