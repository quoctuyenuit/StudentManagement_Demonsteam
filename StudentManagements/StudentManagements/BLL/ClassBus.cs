using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagements.ScoreBoard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.BLL
{
    class ClassBus
    {
        private static ClassBus instance;

        internal static ClassBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassBus();
                return ClassBus.instance;
            }
        }
        public ClassBus()
        {

        }

        public bool saveAddClass(Panel addClassPanel, TextEdit txt_ClassTotal_AddClass, string className, string year)
        {

            StudentManagements.Entities.LOP newLOP = new Entities.LOP(className, 0, year);
            if (!ClassBLL.Instance.checkExistenceClass(newLOP))
            {
                MessageBox.Show("Class already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ClassBLL.Instance.insertClass(newLOP))
            {
                MessageBox.Show("Create Class successful!");
                return true;
            }
            else
            {
                MessageBox.Show("Class is not exists in Rules, Please check again!");
                return false;
            }
        }

        public void deleteStudentInClass(GridView grd_StudentList_View, int MALOP)
        {
            int[] rows = grd_StudentList_View.GetSelectedRows();//Take rows of Table in GridControl StudentList
            foreach (int row in rows)
            {
                ClassBLL.Instance.deleteStudentInClass((int)grd_StudentList_View.GetListSourceRowCellValue(row, "MSHS"), MALOP);
            }
            grd_StudentList_View.DeleteSelectedRows();
        }

        public void deleteSubjectInClass(GridView grd_SubjectList_View, int MALOP)
        {
            int[] rows = grd_SubjectList_View.GetSelectedRows();
            foreach (int row in rows)
            {
                ClassBLL.Instance.deleteSubjectInClass((int)grd_SubjectList_View.GetListSourceRowCellValue(row, "MAMH"), MALOP);
            }
            grd_SubjectList_View.DeleteSelectedRows();
        }
        
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Export to Excel
        //internal void btn_ExportFile_Main_ItemClick(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_CreateReports, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardDetail, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentsList, DevExpress.XtraBars.Navigation.NavigationPage navPage_LookUpStudents, DevExpress.XtraBars.Navigation.TabPane tabPane_Reports, DevExpress.XtraBars.Navigation.TabNavigationPage tab_Subject, Form1.DgetData getTableForExport, Form1.DgetString getSubjectName, Form1.DgetInteger getSemester, Form1.DgetString getClassName, GridView grd_ClassList_View, LabelControl txt_ClassName_ClassInformation, LabelControl txt_ClassTotal_ClassInformation, LabelControl txt_Year_ClassInformation)
        //{
        //    if (navFrame_Main.SelectedPage == navPage_CreateReports)
        //    {
        //        string title = "";
        //        if (tabPane_Reports.SelectedPage == tab_Subject)
        //        {
        //            title = "Báo Cáo Tổng Kết Môn Học";
        //            if (getTableForExport != null && getSubjectName != null && getSemester != null)
        //                DAL.ExportToExcel.Instance.Export_Report_Subject(getTableForExport(), getSubjectName(), getSemester(), "Lop", title);
        //        }
        //        else
        //        {
        //            title = "Báo Cáo Tổng Kế Học Kỳ";
        //            if (getTableForExport != null && getSemester != null)
        //                DAL.ExportToExcel.Instance.Export_Report_Semester(getTableForExport(), getSemester(), "Lop", title);
        //        }
        //    }
        //    else if (navFrame_Main.SelectedPage == navPage_ScoreBoardDetail)
        //    {
        //        if (navPage_ScoreBoardDetail.Controls[0] is uc_ScoreBoardOfClass)
        //            if (getTableForExport != null && getClassName != null && getSubjectName != null && getSemester != null)
        //                DAL.ExportToExcel.Instance.Export_ScoreBoard(getTableForExport(), getClassName(), getSubjectName(), getSemester(), "Bang Điểm", "BẢNG ĐIỂM MÔN HỌC");
        //    }
        //    else if (navFrame_Main.SelectedPage == navPage_ClassInformation)
        //    {
        //        DataTable table = ClassBLL.Instance.getStudentForClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
        //        string ClassName = txt_ClassName_ClassInformation.Text;
        //        int ClassSize = int.Parse(txt_ClassTotal_ClassInformation.Text);
        //        int Year = int.Parse(txt_Year_ClassInformation.Text);
        //        DAL.ExportToExcel.Instance.Export_ClassInformation(table, ClassName, ClassSize, Year, "Lớp", "THÔNG TIN CHI TIẾT LỚP");
        //    }
        //    else if (navFrame_Main.SelectedPage == navPage_StudentsList)
        //    {
        //        DAL.ExportToExcel.Instance.Export_Student(ClassBLL.Instance.getAllStudents(), "Học Sinh", "DANH SÁCH HỌC SINH");
        //    }
        //    else if (navFrame_Main.SelectedPage == navPage_LookUpStudents)
        //        DAL.ExportToExcel.Instance.Export_LookUpStudent(ClassBLL.Instance.getStudentForLookUp(), "Truy vấn", "DANH SÁCH HỌC SINH");


        //}
      
    }
}
