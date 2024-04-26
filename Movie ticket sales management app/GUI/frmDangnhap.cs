using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_ticket_sales_management_app.DTO;
using Movie_ticket_sales_management_app.DAL;

namespace Movie_ticket_sales_management_app
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
          textBox1_TenTaiKhoan.Focus();
            //Background background = new Background();
            //background.ShowDialog();
            

        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmQuenmatkhau quenMatKhau = new frmQuenmatkhau();
            quenMatKhau.ShowDialog();
           

        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangky dangky = new frmDangky();
            dangky.ShowDialog();
            
        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1_TenTaiKhoan.Text;
            string matkhau = textBox2_MatKhau.Text;
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
                string query = "Select * From TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information );
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên tài khản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }

            }    
        }
    }
}
