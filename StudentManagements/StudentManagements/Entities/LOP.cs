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
        string _NamHoc;
        int _MaGV;

        public int MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }

        public string NamHoc
        {
            get { return _NamHoc; }
            set { _NamHoc = value; }
        }
        string _GhiChu;

        public LOP(string TenLop, int SiSo, string NamHoc)
        {
            this.TenLop = TenLop;
            this.SiSo = SiSo;
            this.NamHoc = BLL.ClassBLL.Instance.formatSchoolYear(NamHoc);
        }

        public LOP(int MaLop, string TenLop, int SiSo, string NamHoc, int MaGV)
        {
            this.MaLop = MaLop;
            this.TenLop = TenLop;
            this.SiSo = SiSo;
            this.NamHoc = BLL.ClassBLL.Instance.formatSchoolYear(NamHoc);
            this.MaGV = MaGV;
        }
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
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
