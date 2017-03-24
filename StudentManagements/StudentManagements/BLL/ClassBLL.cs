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
        public bool checkBeforeSave(Control panel, TextEdit txt = null)//Check Are Controls empty
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

        public DataTable getStudentForLookUp()
        {
            return ClassDAL.Instance.getStudentForLookUp();
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

        public bool insertSubjectForClass(int MAMH, int MALOP)
        {
            return ClassDAL.Instance.insertSubjectForClass(MAMH, MALOP);
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

        public DataTable getSubjectForClass(int MALOP)
        {
            return ClassDAL.Instance.getSubjectForClass(MALOP);
        }

        public DataTable getAllSubject()
        {
            return ClassDAL.Instance.getAllSubject();
        }
        
        public bool deleteSubjectInClass(int MAMH, int MALOP)
        {
            return ClassDAL.Instance.deleteSubjectInClass(MAMH, MALOP);
        }

        public bool insertSubject(string TenMH)
        {
            return ClassDAL.Instance.insertSubject(TenMH);
        }

        public bool updateSubject(string TenMH1, string TenMH2)
        {
            return ClassDAL.Instance.updateSubject(TenMH1, TenMH2);
        }

        public bool deleteSubject(string TenLop)
        {
            return ClassDAL.Instance.deleteSubject(TenLop);
        }
        //===================================================================
        //ScoreBoard
        public DataTable getAllScoreBoard()
        {
            return ClassDAL.Instance.getAllScoreBoard();
        }

        public DataTable getScoreBoardAccordingRequire(int MALOP, int MAMH, int HOCKY)
        {
            return ClassDAL.Instance.getScoreBoardAccordingRequire(MALOP, MAMH, HOCKY);
        }

        public bool insertScoreBoard(Entities.KETQUA kq)
        {
            return ClassDAL.Instance.insertScoreBoard(kq);
        }

        public bool deleteScoreBoardCell(int MAKQ)
        {
            return ClassDAL.Instance.deleteScoreBoardCell(MAKQ);
        }

        public bool deleteScoreBoardClass(int MALOP)
        {
            return ClassDAL.Instance.deleteScoreBoardClass(MALOP);
        }

        public bool updateScoreBoardCell(Entities.KETQUA kq)
        {
            return ClassDAL.Instance.updateScoreBoardCell(kq);
        }
        //===================================================================
        //Report
        public DataTable getReport_MONHOC(int MAMH, int HOCKY)
        {
            return ClassDAL.Instance.getReport_MONHOC(MAMH, HOCKY);
        }
        public DataTable getReport_HOCKY(int HOCKY)
        {
            return ClassDAL.Instance.getReport_HOCKY(HOCKY);
        }
        //===================================================================
        //ChangeRules
        public DataRow getRulesStudentAge()
        {
            return ClassDAL.Instance.getRulesStudentAge();
        }

        public bool updateRulesStudentAge(int MinAge, int MaxAge)
        {
            return ClassDAL.Instance.updateRulesStudentAge(MinAge, MaxAge);
        }

        public DataRow getRulesScore()
        {
            return ClassDAL.Instance.getRulesScore();
        }

        public bool updateRulesScore(float MinScore)
        {
            return ClassDAL.Instance.updateRulesScore(MinScore);
        }

        public int getRulesClassSize()
        {
            return ClassDAL.Instance.getRulesClassSize();
        }

        public DataTable getRulesAllClass()
        {
            return ClassDAL.Instance.getRulesAllClass();
        }

        public bool insertRulesClass(string TenLop)
        {
            return ClassDAL.Instance.insertRulesClass(TenLop);
        }

        public bool updateRulesClassName(string newClassName, string oldClassName)
        {
            return ClassDAL.Instance.updateRulesClassName(newClassName, oldClassName);
        }

        public bool updateRulesClassSize(int classSize)
        {
            return ClassDAL.Instance.updateRulesClassSize(classSize);
        }

        public bool deleteRulesClass(string TenLop)
        {
            return ClassDAL.Instance.deleteRulesClass(TenLop);
        }
    }
}
