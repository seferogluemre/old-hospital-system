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
    public partial class formSEKRETERDETAY : Form
    {
        public formSEKRETERDETAY()
        {
            InitializeComponent();
        }
        public string tcnumara;
        

        sqlbaglantı bgl = new sqlbaglantı();

        private void formSEKRETERDETAY_Load(object sender, EventArgs e)
        {

            lblTc.Text = tcnumara;

            // Ad soyad çekme 
            SqlCommand komut1 = new SqlCommand("Select sekreterADSOYAD From sekreterler1 where sekreterTC=@p1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                lblADSOYADsek.Text = dr2[0].ToString();
            }
            bgl.baglantı().Close();

            // branşları datagride aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from branşlar1", bgl.baglantı());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları liste aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktorAD+ ' '+doktorSOYAD)as 'DOKTORLAR',doktorBRANŞ From doktorlar1", bgl.baglantı());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branş comboboxa aktarma
            SqlCommand komut4 = new SqlCommand("Select branşAD from branşlar1", bgl.baglantı());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBRANŞ.Items.Add(dr4[0]);
            }
            bgl.baglantı().Close();



        }

        private void btnBranşPaneli_Click(object sender, EventArgs e)
        {
            formBRANŞEKLEME brn = new formBRANŞEKLEME();
            brn.Show();
        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            if (txtİD.Text=="" || msktxtTARİH.Text=="" || maskedTextTARİHS2.Text==""|| cmbBRANŞ.Text=="" || cmbDOKTOR.Text=="")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");

            }
            else
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Randevular (RandevuId,RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor) values(@r1,@r2,@r3,@r4,@r5)", bgl.baglantı());
                komutkaydet.Parameters.AddWithValue("@r1", txtİD.Text);
                komutkaydet.Parameters.AddWithValue("@r2", msktxtTARİH.Text);
                komutkaydet.Parameters.AddWithValue("@r3", maskedTextTARİHS2.Text);
                komutkaydet.Parameters.AddWithValue("@r4", cmbBRANŞ.Text);
                komutkaydet.Parameters.AddWithValue("@r5", cmbDOKTOR.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Randevu oluşturuldu");
            }

        }

        private void cmbBRANŞ_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Branş seçildigi zaman branşa göre doktor listeleme 
            cmbDOKTOR.Items.Clear();
            SqlCommand komut5 = new SqlCommand("Select doktorAD,doktorSOYAD from doktorlar1 where doktorBRANŞ=@p1", bgl.baglantı());
            komut5.Parameters.AddWithValue("@p1", cmbBRANŞ.Text);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                cmbDOKTOR.Items.Add(dr5[0] + " " + dr5[1]);

            }
            bgl.baglantı().Close();


        }

        private void btnDuyuruOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into duyurular1 (duyuru) values (@d1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1", rchDUYURU.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
            
        }

        private void btnDOKTORPANELİ_Click(object sender, EventArgs e)
        {
            formDOKTORPANELİSEK doktor = new formDOKTORPANELİSEK();
            doktor.Show();
        
            
        }

        private void msktxtTARİH_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRandevuLİst_Click(object sender, EventArgs e)
        {
            formRANDEVULARLİSTE fr1 = new formRANDEVULARLİSTE();
            fr1.Show();
        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtİD.Text = "";
            msktxtTARİH.Text = "";
            maskedTextTARİHS2.Text = "";
            cmbBRANŞ.Text = "";
            cmbDOKTOR.Text = "";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            formDUYURULAR duyur = new formDUYURULAR();
            duyur.Show();
        }
        private void hAKKIMZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımızda hkmzda = new hakkımızda();
            hkmzda.Show();
            
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
            formSEKRETERDETAY sekdty = new formSEKRETERDETAY();
            sekdty.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult tep = new DialogResult();
            tep = MessageBox.Show("Çıkış mı yapacaksınız?", "Çıkış yapıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tep == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                formSEKRETERDETAY sek2 = new formSEKRETERDETAY();
                sek2.ShowDialog();
                this.Close();
            }
        }
    }
}
