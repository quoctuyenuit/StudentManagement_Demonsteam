using StudentManagements.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.Students
{
    public partial class StudentListToEditClass : Form
    {
        private string MaLop;
        public StudentListToEditClass(string MaLop)
        {
            InitializeComponent();

            this.MaLop = MaLop;

            grd_AddStudentForClass.DataSource = ClassBLL.Instance.getStudentForAddClass((int)BLL.ClassBLL.Instance.getClassFromID(MaLop)["NAMHOC"]);
        }

        private void btn_OK_AddStudentForClass_Click(object sender, EventArgs e)
        {
            int[] rows = grd_AddStudentForClass_View.GetSelectedRows();
            foreach (int row in rows)
            {
                if (!ClassBLL.Instance.insertStudetForClass((int)grd_AddStudentForClass_View.GetListSourceRowCellValue(row, "MSHS"), int.Parse(this.MaLop)))
                {
                    MessageBox.Show("Quantity exceeds the limit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            this.tableSources = new DataTable();
            tableSources = ClassBLL.Instance.getStudentForClass(int.Parse(this.MaLop));
        }

        public DataTable tableSources { get; set; }
    }
}
