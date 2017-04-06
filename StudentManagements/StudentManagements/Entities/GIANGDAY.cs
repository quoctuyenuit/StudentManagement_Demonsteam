using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class GIANGDAY
    {
        public GIANGDAY(int MaGD, int MaGV, int MaLop, int MaMH)
        {
            this.MaGD = MaGD;
            this.MaGV = MaGV;
            this.MaLop = MaLop;
            this.MaMH = MaMH;
        }

        public GIANGDAY(int MaGV, int MaLop, int MaMH)
        {
            this.MaGV = MaGV;
            this.MaLop = MaLop;
            this.MaMH = MaMH;
        }

        int maGD;

        public int MaGD
        {
            get { return maGD; }
            set { maGD = value; }
        }
        int maGV;

        public int MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        int maLop;

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        int maMH;

        public int MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
    }
}
