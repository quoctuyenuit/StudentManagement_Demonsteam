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
            btn_Detail_StudentList.Enabled = false;
            DataTable table = new DataTable();
            table = classBLL.getAllStudents();
            grd_StudentList.DataSource = table;
        }

        private void btn_Class_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ClassList;
            DataTable table = new DataTable();
            table = classBLL.getAllClass();
            grd_ClassList.DataSource = table;
        }

        private void btn_ScoreBoard_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardList;
            int ss = classBLL.getTotalOfClass(1);
            MessageBox.Show(ss.ToString());

        }
        //==============================================================================
        //Event
        private void grd_StudentList_Click(object sender, EventArgs e)
        {
            btn_Detail_StudentList.Enabled = true;
        }

        //==============================================================================
        //Student
        private string getTextFromGridControl(string columnName)
        {
            return grd_StudentList_View.GetRowCellDisplayText(grd_StudentList_View.GetSelectedRows().First(), columnName);
        }
        private void btn_Detail_StudentList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_StudentInformation;
            txt_StudentID_StudentInformation_Detail.Text = getTextFromGridControl("MSHS");
            txt_StudentName_StudentInformation_Detail.Text = getTextFromGridControl("HOTEN");
            txt_StudentDateOfBirth_StudentInformation_Detail.Text = getTextFromGridControl("NGSINH");
            txt_StudentEmail_StudentInformation_Detail.Text = getTextFromGridControl("EMAIL");
            txt_StudentSex_StudentInformation_Detail.Text = getTextFromGridControl("GIOITINH");
            txt_StudentAddress_StudentInformation_Detail.Text = getTextFromGridControl("DIACHI");
        }

       
    }
}
