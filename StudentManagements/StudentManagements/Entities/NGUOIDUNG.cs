using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    public class NGUOIDUNG
    {
        int maND;
        string tenNguoiDung;
        string tenDangNhap;
        string matKhau;
        int maPQ;
        string tenPQ;
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string TenPQ
        {
            get { return tenPQ; }
            set { tenPQ = value; }
        }

        public NGUOIDUNG(int MaND, string TenNguoiDung, string TenDangNhap, string MatKhau, string TenPQ, string Email)
        {
            this.MaND = MaND;
            this.TenNguoiDung = TenNguoiDung;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.TenPQ = TenPQ;
            this.Email = Email;
        }

        public NGUOIDUNG(string TenDangNhap, string MatKhau)
        {
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }

        public NGUOIDUNG()
        {
        }

        public int MaPQ
        {
            get { return maPQ; }
            set { maPQ = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string TenNguoiDung
        {
            get { return tenNguoiDung; }
            set { tenNguoiDung = value; }
        }

        public int MaND
        {
            get { return maND; }
            set { maND = value; }
        }
    }
}
