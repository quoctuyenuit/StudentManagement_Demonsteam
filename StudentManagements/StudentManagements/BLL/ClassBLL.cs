using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.BLL
{
    class ClassBLL
    {
        DAL.ClassDAL dal;
        public ClassBLL()
        {
            dal = new DAL.ClassDAL();
        }
        public DataTable getAllStudents()
        {
            return dal.getAllStudents();
        }
        public DataTable getStudentAccordingID(int MSHS)
        {
            return dal.getStudentAccordingID(MSHS);
        }
        public DataTable getStudentForClass(int MALOP)
        {
            return dal.getStudentForClass(MALOP);
        }
        public bool deleteStudent(int MSHS)
        {
            return dal.deleteStudent(MSHS);
        }
        public bool insertStudent(Entities.HOCSINH student)
        {
            return dal.insertStudent(student);
        }
        public bool updateStudent(Entities.HOCSINH student)
        {
            return dal.updateStudent(student);
        }
        //===================================================================
        public DataTable getAllClass()
        {
            return dal.getAllClass();
        }
        public DataTable getClassAccordingID(int MALOP)
        {
            return dal.getClassAccordingID(MALOP);
        }
        public int getTotalOfClass(int MALOP)
        {
            return dal.getTotalOfClass(MALOP);
        }

        //===================================================================
        public int getSubjectsID(string subjectName)
        {
            return dal.getSubjectsID(subjectName);
        }

        public DataTable getSubjectNameAccordingClassID(int MALOP)
        {
            return dal.getSubjectNameAccordingClassID(MALOP);
        }

        //===================================================================
        public DataTable getAllScoreBoard()
        {
            return dal.getAllScoreBoard();
        }
        public DataTable getScoreBoardAccordingRequire(int MALOP, int MAMH)
        {
            return dal.getScoreBoardAccordingRequire(MALOP, MAMH);
        }
        public bool deleteScoreBoardCell(int MAKQ)
        {
            return dal.deleteScoreBoardCell(MAKQ);
        }

    }
}
