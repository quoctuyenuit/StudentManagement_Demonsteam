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
            cbSemester.SelectedIndex = 0;
        }

        public DataTable tableData { get; set; }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSemester.SelectedIndex == 0)
            {
                grd_Report.DataSource = null;
                this.tableData = null;
                return;
            }

            this.semester = int.Parse(cbSemester.SelectedItem.ToString());
            grd_Report.DataSource = BLL.ClassBLL.Instance.getReport_HOCKY(semester);
            this.tableData = (DataTable)grd_Report.DataSource;
        }
    }
}
