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

namespace StudentManagements.AddSubject
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getAllSubject();
            grd_Subjects.DataSource = table;
        }

        private void btn_OK_AddSubjectForm_Click(object sender, EventArgs e)
        {
            int[] rows = grd_Subjects_View.GetSelectedRows();
            subjectIDs = new int[rows.Length];
            for (int i = 0; i < subjectIDs.Length; i++)
            {
                subjectIDs[i] = (int)grd_Subjects_View.GetListSourceRowCellValue(rows[i], grdColumn_MAMH.FieldName);
            }
            this.Close();
        }

        private void btn_Cancel_AddSubjectForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int[] subjectIDs { get; set; }
    }
}
