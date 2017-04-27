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

namespace StudentManagements.LookUpStudents
{
    public partial class uc_LookUpStudent : UserControl
    {
        public uc_LookUpStudent()
        {
            InitializeComponent();
        }

        public delegate void detailEvent(GridView grd_StudentList_View);
        public detailEvent detailClick;

        private void uc_LookUpStudent_Load(object sender, EventArgs e)
        {
            grd_StudentList.DataSource = BLL.ClassBLL.Instance.getStudentForLookUp();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            BLL.ClassBus.Instance.btn_Delete_StudentList_Click(grd_StudentList_View);
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if (detailClick != null)
                detailClick(grd_StudentList_View);
        }
    }
}
