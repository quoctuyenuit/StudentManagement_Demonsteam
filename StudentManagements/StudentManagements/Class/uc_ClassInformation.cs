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
    public partial class uc_ClassInformation : UserControl
    {
        private string classID;

        public delegate void DgetFrameForDetail(Control detail);

        public DgetFrameForDetail getFrameForDetail;
        private int MaGV;

        public uc_ClassInformation(string classID)
        {
            InitializeComponent();

            this.classID = classID;

            DataRow row = BLL.ClassBLL.Instance.getClassFromID(classID);

            this.MaGV = (int)row["MAGVCN"];
            txt_GVCN.Text = row["GVCN"].ToString();
            txt_ClassName_ClassInformation.Text = row["TENLOP"].ToString();
            txt_ClassTotal_ClassInformation.Text = row["SISO"].ToString();
            txt_Year_ClassInformation.Text = row["NAMHOC"].ToString();
            btn_Edit_ClassInformation.Show();
            btn_Save_ClassInformation.Hide();
            btn_DeleteStudent_ClassInformation.Hide();
            btn_AddStudentForClass_ClassInformation.Hide();
            btn_AddSubjectsForClass_ClassInformation.Hide();
            linkEdit.Hide();

            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;//Set away select for grd_StudentList_ClassInformation
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

            grd_StudentList_ClassInformation.DataSource = ClassBLL.Instance.getStudentForClass(int.Parse(classID));
            grd_SubjectList_ClassInformation.DataSource = ClassBLL.Instance.getSubjectForClass(int.Parse(classID));

            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;
        }

        private void btn_DeleteStudent_ClassInformation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int MALOP = int.Parse(this.classID);
                ClassBus.Instance.deleteStudentInClass(grd_StudentList_ClassInformation_View, MALOP);
                ClassBus.Instance.deleteSubjectInClass(grd_SubjectList_ClassInformation_View, MALOP);
                txt_ClassTotal_ClassInformation_Edit.Text = grd_StudentList_ClassInformation_View.RowCount.ToString();
                btn_DeleteStudent_ClassInformation.Enabled = false;//Set enabled for button after User click
            }
        }

        private void btn_Save_ClassInformation_Click(object sender, EventArgs e)
        {
            if (!ClassBLL.Instance.IsNotEmpty(navPage_ClassDetail_Edit))//If any control Empty => return;
                return;

            if (!BLL.ClassBLL.Instance.checkSchoolYear(txt_Year_ClassInformation_Edit.Text))
            {
                MessageBox.Show("The School year is not valid!, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Year_ClassInformation_Edit.Focus();
                return;
            }

            Entities.LOP lop = new Entities.LOP(int.Parse(classID), txt_ClassName_ClassInformation_Edit.Text, int.Parse(txt_ClassTotal_ClassInformation_Edit.Text), txt_Year_ClassInformation_Edit.Text, this.MaGV);
            
            //If don't have any change then return
            if (!txt_ClassName_ClassInformation_Edit.Text.Equals(txt_ClassName_ClassInformation.Text) || !txt_Year_ClassInformation_Edit.Text.Equals(txt_Year_ClassInformation.Text))
            {
                //If Class already exists then return;
                if (!ClassBLL.Instance.checkExistenceClass(lop))
                {
                    MessageBox.Show("Class already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            ClassBLL.Instance.updateClassNameAndClassYear(lop);

            txt_ClassName_ClassInformation.Text = lop.TenLop;
            txt_Year_ClassInformation.Text = lop.NamHoc;
            txt_ClassTotal_ClassInformation.Text = lop.SiSo.ToString();

            btn_DeleteStudent_ClassInformation.Hide();
            btn_Save_ClassInformation.Hide();
            btn_Edit_ClassInformation.Show();
            btn_AddStudentForClass_ClassInformation.Hide();
            btn_AddSubjectsForClass_ClassInformation.Hide();
            linkEdit.Hide();

            grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            grd_SubjectList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail;

            this.className = txt_ClassName_ClassInformation.Text;
            this.classSize = int.Parse(txt_ClassTotal_ClassInformation.Text);
            this.classYear = txt_Year_ClassInformation.Text;
        }

        private void btn_Edit_ClassInformation_Click(object sender, EventArgs e)
        {
            navFrame_ClassInformation.SelectedPage = navPage_ClassDetail_Edit;

            linkEdit.Show();

            txt_ClassName_ClassInformation_Edit.Text = txt_ClassName_ClassInformation.Text;
            txt_ClassTotal_ClassInformation_Edit.Text = txt_ClassTotal_ClassInformation.Text;
            txt_Year_ClassInformation_Edit.Text = txt_Year_ClassInformation.Text;

            btn_DeleteStudent_ClassInformation.Enabled = false;
            btn_Edit_ClassInformation.Hide();
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

        private void btn_AddStudentForClass_ClassInformation_Click(object sender, EventArgs e)
        {
            btn_Save_ClassInformation_Click(null, null);

            using (Students.StudentListToEditClass frm = new Students.StudentListToEditClass(this.classID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.grd_StudentList_ClassInformation.DataSource = frm.tableSources;
                    txt_ClassTotal_ClassInformation_Edit.Text = grd_StudentList_ClassInformation_View.RowCount.ToString();
                }
            }
        }

        private void btn_AddSubjectsForClass_ClassInformation_Click(object sender, EventArgs e)
        {
            using (AddSubjectForm form = new AddSubjectForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int MALOP = int.Parse(this.classID);
                    foreach (int id in form.subjectIDs)
                    {
                        ClassBLL.Instance.insertSubjectForClass(id, MALOP);
                    }
                   
                    grd_SubjectList_ClassInformation.DataSource = ClassBLL.Instance.getSubjectForClass(MALOP);
                }
            }
        }


        private void grd_StudentList_ClassInformation_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudent_ClassInformation.Enabled = (grd_StudentList_ClassInformation_View.SelectedRowsCount != 0) ? true : false;
        }

        private void grd_SubjectList_ClassInformation_View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_DeleteStudent_ClassInformation.Enabled = (grd_SubjectList_ClassInformation_View.SelectedRowsCount != 0) ? true : false;
        }

        private void grd_StudentList_ClassInformation_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.tableData = ClassBLL.Instance.getStudentForClass(int.Parse(this.classID));
        }

        public DataTable tableData { get; set; }

        public string className { get; set; }

        public int classSize { get; set; }

        public string classYear { get; set; }

        private void grd_StudentList_ClassInformation_View_DoubleClick(object sender, EventArgs e)
        {
            Students.uc_DetailStudent detail = new Students.uc_DetailStudent(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_ClassInformation_View, "MSHS"));
            if (getFrameForDetail != null)
                getFrameForDetail(detail);
        }

        private void linkEdit_Click(object sender, EventArgs e)
        {
            using (TeachingDivision.TeacherListForm frm = new TeachingDivision.TeacherListForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txt_GVCN.Text = frm.row["HOTEN"].ToString();
                    this.MaGV = (int)frm.row["MAGV"];
                }
            }
        }
    }
}
