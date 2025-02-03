using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace son
{
    public partial class userDelet : Form
    {
        public userDelet()
        {
            InitializeComponent();
        }

        private void userDelet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet13.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter3.Fill(this.usersDataSet13.tbuse);
            // TODO: Bu kod satırı 'usersDataSet3.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter2.Fill(this.usersDataSet3.tbuse);
            // TODO: Bu kod satırı 'usersDataSet2.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter1.Fill(this.usersDataSet2.tbuse);
            // TODO: Bu kod satırı 'usersDataSet1.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter.Fill(this.usersDataSet1.tbuse);
            // TODO: Bu kod satırı 'dbLoginDataSet3.tbus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbusTableAdapter.Fill(this.dbLoginDataSet3.tbus);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUser f3=new newUser();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMİN f4=new ADMİN();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            string sil = "Delete from tbuse where users_id=@Id";
            SqlCommand verisil = new SqlCommand(sil, baglan);
            verisil.Parameters.AddWithValue("@Id", users_id.Text);
            
            verisil.ExecuteNonQuery();
            baglan.Close();
       
                MessageBox.Show("kayıt başarıyla silindi ");
           
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guncele2 f1=new guncele2();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void users_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
