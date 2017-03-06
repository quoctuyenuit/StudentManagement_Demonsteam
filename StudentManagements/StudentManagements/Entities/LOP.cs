using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class LOP
    {
        int _MaLop;
        string _TenLop;
        int _SiSo;
        int _NamHoc;
        string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        public int NamHoc
        {
            get { return _NamHoc; }
            set { _NamHoc = value; }
        }

        public int SiSo
        {
            get { return _SiSo; }
            set { _SiSo = value; }
        }

        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }

        public int MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
    }
}
