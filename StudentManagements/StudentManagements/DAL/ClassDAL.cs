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
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable table;

        public ClassDAL()
        {
            dataServices = new DataServices();
        }
        //==========================================================================================================
        //Student

        public DataTable getAllStudents()
        {
            string query = "prd_HOCSINH_SelectAll";
            try
            {
                connection = dataServices.getConnect();
                dataAdapter = new SqlDataAdapter(query, connection);
                connection.Open();
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;
        }

        public DataTable getStudentBasedOnID(int MSHS)
        {
            string query = "prd_HOCSINH_SelectID";
            try
            {
                connection = dataServices.getConnect();
                command = new SqlCommand();
                connection.Open();
                command.CommandText = query;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MSHS",SqlDbType.Int).Value = MSHS;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
                
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;
        }

        public bool insertStudent(Entities.HOCSINH student)
        {
            bool check = false;
            string query = "prd_HOCSINH_Insert";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@HOTEN", SqlDbType.Int).Value = student.HoTen;
                command.Parameters.Add("@NGSINH", SqlDbType.Date).Value = student.NgSinh;
                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = student.Email;
                command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = student.GioiTinh;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = student.DiaChi;
                command.ExecuteNonQuery();
                check = true;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return check;

        }
        //==========================================================================================================
        //Class

        public DataTable getAllClass()
        {
            string query = "prd_LOP_SelectAll";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;
        }
    
        public DataTable getClassID(int MALOP)
        {
            string query = "prd_Lop_SelectID";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;
        }

        public int getTotalOfClass(int MALOP)
        {
            int ss = new int();
            string query = "prd_LOP_SelectID";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
                ss = (int)table.Rows[0][2];

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ss;
        }

    }
}
