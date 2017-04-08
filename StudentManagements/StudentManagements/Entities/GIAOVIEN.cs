using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class GIAOVIEN : IComparable<GIAOVIEN>
    {
        int maGV;
        string hoTen;
        bool gioiTinh;
        DateTime ngaySinh;
        string hocHam;
        int namKinhNghiem;
        string urlAnh;

        public string UrlAnh
        {
            get { return urlAnh; }
            set { urlAnh = value; }
        }
        public GIAOVIEN(int MaGV, string HoTen, bool GioiTinh, DateTime NgaySinh, string HocHam, int NamKinhNghiem, string urlAnh)
        {
            this.MaGV = MaGV;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.HocHam = HocHam;
            this.NamKinhNghiem = NamKinhNghiem;
            this.urlAnh = urlAnh;
        }

        public GIAOVIEN(int MaGV, string HoTen, bool GioiTinh, DateTime NgaySinh, string HocHam, int NamKinhNghiem)
        {
            this.MaGV = MaGV;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.HocHam = HocHam;
            this.NamKinhNghiem = NamKinhNghiem;
        }

        public GIAOVIEN(string HoTen, bool GioiTinh, DateTime NgaySinh, string HocHam, int NamKinhNghiem)
        {
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.HocHam = HocHam;
            this.NamKinhNghiem = NamKinhNghiem;
        }

        public string HocHam
        {
            get { return hocHam; }
            set { hocHam = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public int NamKinhNghiem
        {
            get { return namKinhNghiem; }
            set { namKinhNghiem = value; }
        }

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public int MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }

        public int CompareTo(GIAOVIEN other)
        {
            return (this.HoTen == other.HoTen && this.NgaySinh == other.NgaySinh && this.GioiTinh == other.GioiTinh && this.NamKinhNghiem == other.NamKinhNghiem && this.HocHam == other.HocHam) ? 1 : 0;
        }
    }
}
