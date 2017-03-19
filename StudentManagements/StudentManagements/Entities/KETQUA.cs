using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class KETQUA:IComparable<KETQUA>
    {
        int maKQ, hocKy;
        int maMH, maLop, mSHS;

        public int MSHS
        {
            get { return mSHS; }
            set { mSHS = value; }
        }

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public int MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        float diem15, diem1Tiet, diemCuoiKy;

        public float Diem15
        {
            get { return diem15; }
            set { diem15 = value; }
        }

        public float Diem1Tiet
        {
            get { return diem1Tiet; }
            set { diem1Tiet = value; }
        }

        public float DiemCuoiKy
        {
            get { return diemCuoiKy; }
            set { diemCuoiKy = value; }
        }

        public int HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }

        public int MaKQ
        {
            get { return maKQ; }
            set { maKQ = value; }
        }

        public KETQUA(int MaKQ,  float Diem15, float Diem1Tiet, float DiemCuoiKy)
        {
            this.MaKQ = MaKQ;
            this.Diem15 = Diem15;
            this.Diem1Tiet = Diem1Tiet;
            this.DiemCuoiKy = DiemCuoiKy;
        }
        public KETQUA(int MaKQ, int HocKy, float Diem15, float Diem1Tiet, float DiemCuoiKy)
        {
            this.HocKy = HocKy;
            this.MaKQ = MaKQ;
            this.Diem15 = Diem15;
            this.Diem1Tiet = Diem1Tiet;
            this.DiemCuoiKy = DiemCuoiKy;
        }

        public KETQUA(int MSHS, int MaMH, int HocKy, int MaLop,  float Diem15, float Diem1Tiet, float DiemCuoiKy)
        {
            this.MSHS = MSHS;
            this.MaMH = MaMH;
            this.HocKy = HocKy;
            this.MaLop = MaLop;
            this.Diem15 = Diem15;
            this.Diem1Tiet = Diem1Tiet;
            this.DiemCuoiKy = DiemCuoiKy;
        }



        public int CompareTo(KETQUA other)
        {
            return (this.MaKQ == other.MaKQ) ? 1 : 0;
        }
    }
}
