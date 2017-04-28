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
            DataTable table = ClassBLL.Instance.getAllSubject();
            cb_SelectSubject.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
                cb_SelectSubject.Items.Add(table.Rows[i][1]);
            cb_SelectSubject.Items.Add("--Select subject--");
            cb_SelectSubject.SelectedItem = "--Select subject--";
            cb_Semester.SelectedIndex = 0;
            this.semester = 1;

        }

        private void cb_SelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_SelectSubject.SelectedItem.Equals("--Select subject--"))
            {
                grd_Report.DataSource = null;
                
                return;
            }

            this.MaMH = ClassBLL.Instance.getSubjectsID(cb_SelectSubject.SelectedItem.ToString());
            grd_Report.DataSource = ClassBLL.Instance.getReport_MONHOC(MaMH, semester);
            this.subjectName = cb_SelectSubject.SelectedItem.ToString();
            this.tableData = (DataTable)grd_Report.DataSource;
        }

        private void cb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.semester = int.Parse(cb_Semester.SelectedItem.ToString());
            if (cb_SelectSubject.SelectedItem.Equals("--Select subject--"))
            {
                grd_Report.DataSource = null;
                return;
            }
            grd_Report.DataSource = ClassBLL.Instance.getReport_MONHOC(MaMH, semester);
        }

        private void grd_Report_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.tableData = (DataTable)grd_Report.DataSource;
        }

        public DataTable tableData { get; set; }

        public string subjectName { get; set; }
    }
}
