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
    public partial class formDOKTORPANELİSEK : Form
    {
        public formDOKTORPANELİSEK()
        {
            InitializeComponent();
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void formDOKTORPANELİSEK_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From doktorlar1", bgl.baglantı());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //branş comboboxa çekme
            SqlCommand komut4 = new SqlCommand("Select branşAD from branşlar1", bgl.baglantı());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                cmbbxBRANŞ.Items.Add(dr4[0]);
            }
            bgl.baglantı().Close();

        }
       

       
        private void butonEKLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into doktorlar1 (doktorID,doktorAD,doktorSOYAD,doktorBRANŞ,doktorTC,doktorŞİFRE) values (@d1,@d2,@d3,@d4,@d5,@d6)", bgl.baglantı());
            komut2.Parameters.AddWithValue("@d1", txtID.Text);
            komut2.Parameters.AddWithValue("@d2", txtAD.Text);
            komut2.Parameters.AddWithValue("@d3", txtSOYAD.Text);
            komut2.Parameters.AddWithValue("@d4", cmbbxBRANŞ.Text);
            komut2.Parameters.AddWithValue("@d5", maskedTC.Text);
            komut2.Parameters.AddWithValue("@d6", txtŞİFRE.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Doktor Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

  

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtSOYAD.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            cmbbxBRANŞ.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            maskedTC.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            txtŞİFRE.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();

        }

        private void butonSİL_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Delete from doktorlar1 where doktorTC=@p1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@p1", maskedTC.Text);
            komut1.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void butonGÜNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update doktorlar1 set doktorID=@d1,doktorAD=@d2,doktorSOYAD=@d3,doktorBRANŞ=@d4,doktorŞİFRE=@d5 where doktorTC=@d6", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1", txtID.Text);
            komut.Parameters.AddWithValue("@d2", txtAD.Text);
            komut.Parameters.AddWithValue("@d3", txtSOYAD.Text);
            komut.Parameters.AddWithValue("@d4", cmbbxBRANŞ.Text);
            komut.Parameters.AddWithValue("@d5", txtŞİFRE.Text);
            komut.Parameters.AddWithValue("@d6", maskedTC.Text);         
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Bilgiler güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
