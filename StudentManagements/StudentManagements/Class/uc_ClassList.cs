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

namespace StudentManagements.Class
{
    public partial class uc_ClassList : UserControl
    {
        public delegate void DgetFrameForDetail(Control detail);

        public DgetFrameForDetail getFrameForDetail;

        public uc_ClassList()
        {
            InitializeComponent();
            grd_ClassList.DataSource = ClassBLL.Instance.getAllClass();

        }

        private void uc_ClassList_Load(object sender, EventArgs e)
        {

        }

        private void btn_Delete_ClassList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Class?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (!ClassBLL.Instance.deleteClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP"))))
                    MessageBox.Show("Deleted failure!");
            }
            grd_ClassList_View.DeleteSelectedRows();
        }

        private void btn_Detail_ClassList_Click(object sender, EventArgs e)
        {
            uc_ClassInformation classInformation = new uc_ClassInformation(grd_ClassList_View.GetDataRow(grd_ClassList_View.GetSelectedRows().First())["MALOP"].ToString());
            classInformation.getFrameForDetail = new uc_ClassInformation.DgetFrameForDetail(getFrameForDetail);
            if (getFrameForDetail != null)
                getFrameForDetail(classInformation);
        }

        private void grd_ClassList_View_DoubleClick(object sender, EventArgs e)
        {
            btn_Detail_ClassList_Click(null, null);
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Class.uc_AddClass uc_AddClass = new Class.uc_AddClass();
            uc_AddClass.Dock = DockStyle.Fill;
            if (getFrameForDetail != null)
                getFrameForDetail(uc_AddClass);
        }
    }
}
