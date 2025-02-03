using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace son
{
    public partial class chat : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public chat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMİN F1 =new ADMİN();
            F1.StartPosition=FormStartPosition.CenterScreen;
            F1.Show();
            this.Hide();

        }

        private void chat_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet14.tbchat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbchatTableAdapter1.Fill(this.usersDataSet14.tbchat);
            // TODO: Bu kod satırı 'usersDataSet6.tbchat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbchatTableAdapter.Fill(this.usersDataSet6.tbchat);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();

            string sil = "Delete from tbchat where chat_id=@Id";
            SqlCommand verisil = new SqlCommand(sil, baglan);
            verisil.Parameters.AddWithValue("@Id", chat_id.Text);

            verisil.ExecuteNonQuery();
            baglan.Close();
            tablo.Refresh();

            MessageBox.Show("mesaj başarıyla silindi ");
            chat_id.Clear();
            chat_id.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void chat_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
