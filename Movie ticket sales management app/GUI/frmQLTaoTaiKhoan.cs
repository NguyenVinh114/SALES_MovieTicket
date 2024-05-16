using Movie_ticket_sales_management_app.BUS;
using Movie_ticket_sales_management_app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_ticket_sales_management_app.GUI
{
    public partial class frmQLTaoTaiKhoan : Form
    {
        public frmQLTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        Modify modify = new Modify();
        QuanLyTaiKhoan quanly;

        private void frmQLTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select TenTaiKhoan as TaiKhoan, TenNhanVien, Email, ChucVu from TaiKhoanNhanVien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!" + ex.Message);
            }


        }

        private void DeleteTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void DinhDangLuoi()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Tài khoản";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[2].HeaderText = "Email";
            dataGridView1.Columns[2].Width = 450;
            dataGridView1.Columns[3].HeaderText = "Chức vụ";
            dataGridView1.Columns[3].Width = 100;
        }

        private bool CheckTextBoxes()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản!");
                return false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Mật khẩu!");
                return false;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Hãy nhập tên!");
                return false;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Hãy nhập Email!");
                return false;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Hãy nhập chức vụ!");
                return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _taikhoan = textBox1.Text;
            string _matkhau = textBox2.Text;
            string _ten = textBox3.Text;
            string _email = textBox4.Text;
            string _chucvu = textBox6.Text;
            quanly = new QuanLyTaiKhoan(_taikhoan, _matkhau, _ten, _email, _chucvu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO TaiKhoanNhanVien VALUES ('" + quanly.Taikhoan + "', '" + quanly.Matkhau + "', N'" + quanly.Ten + "', '" + quanly.Email + "', N'" + quanly.Vaitro + "' )";
                try
                {
                    if (MessageBox.Show("Bạn có muốn tạo không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Tạo thành công!");
                        frmQLTaoTaiKhoan_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            GetValuesTextBoxes();
            string query = "UPDATE TaiKhoanNhanVien SET TenNhanVien = N'" + quanly.Ten + "', Email = '" + quanly.Email + "', ChucVu = N'" + quanly.Vaitro + "'";
            query += " from TaiKhoanNhanVien Where TenTaiKhoan = '" + quanly.Taikhoan + "'";
            try
            {
                if (MessageBox.Show("Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Đã sữa");
                    frmQLTaoTaiKhoan_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cells = dataGridView1.SelectedCells;
            if (cells.Count > 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["TaiKhoan"].Value.ToString();
                textBox3.Text = row.Cells["TenNhanVien"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
                textBox6.Text = row.Cells["ChucVu"].Value.ToString();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            GetValuesTextBoxes();
            string query = "DELETE FROM TaiKhoanNhanVien WHERE TenTaiKhoan = '" + quanly.Taikhoan + "'";
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Xóa thành công!");
                    frmQLTaoTaiKhoan_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string name = textBox5.Text.Trim();
            if (name == "")
            {
                frmQLTaoTaiKhoan_Load(sender, e);
            }
            else
            {
                string query = "Select TenTaiKhoan as TaiKhoan, TenNhanVien, Email, ChucVu from TaiKhoanNhanVien where TenTaiKhoan like N'%" + name + "%' OR TenNhanVien like N'%" + name + "%' OR Email like N'%" + name + "%' OR ChucVu like N'%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);

            }
        }
    }
}
