using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagements.BLL;

namespace StudentManagements.GUI
{
    public partial class uc_ScoreBoardList : UserControl
    {
        Dictionary<int, Entities.KETQUA> rows;

        internal Dictionary<int, Entities.KETQUA> Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        
        public delegate DataTable getData();
        public getData getTable;
        
        public uc_ScoreBoardList()
        {

            this.Rows = new Dictionary<int, Entities.KETQUA>();
            InitializeComponent();
        }

        private void grd_ScoreBoard_Load(object sender, EventArgs e)
        {
            grd_ScoreBoard.DataSource = getTable(); ;
        }

        private void grd_ScoreBoard_View_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int row = grd_ScoreBoard_View.GetSelectedRows().First();
            int MaKQ = (int)grd_ScoreBoard_View.GetDataRow(row)["MAKQ"];
            int HocKy = (int)grd_ScoreBoard_View.GetDataRow(row)["HOCKY"]; //(int)grd_ScoreBoard_View.GetListSourceRowCellValue(row, "HOCKY");
            float Diem15 = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEM15"].ToString());
            float Diem1Tiet = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEM1TIET"].ToString());
            float DiemCuoiKy = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEMCUOIKY"].ToString());
            Entities.KETQUA kq = new Entities.KETQUA(MaKQ, HocKy, Diem15, Diem1Tiet, DiemCuoiKy);
            if (this.Rows.ContainsKey(kq.MaKQ))
                this.Rows[kq.MaKQ] = kq;
            else
                this.Rows.Add(kq.MaKQ, kq);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Rows.Count == 0)
                return;
            if (MessageBox.Show("Do you want to Change?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                grd_ScoreBoard.DataSource = getTable();
                return;
            }
            foreach(Entities.KETQUA kq in this.Rows.Values)
            {
                ClassBLL.Instance.updateScoreBoardCell(kq);
            }
            grd_ScoreBoard.DataSource = getTable(); ;
        }

        private void btn_Delete_ScoreBoardDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassBLL.Instance.deleteScoreBoardCell(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoard_View, "MAKQ")));
                grd_ScoreBoard.DataSource = getTable();
            }
        }

    }
}
