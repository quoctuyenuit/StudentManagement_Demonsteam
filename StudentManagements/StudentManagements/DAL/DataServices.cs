using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.DAL
{
    class DataServices
    {
        string str;
        public DataServices()
        {
            str = ConfigurationManager.ConnectionStrings["connect"].ToString();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(str);
        }
    }
}
