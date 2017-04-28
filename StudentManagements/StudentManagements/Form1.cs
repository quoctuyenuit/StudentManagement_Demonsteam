using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagements.AddSubject;
using StudentManagements.BLL;
using StudentManagements.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace StudentManagements
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Stack<Control> listBack;

        Stack<Control> listForward;


        string userName;
        private Students.uc_LookUpStudent uc_lookUp;
        private Class.uc_ClassInformation uc_ClassInfor;
        private ScoreBoard.uc_ScoreBoardOfClass uc_ScoreBoard;
        private Report.uc_Report _uc_Report;

        public Form1(string userName)
        {
            InitializeComponent();

            this.listBack = new Stack<Control>();
            this.listForward = new Stack<Control>();

            this.userName = userName;

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Style";

            navFrame_Main.SelectedPage = navPageHome;
        }

        #region Home
        //----------------------------------------------------------------------------
        private void btn_Home_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navFrame_Main.SelectedPage = navPageHome;
        }

        //----------------------------------------------------------------------------
        #endregion
        //===========================================================================================================
        //==================================================GridView Events==========================================
        private void frameMain_ControlAdded(object sender, ControlEventArgs e)
        {
            navFrame_Main.SelectedPage = navPageAction;

            btn_ExportFile_Main.Enabled = false;
            if (navPageAction.Controls.Count > 0)
            {
                Control ctrl = navPageAction.Controls[0];

                if (this.listBack.Count == 0)
                    this.listBack.Push(ctrl);//Thêm userControl đó vào danh sách stack
                else if (!this.listBack.Peek().Name.Equals(ctrl.Name))//Thêm khi phần tử cuối cùng của stack khác phần tử chuẩn bị được thêm
                    this.listBack.Push(ctrl);//Thêm userControl đó vào danh sách stack

                btn_Back_Main.Enabled = true;

                if (ctrl.Name.Equals("uc_LookUpStudent") || ctrl.Name.Equals("uc_ClassInformation") || ctrl.Name.Equals("uc_ScoreBoardOfClass") || ctrl.Name.Equals("uc_Report") || ctrl.Name.Equals("uc_StudentsList"))
                    btn_ExportFile_Main.Enabled = true;
            }


        }
        //===========================================================================================================
        //===================================================Student=================================================
        #region Students
        //----------------------------------------------------------------------------
        void getFrameForDetail(Students.uc_DetailStudent detail)
        {
            detail.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(detail);
        }

        public void btn_Students_Actions_Click(object sender, EventArgs e)
        {
            Students.uc_StudentsList students = new Students.uc_StudentsList();
            students.getFrameForDetail = new Students.uc_StudentsList.DgetFrameForDetail(getFrameForDetail);
            students.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(students);
        }
        //----------------------------------------------------------------------------
        private void btn_LookUpStudent_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uc_lookUp = new Students.uc_LookUpStudent();
            uc_lookUp.Dock = DockStyle.Fill;
            uc_lookUp.getFrameForDetail = new Students.uc_LookUpStudent.DgetFrameForDetail(getFrameForDetail);
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(uc_lookUp);
        }
        //----------------------------------------------------------------------------
        private void btn_AddStudent_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Students.uc_AddStudent uc_AddStudent = new Students.uc_AddStudent();
            uc_AddStudent.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(uc_AddStudent);
        }

        #endregion
        //===========================================================================================================
        //=====================================================Class=================================================
        #region Class
        //----------------------------------------------------------------------------
        void getFrameForDetail(Class.uc_ClassInformation detail)
        {
            this.uc_ClassInfor = detail;
            detail.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(detail);
        }
        private void btn_Class_Actions_Click(object sender, EventArgs e)
        {
            Class.uc_ClassList uc_Class = new Class.uc_ClassList();
            uc_Class.Dock = DockStyle.Fill;
            uc_Class.getFrameForDetail = new Class.uc_ClassList.DgetFrameForDetail(getFrameForDetail);
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(uc_Class);
        }


        private void btn_AddClass_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Class.uc_AddClass uc_AddClass = new Class.uc_AddClass();
            uc_AddClass.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(uc_AddClass);
        }

        #endregion
        //===========================================================================================================
        //==================================================ScoreBoard===============================================
        #region ScoreBoard
        //----------------------------------------------------------------------------
        private void getFrameForDetail(ScoreBoard.uc_ScoreBoardOfClass uc)
        {
            this.uc_ScoreBoard = uc;
            uc.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(uc);
        }
        //--------------------------------------------------------------------------------
        private void btn_ScoreBoard_Actions_Click(object sender, EventArgs e)
        {
            ScoreBoard.uc_ScoreBoard scoreBoard = new ScoreBoard.uc_ScoreBoard();
            scoreBoard.getFrameForLookUp = new ScoreBoard.uc_ScoreBoard.DgetFrameForLookUp(getFrameForDetail);
            scoreBoard.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(scoreBoard);
        }
        //--------------------------------------------------------------------------------
        #endregion
        //===========================================================================================================
        //====================================================Teacher================================================
        #region Teacher
        //----------------------------------------------------------------------------
        private void getFrameForDetail(Teacher.uc_TeacherDetail detail)
        {
            detail.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(detail);
        }

        private void btn_Teachers_Actions_Click(object sender, EventArgs e)
        {
            Teacher.uc_TeacherList uc = new Teacher.uc_TeacherList(true);
            uc.Dock = DockStyle.Fill;
            uc.getFrameForDetail = new Teacher.uc_TeacherList.DgetFrameForDetail(getFrameForDetail);

            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(uc);

        }

        //----------------------------------------------------------------------------
        #endregion
        //===========================================================================================================
        //=====================================================Report================================================
        #region Report
        //----------------------------------------------------------------------------
        private void btn_CreateReport_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _uc_Report = new Report.uc_Report();
            _uc_Report.Dock = DockStyle.Fill;
            navPageAction.Controls.Clear();
            navPageAction.Controls.Add(_uc_Report);
        }

        #endregion
        //===========================================================================================================
        //================================================Export to file=============================================
        #region Export To Excel File
        private void btn_ExportFile_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (navPageAction.Controls.Count <= 0)
                return;
            Control control = navPageAction.Controls[0];

            switch (control.Name)
            {
                case "uc_LookUpStudent":
                    {
                        DAL.ExportToExcel.Instance.Export_LookUpStudent(uc_lookUp.tableData, "Truy vấn", "DANH SÁCH HỌC SINH");
                        break;
                    }
                case "uc_ClassInformation":
                    {
                        DAL.ExportToExcel.Instance.Export_ClassInformation(this.uc_ClassInfor.tableData, this.uc_ClassInfor.className, this.uc_ClassInfor.classSize, this.uc_ClassInfor.classYear, "Lớp", "THÔNG TIN CHI TIẾT LỚP");
                        break;
                    }
                case "uc_ScoreBoardOfClass":
                    {
                        if (this.uc_ScoreBoard.tableData != null)
                            DAL.ExportToExcel.Instance.Export_ScoreBoard(this.uc_ScoreBoard.tableData, this.uc_ScoreBoard.className, this.uc_ScoreBoard.subjectName, this.uc_ScoreBoard.semester, "Bang Điểm", "BẢNG ĐIỂM MÔN HỌC");
                        else
                        {
                            MessageBox.Show("Data is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case "uc_Report":
                    {
                        foreach (Control subControl in control.Controls)
                            if (subControl is TabPane)
                            {
                                TabPane tabPane = (TabPane)subControl;
                                if (tabPane.SelectedPage.Name.Equals("tab_Subject"))
                                {
                                    if (this._uc_Report.uc_Subject.tableData != null)
                                        DAL.ExportToExcel.Instance.Export_Report_Subject(this._uc_Report.uc_Subject.tableData, this._uc_Report.uc_Subject.subjectName, this._uc_Report.uc_Subject.semester, "Lop", "Báo Cáo Tổng Kết Môn Học");
                                    else
                                        MessageBox.Show("Data is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (tabPane.SelectedPage.Name.Equals("tab_Semester"))
                                {
                                    if (this._uc_Report.uc_Semester.tableData != null)
                                        DAL.ExportToExcel.Instance.Export_Report_Semester(this._uc_Report.uc_Semester.tableData, this._uc_Report.uc_Semester.semester, "Lop", "Báo Cáo Tổng Kế Học Kỳ");
                                    else
                                        MessageBox.Show("Data is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        break;
                    }
                case "uc_StudentsList":
                    {
                        DAL.ExportToExcel.Instance.Export_Student(ClassBLL.Instance.getAllStudents(), "Học Sinh", "DANH SÁCH HỌC SINH");
                        break;
                    }
            }
        }
        #endregion
        //===========================================================================================================
        //=================================================Change Rules==============================================
        #region Change Rules
        private void btn_ChangeRules_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Rules.ChangeRules frm = new Rules.ChangeRules();
            frm.ShowDialog();
        }
        #endregion
        //===========================================================================================================
        //=================================================Back Button===============================================
        #region Back Button
        private void btn_Back_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.listBack.Count > 1)
            {
                btn_Forward_Main.Enabled = true;

                navPageAction.Controls.Clear();

                this.listForward.Push(this.listBack.Pop());//Xóa phần tử sau cùng vì phần tử này là thể hiện UI hiện tại chứ ko phải là UI cũ

                navPageAction.Controls.Add(this.listBack.Pop());
            }
            else
            {
                if (this.listBack.Count == 1)
                {
                    this.listForward.Push(this.listBack.Pop());//Nếu còn một control trong stack tức là khi quay lại phải là Home
                    btn_Forward_Main.Enabled = true;
                }
                navFrame_Main.SelectedPage = navPageHome;
                btn_Back_Main.Enabled = false;
            }
        }

        private void btn_Forward_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.listForward.Count > 0)
            {
                navPageAction.Controls.Clear();

                navPageAction.Controls.Add(this.listForward.Pop());
            }

            if (this.listForward.Count == 0)
            {
                btn_Forward_Main.Enabled = false;
            }
        }
        #endregion
        //===========================================================================================================
        //===============================================Teaching Division===========================================
        #region Teaching Division
        private void btn_TeachingDivision_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TeachingDivision.TeachingDivision frm = new TeachingDivision.TeachingDivision();
            frm.ShowDialog();
        }
        #endregion
        //===========================================================================================================
        //=================================================Permission================================================
        #region Permission
        private void btn_Permission_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PermissionUser.PermissionForm frm = new PermissionUser.PermissionForm(userName);
            frm.ShowDialog();
        }
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




    }
}
