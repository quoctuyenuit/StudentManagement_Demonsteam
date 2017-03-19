using DevExpress.XtraEditors;
using StudentManagements.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace StudentManagements 
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2016 Colorful";
        }

        private void navFrame_Main_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            navPage_ScoreBoardDetail2.Controls.Clear();//Dùng để xoá các control mà các trang đang chứa hiện tại(Reset trang)
        }

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

        //
        //Actions
        //
        
        public void btn_Students_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_StudentsList;
            ClassBus.Instance.showStudentList(grd_StudentList);

        }

        private void btn_Class_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ClassList;
            ClassBus.Instance.showClassList(grd_ClassList);
        }

        private void btn_ScoreBoard_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardList;
            ClassBus.Instance.showClassList(grd_ScoreBoardList);//Show ClassList to choose
        }
        
        //
        //Student
        //

        private void btn_AddStudent_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClassBLL.Instance.formatControls(studentInformationPanel);
            navFrame_Main.SelectedPage = navPage_AddStudent;
            txt_StudentName_AddStudent.Focus();
        }

        private void btn_Done_AddStudent_Click(object sender, EventArgs e)//Insert a student into database
        {
            if (!ClassBLL.Instance.checkBeforeSave(studentInformationPanel, txt_StudentEmail_AddStudent))
                return;
            if (ClassBLL.Instance.insertStudent(new Entities.HOCSINH(txt_StudentName_AddStudent.Text, txt_StudentEmail_AddStudent.Text, cb_StudentDateOfBirth_AddStudent.DateTime, cb_StudentSex_AddStudent.SelectedIndex, txt_StudentAddress_AddStudent.Text)))
            {
                //If insert successful
                ClassBLL.Instance.formatControls(studentInformationPanel);
                MessageBox.Show("Insert into database successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
                MessageBox.Show("Insert fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Detail_StudentList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_StudentInformation;
            navFrame_StudentInformation.SelectedPage = navPage_StudentDetail_StudentInformation;
            ClassBLL.Instance.formatControls(navPage_StudentEdit_StudentInformation);
            txt_StudentID_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS");
            txt_StudentName_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "HOTEN");
            txt_StudentDateOfBirth_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "NGSINH");
            txt_StudentEmail_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "EMAIL");
            txt_StudentSex_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "GIOITINH");
            txt_StudentAddress_StudentInformation_Detail.Text = ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "DIACHI");
        }

        private void btn_Delete_StudentList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Student?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ClassBLL.Instance.deleteStudent(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS"))))
                {
                    MessageBox.Show("Delete successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    btn_Students_Actions_Click(sender, e);
                }
                else
                    MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void btn_Save_StudentInformation_Click(object sender, EventArgs e)
        {
            Entities.HOCSINH student = new Entities.HOCSINH(int.Parse(txt_StudentID_StudentInformation_Edit.Text), txt_StudentName_StudentInformation_Edit.Text, txt_StudentEmail_StudentInformation_Edit.Text, cb_StudentDateOfBirth_StudentInformation_Edit.DateTime, cb_StudentSex_StudentInformation_Edit.SelectedIndex, txt_StudentAddress_StudentInformation_Edit.Text);
            if (ClassBLL.Instance.updateStudent(student))//If updated successful -> Show message and update data for controls
            {
                MessageBox.Show("You was updated successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btn_Edit_StudentInformation_Click(object sender, EventArgs e)//EditButon in StudentInformation
        {
            navFrame_StudentInformation.SelectedPage = navPage_StudentEdit_StudentInformation;
            ClassBLL.Instance.formatControls(navPage_StudentEdit_StudentInformation);//Format controls
            //Set Text of Texboxs
            txt_StudentID_StudentInformation_Edit.Text = txt_StudentID_StudentInformation_Detail.Text;
            txt_StudentName_StudentInformation_Edit.Text = txt_StudentName_StudentInformation_Detail.Text;

            cb_StudentDateOfBirth_StudentInformation_Edit.DateTime = DateTime.ParseExact(txt_StudentDateOfBirth_StudentInformation_Detail.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            txt_StudentAddress_StudentInformation_Edit.Text = txt_StudentAddress_StudentInformation_Detail.Text;
            cb_StudentSex_StudentInformation_Edit.SelectedIndex = (txt_StudentSex_StudentInformation_Detail.Text.Equals("Nam")) ? 1 : 0;
            txt_StudentEmail_StudentInformation_Edit.Text = txt_StudentEmail_StudentInformation_Detail.Text;

            btn_Save_StudentInformation.Show();
            btn_Edit_StudentInformation.Hide();
        }
        
        //
        //Class
        //
        private void btn_Delete_ClassList_Click(object sender, EventArgs e)//Delete Class
        {
            if (MessageBox.Show("Do you want to delete this Class?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ClassBLL.Instance.deleteClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP"))))
                    MessageBox.Show("Deleted successful!");
                else
                    MessageBox.Show("Deleted failure!");
            }
            grd_ClassList.DataSource = ClassBLL.Instance.getAllClass();
        }

        //
        //EditClass
        //

        private void init_ClassDetail()//Khởi tạo và set giá trị ban đầu cho các control trước khi vào page thông tin chi tiết của lớp
        {
            txt_ClassName_ClassInformation.Text = ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "TENLOP");
            txt_ClassTotal_ClassInformation.Text = ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "SISO");
            txt_Year_ClassInformation.Text = ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "NAMHOC");
            btn_Edit_ClassInformation.Show();
            btn_Save_ClassInformation.Hide();
            btn_DeleteStudent_ClassInformation.Hide();
            btn_AddStudentForClass_ClassInformation.Hide();
            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            //Set away select for grd_StudentList_ClassInformation
        }
        private void btn_Detail_ClassList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ClassInformation;//Show Page Class Information
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;
            init_ClassDetail();//Khởi tạo dữ liệu
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getStudentForClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
            grd_StudentList_ClassInformation.DataSource = table;

            DataTable subjectTable = new DataTable();
            subjectTable = ClassBLL.Instance.getSubjectForClass(int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
            grd_SubjectList_ClassInformation.DataSource = subjectTable;
            btn_AddSubjectsForClass_ClassInformation.Hide();
        }

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
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail_Edit;
            init_Edit_ClassInformation();
        }

        private void btn_Save_ClassInformation_Click(object sender, EventArgs e)
        {
            if (!ClassBLL.Instance.checkBeforeSave(navPage_ClassDetail_Edit))//If any control Empty => return;
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

            txt_ClassName_ClassInformation.Text = txt_ClassName_ClassInformation_Edit.Text;
            txt_Year_ClassInformation.Text = txt_Year_ClassInformation_Edit.Text;
            btn_DeleteStudent_ClassInformation.Hide();
            btn_Save_ClassInformation.Hide();
            btn_Edit_ClassInformation.Show();
            btn_AddStudentForClass_ClassInformation.Hide();
            btn_AddSubjectsForClass_ClassInformation.Hide();
            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;
        }

        private void btn_AddStudentForClass_ClassInformation_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_AddStudentForClass_Edit;
            ClassBus.Instance.showStudentForAddClass(grd_AddStudentForClass_Edit);
        }

        private void btn_OK_AddStudentForClass_Edit_Click(object sender, EventArgs e)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_ClassInformation.Text, int.Parse(txt_Year_ClassInformation.Text));//Get MALOP from navPage_ClassInformation
            ClassBus.Instance.processClickAddStudentForClass_ClassInformation(MALOP, grd_AddStudentForClass_Edit_View, grd_StudentList_ClassInformation);
            navFrame_Main.SelectedPage = navPage_ClassInformation;
            txt_ClassTotal_ClassInformation_Edit.Text = grd_StudentList_ClassInformation_View.RowCount.ToString();
        }

        private void btn_DeleteStudent_ClassInformation_Click(object sender, EventArgs e)
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

        void addSubjectForClass_EditClass(int[] subjectIDs)
        {
            int MALOP = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View,"MALOP"));
            foreach(int id in subjectIDs)
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
            ClassBus.Instance.showStudentForAddClass(grd_AddStudentForClass);
        }

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
            navFrame_Main.SelectedPage = navPage_AddClass;
            init_AddClass();

        }

        private void btn_Save_AddClass_Click(object sender, EventArgs e)
        {
            if (!ClassBLL.Instance.checkBeforeSave(addClassPanel, txt_ClassTotal_AddClass))//If any Texbox is empty => Exit
            {
                return;
            }
            if (ClassBus.Instance.saveAddClass(addClassPanel, txt_ClassTotal_AddClass, txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text)))
            {
                btn_AddStudentForClass_AddClass.Enabled = true;
                btn_AddSubjectsForClass_AddClass.Enabled = true;
            }
        }

        private void btn_OK_AddStudentForClass_Click(object sender, EventArgs e)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text));//Get MALOP from navPage_AddClass
            ClassBus.Instance.processClickAddStudentForClass_ClassInformation(MALOP, grd_AddStudentForClass_View, grd_StudentList_AddClass);
            //Xử lý thêm học sinh vào cho lớp, lấy thông tin tất cả các học sinh có trong lớp ra grdView hiển thị
            navFrame_Main.SelectedPage = navPage_AddClass;
            txt_ClassName_AddClass.Enabled = false;
            txt_Year_AddClass.Enabled = false;
            btn_Save_AddClass.Enabled = false;
        }

        private void btn_DeleteStudentInClass_AddClass_Click(object sender, EventArgs e)
        {
            int MALOP = ClassBLL.Instance.getClassID(txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text));//Get MALOP from navPage_ClassInformation
            ClassBus.Instance.deleteStudentInClass(grd_StudentList_AddClass_View, grd_StudentList_AddClass, MALOP);
            ClassBus.Instance.deleteSubjectInClass(grd_SubjectList_AddClass_View, grd_SubjectList_AddClass, MALOP);
            btn_DeleteStudentInClass_AddClass.Enabled = false;//Set enabled for button after User click
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getSubjectForClass(MALOP);
            grd_SubjectList_AddClass.DataSource = table;
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
        
        //
        //ScoreBoard
        //

        DataTable getTable()
        {
            return ClassBLL.Instance.getAllScoreBoard(); ;
        }
        private void btn_All_ScoreBoardList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardDetail;
            
            GUI.uc_ScoreBoardList uc = new GUI.uc_ScoreBoardList();
            uc.Dock = DockStyle.Fill;
            uc.getTable = new GUI.uc_ScoreBoardList.getData(getTable);
            navPage_ScoreBoardDetail.Controls.Add(uc);
        }
        private void btn_LookUp_ScoreBoardList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardDetail2;//Show Page
            string TENLOP = ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoardList_View, "TENLOP");
            int MALOP = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoardList_View, "MALOP"));
            GUI.uc_ScoreBoardOfClass uc = new GUI.uc_ScoreBoardOfClass(TENLOP, MALOP);
            uc.Dock = DockStyle.Fill;
            navPage_ScoreBoardDetail2.Controls.Add(uc);
        }

        private void btn_Home_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_Delete_ScoreBoardList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ScoreBoard will deleted\nDo you want to delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ClassBLL.Instance.deleteScoreBoardClass((int)grd_ScoreBoardList_View.GetDataRow(grd_ScoreBoardList_View.GetSelectedRows().First())["MALOP"]);
            }
        }
    }

}
