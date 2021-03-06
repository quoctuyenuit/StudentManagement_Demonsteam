﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagements.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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
        public bool IsNotEmpty(Control panel, TextEdit txt = null)//Check Are Controls empty
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

        public bool IsEmail(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regex = new Regex(strRegex);
            return (regex.IsMatch(email));
        }

        public string formatSchoolYear(string schoolYear)
        {
            string[] temp = schoolYear.Split(' ');
            string result = "";
            foreach (string t in temp)
                result += t;
            return result;
        }

        public bool checkSchoolYear(string schoolYear)
        {
            if (!schoolYear.Contains('-'))
                return false;

            foreach (char str in schoolYear)
                if (str != ' ' && !Char.IsDigit(str) && str != '-')
                    return false;

            string NamHoc = formatSchoolYear(schoolYear);
            string[] temp = NamHoc.Split('-');
            int a = int.Parse(temp[0]);
            int b = int.Parse(temp[1]);
            if (a > b || b - 1 != a)
                return false;

            return true;
        }
        //===================================================================
        //Student

        #region Students
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

        public DataTable getStudentForLookUp(string NAMHOC)
        {
            return ClassDAL.Instance.getStudentForLookUp(NAMHOC);
        }

        public bool isLearning(int MSHS)
        {
            return ClassDAL.Instance.isLearching(MSHS);
        }

        public bool deleteStudent(int MSHS)
        {
            return ClassDAL.Instance.deleteStudent(MSHS);
        }

        public bool insertStudent(Entities.HOCSINH student)
        {
            int age = DateTime.Now.Year - student.NgSinh.Year;
            DataRow row = ClassDAL.Instance.getRulesStudentAge();
            int ageMin = (int)row["TuoiToiThieu"];
            int ageMax = (int)row["TuoiToiDa"];

            if (age < ageMin || age > ageMax)
            {
                MessageBox.Show("The age must between " + ageMin + " and " + ageMax + "! Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return ClassDAL.Instance.insertStudent(student);
        }

        public bool updateStudent(Entities.HOCSINH student)
        {
            int age = DateTime.Now.Year - student.NgSinh.Year;
            DataRow row = ClassDAL.Instance.getRulesStudentAge();
            int ageMin = (int)row["TuoiToiThieu"];
            int ageMax = (int)row["TuoiToiDa"];

            if (age < ageMin || age > ageMax)
            {
                MessageBox.Show("The age must between " + ageMin + " and " + ageMax + "! Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return ClassDAL.Instance.updateStudent(student);
        }

        public DataTable getStudentForAddClass(string NAMHOC)
        {

            NAMHOC = formatSchoolYear(NAMHOC);

            return ClassDAL.Instance.getStudentForAddClass(NAMHOC);
        }
        #endregion
        //===================================================================
        //Class
        #region Class
        public DataTable getAllClass()
        {
            return ClassDAL.Instance.getAllClass();
        }

        public DataRow getClassFromID(string classID)
        {
            DataTable table = ClassDAL.Instance.getAllClass();
            foreach (DataRow row in table.Rows)
                if (row["MALOP"].ToString().Equals(classID))
                    return row;
            return null;
        }

        public DataTable getClassAccordingID(int MALOP)
        {
            return ClassDAL.Instance.getClassAccordingID(MALOP);
        }

        public int getTotalOfClass(int MALOP)
        {
            return ClassDAL.Instance.getTotalOfClass(MALOP);
        }

        public int getClassID(string TENLOP, string NAMHOC)
        {

            NAMHOC = formatSchoolYear(NAMHOC);
            return ClassDAL.Instance.getClassID(TENLOP, NAMHOC);
        }

        public string getClassName(int MALOP)
        {
            return ClassDAL.Instance.getClassName(MALOP);
        }

        public bool checkExistenceClass(Entities.LOP LOP)
        {
            DataTable classTable = getAllClass();
            for (int i = 0; i < classTable.Rows.Count; i++)
            {
                if ((int)classTable.Rows[i]["MALOP"] != LOP.MaLop && classTable.Rows[i]["TENLOP"].Equals(LOP.TenLop) && classTable.Rows[i]["NAMHOC"].ToString().Equals(LOP.NamHoc))
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

        public bool updateClassNameAndClassYear(Entities.LOP lop)
        {
            lop.NamHoc = formatSchoolYear(lop.NamHoc);
            return ClassDAL.Instance.updateClassNameAndClassYear(lop);
        }

        public bool deleteClass(int MALOP)
        {
            return ClassDAL.Instance.deleteClass(MALOP);
        }

        public bool deleteStudentInClass(int MSHS, int MALOP)
        {
            return ClassDAL.Instance.deleteStudentInClass(MSHS, MALOP);
        }

        public List<string> getSchoolYearList()
        {
            List<string> result = new List<string>();

            DataTable table = ClassDAL.Instance.getAllClass();

            foreach (DataRow row in table.Rows)
            {
                string schoolYear = row["NAMHOC"].ToString();
                if (!result.Contains(schoolYear))
                    result.Add(schoolYear);
            }

            return result;
        }
        #endregion
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

        public List<object> getListSubjectName()
        {
            List<object> list = new List<object>();
            foreach (DataRow row in BLL.ClassBLL.Instance.getAllSubject().Rows)
                list.Add(row["TENMH"]);
            return list;
        }

        public bool deleteSubjectInClass(int MAMH, int MALOP)
        {
            return ClassDAL.Instance.deleteSubjectInClass(MAMH, MALOP);
        }

        public bool insertSubject(string TenMH)
        {
            foreach (DataRow row in getAllSubject().Rows)
                if (TenMH.Equals(row["TENMH"].ToString()))
                    return false;
            return ClassDAL.Instance.insertSubject(TenMH);
        }

        public bool updateSubject(string TenMH1, string TenMH2)
        {
            return ClassDAL.Instance.updateSubject(TenMH1, TenMH2);
        }

        public bool deleteSubject(string MaMH)
        {
            return ClassDAL.Instance.deleteSubject(MaMH);
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
            foreach (DataRow row in getRulesAllClass().Rows)
                if (TenLop.Equals(row["TENLOP"].ToString()))
                    return false;
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

        public bool deleteRulesClass(string MaLop)
        {
            return ClassDAL.Instance.deleteRulesClass(MaLop);
        }

        //==========================================================================================================
        //Teaching

        public DataRow getTeacherFromID(int MAGV)
        {
            return ClassDAL.Instance.getTeacherFromID(MAGV);
        }

        public DataTable getTeacherList()
        {
            return ClassDAL.Instance.getTeacherList();
        }

        public int getTeacherIDLast()
        {
            return ClassDAL.Instance.getTeacherIDLast();
        }

        public bool updateTeacher(Entities.GIAOVIEN teacher)
        {
            return ClassDAL.Instance.updateTeacher(teacher);
        }

        public bool insertTeacher(Entities.GIAOVIEN teacher)
        {
            return ClassDAL.Instance.insertTeacher(teacher);
        }

        public bool insertTeaching(Entities.GIANGDAY teaching)
        {
            return ClassDAL.Instance.insertTeaching(teaching);
        }

        public bool updateTeaching(Entities.GIANGDAY teaching)
        {
            return ClassDAL.Instance.updateTeaching(teaching);
        }

        public bool deleteTeacher(int MAGV)
        {
            return ClassDAL.Instance.deleteTeacher(MAGV);
        }

        //==========================================================================================================
        //Login

        public string getUserNameFromEmail(string Email)
        {
            DataTable table = ClassDAL.Instance.getAllUser();
            foreach (DataRow row in table.Rows)
                if (row["EMAIL"].ToString().Equals(Email))
                    return row["TENDANGNHAP"].ToString();
            return null;
        }

        public bool checkUser(Entities.NGUOIDUNG user)
        {
            DataTable table = ClassDAL.Instance.getAllUser();
            foreach (DataRow row in table.Rows)
                if (row["TENDANGNHAP"].ToString().Equals(user.TenDangNhap) && row["MATKHAU"].ToString().Equals(user.MatKhau))
                    return true;
            return false;
        }

        public DataTable getAllUser()
        {
            return ClassDAL.Instance.getAllUser();
        }

        public List<string> getPermissionName()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in ClassDAL.Instance.getAllPermission().Rows)
                list.Add(row["TENPQ"].ToString());
            return list;
        }

        public bool updateUserInformation(Entities.NGUOIDUNG user)
        {
            return ClassDAL.Instance.updateUserInformation(user);
        }

        public bool insertUser(Entities.NGUOIDUNG user)
        {
            return ClassDAL.Instance.insertUser(user);
        }

        public bool deleteUser(int MaND)
        {
            return ClassDAL.Instance.deleteUser(MaND);
        }

        public int coutAdmin()
        {
            int cout = 0;
            foreach (DataRow row in ClassDAL.Instance.getAllUser().Rows)
                if (row["TENPQ"].ToString().Equals("Admin"))
                    cout++;
            return cout;
        }

        //Lấy mã phân quyền
        public int getPermissionID(string userName)
        {
            foreach (DataRow row in ClassDAL.Instance.getAllUser().Rows)
                if (userName.Equals(row["TENDANGNHAP"].ToString()))
                    return (int)row["MAPQ"];
            return 0;
        }

        public string getEmail(string userName)
        {
            foreach (DataRow row in ClassDAL.Instance.getAllUser().Rows)
                if (userName.Equals(row["TENDANGNHAP"].ToString()))
                    return row["EMAIL"].ToString();
            return null;
        }

        public bool updateUserPassword(string newPassword, string userName)
        {
            return ClassDAL.Instance.updateUserPassword(newPassword, userName);
        }
    }
}
