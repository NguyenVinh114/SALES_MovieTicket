using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_ticket_sales_management_app.GUI
{
    public partial class frmQLBanVevaChiTiet : Form
    {

        private int maHoaDon;
        private DataTable tblChiTietHoaDon;
        private int soLuongVeMua;
        public frmQLBanVevaChiTiet()
        {
            InitializeComponent();
            maHoaDon = 1;
            soLuongVeMua = 0;
            tblChiTietHoaDon = new DataTable();
            tblChiTietHoaDon.Columns.Add("Mã Hóa Đơn", typeof(string));
            tblChiTietHoaDon.Columns.Add("Số Ghế", typeof(int));
            tblChiTietHoaDon.Columns.Add("Giá Tiền", typeof(double));
            btnThoat.Click += BtnThoat_Click;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmQLBanVevaChiTietHD_Load(object sender, EventArgs e)
        {
            KhoiTosoGhe(5, 6);
        }

        private void KhoiTosoGhe(int dong, int cot)
        {
            int x, y = 13, KhoangCachX = 180, KhoangCachY = 75, dem = 1;
            Button btnGhe;
            for (int i = 0; i < dong; i++)
            {
                x = 26;
                for (int j = 0; j < cot; j++)
                {
                    btnGhe = new Button();
                    btnGhe.Location = new Point(x, y);
                    btnGhe.Size = new Size(100, 50);
                    btnGhe.Text = dem++.ToString();
                    if (i == 1 && j == 3 || i == 1 && j == 4 || i == 2 && j == 2)
                    {
                        btnGhe.BackColor = Color.Yellow;
                    }
                    else
                    {
                        btnGhe.BackColor = Color.White;
                    }
                    btnGhe.Click += BtnGhe_Click;
                    pnlHangGhe.Controls.Add(btnGhe);
                    x += KhoangCachX;

                }
                y += KhoangCachY;
            }
        }


        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button btnGhe = (Button)sender;
            if (btnGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghe nay da duoc mua!!");
                return;
            }
            btnGhe.BackColor = (btnGhe.BackColor == Color.White) ? Color.Blue : Color.White;

        }
        private int DemSoLuongVeDaMua()
        {
            int soLuongVeDaMua = 0;
            foreach (Button ghe in pnlHangGhe.Controls)
            {
                if (ghe.BackColor == Color.Yellow)
                {
                    soLuongVeDaMua++;
                }
            }
            return soLuongVeDaMua;
        }
        private void btnMua_Click_1(object sender, EventArgs e)
        {

            double tongTien = 0, Giaghe = 0;
            int LanMua = 0, soGhe;
            foreach (Button ghe in pnlHangGhe.Controls)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    soGhe = int.Parse(ghe.Text);
                    Giaghe = TinhTien(soGhe);
                    tongTien += Giaghe;
                    ghe.BackColor = Color.Yellow;
                    tblChiTietHoaDon.Rows.Add("HD" + maHoaDon, soGhe, Giaghe);
                    Luu("HD" + maHoaDon, soGhe, Giaghe);
                    LanMua++;
                }
            }
            txtSoTien.Text = tongTien.ToString();
            ThemHoaDon(tongTien, maHoaDon++);
            soLuongVeMua += LanMua;
            txtSoVe.Text = "Số lượng ghế mua: " + soLuongVeMua.ToString();
            int soLuongVeDaMua = DemSoLuongVeDaMua();
            txtmua.Text = "Tổng ghế đã đặt: " + soLuongVeDaMua.ToString();

        }

        private void Luu(string maHoaDon, int soGhe, double giaTien)
        {
            string connectionString = @"Data Source=NGUYENHOANGNAM\SQLEXPRESS;Initial Catalog=CHITIET;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO ChiTietHoaDon (MaHoaDon, SoGhe, GiaTien) VALUES (@MaHoaDon, @SoGhe, @GiaTien)";
                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    command.Parameters.AddWithValue("@SoGhe", soGhe);
                    command.Parameters.AddWithValue("@GiaTien", giaTien);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ThemHoaDon(double tongTien, int maHoaDon)
        {

            var rowIndex = dgvDanhSachHoaDon.Rows.Add();
            dgvDanhSachHoaDon.Rows[rowIndex].Cells[0].Value = "HD" + maHoaDon;
            dgvDanhSachHoaDon.Rows[rowIndex].Cells[1].Value = tongTien;
            dgvDanhSachHoaDon.Rows[rowIndex].Cells[2].Value = DateTime.Now.ToString(format: "dd/MM/yyyy");
        }

        private double TinhTien(int viTriGhe)
        {
            if (viTriGhe <= 6)
            {
                return 5000;
            }
            else if (viTriGhe <= 12)
            {
                return 6500;
            }
            return 8000;

        }



      

        private void dgvDanhSachHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            string maHoaDon = dgvDanhSachHoaDon.Rows[rowIndex].Cells[0].Value.ToString();
            DataTable tblChiTietTheoMaHoaDon = tblChiTietHoaDon.AsEnumerable()
                .Where(row => row.Field<String>("Mã Hóa Đơn") == maHoaDon)
                .CopyToDataTable();
            dgvDanhSachChiTietHoaDon.DataSource = tblChiTietTheoMaHoaDon;
        }
    }
}
