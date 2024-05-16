using Movie_ticket_sales_management_app.BUS;
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
    public partial class frmQLDangNhap : Form
    {
        public frmQLDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuenmatkhau quenMatKhau = new frmQuenmatkhau();
            quenMatKhau.ShowDialog();
        }

        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            string matkhau = textBox2.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                string query = "Select * From TaiKhoanNhanVien where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "' and ChucVu = N'" + "Quản lý" + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmQuanLy frmQuan = new frmQuanLy();
                    frmQuan.ShowDialog();
                    this.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Tên tài khản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }

            }
        }

        private void frmQLDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đóng chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void frmQLDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
