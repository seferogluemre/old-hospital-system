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
    public partial class hasta_detay : Form
    {
        public hasta_detay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantı bgl = new sqlbaglantı();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
       
        private void hasta_detay_Load(object sender, EventArgs e)
        {

            // ad soyad çekme
            lblTCKMLKNO2.Text = tc;
            SqlCommand komut = new SqlCommand("Select hastaAD,hastaSOYAD From hastalar1 where hastaTC=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lblTCKMLKNO2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblhstADSoyad2.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglantı().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular1 where hastaTC="+tc ,bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select branşAD From branşlar1", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBRANŞ.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();


        }

        private void cmbDOKTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular1 where randevuBRANŞ='" + cmbBRANŞ.Text + "'" + " and randevuDOKTOR='" + cmbDOKTOR.Text+"' and randevuDURUM=0", bgl.baglantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void cmbBRANŞ_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDOKTOR.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAD,doktorSOYAD From doktorlar1 where doktorBRANŞ=@p1", bgl.baglantı());
            komut3.Parameters.AddWithValue("@p1", cmbBRANŞ.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDOKTOR.Items.Add(dr3[0]+" "+dr3[1]);

            }
            bgl.baglantı().Close();
        }
        
        private void linkLBİLGİDÜZENLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHASTABLGDÜZENLE frm1 = new frmHASTABLGDÜZENLE();
            frm1.Tcno = lblTCKMLKNO2.Text;
            frm1.Show();

          
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            


        }

        private void btnRANDEVUAL_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update randevular1 Set randevuDURUM=1,hastaTC=@p1,hastaŞİKAYET=@p2 where randevuID=@p3", bgl.baglantı());
            kmt.Parameters.AddWithValue("@p1", lblTCKMLKNO2.Text);
            kmt.Parameters.AddWithValue("@p2", richŞİKAYT.Text);
            kmt.Parameters.AddWithValue("@p3", txtID.Text);
            kmt.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seç = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[seç].Cells[0].Value.ToString();
        }

        private void hASTANEGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hASTAGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sEKRETERGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSEKRETERGİRİA sk2 = new formSEKRETERGİRİA();
            sk2.Show();
            this.Hide();
        }

        private void dOKTORGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doktor_giriş_form dk = new doktor_giriş_form();
            dk.Show();
            this.Hide();
        }

        private void hAKKIMZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımızda hkmz = new hakkımızda();
            hkmz.Show();
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

        private void hAKKIMZDAToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                hAKKIMZDAToolStripMenuItem.BackColor = Color.White;
            }
           
        }

        private void hAKKIMZDAToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                hAKKIMZDAToolStripMenuItem.BackColor = Color.CadetBlue;
            }
        }

        private void aLBÜMLERİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            albümler albm = new albümler();
            albm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hasta_detay hstdety = new hasta_detay();
            hstdety.ShowDialog();
        }
    }
}
