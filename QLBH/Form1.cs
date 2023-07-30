using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Class;

namespace QLBH
{
    public partial class Form1 : Form
    {
        public Form1(String username)
        {
            InitializeComponent();
            lblUsername.Text = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Function.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            DanhMucChatLieu frm = new DanhMucChatLieu();
            frm.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            DanhMucHangHoa frm = new DanhMucHangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            DanhMucNhanVien frm = new DanhMucNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            DanhMucKhachHang frm = new DanhMucKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonBanHang frm = new HoaDonBanHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TroGiup frm = new TroGiup();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
