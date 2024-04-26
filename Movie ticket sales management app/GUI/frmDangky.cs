using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Movie_ticket_sales_management_app.DTO;
using Movie_ticket_sales_management_app.DAL;

namespace Movie_ticket_sales_management_app
{
    public partial class frmDangky : Form
    {
        public frmDangky()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
           
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập tên mật khẩu 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email ='" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "', '" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
                {
                  
                    this.Close();

                }

            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!");
            }

        }

        private void frmDangky_Load(object sender, EventArgs e)
        {
            textBox_TenTaiKhoan.Focus();
        }
    }
}
