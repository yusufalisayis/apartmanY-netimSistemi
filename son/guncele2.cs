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
    public partial class guncele2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public guncele2()
        {
            InitializeComponent();
        }

        private void guncele2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'usersDataSet11.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter1.Fill(this.usersDataSet11.tbuse);
            // TODO: Bu kod satırı 'usersDataSet5.tbuse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbuseTableAdapter.Fill(this.usersDataSet5.tbuse);
            // TODO: Bu kod satırı 'dbLoginDataSet4.tbus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbusTableAdapter.Fill(this.dbLoginDataSet4.tbus);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADMİN f3 = new ADMİN();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KDPN9BRS\\MSSQLSERVER01;Initial Catalog=users;Integrated Security=True");
            baglan.Open();
            int adrool = 0; // Varsayılan olarak 0 (kullanıcı) rolü atanır

            if (userRool.SelectedItem.ToString() == "Admin")
            {
                adrool = 1; // Eğer admin seçildiyse rol değeri bir olur
            }
            string upload = "UPDATE tbuse SET usEposta='"+userEposta.Text+"', usPhon='"+userPhonNum.Text+"', usGG='"+userGG.Text+"' ' ,usHomNo='"+userHomeNo.Text+"',  usDoorNo='"+userDoorNo.Text+", rool='"+adrool+"' where users_id="+usersid.Text;
            SqlCommand ekle = new SqlCommand(upload, baglan);
           
            ekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kayıt başarıyla güncellendi ");
        }
    }
}
