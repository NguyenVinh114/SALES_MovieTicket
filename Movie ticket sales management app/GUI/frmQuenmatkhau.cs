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
    public partial class frmQuenmatkhau : Form
    {
        public frmQuenmatkhau()
        {
            InitializeComponent();
            label2.Text = "";
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đã đăng ký!"); }

            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
           

                if ((modify.TaiKhoans(query).Count != 0))
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
              
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email chưa được đăng ký!";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
           
           
            
        }

        private void frmQuenmatkhau_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
