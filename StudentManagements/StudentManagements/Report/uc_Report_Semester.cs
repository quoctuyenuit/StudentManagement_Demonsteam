using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.Report
{
    public partial class uc_Report_Semester : UserControl
    {
        public int semester { get; set; }
        public uc_Report_Semester()
        {
            InitializeComponent();
            cb_Semester.SelectedIndex = 0;
        }

        private void cb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Semester.SelectedIndex == 0)
            {
                grd_Report.DataSource = null;
                this.tableData = null;
                return;
            }
          
            this.semester = int.Parse(cb_Semester.SelectedItem.ToString());
            grd_Report.DataSource = BLL.ClassBLL.Instance.getReport_HOCKY(semester);
            this.tableData = (DataTable)grd_Report.DataSource;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.tableData = (DataTable)grd_Report.DataSource;
        }

        public DataTable tableData { get; set; }
    }
}
