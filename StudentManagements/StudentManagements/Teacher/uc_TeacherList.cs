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
        }
        public delegate DataTable DgetTable();
        public DgetTable getTable;

        public delegate void DgiveRow(TeachingDivision.TeacherListForm.DgetRow getRow);
        public DgiveRow giveRow;
        public delegate void Ddetail();
        public Ddetail detail;

        public delegate void DreturnData(object sender, EventArgs e);
        public DreturnData returnData;

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if (detail != null)
                detail();
        }

        private void uc_TeacherList_Load(object sender, EventArgs e)
        {
            if (getTable != null)
            {
                grd_TeacherList.DataSource = null;
                grd_TeacherList.DataSource = getTable();
            }
            if (giveRow != null)
                giveRow(new TeachingDivision.TeacherListForm.DgetRow(getSelected));
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

        public DataRow getSelected()
        {
            return grd_TeacherList_View.GetDataRow(grd_TeacherList_View.GetSelectedRows().First());
        }

        private void grd_TeacherList_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //if (giveRow != null)
            //    giveRow(new TeacherListForm.DgetRow(getSelected));
        }

        private void grd_TeacherList_View_DoubleClick(object sender, EventArgs e)
        {
            if (returnData != null)
                returnData(new object(), new EventArgs());
        }
    }
}
