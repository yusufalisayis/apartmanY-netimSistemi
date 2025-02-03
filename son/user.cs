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



namespace son
{
    public partial class user : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userChat f1 = new userChat();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            userfatura f1=new userfatura();
            f1.StartPosition=FormStartPosition.CenterScreen ;
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.CenterScreen ;
            f1.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           refkey f1 =new refkey();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }
    }
}
