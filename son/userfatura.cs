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
    public partial class userfatura : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public userfatura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user f1=new user();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
        }

        private void userfatura_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet8.tbfatura' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbfaturaTableAdapter.Fill(this.usersDataSet8.tbfatura);

        }

        private void okUserfatura_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            string sil = "delete from tbfatura where fatura_id=@p1";
            SqlCommand faturasil=new SqlCommand(sil,baglan);
            faturasil.Parameters.AddWithValue("@p1", okFatura.Text);
            faturasil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("fatura silindi");

        }
    }
}
