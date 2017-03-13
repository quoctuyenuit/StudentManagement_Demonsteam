using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagements.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagements.BLL
{
    class ClassBLL
    {
        private static ClassBLL instance;

        internal static ClassBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassBLL();
                return ClassBLL.instance;
            }
        }
        public ClassBLL()
        {
        }

        //===================================================================
        public void formatControls(Control panel)//Format controls for null
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is TextEdit || ctrl is DateEdit || ctrl is System.Windows.Forms.ComboBox || ctrl is RichTextBox)
                    ctrl.Text = null;
            }
        }
        public string getTextFromGridControl(GridView gridView, string columnName)//Take string from gridview
        {
            return gridView.GetRowCellDisplayText(gridView.GetSelectedRows().First(), columnName);
        }
        public bool checkBeforeSave(Panel panel, TextEdit txt = null)//Check Are Controls empty
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
        //===================================================================
        //Student
        public DataTable getAllStudents()
        {
            return ClassDAL.Instance.getAllStudents();
        }

        public DataTable getStudentAccordingID(int MSHS)
        {
            return ClassDAL.Instance.getStudentAccordingID(MSHS);
        }

        public DataTable getStudentForClass(int MALOP)
        {
            return ClassDAL.Instance.getStudentForClass(MALOP);
        }

        public bool deleteStudent(int MSHS)
        {
            return ClassDAL.Instance.deleteStudent(MSHS);
        }

        public bool insertStudent(Entities.HOCSINH student)
        {
            return ClassDAL.Instance.insertStudent(student);
        }

        public bool updateStudent(Entities.HOCSINH student)
        {
            return ClassDAL.Instance.updateStudent(student);
        }

        public DataTable getStudentForAddClass()
        {
            return ClassDAL.Instance.getStudentForAddClass();
        }
        //===================================================================
        //Class
        public DataTable getAllClass()
        {
            return ClassDAL.Instance.getAllClass();
        }

        public DataTable getClassAccordingID(int MALOP)
        {
            return ClassDAL.Instance.getClassAccordingID(MALOP);
        }

        public int getTotalOfClass(int MALOP)
        {
            return ClassDAL.Instance.getTotalOfClass(MALOP);
        }

        public int getClassID(string TENLOP, int NAMHOC)
        {
            return ClassDAL.Instance.getClassID(TENLOP, NAMHOC);
        }

        public bool checkExistenceClass(Entities.LOP LOP)
        {
            DataTable classTable = getAllClass();
            for (int i = 0; i < classTable.Rows.Count; i++)
            {
                if (classTable.Rows[i]["TENLOP"].Equals(LOP.TenLop) && (int)classTable.Rows[i]["NAMHOC"] == LOP.NamHoc)
                    return false;
            }
            return true;
        }

        public bool insertClass(Entities.LOP myClass)
        {
            return ClassDAL.Instance.insertClass(myClass);
        }

        public bool insertStudetForClass(int MSHS, int MALOP)
        {
            return ClassDAL.Instance.insertStudentForClass(MSHS, MALOP);
        }

        public bool updateClassTotal(int MALOP, int SISO)
        {
            return ClassDAL.Instance.updateClassTotal(MALOP, SISO);
        }

        public bool updateClassNameAndClassYear(string TENLOP, int NAMHOC, int MALOP)
        {
            return ClassDAL.Instance.updateClassNameAndClassYear(TENLOP, NAMHOC, MALOP);
        }

        public bool deleteClass(int MALOP)
        {
            return ClassDAL.Instance.deleteClass(MALOP);
        }

        public bool deleteStudentInClass(int MSHS, int MALOP)
        {
            return ClassDAL.Instance.deleteStudentInClass(MSHS, MALOP);
        }
        //===================================================================
        //Subject
        public int getSubjectsID(string subjectName)
        {
            return ClassDAL.Instance.getSubjectsID(subjectName);
        }

        public DataTable getSubjectNameAccordingClassID(int MALOP)
        {
            return ClassDAL.Instance.getSubjectNameAccordingClassID(MALOP);
        }

        //===================================================================
        public DataTable getAllScoreBoard()
        {
            return ClassDAL.Instance.getAllScoreBoard();
        }

        public DataTable getScoreBoardAccordingRequire(int MALOP, int MAMH)
        {
            return ClassDAL.Instance.getScoreBoardAccordingRequire(MALOP, MAMH);
        }

        public bool deleteScoreBoardCell(int MAKQ)
        {
            return ClassDAL.Instance.deleteScoreBoardCell(MAKQ);
        }

    }
}
