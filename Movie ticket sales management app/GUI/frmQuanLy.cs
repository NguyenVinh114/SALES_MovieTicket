using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_ticket_sales_management_app.GUI
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTaoTaiKhoan frmQLTaoTaiKhoan = new frmQLTaoTaiKhoan();
            frmQLTaoTaiKhoan.ShowDialog();
            this.Show();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLThongTinKhachHang frmQLThongTinKhachHang = new frmQLThongTinKhachHang();
            frmQLThongTinKhachHang.ShowDialog();
            this.Show();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhuyenMai frmKhuyenMai = new frmKhuyenMai();
            frmKhuyenMai.ShowDialog();
            this.Show();
        }
    }
}
