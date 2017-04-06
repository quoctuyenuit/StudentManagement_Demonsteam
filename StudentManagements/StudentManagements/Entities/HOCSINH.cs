using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class HOCSINH
    {
        int _MSHS;
        string _HoTen;
        string _Email;
        DateTime _NgSinh;
        int _GioiTinh;
        string _DiaChi;
        string urlAnh;

        public string UrlAnh
        {
            get { return urlAnh; }
            set { urlAnh = value; }
        }
        public HOCSINH()
        {

        }
        public HOCSINH(string HoTen, string Email, DateTime NgSinh, int GioiTinh, string DiaChi)
        {
            this.HoTen = HoTen;
            this.Email = Email;
            this.NgSinh = NgSinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
        }

        public HOCSINH(string HoTen, string Email, DateTime NgSinh, int GioiTinh, string DiaChi, string UrlAnh)
        {
            this.HoTen = HoTen;
            this.Email = Email;
            this.NgSinh = NgSinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.UrlAnh = UrlAnh;
        }

        public HOCSINH(int MSHS, string HoTen, string Email, DateTime NgSinh, int GioiTinh, string DiaChi, string UrlAnh)
        {
            this.MSHS = MSHS;
            this.HoTen = HoTen;
            this.Email = Email;
            this.NgSinh = NgSinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.UrlAnh = UrlAnh;
        }
        public int MSHS
        {
            get { return _MSHS; }
            set { _MSHS = value; }
        }

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime NgSinh
        {
            get { return _NgSinh; }
            set { _NgSinh = value; }
        }

        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
    }
}
