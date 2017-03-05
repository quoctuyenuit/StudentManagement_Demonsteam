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
        byte _GioiTinh;
        string _DiaChi;

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

        public byte GioiTinh
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
