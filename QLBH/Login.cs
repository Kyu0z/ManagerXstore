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
using QLBH.Class;


namespace QLBH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Server=LAPTOP-KD\SQLEXPRESS;Database=QLBHWF;Trusted_Connection=True;TrustServerCertificate=True");
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            if(username == null || username.Equals(""))
            {
                MessageBox.Show("Chưa nhập username");
                return;
            }
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("Chưa nhập password");
                return;
            }
            sqlcon.Open();
            string query = "Select Username,Password from Login Where Username = '" + username + "' and Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dt = cmd.ExecuteReader();

            if (dt.Read())
            {
                MessageBox.Show("Login Thanh cong");
                Form1 frm = new Form1(username);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login That Bai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
