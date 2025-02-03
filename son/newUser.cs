using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace son
{
    public partial class newUser : Form
    {

         private string hash = "www.emrekoyuncu.net";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public newUser()
        {   

            InitializeComponent();

          
        }

        private void newUser_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbLoginDataSet6.tbus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbusTableAdapter.Fill(this.dbLoginDataSet6.tbus);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMİN a1 = new ADMİN();

            a1.StartPosition = FormStartPosition.CenterScreen;
            a1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var passwordHash = BCrypt.Net.BCrypt.HashPassword(userPwd1.Text);

                

                SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            string kayıt = "insert into tbuse(usName,usSurname,usEposta,usPhon,usGG,usPwd1,usBload,usHomNo,usDoorNo,usSex,rool,ustime) values (@p1,@p2,@p3,@p4,@p5,@p6,@p8,@p9,@p10,@p11,@p12,@p13)";
            SqlCommand ekle = new SqlCommand(kayıt, baglan);
            ekle.Parameters.AddWithValue("@p1", userName.Text);
            ekle.Parameters.AddWithValue("@p2", userSurname.Text);
            ekle.Parameters.AddWithValue("@p3", userEposta.Text);
            ekle.Parameters.AddWithValue("@p4", userPhonNum.Text);
            ekle.Parameters.AddWithValue("@p5", userGG.Text);
            ekle.Parameters.AddWithValue("@p6", passwordHash);
            ekle.Parameters.AddWithValue("@p8", userBload.Text);
            ekle.Parameters.AddWithValue("@p9", userHomeNo.Text);
            ekle.Parameters.AddWithValue("@p10", userDoorNo.Text);
            ekle.Parameters.AddWithValue("@p11", userSex.Text);
            ekle.Parameters.AddWithValue("@p13", userDateTime.Value);
            int adrool = 0; // Varsayılan olarak 0 (kullanıcı) rolü atanır

            if (userRool.SelectedItem.ToString() == "Admin")
            {
                adrool = 1; // Eğer admin seçildiyse rol değeri bir olur
            }

            ekle.Parameters.AddWithValue("@p12",adrool);
            ekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kayıt başarıyla eklendi ");

        }

        

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
