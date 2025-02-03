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
    public partial class faturacs : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public faturacs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMİN f1 = new ADMİN();
            f1.StartPosition=FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            string ekle = "insert into tbfatura (faturaIsim,faturaFiyat) values (@p1,@p2) ";

            SqlCommand fat=new SqlCommand(ekle,baglan);
            fat.Parameters.AddWithValue("@p1" ,faturaN.Text);
            fat.Parameters.AddWithValue("@p2", faturafiyat.Text);
            fat.Parameters.AddWithValue("@p3",userid.Text);
            fat.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("faturra eklenmiştir");

        }

        private void faturacs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet12.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter1.Fill(this.usersDataSet12.tbuse);
            // TODO: Bu kod satırı 'usersDataSet7.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter.Fill(this.usersDataSet7.tbuse);

        }
    }
}
