using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static son.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace son
{
    public partial class newpwd : Form
    {
        SqlCommand cmd;
        public newpwd()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Random ras=new Random();
            string karakterler = "QWERTYUIOPĞÜİŞLKJHGFDSAZXCVBNMÖÇqwertyuıopğüişlkjhgfdsazxcvbnmöç1234567890";
            string sonuc = "";
            string kod="";
            for (int i = 0; i<8; i++){
                sonuc += karakterler[ras.Next(karakterler.Length)];
              
            }
            kod = sonuc;
            MailMessage sms = new MailMessage("goncapartmani@outlook.com", textBox1.Text, "YENİ ŞİFRE", "\t\t\t\t\t\t\tYeni şifrenizi kimseyle paylaşmayınız.\n\t\t\t\t\t\t\tGüvenlik kodu:"+ kod);
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential("goncapartmani@outlook.com", "252380yu");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;
            smtpClient.Send(sms);
            MessageBox.Show("şifre gönderilmiştir");

            var passwordHash = BCrypt.Net.BCrypt.HashPassword(kod);
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            string upload = "UPDATE tbuse SET usPwd1=@p1 WHERE usEposta=@p2";

            SqlCommand ekle = new SqlCommand(upload, baglan);
            ekle.Parameters.AddWithValue("@p1", passwordHash); // Şifreyi hashlenmiş haliyle ekliyoruz
            ekle.Parameters.AddWithValue("@p2", textBox1.Text); // E-posta adresi parametresi

            ekle.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Şifre başarıyla güncellendi ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.StartPosition=FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }
    }
}
