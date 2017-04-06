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

namespace StudentManagements.GUI
{
    public partial class uc_Report_Subject : UserControl
    {
        private int MaMH;
        private int HocKy;
        public uc_Report_Subject()
        {
            InitializeComponent();
        }

        public uc_Report_Subject(ref Form1.DgetData getTableForExport)
        {
            // TODO: Complete member initialization
            getTableForExport = new Form1.DgetData(getTable);
        }

        public delegate void CallBack(bool values);
        public CallBack setVisible;
        public delegate void getDelegate(Form1.DgetData data, Form1.DgetString subject, Form1.DgetInteger semester);//Truyền một delegate chứa hàm GetTable về cho hàm trong Form1
        public getDelegate getDelegateData;

        public DataTable getTable()
        {
            return ClassBLL.Instance.getReport_MONHOC(MaMH, HocKy);
        }
        public string getSubject()
        {
            return cb_SelectSubject.SelectedItem.ToString();
        }
        public int getSemester()
        {
            return HocKy;
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
            this.HocKy = 1;

            if (getDelegateData != null)
                getDelegateData(getTable, getSubject, getSemester);//Truyền delegate ngược về cho ParentForm
        }

        private void cb_SelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_SelectSubject.SelectedItem.Equals("--Select subject--"))
            {
                grd_Report.DataSource = null;
                if (setVisible != null)
                    setVisible(false);
                return;
            }
            if (setVisible != null)
                setVisible(true);

           

            this.MaMH = ClassBLL.Instance.getSubjectsID(cb_SelectSubject.SelectedItem.ToString());
            grd_Report.DataSource = ClassBLL.Instance.getReport_MONHOC(MaMH, HocKy);
        }

        private void cb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HocKy = int.Parse(cb_Semester.SelectedItem.ToString());
            if (cb_SelectSubject.SelectedItem.Equals("--Select subject--"))
            {
                grd_Report.DataSource = null;
                return;
            }
            grd_Report.DataSource = ClassBLL.Instance.getReport_MONHOC(MaMH, HocKy);
        }
    }
}
