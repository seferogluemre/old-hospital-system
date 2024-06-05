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
    public partial class doktor_detay_form : Form
    {
        public doktor_detay_form()
        {
            InitializeComponent();
        }
        sqlbaglantı b = new sqlbaglantı();

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            formDOKTORBİLGİDÜZENLE fr = new formDOKTORBİLGİDÜZENLE();
            fr.tCno = lblTCNO3.Text;
            fr.Show();

        }
        public string TC1;
        private void doktor_detay_form_Load(object sender, EventArgs e)
        {          
            lblTCNO3.Text = TC1;

            //doktor ad soyad çekme
            SqlCommand km = new SqlCommand("Select doktorAD,doktorSOYAD from doktorlar1 where doktorTC=@p1", b.baglantı());
            km.Parameters.AddWithValue("@p1", lblTCNO3.Text);
            SqlDataReader dr = km.ExecuteReader();
            while (dr.Read())
            {
                lblADSOYAD3.Text = dr[0] + " " + dr[1];
            }
            b.baglantı().Close();

            //randevular çekme
            DataTable dt = new DataTable();
            SqlDataAdapter dar = new SqlDataAdapter("Select * From randevular1 where randevuDOKTOR='" + lblADSOYAD3.Text + "'", b.baglantı());
            dar.Fill(dt);
            dataGridView1.DataSource = dt;


            //Doktor alanını çekme (label)
            SqlCommand kmt = new SqlCommand("Select doktorBRANŞ from doktorlar1 where doktorTC=@p1 ", b.baglantı());
            kmt.Parameters.AddWithValue("@p1", lblTCNO3.Text);
            SqlDataReader dr3= kmt.ExecuteReader();
            while (dr3.Read())
            {
               lblDktrKLİNİK.Text = dr3["doktorBRANŞ"].ToString();
                
            }
            b.baglantı().Close();


            //Yöneticiden doktora gelen mesaj kontrolü
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("Select * from yöneticidenMESAJ", b.baglantı());
            da5.Fill(dt5);
            dataGridView2.DataSource = dt5;

        }

        private void btnDUYURULAR_Click(object sender, EventArgs e)
        {
            formDUYURULAR dyr = new formDUYURULAR();
            dyr.Show();

        }

        private void btnİnternet_Click(object sender, EventArgs e)
        {
            formİNTERNET nt = new formİNTERNET();
            nt.Show();
        }

        private void btnÇIKIŞ_Click(object sender, EventArgs e)
        {
            DialogResult tep = new DialogResult();
            tep = MessageBox.Show("Çıkış mı yapacaksınız?", "Çıkış yapıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tep==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                doktor_detay_form dr = new doktor_detay_form();
                dr.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Data hücreye tıklandıgı zaman tcye eşit olan hasta ad,soyad getirme

            int seçen = dataGridView1.SelectedCells[0].RowIndex;
            rchRANDEVUDETAY.Text = dataGridView1.Rows[seçen].Cells[7].Value.ToString();

            int seçen2 = dataGridView1.SelectedCells[0].RowIndex;
            label3.Text = dataGridView1.Rows[seçen2].Cells[6].Value.ToString();



            SqlCommand kmt = new SqlCommand("Select hastaAD,hastaSOYAD from hastalar1 where hastaTC=@p1 ", b.baglantı());
            kmt.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lblAD1.Text = dr["hastaAD"].ToString();
                lblSOYAD1.Text  = dr["hastaSOYAD"].ToString();
            }
            b.baglantı().Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlCommand komut = new SqlCommand("Delete from randevular1 where hastaTC=@p1", b.baglantı());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            komut.ExecuteNonQuery();
            b.baglantı().Close();
            MessageBox.Show("Randevu tamamlandı");
            dataGridView1.Refresh();
            label3.Text = "";
            lblAD1.Text = "";
            lblSOYAD1.Text = "";
            rchRANDEVUDETAY.Text = "";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımızda hkm = new hakkımızda();
            hkm.Show();
        }

     

        private void hAKKIMZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımızda hk1 = new hakkımızda();
            hk1.Show();
        }

  

      

        private void dOKTORGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void hAKKIMZDAToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            for(int i = 0; i <= 30; i++)
            {
                hAKKIMZDAToolStripMenuItem.BackColor = Color.White;
            }
           
        }

        private void hAKKIMZDAToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            for(int i = 0; i <= 30; i++)
            {
                hAKKIMZDAToolStripMenuItem.BackColor = Color.CadetBlue;

            }
          
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

        private void aLBÜMLERİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            albümler albm2 = new albümler();
            albm2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktor_detay_form detaydoktor = new doktor_detay_form();
            detaydoktor.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
