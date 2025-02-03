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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace son
{
    public partial class userChat : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public userChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            string chat = "insert into tbchat (chat) values (@p1)";
            SqlCommand chatt =new  SqlCommand (chat, baglan);

           chatt.Parameters.AddWithValue("@p1", uschat.Text);
            chatt.ExecuteScalar();
            baglan.Close();
            MessageBox.Show("mesajınız gönderildi");
            uschat.Clear();
            uschat.Focus();
        }

        private void uschat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            user f1= new user();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }
    }
}
