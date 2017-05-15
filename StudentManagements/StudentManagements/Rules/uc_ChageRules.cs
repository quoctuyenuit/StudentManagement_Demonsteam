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

namespace StudentManagements.Rules
{
    public partial class uc_ChageRules : UserControl
    {
        public uc_ChageRules()
        {
            InitializeComponent();
        }
        public delegate void exit();
        public exit Exit;
        private void showRulesStudentAge()
        {
            DataRow rowAge = ClassBLL.Instance.getRulesStudentAge();
            txt_MinAge_RulesStudentAge.Text = rowAge[0].ToString();
            txt_MaxAge_RulesStudentAge.Text = rowAge[1].ToString();

        }
        private void showRulesScore()
        {
            txt_MinScore_RulesScore.Text = ClassBLL.Instance.getRulesScore()[0].ToString();
        }
        private void showRulesClass()
        {
            grdClassList.DataSource = BLL.ClassBLL.Instance.getRulesAllClass();

            txt_TotalClass_RulesClass.Text = grdClassList_View.RowCount.ToString();
            txt_MaxClassSize_RulesClass.Text = ClassBLL.Instance.getRulesClassSize().ToString();
            btn_AddClass_RulesClass.Enabled = false;
            txt_ClassName_RulesClass.Enabled = false;
            btn_Delete_RulesClass.Enabled = false;
            btn_Edit_RulesClass.Text = "Edit";
        }
        private void showRulesSubjects()
        {

            grdSubjectList.DataSource = BLL.ClassBLL.Instance.getAllSubject();

            txt_TotalSubjects_RulesSubjects.Text = grdSubjectList_View.RowCount.ToString();
            btn_AddSubjects_RulesSubjects.Enabled = false;
            btn_Delete_RulesSubjects.Enabled = false;
            btn_Edit_RulesSubjects.Text = "Edit";
        }

        private void uc_ChageRules_Load(object sender, EventArgs e)
        {
            showRulesStudentAge();
            showRulesScore();
            showRulesClass();
            showRulesSubjects();
        }

        private void btn_Edit_RulesStudentAge_Click(object sender, EventArgs e)
        {
            if (btn_Edit_RulesStudentAge.Text.Equals("Edit"))
            {
                btn_Edit_RulesStudentAge.Text = "Save";
                txt_MinAge_RulesStudentAge.Enabled = true;
                txt_MaxAge_RulesStudentAge.Enabled = true;
            }
            else
            {
                btn_Edit_RulesStudentAge.Text = "Edit";
                if (!ClassBLL.Instance.updateRulesStudentAge(int.Parse(txt_MinAge_RulesStudentAge.Text), int.Parse(txt_MaxAge_RulesStudentAge.Text)))
                    MessageBox.Show("Error: MinAge > MaxAge");

                showRulesStudentAge();
                txt_MinAge_RulesStudentAge.Enabled = false;
                txt_MaxAge_RulesStudentAge.Enabled = false;
            }

        }

        private void btn_Edit_RulesScore_Click(object sender, EventArgs e)
        {
            if (btn_Edit_RulesScore.Text.Equals("Edit"))
            {
                btn_Edit_RulesScore.Text = "Save";
                txt_MinScore_RulesScore.Enabled = true;
            }
            else
            {
                btn_Edit_RulesScore.Text = "Edit";
                if (!ClassBLL.Instance.updateRulesScore(float.Parse(txt_MinScore_RulesScore.Text)))
                    MessageBox.Show("Error: 0< Score < 10 ");

                showRulesScore();
                txt_MinScore_RulesScore.Enabled = false;
            }
        }

        private void btn_Edit_RulesClass_Click(object sender, EventArgs e)
        {
            if (btn_Edit_RulesClass.Text.Equals("Edit"))
            {
                btn_Edit_RulesClass.Text = "Save";
                btn_AddClass_RulesClass.Enabled = true;
                txt_MaxClassSize_RulesClass.Enabled = true;
                txt_ClassName_RulesClass.Enabled = true;
                btn_Delete_RulesClass.Enabled = true;
            }
            else
            {
                btn_Edit_RulesClass.Text = "Edit";
                if (ClassBLL.Instance.updateRulesClassSize(int.Parse(txt_MaxClassSize_RulesClass.Text)))
                {
                    txt_MaxClassSize_RulesClass.Enabled = false;
                    btn_AddClass_RulesClass.Enabled = false;
                    txt_ClassName_RulesClass.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Class Size can't negative numbers");
                }
                if (!ClassBLL.Instance.updateRulesClassName(txt_ClassName_RulesClass.Text, grdClassList_View.GetDataRow(grdClassList_View.GetSelectedRows().First())["TENLOP"].ToString()))
                    MessageBox.Show("The class name already exists");
                showRulesClass();
            }
        }

        private void btn_Edit_RulesSubjects_Click(object sender, EventArgs e)
        {
            if (btn_Edit_RulesSubjects.Text.Equals("Edit"))
            {
                btn_Edit_RulesSubjects.Text = "Save";
                btn_AddSubjects_RulesSubjects.Enabled = true;
                txt_SubjectName_RulesSubjets.Enabled = true;
                btn_Delete_RulesSubjects.Enabled = true;
            }
            else
            {
                btn_Edit_RulesSubjects.Text = "Edit";

                if (ClassBLL.Instance.updateSubject(txt_SubjectName_RulesSubjets.Text, grdSubjectList_View.GetDataRow(grdSubjectList_View.GetSelectedRows().First())["TENMH"].ToString()))
                {
                    btn_AddSubjects_RulesSubjects.Enabled = false;
                    txt_SubjectName_RulesSubjets.Enabled = false;
                    showRulesSubjects();
                }
                else
                {
                    MessageBox.Show("Can't update");
                    showRulesSubjects();
                }
            }
        }
      
        private void btn_SaveAll_Click(object sender, EventArgs e)
        {
            btn_Edit_RulesStudentAge_Click(sender, e);
            btn_Edit_RulesScore_Click(sender, e);
            btn_Edit_RulesClass_Click(sender, e);
            btn_Edit_RulesSubjects_Click(sender, e);
            this.Exit();
        }

        private void callBack_RulesClass(string data)
        {
            if (ClassBLL.Instance.insertRulesClass(data))
            {
                showRulesClass();
            }
        }
        private void btn_AddClass_RulesClass_Click(object sender, EventArgs e)
        {
            Rules.AddForm frm = new Rules.AddForm();
            frm.getData = new Rules.AddForm.returnData(callBack_RulesClass);
            frm.ShowDialog();
        }

        private void callBack_RulesSubject(string data)
        {
            if (ClassBLL.Instance.insertSubject(data))
            {
                showRulesSubjects();
            }
        }
        private void btn_AddSubjects_RulesSubjects_Click(object sender, EventArgs e)
        {
            Rules.AddForm frm = new Rules.AddForm();
            frm.getData = new Rules.AddForm.returnData(callBack_RulesSubject);
            frm.ShowDialog();
        }

        private void btn_Delete_RulesClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClassBLL.Instance.deleteRulesClass(grdClassList_View.GetDataRow(grdClassList_View.GetSelectedRows().First())["MAQD"].ToString()))
                    MessageBox.Show("Delete failure");

                grdClassList_View.DeleteRow(grdClassList_View.GetSelectedRows().First());

                txt_TotalClass_RulesClass.Text = grdClassList_View.RowCount.ToString();
            }
            catch (Exception ex) { }
        }

        private void btn_Delete_RulesSubjects_Click(object sender, EventArgs e)
        {
            try
            {
                string MAMH = grdSubjectList_View.GetDataRow(grdSubjectList_View.GetSelectedRows().First())["MAMH"].ToString();
                if (!ClassBLL.Instance.deleteSubject(MAMH))
                    MessageBox.Show("Delete failure");

                grdSubjectList_View.DeleteRow(grdSubjectList_View.GetSelectedRows().First());

                txt_TotalSubjects_RulesSubjects.Text = grdSubjectList_View.RowCount.ToString();
            }
            catch (Exception ex) { }
        }

        private void grdSubjectList_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdSubjectList_View.RowCount > 0)
                txt_SubjectName_RulesSubjets.Text = grdSubjectList_View.GetDataRow(grdSubjectList_View.GetSelectedRows().First())["TENMH"].ToString();
            else
                txt_SubjectName_RulesSubjets.Text = "";
        }

        private void grdClassList_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdClassList_View.RowCount > 0)
                txt_ClassName_RulesClass.Text = grdClassList_View.GetDataRow(grdClassList_View.GetSelectedRows().First())["TENLOP"].ToString();
            else
                txt_ClassName_RulesClass.Text = "";
        }
    }
}
