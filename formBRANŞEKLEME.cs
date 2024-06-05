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
    public partial class formBRANŞEKLEME : Form
    {
        public formBRANŞEKLEME()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void butonEKLE_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into branşlar1 (branşID,branşAD) values (@p1,@p2) ", bgl.baglantı());
            kmt.Parameters.AddWithValue("@p1", textID.Text);
            kmt.Parameters.AddWithValue("@p2", txtBranşAD.Text);
            kmt.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Branş Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        
        }

        private void formBRANŞEKLEME_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From branşlar1", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.SelectedCells[0].RowIndex;
            textID.Text = dataGridView1.Rows[deger].Cells[0].Value.ToString();
            txtBranşAD.Text = dataGridView1.Rows[deger].Cells[1].Value.ToString();

        }

        private void butonSİL_Click(object sender, EventArgs e)
        {
            //Branş Silme
            SqlCommand kmt = new SqlCommand("Delete from branşlar1 where branşID=@b1", bgl.baglantı());
            kmt.Parameters.AddWithValue("@b1", textID.Text);
            kmt.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Branş Silindi!");

        }

        private void butonGÜNCELLE_Click(object sender, EventArgs e)
        {
            //branş güncelleme
            SqlCommand kmt1 = new SqlCommand("Update branşlar1 set branşID=@p1 where branşAD=@p2", bgl.baglantı());
            kmt1.Parameters.AddWithValue("@p1", textID.Text);
            kmt1.Parameters.AddWithValue("@p2", txtBranşAD.Text);
            kmt1.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Branş güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBRANŞEKLEME branş = new formBRANŞEKLEME();
            branş.ShowDialog();
        }
    }
}
