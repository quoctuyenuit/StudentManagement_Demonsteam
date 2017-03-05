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

    }
}
