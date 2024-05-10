using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_ticket_sales_management_app.DTO
{
    internal class QuanLyDoanhThu
    {
        private string _tenPhim;
        private string _loaiVe;
        private double _giaVe;
        private int _slVe;

        public QuanLyDoanhThu() { }
        public QuanLyDoanhThu(string tenPhim, string loaiVe, double giaVe, int slVe)
        {
            _giaVe = giaVe;
            _loaiVe = loaiVe;
            _tenPhim = tenPhim;
            _slVe = slVe;
        }

        public string TenPhim { get => _tenPhim; set => _tenPhim = value; }
        public string LoaiVe { get => _loaiVe; set => _loaiVe = value; }
        public double GiaVe { get => _giaVe; set => _giaVe = value; }
        public int SlVe { get => _slVe; set => _slVe = value; }

        public double DoanhThu()
        {
            return SlVe * GiaVe;
        }
    }
}
