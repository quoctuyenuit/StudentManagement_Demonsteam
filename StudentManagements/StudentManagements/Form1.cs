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
        delegate void back();

        Stack<back> listBack;//Danh sách để back
        bool checkBack;//Tín hiệu back1

        string userName;


        public Form1(string userName)
        {
            InitializeComponent();
            listBack = new Stack<back>();
            checkBack = true;
            btn_Back_Main.Enabled = false;

            this.userName = userName;

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Style";
        }

        //----------------------------------------------------------------------------
        private void btn_Home_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkBack = true;
            btn_Home_Main_ItemClick_back();
        }

        private void btn_Home_Main_ItemClick_back()
        {
            navFrame_Main.SelectedPage = navPage_Home;
        }
        //----------------------------------------------------------------------------

        private void grd_StudentList_ClassInformation_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudent_ClassInformation.Enabled = (grd_StudentList_ClassInformation_View.SelectedRowsCount != 0) ? true : false;
        }

        private void grd_SubjectList_ClassInformation_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudent_ClassInformation.Enabled = (grd_SubjectList_ClassInformation_View.SelectedRowsCount != 0) ? true : false;
        }

        private void grd_StudentList_AddClass_View_DataSourceChanged(object sender, EventArgs e)
        {
            txt_ClassTotal_AddClass.Text = grd_StudentList_AddClass_View.RowCount.ToString();
        }

        private void grd_StudentList_AddClass_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudentInClass_AddClass.Enabled = (grd_StudentList_AddClass_View.SelectedRowsCount != 0) ? true : false;
        }

        private void grd_SubjectList_AddClass_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudentInClass_AddClass.Enabled = (grd_StudentList_AddClass_View.SelectedRowsCount != 0) ? true : false;
        }

        private void navFrame_Main_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (navFrame_Main.SelectedPage == navPage_StudentsList || navFrame_Main.SelectedPage == navPage_ClassInformation || navFrame_Main.SelectedPage == navPage_LookUpStudents)
            {
                btn_ExportFile_Main.Enabled = true;
            }
            else
                btn_ExportFile_Main.Enabled = false;
        }

        private void navFrame_Main_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (!checkBack)
                return;
            btn_Back_Main.Enabled = true;
            if (navFrame_Main.SelectedPage == navPage_Home)
                listBack.Push(new back(btn_Home_Main_ItemClick_back));

            else if (navFrame_Main.SelectedPage == navPage_StudentsList)
                listBack.Push(new back(btn_Students_Actions_Click_back));

            else if (navFrame_Main.SelectedPage == navPage_StudentInformation)
                listBack.Push(new back(btn_Detail_StudentList_Click_back));

            else if (navFrame_Main.SelectedPage == navPage_ClassList)
                listBack.Push(new back(btn_Class_Actions_Click_back));

            else if (navFrame_Main.SelectedPage == navPage_ClassInformation)
                listBack.Push(new back(btn_Detail_ClassList_Click_back));

            else if (navFrame_Main.SelectedPage == navPage_ScoreBoardList)
                listBack.Push(new back(btn_ScoreBoard_Actions_Click_back));

            else if (navFrame_Main.SelectedPage == navPage_ScoreBoardDetail)
                listBack.Push(new back(btn_LookUp_ScoreBoardList_Click_back));

            else if (navFrame_Main.SelectedPage == navPage_AddStudent)
                listBack.Push(new back(btn_AddStudent_Main_ItemClick_back));

            else if (navFrame_Main.SelectedPage == navPage_AddClass)
                listBack.Push(new back(btn_AddClass_Main_ItemClick_back));

            else if (navFrame_Main.SelectedPage == navPage_LookUpStudents)
                listBack.Push(new back(btn_LookUpStudent_Main_ItemClick_back));

            else if (navFrame_Main.SelectedPage == navPage_CreateReports)
                listBack.Push(new back(btn_CreateReport_Main_ItemClick_back));

            else if (navFrame_Main.SelectedPage == navPage_TeachersList)
                listBack.Push(new back(btn_Teachers_Actions_Click_back));
        }


        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Actions


        //----------------------------------------------------------------------------
        public void btn_Students_Actions_Click(object sender, EventArgs e)
        {
            checkBack = true;
            btn_Students_Actions_Click_back();
        }
        private void btn_Students_Actions_Click_back()
        {
            ClassBus.Instance.btn_Students_Actions_Click(navFrame_Main, navPage_StudentsList, grd_StudentList);
        }
        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        private void btn_Class_Actions_Click(object sender, EventArgs e)
        {
            checkBack = true;
            btn_Class_Actions_Click_back();
        }

        private void btn_Class_Actions_Click_back()
        {
            ClassBus.Instance.btn_Class_Actions_Click(navFrame_Main, navPage_ClassList, grd_ClassList);
        }

        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        private void btn_ScoreBoard_Actions_Click(object sender, EventArgs e)
        {
            checkBack = true;
            btn_ScoreBoard_Actions_Click_back();
        }

        private void btn_ScoreBoard_Actions_Click_back()
        {
            ClassBus.Instance.btn_ScoreBoard_Actions_Click(navFrame_Main, navPage_ScoreBoardList, grd_ScoreBoardList);
        }
        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        private void btn_Teachers_Actions_Click(object sender, EventArgs e)
        {
            checkBack = true;
            btn_Teachers_Actions_Click_back();
        }

        void teacherDetail()
        {
            navFrame_Main.SelectedPage = navPage_TeacherDetail;
            if (getRow != null)
            {
                GUI.uc_TeacherDetail uc = new GUI.uc_TeacherDetail(getRow());
                uc.Dock = DockStyle.Fill;
                navPage_TeacherDetail.Controls.Clear();
                navPage_TeacherDetail.Controls.Add(uc);
            }
        }
        DataTable getTeacherList()
        {
            return BLL.ClassBLL.Instance.getTeacherList();
        }

        public TeacherListForm.DgetRow getRow;

        public void getDelegate(TeacherListForm.DgetRow getRow)
        {
            this.getRow = getRow;
        }
        private void btn_Teachers_Actions_Click_back()
        {
            //ClassBus.Instance.btn_Teachers_Actions_Click(navFrame_Main, navPage_TeachersList, teacherDetail);
            navFrame_Main.SelectedPage = navPage_TeachersList;
            GUI.uc_TeacherList uc = new GUI.uc_TeacherList(true);
            uc.Dock = DockStyle.Fill;
            uc.detail = new GUI.uc_TeacherList.Ddetail(teacherDetail);
            uc.getTable = new GUI.uc_TeacherList.DgetTable(getTeacherList);
            uc.giveRow = new GUI.uc_TeacherList.DgiveRow(getDelegate);
            navPage_TeachersList.Controls.Clear();
            navPage_TeachersList.Controls.Add(uc);

        }
        //----------------------------------------------------------------------------
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Student
        //----------------------------------------------------------------------------
        private void btn_LookUpStudent_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkBack = true;
            btn_LookUpStudent_Main_ItemClick_back();
        }

        private void btn_LookUpStudent_Main_ItemClick_back()
        {
            ClassBus.Instance.btn_LookUpStudent_Main_ItemClick(navFrame_Main, navPage_LookUpStudents, btn_Detail_StudentList_Click_back_callBack);
        }
        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        private void btn_AddStudent_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkBack = true;
            pic_StudentInformation_AddStudent.Image = Resources.StudentIcon;
            pic_StudentInformation_AddStudent.BackColor = Color.CornflowerBlue;
            btn_AddStudent_Main_ItemClick_back();
        }

        private void btn_AddStudent_Main_ItemClick_back()
        {
            ClassBus.Instance.btn_AddStudent_Main_ItemClick(studentInformationPanel, navFrame_Main, navPage_AddStudent, txt_StudentName_AddStudent);
        }
        //----------------------------------------------------------------------------

        private string urlImage;
        private void btn_Done_AddStudent_Click(object sender, EventArgs e)//Insert a student into database
        {
            pic_StudentInformation_AddStudent.Image = Resources.StudentIcon;
            pic_StudentInformation_AddStudent.BackColor = Color.CornflowerBlue;
            ClassBus.Instance.btn_Done_AddStudent_Click(studentInformationPanel, txt_StudentEmail_AddStudent, txt_StudentName_AddStudent, cb_StudentDateOfBirth_AddStudent, cb_StudentSex_AddStudent, txt_StudentAddress_AddStudent, urlImage);
        }

        private void link_EditImage_AddStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" + "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pic_StudentInformation_AddStudent.Image = Image.FromFile(dialog.FileName);
                    this.urlImage = dialog.FileName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error");
                    return;
                }
            }
        }
        //----------------------------------------------------------------------------
        private string urlImage_EditStudent;
        private void link_Edit_StudentInformation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" + "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pic_StudentInformation.Image = Image.FromFile(dialog.FileName);
                    this.urlImage_EditStudent = dialog.FileName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error");
                    return;
                }
            }
        }

        private void btn_Detail_StudentList_Click(object sender, EventArgs e)
        {
            btn_Detail_StudentList_Click_back();
        }

        private void btn_Detail_StudentList_Click_back()
        {
            btn_Detail_StudentList_Click_back_callBack(grd_StudentList_View);
        }

        private void btn_Detail_StudentList_Click_back_callBack(DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_View)
        {
            checkBack = true;
            btn_Edit_StudentInformation.Show();
            btn_Apply_StudentInformation.Hide();
            link_EditImage_StudentInformation.Hide();
            pic_StudentInformation.Image = Resources.StudentIcon;
            pic_StudentInformation.BackColor = Color.CornflowerBlue;
            ClassBus.Instance.btn_Detail_StudentList_Click(navFrame_Main, navFrame_StudentInformation, navPage_StudentInformation, navPage_StudentDetail_StudentInformation, navPage_StudentEdit_StudentInformation, grd_StudentList_View, txt_StudentID_StudentInformation_Detail, txt_StudentName_StudentInformation_Detail, txt_StudentDateOfBirth_StudentInformation_Detail, txt_StudentEmail_StudentInformation_Detail, txt_StudentSex_StudentInformation_Detail, txt_StudentAddress_StudentInformation_Detail, pic_StudentInformation);
        }
        //----------------------------------------------------------------------------

        private void btn_Delete_StudentList_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_Delete_StudentList_Click(grd_StudentList_View);
        }

        private void btn_Apply_StudentInformation_Click(object sender, EventArgs e)
        {
            link_EditImage_StudentInformation.Hide();
            ClassBus.Instance.btn_Save_StudentInformation_Click(txt_StudentEmail_StudentInformation_Edit, txt_StudentID_StudentInformation_Edit, txt_StudentName_StudentInformation_Edit, cb_StudentDateOfBirth_StudentInformation_Edit, cb_StudentSex_StudentInformation_Edit, txt_StudentAddress_StudentInformation_Edit,
               txt_StudentID_StudentInformation_Detail, txt_StudentName_StudentInformation_Detail, txt_StudentDateOfBirth_StudentInformation_Detail, txt_StudentEmail_StudentInformation_Detail,
               txt_StudentSex_StudentInformation_Detail, txt_StudentAddress_StudentInformation_Detail, navFrame_StudentInformation, navPage_StudentDetail_StudentInformation, btn_Apply_StudentInformation, btn_Edit_StudentInformation, urlImage_EditStudent);
        }

        private void btn_Edit_StudentInformation_Click(object sender, EventArgs e)//EditButon in StudentInformation
        {
            link_EditImage_StudentInformation.Show();//Hiển thị button để thay đổi ảnh
            ClassBus.Instance.btn_Edit_StudentInformation_Click(navFrame_StudentInformation, navPage_StudentEdit_StudentInformation, txt_StudentID_StudentInformation_Edit, txt_StudentID_StudentInformation_Detail,
                txt_StudentName_StudentInformation_Edit, txt_StudentName_StudentInformation_Detail, cb_StudentDateOfBirth_StudentInformation_Edit, txt_StudentDateOfBirth_StudentInformation_Detail,
                txt_StudentAddress_StudentInformation_Edit, txt_StudentAddress_StudentInformation_Detail, cb_StudentSex_StudentInformation_Edit, txt_StudentSex_StudentInformation_Detail,
                txt_StudentEmail_StudentInformation_Edit, txt_StudentEmail_StudentInformation_Detail, btn_Apply_StudentInformation, btn_Edit_StudentInformation);
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Class
        private void btn_Delete_ClassList_Click(object sender, EventArgs e)//Delete Class
        {
            ClassBus.Instance.btn_Delete_ClassList_Click(grd_ClassList_View);
        }

        //----------------------------------------------------------------------------
        private void btn_Detail_ClassList_Click(object sender, EventArgs e)
        {
            checkBack = true;
            btn_Detail_ClassList_Click_back();
        }

        private void btn_Detail_ClassList_Click_back()
        {
            ClassBus.Instance.btn_Detail_ClassList_Click(navFrame_Main, navPage_ClassInformation, navFrame_ClassInformation, navPage_ClassDetail, grd_ClassList_View, grd_StudentList_ClassInformation,
                 grd_SubjectList_ClassInformation, btn_AddSubjectsForClass_ClassInformation,
                 txt_ClassName_ClassInformation, txt_ClassTotal_ClassInformation, txt_Year_ClassInformation, btn_Edit_ClassInformation, btn_Save_ClassInformation, btn_DeleteStudent_ClassInformation,
                 btn_AddStudentForClass_ClassInformation, grd_StudentList_ClassInformation_View, grd_SubjectList_ClassInformation_View);
        }
        //----------------------------------------------------------------------------

        private void init_Edit_ClassInformation()//Khởi tạo các giá trị cho các control khi chọn edit
        {
            txt_ClassName_ClassInformation_Edit.Text = txt_ClassName_ClassInformation.Text;
            txt_ClassTotal_ClassInformation_Edit.Text = txt_ClassTotal_ClassInformation.Text;
            txt_Year_ClassInformation_Edit.Text = txt_Year_ClassInformation.Text;
            btn_Edit_ClassInformation.Hide();
            btn_DeleteStudent_ClassInformation.Enabled = false;
            btn_Save_ClassInformation.Show();
            btn_DeleteStudent_ClassInformation.Show();
            btn_AddStudentForClass_ClassInformation.Show();
            btn_AddSubjectsForClass_ClassInformation.Show();
            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelect = true;
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            grd_StudentList_ClassInformation_View.ClearSelection();
            grd_SubjectList_ClassInformation_View.ClearSelection();
            txt_ClassName_ClassInformation_Edit.Focus();
        }
        private void btn_Edit_ClassInformation_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.call = new ClassBus.init_CallBack(init_Edit_ClassInformation);
            ClassBus.Instance.btn_Edit_ClassInformation_Click(navFrame_ClassInformation, navPage_ClassDetail_Edit);

        }

        void init_SaveClassInformation()
        {
            txt_ClassName_ClassInformation.Text = txt_ClassName_ClassInformation_Edit.Text;
            txt_Year_ClassInformation.Text = txt_Year_ClassInformation_Edit.Text;
            txt_ClassTotal_ClassInformation.Text = txt_ClassTotal_ClassInformation_Edit.Text;
            btn_DeleteStudent_ClassInformation.Hide();
            btn_Save_ClassInformation.Hide();
            btn_Edit_ClassInformation.Show();
            btn_AddStudentForClass_ClassInformation.Hide();
            btn_AddSubjectsForClass_ClassInformation.Hide();
            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;
        }
        private void btn_Save_ClassInformation_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.call = new ClassBus.init_CallBack(init_SaveClassInformation);
            ClassBus.Instance.btn_Save_ClassInformation_Click(navPage_ClassDetail_Edit, txt_ClassName_ClassInformation_Edit, txt_ClassName_ClassInformation, txt_Year_ClassInformation_Edit,
                txt_Year_ClassInformation, txt_ClassTotal_ClassInformation_Edit, navPage_ClassDetail_Edit, grd_ClassList_View);
        }

        private void btn_AddStudentForClass_ClassInformation_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_AddStudentForClass_Edit;
            grd_AddStudentForClass_Edit.DataSource = ClassBLL.Instance.getStudentForAddClass(int.Parse(txt_Year_ClassInformation.Text));
        }

        private void btn_OK_AddStudentForClass_Edit_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_OK_AddStudentForClass_Edit_Click(txt_ClassName_ClassInformation, txt_Year_ClassInformation, grd_AddStudentForClass_Edit_View, grd_StudentList_ClassInformation, navFrame_Main,
                navPage_ClassInformation, txt_ClassTotal_ClassInformation_Edit, grd_StudentList_ClassInformation_View);
        }

        private void btn_DeleteStudent_ClassInformation_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_DeleteStudent_ClassInformation_Click(grd_ClassList_View, grd_StudentList_ClassInformation_View, grd_StudentList_ClassInformation, grd_SubjectList_ClassInformation_View,
                grd_SubjectList_ClassInformation, txt_ClassTotal_ClassInformation_Edit, btn_DeleteStudent_ClassInformation);
        }

        void addSubjectForClass_EditClass(int[] subjectIDs)
        {
            int MALOP = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP"));
            foreach (int id in subjectIDs)
            {
                ClassBLL.Instance.insertSubjectForClass(id, MALOP);
            }
            DataTable subjectTable = new DataTable();
            subjectTable = ClassBLL.Instance.getSubjectForClass(MALOP);
            grd_SubjectList_ClassInformation.DataSource = subjectTable;
        }
        private void btn_AddSubjectsForClass_ClassInformation_Click(object sender, EventArgs e)
        {
            AddSubjectForm form = new AddSubjectForm();
            form.returnData = new AddSubjectForm.callBack(addSubjectForClass_EditClass);
            form.ShowDialog();
        }

        //
        //AddClass
        //

        private void btn_AddStudentForClass_AddClass_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_AddStudentForClass;
            grd_AddStudentForClass.DataSource = ClassBLL.Instance.getStudentForAddClass(int.Parse(txt_Year_AddClass.Text));
        }

        //--------------------------------------------------------------------------------
        private void init_AddClass()
        {
            btn_AddStudentForClass_AddClass.Enabled = false;
            btn_Save_AddClass.Enabled = true;
            txt_ClassName_AddClass.Enabled = true;
            txt_Year_AddClass.Enabled = true;

            txt_ClassName_AddClass.Text = "";
            txt_Year_AddClass.Text = "";
            txt_ClassTotal_AddClass.Text = "";
            txt_ClassName_AddClass.Focus();
            grd_StudentList_AddClass.DataSource = null;
            grd_SubjectList_AddClass.DataSource = null;
            btn_DeleteStudentInClass_AddClass.Enabled = false;
            btn_AddSubjectsForClass_AddClass.Enabled = false;

        }
        private void btn_AddClass_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkBack = true;
            btn_AddClass_Main_ItemClick_back();
        }

        private void btn_AddClass_Main_ItemClick_back()
        {
            navFrame_Main.SelectedPage = navPage_AddClass;
            init_AddClass();
        }
        //--------------------------------------------------------------------------------

        private void btn_Save_AddClass_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_Save_AddClass_Click(addClassPanel, txt_ClassTotal_AddClass, txt_ClassName_AddClass, txt_Year_AddClass, btn_AddStudentForClass_AddClass, btn_AddSubjectsForClass_AddClass);
        }

        private void btn_OK_AddStudentForClass_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_OK_AddStudentForClass_Click(txt_ClassName_AddClass, txt_Year_AddClass, grd_AddStudentForClass_View, grd_StudentList_AddClass, navFrame_Main, navPage_AddClass,
                txt_ClassName_AddClass, txt_Year_AddClass, btn_Save_AddClass);
        }

        private void btn_DeleteStudentInClass_AddClass_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_DeleteStudentInClass_AddClass_Click(txt_ClassName_AddClass, txt_Year_AddClass, grd_StudentList_AddClass_View, grd_StudentList_AddClass, grd_SubjectList_AddClass_View, grd_SubjectList_AddClass,
                btn_DeleteStudentInClass_AddClass, grd_SubjectList_AddClass);
        }

        void addSubjectForClass_AddClass(int[] subjectIDs)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text));
            foreach (int id in subjectIDs)
            {
                ClassBLL.Instance.insertSubjectForClass(id, MALOP);
            }
            grd_SubjectList_AddClass.DataSource = ClassBLL.Instance.getSubjectForClass(MALOP); ;
        }
        private void btn_AddSubjectsForClass_AddClass_Click(object sender, EventArgs e)
        {
            AddSubjectForm frm = new AddSubjectForm();
            frm.returnData = new AddSubjectForm.callBack(addSubjectForClass_AddClass);
            frm.ShowDialog();
        }

        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //ScoreBoard
        DataTable getTableForScoreBoard()
        {
            return ClassBLL.Instance.getAllScoreBoard(); ;
        }

        //--------------------------------------------------------------------------------
        DgetString getClassName;
        public void getDelegateForScoreBoard(DgetData getTable, DgetString getClassName, DgetString getSubjectName, DgetInteger getSemester)
        {
            this.getTableForExport = getTable;
            this.getClassName = getClassName;
            this.getSubjectName = getSubjectName;
            this.getSemester = getSemester;
        }
        //--------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------
        private void btn_LookUp_ScoreBoardList_Click(object sender, EventArgs e)
        {
            checkBack = true;
            btn_LookUp_ScoreBoardList_Click_back();
        }

        private void btn_LookUp_ScoreBoardList_Click_back()
        {
            ClassBus.Instance.btn_LookUp_ScoreBoardList_Click(navFrame_Main, navPage_ScoreBoardDetail, grd_ScoreBoardList_View, setVisibleExportFile, getDelegateForScoreBoard);
        }
        //--------------------------------------------------------------------------------

        private void btn_Delete_ScoreBoardList_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.btn_Delete_ScoreBoardList_Click(grd_ScoreBoardList_View);
        }
        //=================================================================================================================
        //=================================================================================================================
        //=================================================================================================================
        //Report
        public delegate DataTable DgetData();
        public delegate string DgetString();
        public delegate int DgetInteger();
        public DgetData getTableForExport;
        public DgetString getSubjectName;
        public DgetInteger getSemester;
        //--------------------------------------------------------------------------------
        private void setVisibleExportFile(bool values)
        {
            btn_ExportFile_Main.Enabled = values;

        }
        private void getDelegateTable(DgetData data, DgetString subject, DgetInteger semester)
        {
            getTableForExport = data;
            getSubjectName = subject;
            getSemester = semester;
        }
        //--------------------------------------------------------------------------------
        private void tabPane_Reports_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            ClassBus.Instance.tabPane_Reports_SelectedPageChanged(tabPane_Reports, tab_Subject, setVisibleExportFile, getDelegateTable, tab_Semester);

        }
        //===========================================================================================================
        //===========================================================================================================
        //===========================================================================================================
        //Export to file

        private void btn_ExportFile_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClassBus.Instance.btn_ExportFile_Main_ItemClick(navFrame_Main, navPage_CreateReports, navPage_ClassInformation, navPage_ScoreBoardDetail, navPage_StudentsList, navPage_LookUpStudents, tabPane_Reports, tab_Subject, getTableForExport, getSubjectName, getSemester,
                getClassName, grd_ClassList_View, txt_ClassName_ClassInformation, txt_ClassTotal_ClassInformation, txt_Year_ClassInformation);
        }


        //===========================================================================================================
        //===========================================================================================================
        //===========================================================================================================
        //Ribb
        private void btn_ChangeRules_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeRules frm = new ChangeRules();
            frm.callBack = new ChangeRules.DcallBack(btn_Home_Main_ItemClick_back);
            frm.ShowDialog();
        }

        //----------------------------------------------------------------------------
        private void btn_CreateReport_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkBack = true;
            btn_CreateReport_Main_ItemClick_back();
        }

        private void btn_CreateReport_Main_ItemClick_back()
        {
            ClassBus.Instance.btn_CreateReport_Main_ItemClick(navFrame_Main, navPage_CreateReports, tabPane_Reports, tab_Subject, setVisibleExportFile, getDelegateTable);
        }
        //----------------------------------------------------------------------------
        private void btn_Back_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkBack = false;
            if (listBack.Count == 1)
                btn_Back_Main.Enabled = false;
            if (listBack.Count > 0)
                listBack.Pop()();
        }

        private void btn_TeachingDivision_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TeachingDivision frm = new TeachingDivision();
            frm.callBack = new TeachingDivision.DcallBack(btn_Home_Main_ItemClick_back);//Khi kết thúc sẽ phải quay lại page home
            frm.ShowDialog();
        }

        private void btn_Permission_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PermissionForm frm = new PermissionForm(userName);
            frm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
