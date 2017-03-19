using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class MONHOC
    {
        public MONHOC(int MaMH, string TenMH)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
        }

        public MONHOC()
        {

        }

        public int MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }

        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }
        int maMH;
        string tenMH;
    }
}
