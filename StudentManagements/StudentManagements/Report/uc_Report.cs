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
    public partial class uc_Report : UserControl
    {
        public uc_Report()
        {
            InitializeComponent();

            tabPane_Reports.SelectedPage = tab_Subject;
            uc_Subject = new Report.uc_Report_Subject();
            uc_Subject.Dock = DockStyle.Fill;
            tab_Subject.Controls.Clear();
            tab_Subject.Controls.Add(uc_Subject);
        }

        private void tabPane_Reports_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPane_Reports.SelectedPage == tab_Subject)
            {
                uc_Subject = new Report.uc_Report_Subject();
                uc_Subject.Dock = DockStyle.Fill;
                tab_Subject.Controls.Clear();
                tab_Subject.Controls.Add(uc_Subject);
            }
            else if (tabPane_Reports.SelectedPage == tab_Semester)
            {
                uc_Semester = new Report.uc_Report_Semester();
                uc_Semester.Dock = DockStyle.Fill;
                tab_Semester.Controls.Clear();
                tab_Semester.Controls.Add(uc_Semester);
            }
        }

        public uc_Report_Subject uc_Subject { get; set; }

        public uc_Report_Semester uc_Semester { get; set; }
    }
}
