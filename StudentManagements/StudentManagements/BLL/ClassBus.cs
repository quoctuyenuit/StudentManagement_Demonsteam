using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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

        public delegate void init_CallBack();
        public init_CallBack call;
        public void showScoreBoardList(GridControl grd)
        {
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getAllScoreBoard();
            grd.DataSource = table;
        }
        //========================================================================================================================

        public void processClickAddStudentForClass_ClassInformation(int MALOP, GridView grd, GridControl grdSource)
        {
            int[] rows = grd.GetSelectedRows();
            foreach (int row in rows)
            {
                if (!ClassBLL.Instance.insertStudetForClass((int)grd.GetListSourceRowCellValue(row, "MSHS"), MALOP))
                {
                    MessageBox.Show("Quantity exceeds the limit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getStudentForClass(MALOP);
            grdSource.DataSource = table;
        }

        public bool saveAddClass(Panel addClassPanel, TextEdit txt_ClassTotal_AddClass, string className, int year)
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
                MessageBox.Show("Create Class failure!");
                return false;
            }
        }

        public void deleteStudentInClass(GridView grd_StudentList_View, GridControl grd_StudentList, int MALOP)
        {
            int[] rows = grd_StudentList_View.GetSelectedRows();//Take rows of Table in GridControl StudentList
            foreach (int row in rows)
            {
                ClassBLL.Instance.deleteStudentInClass((int)grd_StudentList_View.GetListSourceRowCellValue(row, "MSHS"), MALOP);
            }
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getStudentForClass(MALOP);
            grd_StudentList.DataSource = table;
        }

        public void deleteSubjectInClass(GridView grd_SubjectList_View, GridControl grd_SubjectList, int MALOP)
        {
            int[] rows = grd_SubjectList_View.GetSelectedRows();
            foreach (int row in rows)
            {
                ClassBLL.Instance.deleteSubjectInClass((int)grd_SubjectList_View.GetListSourceRowCellValue(row, "MAMH"), MALOP);
            }
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getSubjectForClass(MALOP);
            grd_SubjectList.DataSource = table;
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Student
        internal void btn_Detail_StudentList_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationFrame navFrame_StudentInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentDetail_StudentInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentEdit_StudentInformation, GridView grd_StudentList_View, LabelControl txt_StudentID_StudentInformation_Detail, LabelControl txt_StudentName_StudentInformation_Detail, LabelControl txt_StudentDateOfBirth_StudentInformation_Detail, LabelControl txt_StudentEmail_StudentInformation_Detail, LabelControl txt_StudentSex_StudentInformation_Detail, LabelControl txt_StudentAddress_StudentInformation_Detail, PictureBox pic_StudentInformation)
        {
            navFrame_Main.SelectedPage = navPage_StudentInformation;
            navFrame_StudentInformation.SelectedPage = navPage_StudentDetail_StudentInformation;
            ClassBLL.Instance.formatControls(navPage_StudentEdit_StudentInformation);
            txt_StudentID_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS");
            DataRow row = ClassBLL.Instance.getStudentAccordingID(int.Parse(txt_StudentID_StudentInformation_Detail.Text)).Rows[0];

            txt_StudentName_StudentInformation_Detail.Text = row["HOTEN"].ToString();
            string[] temp = row["NGSINH"].ToString().Split(' ');
            temp = temp[0].Split('/');
            string day = (temp[1].Length == 1) ? "0" + temp[1] : temp[1];
            string month = (temp[0].Length == 1) ? "0" + temp[0] : temp[0];
            txt_StudentDateOfBirth_StudentInformation_Detail.Text = day + "/" + month + "/" + temp[2];
            txt_StudentEmail_StudentInformation_Detail.Text = row["EMAIL"].ToString();
            txt_StudentSex_StudentInformation_Detail.Text = row["GIOITINH"].ToString();
            txt_StudentAddress_StudentInformation_Detail.Text = row["DIACHI"].ToString();
            if (!String.IsNullOrEmpty(row["ANH"].ToString()))
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(row["ANH"]);
                MemoryStream mem = new MemoryStream(data);
                pic_StudentInformation.Image = Image.FromStream(mem);
            }
        }

        internal void btn_Done_AddStudent_Click(Panel studentInformationPanel, TextEdit txt_StudentEmail_AddStudent, TextEdit txt_StudentName_AddStudent, DateEdit cb_StudentDateOfBirth_AddStudent, System.Windows.Forms.ComboBox cb_StudentSex_AddStudent, RichTextBox txt_StudentAddress_AddStudent, string urlImage)
        {
            if (!ClassBLL.Instance.IsNotEmpty(studentInformationPanel, txt_StudentEmail_AddStudent))
                return;

            if (!string.IsNullOrEmpty(txt_StudentEmail_AddStudent.Text) && !ClassBLL.Instance.IsEmail(txt_StudentEmail_AddStudent.Text))
            {
                MessageBox.Show("Invalid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClassBLL.Instance.insertStudent(new Entities.HOCSINH(txt_StudentName_AddStudent.Text, txt_StudentEmail_AddStudent.Text, cb_StudentDateOfBirth_AddStudent.DateTime, cb_StudentSex_AddStudent.SelectedIndex, txt_StudentAddress_AddStudent.Text, urlImage)))
            {
                //If insert successful
                ClassBLL.Instance.formatControls(studentInformationPanel);
                MessageBox.Show("Insert into database successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                DataRow r = ClassBLL.Instance.getRulesStudentAge();
                MessageBox.Show("Insert fail!, Student Age must be between " + r[0] + " and " + r[1], "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_StudentDateOfBirth_AddStudent.Focus();
            }
        }

        internal void btn_AddStudent_Main_ItemClick(Panel studentInformationPanel, DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_AddStudent, TextEdit txt_StudentName_AddStudent)
        {
            ClassBLL.Instance.formatControls(studentInformationPanel);
            navFrame_Main.SelectedPage = navPage_AddStudent;
            txt_StudentName_AddStudent.Focus();
        }

        internal void btn_LookUpStudent_Main_ItemClick(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_LookUpStudents, Action<GridView> btn_Detail_StudentList_Click_back)
        {
            navFrame_Main.SelectedPage = navPage_LookUpStudents;
            GUI.uc_LookUpStudent uc = new GUI.uc_LookUpStudent();
            uc.Dock = DockStyle.Fill;
            uc.detailClick = new GUI.uc_LookUpStudent.detailEvent(btn_Detail_StudentList_Click_back);
            navPage_LookUpStudents.Controls.Clear();//Dùng để xoá các control mà các trang đang chứa hiện tại(Reset trang)
            navPage_LookUpStudents.Controls.Add(uc);
        }

        internal void btn_Delete_StudentList_Click(GridView grd_StudentList_View, GridControl grd_StudentList)
        {
            if (MessageBox.Show("Do you want to delete this Student?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ClassBLL.Instance.deleteStudent(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS"))))
                {
                    grd_StudentList.DataSource = ClassBLL.Instance.getAllStudents();
                }
                else
                    MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        internal void btn_Save_StudentInformation_Click(TextEdit txt_StudentEmail_StudentInformation_Edit, TextEdit txt_StudentID_StudentInformation_Edit, TextEdit txt_StudentName_StudentInformation_Edit, DateEdit cb_StudentDateOfBirth_StudentInformation_Edit, System.Windows.Forms.ComboBox cb_StudentSex_StudentInformation_Edit, TextEdit txt_StudentAddress_StudentInformation_Edit, LabelControl txt_StudentID_StudentInformation_Detail, LabelControl txt_StudentName_StudentInformation_Detail, LabelControl txt_StudentDateOfBirth_StudentInformation_Detail, LabelControl txt_StudentEmail_StudentInformation_Detail, LabelControl txt_StudentSex_StudentInformation_Detail, LabelControl txt_StudentAddress_StudentInformation_Detail, DevExpress.XtraBars.Navigation.NavigationFrame navFrame_StudentInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentDetail_StudentInformation, SimpleButton btn_Save_StudentInformation, SimpleButton btn_Edit_StudentInformation,string  urlImage_EditStudent)
        {
            if (!string.IsNullOrEmpty(txt_StudentEmail_StudentInformation_Edit.Text) && !ClassBLL.Instance.IsEmail(txt_StudentEmail_StudentInformation_Edit.Text))
            {
                MessageBox.Show("Invalid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_StudentEmail_StudentInformation_Edit.Focus();
                return;
            }
            Entities.HOCSINH student = new Entities.HOCSINH(int.Parse(txt_StudentID_StudentInformation_Edit.Text), txt_StudentName_StudentInformation_Edit.Text, txt_StudentEmail_StudentInformation_Edit.Text, cb_StudentDateOfBirth_StudentInformation_Edit.DateTime, cb_StudentSex_StudentInformation_Edit.SelectedIndex, txt_StudentAddress_StudentInformation_Edit.Text, urlImage_EditStudent);
            if (ClassBLL.Instance.updateStudent(student))//If updated successful -> Show message and update data for controls
            {
                txt_StudentID_StudentInformation_Detail.Text = txt_StudentID_StudentInformation_Edit.Text;
                txt_StudentName_StudentInformation_Detail.Text = txt_StudentName_StudentInformation_Edit.Text;
                txt_StudentDateOfBirth_StudentInformation_Detail.Text = cb_StudentDateOfBirth_StudentInformation_Edit.Text;
                txt_StudentEmail_StudentInformation_Detail.Text = txt_StudentEmail_StudentInformation_Edit.Text;
                txt_StudentSex_StudentInformation_Detail.Text = cb_StudentSex_StudentInformation_Edit.Text;
                txt_StudentAddress_StudentInformation_Detail.Text = txt_StudentAddress_StudentInformation_Edit.Text;
                navFrame_StudentInformation.SelectedPage = navPage_StudentDetail_StudentInformation;

                btn_Save_StudentInformation.Hide();
                btn_Edit_StudentInformation.Show();
            }
            else
            {
                DataRow r = ClassBLL.Instance.getRulesStudentAge();
                MessageBox.Show("Insert fail!, Student Age must be between " + r[0] + " and " + r[1], "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_StudentDateOfBirth_StudentInformation_Edit.DateTime = DateTime.ParseExact(txt_StudentDateOfBirth_StudentInformation_Detail.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }

        internal void btn_Edit_StudentInformation_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_StudentInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentEdit_StudentInformation, TextEdit txt_StudentID_StudentInformation_Edit, LabelControl txt_StudentID_StudentInformation_Detail, TextEdit txt_StudentName_StudentInformation_Edit, LabelControl txt_StudentName_StudentInformation_Detail, DateEdit cb_StudentDateOfBirth_StudentInformation_Edit, LabelControl txt_StudentDateOfBirth_StudentInformation_Detail, TextEdit txt_StudentAddress_StudentInformation_Edit, LabelControl txt_StudentAddress_StudentInformation_Detail, System.Windows.Forms.ComboBox cb_StudentSex_StudentInformation_Edit, LabelControl txt_StudentSex_StudentInformation_Detail, TextEdit txt_StudentEmail_StudentInformation_Edit, LabelControl txt_StudentEmail_StudentInformation_Detail, SimpleButton btn_Save_StudentInformation, SimpleButton btn_Edit_StudentInformation)
        {
            navFrame_StudentInformation.SelectedPage = navPage_StudentEdit_StudentInformation;
            ClassBLL.Instance.formatControls(navPage_StudentEdit_StudentInformation);//Format controls
            //Set Text of Texboxs
            txt_StudentID_StudentInformation_Edit.Text = txt_StudentID_StudentInformation_Detail.Text;
            txt_StudentName_StudentInformation_Edit.Text = txt_StudentName_StudentInformation_Detail.Text;

            cb_StudentDateOfBirth_StudentInformation_Edit.DateTime = DateTime.ParseExact(txt_StudentDateOfBirth_StudentInformation_Detail.Text, "d/MM/yyyy", CultureInfo.InvariantCulture);

            txt_StudentAddress_StudentInformation_Edit.Text = txt_StudentAddress_StudentInformation_Detail.Text;
            cb_StudentSex_StudentInformation_Edit.SelectedIndex = (txt_StudentSex_StudentInformation_Detail.Text.Equals("Nam")) ? 1 : 0;
            txt_StudentEmail_StudentInformation_Edit.Text = txt_StudentEmail_StudentInformation_Detail.Text;

            btn_Save_StudentInformation.Show();
            btn_Edit_StudentInformation.Hide();
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Action
        internal void btn_Students_Actions_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentsList, GridControl grd_StudentList)
        {
            navFrame_Main.SelectedPage = navPage_StudentsList;
            grd_StudentList.DataSource = ClassBLL.Instance.getAllStudents();
        }

        internal void btn_Class_Actions_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassList, GridControl grd_ClassList)
        {
            navFrame_Main.SelectedPage = navPage_ClassList;
            grd_ClassList.DataSource = ClassBLL.Instance.getAllClass();
        }

        internal void btn_ScoreBoard_Actions_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardList, GridControl grd_ScoreBoardList)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardList;
            grd_ScoreBoardList.DataSource = ClassBLL.Instance.getAllClass();//Show ClassList to choose
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Report
        internal void btn_CreateReport_Main_ItemClick(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_CreateReports, DevExpress.XtraBars.Navigation.TabPane tabPane_Reports, DevExpress.XtraBars.Navigation.TabNavigationPage tab_Subject, Action<bool> setVisibleExportFile, Action<Form1.DgetData, Form1.DgetString, Form1.DgetInteger> getDelegateTable)
        {
            navFrame_Main.SelectedPage = navPage_CreateReports;
            tabPane_Reports.SelectedPage = tab_Subject;
            GUI.uc_Report_Subject uc = new GUI.uc_Report_Subject();
            uc.Dock = DockStyle.Fill;
            uc.setVisible = new GUI.uc_Report_Subject.CallBack(setVisibleExportFile);
            uc.getDelegateData = new GUI.uc_Report_Subject.getDelegate(getDelegateTable);
            tab_Subject.Controls.Clear();
            tab_Subject.Controls.Add(uc);
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Class
        internal void btn_Delete_ClassList_Click(GridView grd_ClassList_View, GridControl grd_ClassList)
        {
            if (MessageBox.Show("Do you want to delete this Class?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (!ClassBLL.Instance.deleteClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP"))))
                    MessageBox.Show("Deleted failure!");
            }
            grd_ClassList.DataSource = ClassBLL.Instance.getAllClass();
        }

        internal void btn_Detail_ClassList_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassInformation, DevExpress.XtraBars.Navigation.NavigationFrame navFrame_ClassInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail, GridView grd_ClassList_View, GridControl grd_StudentList_ClassInformation, GridControl grd_SubjectList_ClassInformation, SimpleButton btn_AddSubjectsForClass_ClassInformation, LabelControl txt_ClassName_ClassInformation, LabelControl txt_ClassTotal_ClassInformation, LabelControl txt_Year_ClassInformation, SimpleButton btn_Edit_ClassInformation, SimpleButton btn_Save_ClassInformation, SimpleButton btn_DeleteStudent_ClassInformation, SimpleButton btn_AddStudentForClass_ClassInformation, GridView grd_StudentList_ClassInformation_View, GridView grd_SubjectList_ClassInformation_View)
        {
            navFrame_Main.SelectedPage = navPage_ClassInformation;//Show Page Class Information
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;

            //Khởi tạo dữ liệu 

            txt_ClassName_ClassInformation.Text = ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "TENLOP");
            txt_ClassTotal_ClassInformation.Text = ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "SISO");
            txt_Year_ClassInformation.Text = ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "NAMHOC");
            btn_Edit_ClassInformation.Show();
            btn_Save_ClassInformation.Hide();
            btn_DeleteStudent_ClassInformation.Hide();
            btn_AddStudentForClass_ClassInformation.Hide();
            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;//Set away select for grd_StudentList_ClassInformation
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

            grd_StudentList_ClassInformation.DataSource = ClassBLL.Instance.getStudentForClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP"))); ;
            grd_SubjectList_ClassInformation.DataSource = ClassBLL.Instance.getSubjectForClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
            btn_AddSubjectsForClass_ClassInformation.Hide();
        }

        internal void btn_Edit_ClassInformation_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_ClassInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail_Edit)
        {
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail_Edit;
            if (call != null)
                call();
        }

        internal void btn_Save_ClassInformation_Click(DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail_Edit, TextEdit txt_ClassName_ClassInformation_Edit, LabelControl txt_ClassName_ClassInformation, TextEdit txt_Year_ClassInformation_Edit, LabelControl txt_Year_ClassInformation, TextEdit txt_ClassTotal_ClassInformation_Edit, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail_Edit2, GridView grd_ClassList_View)
        {
            if (!ClassBLL.Instance.IsNotEmpty(navPage_ClassDetail_Edit))//If any control Empty => return;
            {
                return;
            }
            //If don't have any change then return
            if (!txt_ClassName_ClassInformation_Edit.Text.Equals(txt_ClassName_ClassInformation.Text) || !txt_Year_ClassInformation_Edit.Text.Equals(txt_Year_ClassInformation.Text))
            {
                //-----------------------------------------------
                //If Class already exists then return;
                Entities.LOP lop = new Entities.LOP(txt_ClassName_ClassInformation_Edit.Text, int.Parse(txt_ClassTotal_ClassInformation_Edit.Text), int.Parse(txt_Year_ClassInformation_Edit.Text));
                if (!ClassBLL.Instance.checkExistenceClass(lop))
                {
                    MessageBox.Show("Class already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            ClassBLL.Instance.updateClassNameAndClassYear(txt_ClassName_ClassInformation_Edit.Text, int.Parse(txt_Year_ClassInformation_Edit.Text), int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
            if (call != null)
                call();
        }

        internal void btn_OK_AddStudentForClass_Edit_Click(LabelControl txt_ClassName_ClassInformation, LabelControl txt_Year_ClassInformation, GridView grd_AddStudentForClass_Edit_View, GridControl grd_StudentList_ClassInformation, DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassInformation, TextEdit txt_ClassTotal_ClassInformation_Edit, GridView grd_StudentList_ClassInformation_View)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_ClassInformation.Text, int.Parse(txt_Year_ClassInformation.Text));//Get MALOP from navPage_ClassInformation
            this.processClickAddStudentForClass_ClassInformation(MALOP, grd_AddStudentForClass_Edit_View, grd_StudentList_ClassInformation);
            navFrame_Main.SelectedPage = navPage_ClassInformation;
            txt_ClassTotal_ClassInformation_Edit.Text = grd_StudentList_ClassInformation_View.RowCount.ToString();
        }

        internal void btn_DeleteStudent_ClassInformation_Click(GridView grd_ClassList_View, GridView grd_StudentList_ClassInformation_View, GridControl grd_StudentList_ClassInformation, GridView grd_SubjectList_ClassInformation_View, GridControl grd_SubjectList_ClassInformation, TextEdit txt_ClassTotal_ClassInformation_Edit, SimpleButton btn_DeleteStudent_ClassInformation)
        {
            if (MessageBox.Show("Do you want to Delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int MALOP = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")); ;//Get MALOP from navPage_ClassInformation
                ClassBus.Instance.deleteStudentInClass(grd_StudentList_ClassInformation_View, grd_StudentList_ClassInformation, MALOP);
                ClassBus.Instance.deleteSubjectInClass(grd_SubjectList_ClassInformation_View, grd_SubjectList_ClassInformation, MALOP);
                txt_ClassTotal_ClassInformation_Edit.Text = grd_StudentList_ClassInformation_View.RowCount.ToString();
                btn_DeleteStudent_ClassInformation.Enabled = false;//Set enabled for button after User click
            }
        }

        internal void btn_Save_AddClass_Click(Panel addClassPanel, TextEdit txt_ClassTotal_AddClass, TextEdit txt_ClassName_AddClass, TextEdit txt_Year_AddClass, SimpleButton btn_AddStudentForClass_AddClass, SimpleButton btn_AddSubjectsForClass_AddClass)
        {
            if (!ClassBLL.Instance.IsNotEmpty(addClassPanel, txt_ClassTotal_AddClass))//If any Texbox is empty => Exit
            {
                return;
            }
            if (ClassBus.Instance.saveAddClass(addClassPanel, txt_ClassTotal_AddClass, txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text)))
            {
                btn_AddStudentForClass_AddClass.Enabled = true;
                btn_AddSubjectsForClass_AddClass.Enabled = true;
            }
        }

        internal void btn_OK_AddStudentForClass_Click(TextEdit txt_ClassName_AddClass, TextEdit txt_Year_AddClass, GridView grd_AddStudentForClass_View, GridControl grd_StudentList_AddClass, DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_AddClass, TextEdit txt_ClassName_AddClass2, TextEdit txt_Year_AddClass2, SimpleButton btn_Save_AddClass)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text));//Get MALOP from navPage_AddClass
            ClassBus.Instance.processClickAddStudentForClass_ClassInformation(MALOP, grd_AddStudentForClass_View, grd_StudentList_AddClass);
            //Xử lý thêm học sinh vào cho lớp, lấy thông tin tất cả các học sinh có trong lớp ra grdView hiển thị
            navFrame_Main.SelectedPage = navPage_AddClass;
            txt_ClassName_AddClass.Enabled = false;
            txt_Year_AddClass.Enabled = false;
            btn_Save_AddClass.Enabled = false;
        }

        internal void btn_DeleteStudentInClass_AddClass_Click(TextEdit txt_ClassName_AddClass, TextEdit txt_Year_AddClass, GridView grd_StudentList_AddClass_View, GridControl grd_StudentList_AddClass, GridView grd_SubjectList_AddClass_View, GridControl grd_SubjectList_AddClass1, SimpleButton btn_DeleteStudentInClass_AddClass, GridControl grd_SubjectList_AddClass)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text));//Get MALOP from navPage_ClassInformation
            ClassBus.Instance.deleteStudentInClass(grd_StudentList_AddClass_View, grd_StudentList_AddClass, MALOP);
            ClassBus.Instance.deleteSubjectInClass(grd_SubjectList_AddClass_View, grd_SubjectList_AddClass, MALOP);
            btn_DeleteStudentInClass_AddClass.Enabled = false;//Set enabled for button after User click
            grd_SubjectList_AddClass.DataSource = ClassBLL.Instance.getSubjectForClass(MALOP);
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //ScoreBoard

        internal void btn_LookUp_ScoreBoardList_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardDetail, GridView grd_ScoreBoardList_View, Action<bool> setVisibleExportFile, Action<Form1.DgetData, Form1.DgetString, Form1.DgetString, Form1.DgetInteger> getDelegateForScoreBoard)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardDetail;//Show Page
            string TENLOP = ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoardList_View, "TENLOP");
            int MALOP = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoardList_View, "MALOP"));
            GUI.uc_ScoreBoardOfClass uc = new GUI.uc_ScoreBoardOfClass(TENLOP, MALOP);
            uc.setVisible = new GUI.uc_ScoreBoardOfClass.CallBack(setVisibleExportFile);
            uc.getDelegateData = new GUI.uc_ScoreBoardOfClass.getDelegate(getDelegateForScoreBoard);
            uc.Dock = DockStyle.Fill;
            navPage_ScoreBoardDetail.Controls.Clear();
            navPage_ScoreBoardDetail.Controls.Add(uc);
        }

        internal void btn_Delete_ScoreBoardList_Click(GridView grd_ScoreBoardList_View)
        {
            if (MessageBox.Show("ScoreBoard will deleted\nDo you want to delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ClassBLL.Instance.deleteScoreBoardClass((int)grd_ScoreBoardList_View.GetDataRow(grd_ScoreBoardList_View.GetSelectedRows().First())["MALOP"]);
            }
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Report
        internal void tabPane_Reports_SelectedPageChanged(DevExpress.XtraBars.Navigation.TabPane tabPane_Reports, DevExpress.XtraBars.Navigation.TabNavigationPage tab_Subject, Action<bool> setVisibleExportFile, Action<Form1.DgetData, Form1.DgetString, Form1.DgetInteger> getDelegateTable, DevExpress.XtraBars.Navigation.TabNavigationPage tab_Semester)
        {
            if (tabPane_Reports.SelectedPage == tab_Subject)
            {
                GUI.uc_Report_Subject uc = new GUI.uc_Report_Subject();
                uc.Dock = DockStyle.Fill;
                uc.setVisible = new GUI.uc_Report_Subject.CallBack(setVisibleExportFile);
                uc.getDelegateData = new GUI.uc_Report_Subject.getDelegate(getDelegateTable);
                tab_Subject.Controls.Clear();
                tab_Subject.Controls.Add(uc);
            }
            else if (tabPane_Reports.SelectedPage == tab_Semester)
            {
                GUI.uc_Report_Semester uc = new GUI.uc_Report_Semester();
                uc.Dock = DockStyle.Fill;
                uc.setVisible = new GUI.uc_Report_Semester.CallBack(setVisibleExportFile);
                uc.getDelegateTable = new GUI.uc_Report_Semester.getDelegate(getDelegateTable);
                tab_Semester.Controls.Clear();
                tab_Semester.Controls.Add(uc);
            }
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Export to Excel
        internal void btn_ExportFile_Main_ItemClick(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_CreateReports, DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassInformation, DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardDetail, DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentsList, DevExpress.XtraBars.Navigation.TabPane tabPane_Reports, DevExpress.XtraBars.Navigation.TabNavigationPage tab_Subject, Form1.DgetData getTableForExport, Form1.DgetString getSubjectName, Form1.DgetInteger getSemester, Form1.DgetString getClassName, GridView grd_ClassList_View, LabelControl txt_ClassName_ClassInformation, LabelControl txt_ClassTotal_ClassInformation, LabelControl txt_Year_ClassInformation)
        {
            if (navFrame_Main.SelectedPage == navPage_CreateReports)
            {
                string title = "";
                if (tabPane_Reports.SelectedPage == tab_Subject)
                {
                    title = "Báo Cáo Tổng Kết Môn Học";
                    if (getTableForExport != null && getSubjectName != null && getSemester != null)
                        DAL.ExportToExcel.Instance.Export_Report_Subject(getTableForExport(), getSubjectName(), getSemester(), "Lop", title);
                }
                else
                {
                    title = "Báo Cáo Tổng Kế Học Kỳ";
                    if (getTableForExport != null && getSemester != null)
                        DAL.ExportToExcel.Instance.Export_Report_Semester(getTableForExport(), getSemester(), "Lop", title);
                }
            }
            else if (navFrame_Main.SelectedPage == navPage_ScoreBoardDetail)
            {
                if (navPage_ScoreBoardDetail.Controls[0] is GUI.uc_ScoreBoardOfClass)
                    if (getTableForExport != null && getClassName != null && getSubjectName != null && getSemester != null)
                        DAL.ExportToExcel.Instance.Export_ScoreBoard(getTableForExport(), getClassName(), getSubjectName(), getSemester(), "Bang Điểm", "BẢNG ĐIỂM MÔN HỌC");
            }
            else if (navFrame_Main.SelectedPage == navPage_ClassInformation)
            {
                DataTable table = ClassBLL.Instance.getStudentForClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
                string ClassName = txt_ClassName_ClassInformation.Text;
                int ClassSize = int.Parse(txt_ClassTotal_ClassInformation.Text);
                int Year = int.Parse(txt_Year_ClassInformation.Text);
                DAL.ExportToExcel.Instance.Export_ClassInformation(table, ClassName, ClassSize, Year, "Lớp", "THÔNG TIN CHI TIẾT LỚP");
            }
            else if (navFrame_Main.SelectedPage == navPage_StudentsList)
            {
                DAL.ExportToExcel.Instance.Export_Student(ClassBLL.Instance.getAllStudents(), "Học Sinh", "DANH SÁCH HỌC SINH");
            }

        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Teacher
        DataTable getTeacherList()
        {
            return BLL.ClassBLL.Instance.getTeacherList();
        }
        internal void btn_Teachers_Actions_Click(DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main, DevExpress.XtraBars.Navigation.NavigationPage navPage_TeachersList, Action detailTeacher)
        {
            navFrame_Main.SelectedPage = navPage_TeachersList;
            GUI.uc_TeacherList uc = new GUI.uc_TeacherList(true);
            uc.Dock = DockStyle.Fill;
            uc.detail = new GUI.uc_TeacherList.Ddetail(detailTeacher);
            uc.getTable = new GUI.uc_TeacherList.DgetTable(getTeacherList);
            navPage_TeachersList.Controls.Add(uc);
        }
    }
}
