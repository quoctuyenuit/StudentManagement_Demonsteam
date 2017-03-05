using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagements
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLL.ClassBLL classBLL;
        
        public Form1()
        {
            InitializeComponent();
            classBLL = new BLL.ClassBLL();
        }   
       
        //==============================================================================
        //Actions
        private void btn_Students_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_StudentsList;
            DataTable dataTable = new DataTable();
            dataTable = classBLL.getAllStudents();
            grd_StudentList.DataSource = dataTable;
        }

        private void btn_Class_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ClassList;
        }
    }
}
