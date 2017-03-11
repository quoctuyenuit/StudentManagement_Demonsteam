using DevExpress.XtraEditors;
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
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2016 Colorful";
        }

        //==============================================================================
        //Actions
        private void btn_Students_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_StudentsList;
            btn_Detail_StudentList.Enabled = false;
            btn_Delete_StudentList.Enabled = false;
            DataTable table = new DataTable();
            table = classBLL.getAllStudents();
            grd_StudentList.DataSource = table;
        }

        private void btn_Class_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ClassList;
            btn_Detail_ClassList.Enabled = false;
            btn_Delete_ClassList.Enabled = false;
            DataTable table = new DataTable();
            table = classBLL.getAllClass();
            grd_ClassList.DataSource = table;
        }

        private void btn_ScoreBoard_Actions_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardList;
            DataTable table = new DataTable();
            table = classBLL.getAllClass();
            grd_ScoreBoardList.DataSource = table;
        }
        //==============================================================================
        //Event
        private void grd_StudentList_Click(object sender, EventArgs e)
        {
            btn_Detail_StudentList.Enabled = true;
            btn_Delete_StudentList.Enabled = true;
        }

        private void grd_ClassList_Click(object sender, EventArgs e)
        {
            btn_Detail_ClassList.Enabled = true;
            btn_Delete_ClassList.Enabled = true;
        }
        //==============================================================================
        //Student

        private void formatControls(Control panel)//Format controls for null
        {
            foreach(Control ctrl in panel.Controls)
            {
                if (ctrl is TextEdit || ctrl is DateEdit || ctrl is System.Windows.Forms.ComboBox || ctrl is RichTextBox)
                    ctrl.Text = null;
            }
        }

        private string getTextFromStudentList(string columnName)
        {
            return grd_StudentList_View.GetRowCellDisplayText(grd_StudentList_View.GetSelectedRows().First(), columnName);
        }

        private void btn_Detail_StudentList_Click(object sender, EventArgs e)
        {


            navFrame_Main.SelectedPage = navPage_StudentInformation;
            navFrame_StudentInformation.SelectedPage = navPage_StudentDetail_StudentInformation;
            formatControls(navPage_StudentEdit_StudentInformation);
            txt_StudentID_StudentInformation_Detail.Text = getTextFromStudentList("MSHS");
            txt_StudentName_StudentInformation_Detail.Text = getTextFromStudentList("HOTEN");
            txt_StudentDateOfBirth_StudentInformation_Detail.Text = getTextFromStudentList("NGSINH");
            txt_StudentEmail_StudentInformation_Detail.Text = getTextFromStudentList("EMAIL");
            txt_StudentSex_StudentInformation_Detail.Text = getTextFromStudentList("GIOITINH");
            txt_StudentAddress_StudentInformation_Detail.Text = getTextFromStudentList("DIACHI");
        }

        private void btn_Delete_StudentList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Student?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (classBLL.deleteStudent(int.Parse(getTextFromStudentList("MSHS"))))
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
            Entities.HOCSINH student = new Entities.HOCSINH(int.Parse(txt_StudentID_StudentInformation_Edit.Text), txt_StudentName_StudentInformation_Edit.Text, txt_StudentEmail_StudentInformation_Edit.Text,cb_StudentDateOfBirth_StudentInformation_Edit.DateTime, cb_StudentSex_StudentInformation_Edit.SelectedIndex,txt_StudentAddress_StudentInformation_Edit.Text);
            if (classBLL.updateStudent(student))//If updated successful -> Show message and update data for controls
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
            formatControls(navPage_StudentEdit_StudentInformation);
            txt_StudentID_StudentInformation_Edit.Text = txt_StudentID_StudentInformation_Detail.Text;
            txt_StudentName_StudentInformation_Edit.Text = txt_StudentName_StudentInformation_Detail.Text;
            cb_StudentDateOfBirth_StudentInformation_Edit.DateTime = DateTime.Parse(txt_StudentDateOfBirth_StudentInformation_Detail.Text);
            txt_StudentAddress_StudentInformation_Edit.Text = txt_StudentAddress_StudentInformation_Detail.Text;
            cb_StudentSex_StudentInformation_Edit.SelectedIndex = (txt_StudentSex_StudentInformation_Detail.Text.Equals("Nam")) ? 1 : 0;
            txt_StudentEmail_StudentInformation_Edit.Text = txt_StudentEmail_StudentInformation_Detail.Text;
            btn_Save_StudentInformation.Show();
            btn_Edit_StudentInformation.Hide();
        }
        //==============================================================================
        //Class
        private string getTextFromClassList(string columnName)
        {
            return grd_ClassList_View.GetRowCellDisplayText(grd_ClassList_View.GetSelectedRows().First(), columnName);
        }
        private void btn_Detail_ClassList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ClassInformation;//Show Page Class Information
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;
            txt_ClassName_ClassInformation.Text = getTextFromClassList("TENLOP");
            txt_ClassTotal_ClassInformation.Text = getTextFromClassList("SISO");

            DataTable table = new DataTable();
            table = classBLL.getStudentForClass(int.Parse(getTextFromClassList("MALOP")));
            grd_ClassInformation.DataSource = table;
        }

        private void btn_Edit_ClassInformation_Click(object sender, EventArgs e)
        {
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail_Edit;
            txt_ClassName_ClassInformation_Edit.Text = txt_ClassName_ClassInformation.Text;
            txt_ClassTotal_ClassInformation_Edit.Text = txt_ClassTotal_ClassInformation.Text;
            btn_Edit_ClassInformation.Hide();
            btn_Save_ClassInformation.Show();
        }

        private void btn_Save_ClassInformation_Click(object sender, EventArgs e)
        {

        }
        private void btn_AddStudentForClass_AddClass_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_AddStudentForClass;
            DataTable table = new DataTable();
            table = classBLL.getStudentForAddClass();
            grd_AddStudentForClass.DataSource = table;
        }

        private void btn_AddClass_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_AddClass;
            btn_AddStudentForClass_AddClass.Hide();
        }

        private void btn_Save_AddClass_Click(object sender, EventArgs e)
        {
            if (!checkBeforeSave(addClassPanel, txt_ClassTotal_AddClass))
            {
                return;
            }
            StudentManagements.Entities.LOP newLOP = new Entities.LOP(txt_ClassName_AddClass.Text, 0, int.Parse(txt_Year_AddClass.Text));
            if (classBLL.insertClass(newLOP))
            {
                MessageBox.Show("Create Class successful!");
                btn_Save_AddClass.Show();
            }
            else
            {
                MessageBox.Show("Create Class failure!");
            }
        }

        private void btn_OK_AddStudentForClass_Click(object sender, EventArgs e)
        {
            int MALOP = classBLL.getClassID(txt_ClassName_AddClass.Text, int.Parse(txt_Year_AddClass.Text));//Get MALOP from navPage_AddClass
            int[] rows = grd_AddStudentForClass_View.GetSelectedRows();
            foreach(int row in rows)
            {
                classBLL.insertStudetForClass((int)grd_AddStudentForClass_View.GetListSourceRowCellValue(row,"MSHS"), MALOP);
            }
            classBLL.updateClassTotal(MALOP, rows.Length);
            MessageBox.Show("Insert Student for class Successful!");
        }
        //==============================================================================
        //Menubar
        private void btn_AddStudent_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formatControls(studentInformationPanel);
            navFrame_Main.SelectedPage = navPage_AddStudent;

        }

        private bool checkBeforeSave(Panel panel, TextEdit txt = null)//Check Are Controls empty
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl != txt)
                {
                    if ((ctrl is TextEdit || ctrl is DateEdit || ctrl is RichTextBox || ctrl is System.Windows.Forms.ComboBox) && string.IsNullOrEmpty(ctrl.Text))
                    {
                        MessageBox.Show("Something is Empty!\nPlease check again", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btn_Done_AddStudent_Click(object sender, EventArgs e)//Insert a student into database
        {
            if (!checkBeforeSave(studentInformationPanel, txt_StudentEmail_AddStudent))
                return;
            if (classBLL.insertStudent(new Entities.HOCSINH(txt_StudentName_AddStudent.Text, txt_StudentEmail_AddStudent.Text, cb_StudentDateOfBirth_AddStudent.DateTime, cb_StudentSex_AddStudent.SelectedIndex, txt_StudentAddress_AddStudent.Text)))
            {
                formatControls(studentInformationPanel);
                MessageBox.Show("Insert into database successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
                MessageBox.Show("Insert fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        //==============================================================================
        //ScoreBoard
        private string getTextFromScoreBoardList(string columnName)
        {
            return grd_ScoreBoardList_View.GetRowCellDisplayText(grd_ScoreBoardList_View.GetSelectedRows().First(), columnName);
        }

        private void btn_All_ScoreBoardList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardDetail;
            DataTable table = new DataTable();
            table = classBLL.getAllScoreBoard();
            grd_ScoreBoardDetail.DataSource = table;
        }

        private void btn_LookUp_ScoreBoardList_Click(object sender, EventArgs e)
        {
            navFrame_Main.SelectedPage = navPage_ScoreBoardDetail2;//Show Page

            txt_ClassName_ScoreBoardDetail2.Text = getTextFromScoreBoardList("TENLOP");//Take ClassName I selected

            DataTable table = new DataTable();
            table = classBLL.getSubjectNameAccordingClassID(int.Parse(getTextFromScoreBoardList("MALOP")));//Take table when know ClassID

            cb_SelectSubject_ScoreBoardDetail.Items.Clear();//Clear Combobox before give data

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cb_SelectSubject_ScoreBoardDetail.Items.Add(table.Rows[i][0]);
            }

            txt_ClassID.Text = getTextFromScoreBoardList("MALOP");//Save MALOP into TextBox txt_ClassID
        }

        private void cb_SelectSubject_ScoreBoardDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            int classBLLgetSubjectsID = classBLL.getSubjectsID(cb_SelectSubject_ScoreBoardDetail.SelectedItem.ToString());
            table = classBLL.getScoreBoardAccordingRequire(int.Parse(txt_ClassID.Text), classBLLgetSubjectsID);
            grd_ScoreBoardDetail2.DataSource = table;
        }

        private void btn_Delete_ScoreBoardDetail2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (classBLL.deleteScoreBoardCell(int.Parse(grd_ScoreBoardDetail2_View.GetRowCellDisplayText(grd_ScoreBoardDetail2_View.GetSelectedRows().First(), "MAKQ"))))
                {
                    MessageBox.Show("Delete successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    cb_SelectSubject_ScoreBoardDetail_SelectedIndexChanged(sender, e);
                }
                else
                    MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

      
        private void grd_ScoreBoardDetail2_Click(object sender, EventArgs e)
        {

        }

     

     
        

       


    }

}
