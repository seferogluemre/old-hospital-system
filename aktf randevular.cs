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
    public partial class aktf_randevular : Form
    {
        private Stack<Form> formStack = new Stack<Form>();
        public aktf_randevular()
        {

            InitializeComponent();


        }
        sqlbaglantı bg = new sqlbaglantı();

        private void aktf_randevular_Load(object sender, EventArgs e)
        {
            formStack.Push(this);

            //Form yüklendigi zaman randevu verilerini çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from randevular1 where  randevuDURUM=0", bg.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonSİL_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete from randevular1 where randevuID=@b1", bg.baglantı());
            kmt.Parameters.AddWithValue("@b1", textID.Text);
            kmt.ExecuteNonQuery();
            bg.baglantı().Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçen2 = dataGridView1.SelectedCells[0].RowIndex;
            textID.Text = dataGridView1.Rows[seçen2].Cells[0].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[seçen2].Cells[1].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[seçen2].Cells[2].Value.ToString();
            comboBoxBRANŞ.Text = dataGridView1.Rows[seçen2].Cells[3].Value.ToString();
            comboBoxDOKTOR.Text = dataGridView1.Rows[seçen2].Cells[4].Value.ToString();

        }

        private void butonGÜNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komt = new SqlCommand("Update randevular1 set randevuTARİH=@P2,randevuSAAT=@P3,randevuBRANŞ=@P4 ,randevuDOKTOR=@P5 where randevuID=@P1 AND randevuDURUM=0", bg.baglantı());
            komt.Parameters.AddWithValue("@P1", textID.Text);
            komt.Parameters.AddWithValue("@P2", maskedTextBox1.Text);
            komt.Parameters.AddWithValue("@P3", maskedTextBox2.Text);
            komt.Parameters.AddWithValue("@P4", comboBoxBRANŞ.Text);
            komt.Parameters.AddWithValue("@P5", comboBoxDOKTOR.Text);
            komt.ExecuteNonQuery();
            bg.baglantı().Close();
            MessageBox.Show("Kayıt güncellendi");
        }

      
    }
}
