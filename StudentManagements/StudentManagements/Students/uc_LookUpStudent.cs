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
using DevExpress.XtraGrid.Views.Grid;
using StudentManagements.Students;

namespace StudentManagements.Students
{
    public partial class uc_LookUpStudent : UserControl
    {
        public delegate void DgetFrameForDetail(uc_DetailStudent detail);

        public DgetFrameForDetail getFrameForDetail;

        public uc_LookUpStudent()
        {
            InitializeComponent();
            grd_StudentList.DataSource = BLL.ClassBLL.Instance.getStudentForLookUp();
        }

        private void uc_LookUpStudent_Load(object sender, EventArgs e)
        {
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Student?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ClassBLL.Instance.deleteStudent(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS"))))
                {
                    grd_StudentList_View.DeleteSelectedRows();
                }
                else
                    MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            uc_DetailStudent detail = new uc_DetailStudent(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS"));
            if (getFrameForDetail != null)
                getFrameForDetail(detail);
        }

        private void grd_StudentList_View_DoubleClick(object sender, EventArgs e)
        {
            btn_Detail_Click(null, null);
        }

        private void grd_StudentList_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.tableData = BLL.ClassBLL.Instance.getStudentForLookUp();
        }

        public DataTable tableData { get; set; }
    }
}
