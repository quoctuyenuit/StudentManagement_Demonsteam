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

namespace StudentManagements.Teacher
{
    public partial class uc_TeacherList : UserControl
    {
        public uc_TeacherList(bool enable = false)//Cho button Detail ẩn khi show trong danh sách để phân công
        {
            InitializeComponent();
            btn_Detail.Enabled = enable;
            grd_TeacherList.DataSource = BLL.ClassBLL.Instance.getTeacherList();
        }

        public delegate void DgetFrameForDetail(Control detail);
        public DgetFrameForDetail getFrameForDetail;

        public delegate void DreturnData(object sender, EventArgs e);
        public DreturnData returnData;

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            string MAGV = grd_TeacherList_View.GetDataRow(grd_TeacherList_View.GetSelectedRows().First())["MAGV"].ToString();
            Teacher.uc_TeacherDetail detail = new uc_TeacherDetail(MAGV);

            if (getFrameForDetail != null)
                getFrameForDetail(detail);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Student?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ClassBLL.Instance.deleteTeacher(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_TeacherList_View, "MAGV"))))
                    grd_TeacherList_View.DeleteSelectedRows();
                else
                    MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void grd_TeacherList_View_DoubleClick(object sender, EventArgs e)
        {
            if (returnData != null && !btn_Detail.Enabled)//Nếu delegate returnData != null và UI đang ở trong phần tìm giáo viên trong TeachingDivision
                returnData(new object(), new EventArgs());
            else
                btn_Detail_Click(null, null);
        }

        private void grd_TeacherList_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.row = grd_TeacherList_View.GetDataRow(grd_TeacherList_View.GetSelectedRows().First());
        }

        public DataRow row { get; set; }
    }
}
