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

namespace StudentManagements.ScoreBoard
{
    public partial class uc_ScoreBoardOfClass : UserControl
    {
        Dictionary<int, Entities.KETQUA> rows;//Danh sách kết quả cần sửa
        Dictionary<int, Entities.KETQUA> newRows;//Danh sách kết quả chưa có trong bảng kết quả cần thêm mới

        internal Dictionary<int, Entities.KETQUA> NewRows
        {
            get { return newRows; }
            set { newRows = value; }
        }
        internal Dictionary<int, Entities.KETQUA> Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        private int MaLop;
        private int MaMH;
        public int semester { get; set; }

        public uc_ScoreBoardOfClass(string TENLOP, int MALOP)
        {
            InitializeComponent();

            txt_ClassName.Text = TENLOP;

            this.className = TENLOP;

            this.MaLop = MALOP;
            DataTable table = ClassBLL.Instance.getSubjectForClass(MALOP);//Take subjects when know ClassID
            cb_SelectSubject.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
                cb_SelectSubject.Items.Add(table.Rows[i]["TENMH"]);
            cb_SelectSubject.Items.Add("--Select subject--");
            cb_SelectSubject.SelectedItem = "--Select subject--";

            this.Rows = new Dictionary<int, Entities.KETQUA>();
            this.NewRows = new Dictionary<int, Entities.KETQUA>();
            this.cb_Semester.SelectedIndex = 0;
        }

        void rowUpdatedEvent()
        {
            int row = grd_ScoreBoard_View.GetSelectedRows().First();
            float DiemMieng1 = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEMMIENG1"].ToString());
            float DiemMieng2 = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEMMIENG2"].ToString());

            float Diem15 = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEM15"].ToString());
            float Diem1Tiet = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEM1TIET"].ToString());
            float DiemCuoiKy = float.Parse(grd_ScoreBoard_View.GetDataRow(row)["DIEMCUOIKY"].ToString());
            try
            {
                int MaKQ = (int)grd_ScoreBoard_View.GetDataRow(row)["MAKQ"];//Nếu kết quả tồn tại
                Entities.KETQUA kq = new Entities.KETQUA(MaKQ, DiemMieng1, DiemMieng2, Diem15, Diem1Tiet, DiemCuoiKy);
                if (this.Rows.ContainsKey(kq.MaKQ))
                    this.Rows[kq.MaKQ] = kq;
                else
                    this.Rows.Add(kq.MaKQ, kq);
            }
            catch (Exception ex)
            {
                int MSHS = (int)grd_ScoreBoard_View.GetListSourceRowCellValue(row, "MSHS");
                Entities.KETQUA kq = new Entities.KETQUA(MSHS, MaMH, semester, MaLop, DiemMieng1, DiemMieng2, Diem15, Diem1Tiet, DiemCuoiKy);
                this.NewRows.Add(kq.MaKQ, kq);
            }
        }
        private void grd_ScoreBoard_View_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            rowUpdatedEvent();
            btn_Save.Enabled = true;
        }

        private void cb_SelectSubject_ScoreBoardDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_SelectSubject.SelectedItem.Equals("--Select subject--"))
            {
                btn_Save.Enabled = false;
                btn_Delete.Enabled = false;
                grd_ScoreBoard.DataSource = null;
                this.tableData = null;
                return;
            }

            this.MaMH = ClassBLL.Instance.getSubjectsID(cb_SelectSubject.SelectedItem.ToString());
            
            this.subjectName = cb_SelectSubject.SelectedItem.ToString();

            grd_ScoreBoard.DataSource = ClassBLL.Instance.getScoreBoardAccordingRequire(MaLop, MaMH, semester);
            btn_Delete.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Rows.Count == 0 && this.NewRows.Count == 0)
                return;
            if (MessageBox.Show("Do you want to Change?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                grd_ScoreBoard.DataSource = ClassBLL.Instance.getScoreBoardAccordingRequire(MaLop, MaMH, semester);
                return;
            }

            foreach (Entities.KETQUA kq in this.Rows.Values)
            {
                ClassBLL.Instance.updateScoreBoardCell(kq);
            }
            foreach (Entities.KETQUA kq in this.NewRows.Values)
            {
                ClassBLL.Instance.insertScoreBoard(kq);
            }
            grd_ScoreBoard.DataSource = ClassBLL.Instance.getScoreBoardAccordingRequire(MaLop, MaMH, semester);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ClassBLL.Instance.deleteScoreBoardCell(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoard_View, "MAKQ")));
                    grd_ScoreBoard_View.DeleteSelectedRows();
                }
                catch(Exception ex)
                { }
            }
        }

        private void cb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.semester = int.Parse(cb_Semester.SelectedItem.ToString());
            if (cb_SelectSubject.SelectedItem.Equals("--Select subject--"))
            {
                btn_Save.Enabled = false;
                btn_Delete.Enabled = false;
                grd_ScoreBoard.DataSource = null;
                return;
            }

            grd_ScoreBoard.DataSource = ClassBLL.Instance.getScoreBoardAccordingRequire(MaLop, MaMH, semester);
            btn_Delete.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void grd_ScoreBoard_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.tableData = ClassBLL.Instance.getScoreBoardAccordingRequire(MaLop, MaMH, semester);
            }
            catch (Exception ex) { }
        }

        public DataTable tableData { get; set; }

        public string className { get; set; }

        public string subjectName { get; set; }
    }
}
