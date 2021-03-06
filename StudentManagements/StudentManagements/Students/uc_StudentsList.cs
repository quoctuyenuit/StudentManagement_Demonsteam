﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagements.BLL;

namespace StudentManagements.Students
{
    public partial class uc_StudentsList : UserControl
    {
        public delegate void DgetFrameForDetail(Control detail);

        public DgetFrameForDetail getFrameForDetail;

        public uc_StudentsList()
        {
            InitializeComponent();
            grd_StudentList.DataSource = ClassBLL.Instance.getAllStudents();
        }

        private void btn_Detail_StudentList_Click(object sender, EventArgs e)
        {
            uc_DetailStudent detail = new uc_DetailStudent(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS"));
            if (getFrameForDetail != null)
                getFrameForDetail(detail);
        }

        private void btn_Delete_StudentList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Student?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int MSHS = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_StudentList_View, "MSHS"));
                if (ClassBLL.Instance.isLearning(MSHS))
                {
                    //Nếu học sinh đang theo học trong thời gian hiện tại thì thông báo cho người dùng quyết định có xóa hay không
                    if (MessageBox.Show("This student is learning in the school! Are you sure you want to delete this Student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (ClassBLL.Instance.deleteStudent(MSHS))
                            grd_StudentList_View.DeleteSelectedRows();
                        else
                            MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                    else
                        return;
                }
                else
                {
                    if (ClassBLL.Instance.deleteStudent(MSHS))
                        grd_StudentList_View.DeleteSelectedRows();
                    else
                        MessageBox.Show("Delete fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void grd_StudentList_View_DoubleClick(object sender, EventArgs e)
        {
            btn_Detail_StudentList_Click(null, null);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Students.uc_AddStudent uc_AddStudent = new Students.uc_AddStudent();
            if (getFrameForDetail != null)
                getFrameForDetail(uc_AddStudent);
        }

    }
}
