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
using StudentManagements.AddSubject;

namespace StudentManagements.Class
{
    public partial class uc_AddClass : UserControl
    {
        private int MaLop;
        public uc_AddClass()
        {
            InitializeComponent();

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

        private void btn_Save_AddClass_Click(object sender, EventArgs e)
        {
            if (!ClassBLL.Instance.IsNotEmpty(addClassPanel, txt_ClassTotal_AddClass))//If any Texbox is empty => Exit
            {
                return;
            }

            if (!BLL.ClassBLL.Instance.checkSchoolYear(txt_Year_AddClass.Text))
            {
                MessageBox.Show("The School year is not valid!, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClassBus.Instance.saveAddClass(addClassPanel, txt_ClassTotal_AddClass, txt_ClassName_AddClass.Text, txt_Year_AddClass.Text))
            {
                btn_AddStudentForClass_AddClass.Enabled = true;
                btn_AddSubjectsForClass_AddClass.Enabled = true;
                this.MaLop = ClassBLL.Instance.getClassID(txt_ClassName_AddClass.Text, txt_Year_AddClass.Text);
            }
        }

        private void btn_DeleteStudentInClass_AddClass_Click(object sender, EventArgs e)
        {
            ClassBus.Instance.deleteStudentInClass(grd_StudentList_AddClass_View, MaLop);
            ClassBus.Instance.deleteSubjectInClass(grd_SubjectList_AddClass_View, MaLop);
            btn_DeleteStudentInClass_AddClass.Enabled = false;//Set enabled for button after User click
            grd_SubjectList_AddClass.DataSource = ClassBLL.Instance.getSubjectForClass(MaLop);
        }

        private void btn_AddStudentForClass_AddClass_Click(object sender, EventArgs e)
        {
            using (Students.StudentListToEditClass studentList = new Students.StudentListToEditClass(this.MaLop.ToString()))
            {
                if (studentList.ShowDialog() == DialogResult.OK)
                {
                    this.grd_StudentList_AddClass.DataSource = studentList.tableSources;
                    txt_ClassTotal_AddClass.Text = grd_StudentList_AddClass_View.RowCount.ToString();
                }
            }
        }

        private void grd_StudentList_AddClass_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudentInClass_AddClass.Enabled = (grd_StudentList_AddClass_View.SelectedRowsCount != 0) ? true : false;
        }

        private void grd_SubjectList_AddClass_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudentInClass_AddClass.Enabled = (grd_StudentList_AddClass_View.SelectedRowsCount != 0) ? true : false;

        }

        private void btn_AddSubjectsForClass_AddClass_Click(object sender, EventArgs e)
        {
            using (AddSubjectForm form = new AddSubjectForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (int id in form.subjectIDs)
                    {
                        ClassBLL.Instance.insertSubjectForClass(id, MaLop);
                    }
                    
                    grd_SubjectList_AddClass.DataSource = ClassBLL.Instance.getSubjectForClass(MaLop); 
                }
            }
        }
    }
}
