using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagements.DAL
{
    class ClassDAL
    {
        DataServices dataServices;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        public ClassDAL()
        {
            dataServices = new DataServices();
        }
        public DataTable getAllStudents()
        {
            string sql = "prd_HOCSINH_SelectAll";
            try
            {
                sqlConnection = dataServices.getConnect();
                sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
                sqlConnection.Open();
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            return dataTable;
        }


    }
}
