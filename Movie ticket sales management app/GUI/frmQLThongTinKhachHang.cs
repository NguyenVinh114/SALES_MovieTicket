using Movie_ticket_sales_management_app.BUS;
using Movie_ticket_sales_management_app.DTO;
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
    public partial class frmQLThongTinKhachHang : Form
    {
        public frmQLThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            comboBox1.ResetText();
        }

        Modify modify = new Modify();
        QuanLyThongTinKhachHang quanly;

        private void frmQLThongTinKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("select TenTaiKhoan, MatKhau, TenKhachHang, Phai, Email, DiaChi, VIP, TichLuy from TaiKhoanKhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            DeleteTextBoxes();
            DinhDangLuoi();
        }

        private void DeleteTextBoxes()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void DinhDangLuoi()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "TenTaiKhoan";
            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[1].HeaderText = "MatKhau";
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "TenKhachHang";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Phai";
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].HeaderText = "DiaChi";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].HeaderText = "VIP";
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns[7].HeaderText = "TichLuy";
            dataGridView1.Columns[7].Width = 75;

        }

        private void GetValuesTextBoxes()
        {
            string _tenTaiKhoan = textBox1.Text;
            string _matKhau = textBox2.Text;
            string _tenKhachHang = textBox3.Text;
            string _phai = textBox4.Text;
            string _email = textBox5.Text;
            string _diaChi = textBox6.Text;
            string _vIP = comboBox1.Text;
            int _tichLuy = textBox8.TextLength;
            quanly = new QuanLyThongTinKhachHang(_tenTaiKhoan, _matKhau, _tenKhachHang, _phai, _email, _diaChi, _vIP, _tichLuy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Text = "0";
            GetValuesTextBoxes();
            string query = "INSERT INTO TaiKhoanKhachHang VALUES ('" + quanly.TenTaiKhoan + "', '" + quanly.MatKhau + "', N'" + quanly.TenKhachHang + "', N'" + quanly.Phai + "', '" + quanly.Email + "', '" + quanly.DiaChi + "', '" + quanly.VIP + "', '" + textBox8.Text + "')";
            try
            {
                if (MessageBox.Show("Bạn có muốn thêm không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Thêm thành công!");
                    frmQLThongTinKhachHang_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
            string query = "UPDATE TaiKhoanKhachHang SET TenTaiKhoan = N'" + quanly.TenTaiKhoan + "', MatKhau = '" + quanly.MatKhau + "', TenKhachHang = N'" + quanly.TenKhachHang + "', Phai = N'" + quanly.Phai + "', Email = '" + quanly.Email + "', DiaChi = '" + quanly.DiaChi + "', VIP = '" + quanly.VIP + "', TichLuy = " + quanly.TichLuy + "";
            query += "from TaiKhoanKhachHang Where TenTaiKhoan  = N'" + quanly.TenTaiKhoan + "'";
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Sửa thành công!");
                    frmQLThongTinKhachHang_Load(sender, e);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa!" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView1.SelectedCells;
            if (cell.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                textBox2.Text = new string('*', row.Cells["MatKhau"].Value.ToString().Length); textBox3.Text = row.Cells["TenKhachHang"].Value.ToString();
                textBox4.Text = row.Cells["Phai"].Value.ToString();
                textBox5.Text = row.Cells["Email"].Value.ToString();
                textBox6.Text = row.Cells["DiaChi"].Value.ToString();
                comboBox1.Text = row.Cells["VIP"].Value.ToString();
                textBox8.Text = row.Cells["TichLuy"].Value.ToString();
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
            string query = "DELETE FROM TaiKhoanKhachHang WHERE TenTaiKhoan = '" + quanly.TenTaiKhoan + "'";
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Xóa thành công!");
                    frmQLThongTinKhachHang_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string name = textBox9.Text.Trim();
            if (name == "")
            {
                frmQLThongTinKhachHang_Load(sender, e);
            }
            else
            {
                string query = "select TenTaiKhoan, TenKhachHang, Phai, Email, DiaChi, VIP, TichLuy from TaiKhoanKhachHang where TenTaiKhoan like N'%" + name + "%' OR TenKhachHang like N'%" + name + "%' OR Phai like N'%" + name + "%' OR Email like N'%" + name + "%' OR DiaChi like N'%" + name + "%' OR VIP like N'%" + name + "%' OR TichLuy like N'%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);

            }
        }
    }
}
