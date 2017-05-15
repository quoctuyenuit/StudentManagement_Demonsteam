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

namespace StudentManagements.Report
{
    public partial class uc_Report_Subject : UserControl
    {
        private int MaMH;
        public int semester { get; set; }

        public uc_Report_Subject()
        {
            InitializeComponent();
        }

        private void uc_Report_Subject_Load(object sender, EventArgs e)
        {
            cbSubject.Properties.Items.Clear();
            cbSubject.Properties.Items.Add("--Select subject--");
            cbSubject.SelectedItem = "--Select subject--";
            cbSubject.Properties.Items.AddRange(BLL.ClassBLL.Instance.getListSubjectName());
            cbSemester.SelectedIndex = 0;
            this.semester = 1;
        }

        private void grd_Report_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.tableData = (DataTable)grd_Report.DataSource;
        }

        public DataTable tableData { get; set; }

        public string subjectName { get; set; }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubject.SelectedItem.Equals("--Select subject--"))
            {
                grd_Report.DataSource = null;

                return;
            }

            this.MaMH = ClassBLL.Instance.getSubjectsID(cbSubject.SelectedItem.ToString());
            grd_Report.DataSource = ClassBLL.Instance.getReport_MONHOC(MaMH, semester);
            this.subjectName = cbSubject.SelectedItem.ToString();
            this.tableData = (DataTable)grd_Report.DataSource;
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.semester = int.Parse(cbSemester.SelectedItem.ToString());
            if (cbSubject.SelectedItem.Equals("--Select subject--"))
            {
                grd_Report.DataSource = null;
                return;
            }
            grd_Report.DataSource = ClassBLL.Instance.getReport_MONHOC(MaMH, semester);
        }
    }
}
