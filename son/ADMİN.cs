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
    public partial class ADMİN : Form
    {
        public ADMİN()
        {
            SqlConnection con;
            SqlCommand cmd;
            InitializeComponent();
        }

        private void ADMİN_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet4.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter.Fill(this.usersDataSet4.tbuse);
            // TODO: Bu kod satırı 'dbLoginDataSet2.tbus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbusTableAdapter.Fill(this.dbLoginDataSet2.tbus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUser f4=new newUser();
             f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userDelet f4=new userDelet();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncele2 f1 = new guncele2();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chat f1 =new chat();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            faturacs f1 = new faturacs();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            refkey f1 = new refkey();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 F1=new Form1();
            F1.StartPosition = FormStartPosition.CenterScreen;
            F1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            }
}
