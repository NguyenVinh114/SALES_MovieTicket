using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Movie_ticket_sales_management_app.DTO
{
    internal class QuanLyThongTinKhachHang
    {
        private string _tenTaiKhoan;
        private string _matKhau;
        private string _tenKhachHang;
        private string _phai;
        private string _email;
        private string _diaChi;
        private string _vIP;
        private int _tichLuy;

        public QuanLyThongTinKhachHang() { }

        public QuanLyThongTinKhachHang(string tenTaiKhoan, string matKhau, string tenKhachHang, string phai, string email, string diaChi, string vIP, int tichLuy)
        {
            _tenTaiKhoan = tenTaiKhoan;
            _matKhau = matKhau;
            _tenKhachHang = tenKhachHang;
            _phai = phai;
            _email = email;
            _diaChi = diaChi;
            _vIP = vIP;
            _tichLuy = tichLuy;
        }

        public string TenTaiKhoan {get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string TenKhachHang {  get => _tenKhachHang; set => _tenKhachHang = value;}
        public string Phai { get => _phai; set => _phai = value; }
        public string Email { get => _email; set => _email = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string VIP { get => _vIP; set => _vIP = value; }
        public int TichLuy { get => _tichLuy; set => _tichLuy = value; }
    }
}