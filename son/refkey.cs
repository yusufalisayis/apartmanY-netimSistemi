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
using System.Net.Mail;

namespace son
{
    public partial class refkey : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public refkey()
        {
            InitializeComponent();
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();

            // Örnek olarak, 'tbuse' tablosundan bir kullanıcının bilgilerini alalım (örneğin ilk sıradaki kullanıcı)
            string sorgu = "SELECT * FROM tbuse WHERE users_id = 21"; // ID = 1 olan kullanıcıyı seçiyoruz (bu kısmı kendi mantığınıza göre düzenlemelisiniz)
            SqlCommand cmd = new SqlCommand(sorgu, baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                labelUserName.Text = "isim: " + dr["usName"].ToString();
                labelUserSurname.Text = "soyisim: " + dr["usSurname"].ToString();
                labelUserEposta.Text = "Eposta: " + dr["usEposta"].ToString();
                labelUserPhonNum.Text = "telefon numarası: " + dr["usPhon"].ToString();
                labelUserGG.Text = "medeni durum: " + dr["usGG"].ToString();
                labelUserHomeNo.Text = "kat No: " + dr["usHomNo"].ToString();
                labelUserDoorNo.Text = "Dkapı No: " + dr["usDoorNo"].ToString();
                labelUserSex.Text = "cinsiyet: " + dr["usSex"].ToString();

            }

            baglan.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gonder_Click(object sender, EventArgs e)
        {
           

        }

        private void refkey_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet9.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter.Fill(this.usersDataSet9.tbuse);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user f1 = new user();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
