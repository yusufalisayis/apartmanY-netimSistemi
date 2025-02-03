using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace son
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public static class FormData
        {
            public static string SharedInfo { get; set; }

        }
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM tbuse WHERE usName = @user";
            con = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@user", userName.Text);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string hashedPasswordFromDatabase = dr["usPwd1"].ToString();

           
                string userInputPassword = userPwd.Text;

                bool passwordMatches = BCrypt.Net.BCrypt.Verify(userInputPassword, hashedPasswordFromDatabase);

                if (passwordMatches)
                {
                    bool isadmin = Convert.ToBoolean(dr["rool"]);

                    if (isadmin)
                    {
                        this.Hide();
                        Console.WriteLine("Admin sayfasına yönlendiriliyorsunuz.");
                        ADMİN f4 = new ADMİN();
                        f4.StartPosition = FormStartPosition.CenterScreen;
                        f4.Show();
                    }
                    else
                    {
                        this.Hide();
                        Console.WriteLine("Kullanıcı sayfasına yönlendiriliyorsunuz.");
                        user f1 = new user();
                        f1.StartPosition = FormStartPosition.CenterScreen;
                        f1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Şifre hatalı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newpwd f1 = new newpwd();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
