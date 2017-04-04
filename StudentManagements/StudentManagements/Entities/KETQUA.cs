using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.Entities
{
    class KETQUA : IComparable<KETQUA>
    {
        int maKQ, hocKy;
        int maMH, maLop, mSHS;
        float diemMieng1, diemMieng2, diem15, diem1Tiet, diemCuoiKy;

        public float DiemMieng1
        {
            get { return diemMieng1; }
            set { diemMieng1 = value; }
        }

        public float DiemMieng2
        {
            get { return diemMieng2; }
            set { diemMieng2 = value; }
        }

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

        public KETQUA(int MaKQ, float DiemMieng1, float DiemMieng2, float Diem15, float Diem1Tiet, float DiemCuoiKy)
        {
            this.DiemMieng1 = DiemMieng1;
            this.DiemMieng2 = DiemMieng2;
            this.MaKQ = MaKQ;
            this.Diem15 = Diem15;
            this.Diem1Tiet = Diem1Tiet;
            this.DiemCuoiKy = DiemCuoiKy;
        }
        public KETQUA(int MaKQ, int HocKy, float DiemMieng1, float DiemMieng2, float Diem15, float Diem1Tiet, float DiemCuoiKy)
        {
            this.DiemMieng1 = DiemMieng1;
            this.DiemMieng2 = DiemMieng2;
            this.HocKy = HocKy;
            this.MaKQ = MaKQ;
            this.Diem15 = Diem15;
            this.Diem1Tiet = Diem1Tiet;
            this.DiemCuoiKy = DiemCuoiKy;
        }

        public KETQUA(int MSHS, int MaMH, int HocKy, int MaLop, float DiemMieng1, float DiemMieng2, float Diem15, float Diem1Tiet, float DiemCuoiKy)
        {
            this.DiemMieng1 = DiemMieng1;
            this.DiemMieng2 = DiemMieng2;
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
