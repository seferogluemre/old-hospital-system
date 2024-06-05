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
    public partial class bekleyen_hastalar : Form
    {
        public bekleyen_hastalar()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bekleyen_hastalar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from randevular1 where  randevuDURUM=1", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seç = dataGridView1.SelectedCells[0].RowIndex;
            txtdoktorADSOYADbklynhastalar.Text = dataGridView1.Rows[seç].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into yöneticidenMESAJ (yöneticiMESAJI2,yöneticiMESAJDKTR) values (@m1,@m2)", bgl.baglantı());
            komut2.Parameters.AddWithValue("@m1", richTextBox1.Text);
            komut2.Parameters.AddWithValue("@m2", txtdoktorADSOYADbklynhastalar.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Mesaj gönderildi");    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i <= 50; i++)
            {
                if (checkBox1.Checked==true)
                {
                    label3.Visible = true;
                   txtdoktorADSOYADbklynhastalar.Visible = true;
                    label5.Visible = true;
                    richTextBox1.Visible = true;
                    button2.Visible = true;
                }
                else
                {
                    label3.Visible = false;
                    txtdoktorADSOYADbklynhastalar.Visible = false;
                    label5.Visible = false;
                    richTextBox1.Visible = false;
                    button2.Visible = false;
                }
              
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
