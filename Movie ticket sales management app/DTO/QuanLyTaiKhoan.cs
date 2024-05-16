using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Movie_ticket_sales_management_app.DTO
{
    internal class QuanLyTaiKhoan
    {
        private string _taikhoan;
        private string _matkhau;
        private string _ten;
        private string _email;
        private string _vaitro;

        public QuanLyTaiKhoan() { }
        
        public QuanLyTaiKhoan(string taikhoan, string matkhau, string ten, string email, string vaitro)
        {
            _taikhoan = taikhoan;
            _matkhau = matkhau;
            _ten = ten;
            _email = email;
            _vaitro = vaitro;
        }

        public string Taikhoan { get => _taikhoan; set => _taikhoan = value; }
        public string Matkhau { get => _matkhau; set => _matkhau = value;}
        public string Ten { get => _ten; set => _ten = value; }
        public string Email { get => _email; set => _email = value; }
        public string Vaitro { get => _vaitro; set => _vaitro = value; }
    }
}