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
        public DataTable getStudentBasedOnID(int MSHS)
        {
            return dal.getStudentBasedOnID(MSHS);
        }
        public DataTable getAllClass()
        {
            return dal.getAllClass();
        }
        public DataTable getClassID(int MALOP)
        {
            return dal.getClassID(MALOP);
        }
        public int getTotalOfClass(int MALOP)
        {
            return dal.getTotalOfClass(MALOP);
        }
    }
}
