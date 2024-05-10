using Movie_ticket_sales_management_app.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_ticket_sales_management_app.DTO;

namespace Movie_ticket_sales_management_app.GUI
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_TenPhim.ResetText();
            textBox_GiaVe.ResetText();
            textBox_SLVe.ResetText();
            comboBox_LoaiVe.ResetText();
            comboBox_TenPhim.Focus();
        }

        Modify modify = new Modify();
        QuanLyDoanhThu quanLy;

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("select * from DoanhThu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            DeleteTextBoxes();
            DinhDangLuoi();

        }
        private void DinhDangLuoi()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Tên phim";
            dataGridView1.Columns[0].Width = 314;
            dataGridView1.Columns[1].HeaderText = "Loại vé";
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].HeaderText = "Giá vé";
            dataGridView1.Columns[2].Width = 115;
            dataGridView1.Columns[3].HeaderText = "Số lượng vé";
            dataGridView1.Columns[3].Width = 115;
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[4].Width = 160;

        }

        private void comboBox_TenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox_TenPhim.SelectedIndex == 0)
            //{
            //    textBox_GiaVe.Text = "";
            //    comboBox_LoaiVe.Text = "";
            //}
        }

        private void comboBox_LoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LoaiVe.SelectedIndex == 0)
            {
                textBox_GiaVe.Text = "70.000";
            }
            if (comboBox_LoaiVe.SelectedIndex == 1)
            {
                textBox_GiaVe.Text = "40.000";
            }
        }

        private void textBox_SLVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }


        private void DeleteTextBoxes()
        {
            comboBox_TenPhim.SelectedIndex = -1;
            comboBox_LoaiVe.Text = "";
            textBox_GiaVe.Text = "";
            textBox_SLVe.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (comboBox_TenPhim.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn phim!"); return false;
            }
            if (comboBox_LoaiVe.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn loại vé!");
                return false;
            }
            if (textBox_SLVe.Text == "")
            {
                MessageBox.Show("Mời bạn nhập số lượng vé!");
                return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenPhim = comboBox_TenPhim.Text;
            string _loaiVe = comboBox_LoaiVe.Text;
            double _giaVe = double.Parse(textBox_GiaVe.Text);
            int _slVe = int.Parse(textBox_SLVe.Text);
            quanLy = new QuanLyDoanhThu(_tenPhim, _loaiVe, _giaVe, _slVe);
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO DoanhThu VALUES (N'" + quanLy.TenPhim + "', '" + quanLy.LoaiVe + "',  " + quanLy.GiaVe + ", " + quanLy.SlVe + ", " + quanLy.DoanhThu() + ")";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thành công!");
                        frmDoanhThu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm!" + ex.Message);
                }
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "UPDATE DoanhThu SET LoaiVe = '" + quanLy.LoaiVe + "', GiaVe = '" + quanLy.GiaVe + "', SoLuongVe = " + quanLy.SlVe + ", TongTien = " + quanLy.DoanhThu() + "";
                query += "from DoanhThu Where TenPhim  = '" + quanLy.TenPhim + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thành công!");
                        frmDoanhThu_Load(sender, e);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa!" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView1.SelectedCells;
            if (cell.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox_TenPhim.Text = row.Cells["TenPhim"].Value.ToString();
                comboBox_LoaiVe.Text = row.Cells["LoaiVe"].Value.ToString();
                textBox_GiaVe.Text = row.Cells["GiaVe"].Value.ToString();
                textBox_SLVe.Text = row.Cells["SoLuongVe"].Value.ToString();


            }


        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {

                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE DoanhThu ";
                query += "FROM DoanhThu WHERE TenPhim = '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        frmDoanhThu_Load(sender, e);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa!" + ex.Message);
                }
            }

        }

        private void textBox_TìmKiem_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TìmKiem.Text.Trim();
            if (name == "")
            {
                frmDoanhThu_Load(sender, e);
            }
            else
            {
                string query = "Select* from DoanhThu where TenPhim like N'%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không!","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
            {
                this.Close();

            }
        }
    }
}
