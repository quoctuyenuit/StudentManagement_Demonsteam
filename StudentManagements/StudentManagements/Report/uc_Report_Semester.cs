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
        private int HocKy;
        public uc_Report_Semester()
        {
            InitializeComponent();
            cb_Semester.SelectedIndex = 0;
        }

        public delegate void CallBack(bool values);
        public CallBack setVisible;
        public delegate void getDelegate(Form1.DgetData data, Form1.DgetString subject, Form1.DgetInteger semester);//Tuyền Delegate
        public getDelegate getDelegateTable;

        public DataTable getTable()
        {
            return BLL.ClassBLL.Instance.getReport_HOCKY(HocKy);
        }
        public int getSemester()
        {
            return HocKy;
        }
        private void cb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Semester.SelectedIndex == 0)
            {
                grd_Report.DataSource = null;
                if (setVisible != null)
                    setVisible(false);
                return;
            }
            if (setVisible != null)
                setVisible(true);
            this.HocKy = int.Parse(cb_Semester.SelectedItem.ToString());
            grd_Report.DataSource = BLL.ClassBLL.Instance.getReport_HOCKY(HocKy);
        }

        private void uc_Report_Semester_Load(object sender, EventArgs e)
        {
            if (getDelegateTable != null)
                getDelegateTable(getTable, null, getSemester);
        }
    }
}
