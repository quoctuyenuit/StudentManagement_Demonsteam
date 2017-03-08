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

        public DataTable getStudentAccordingID(int MSHS)
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
                command.Parameters.Add("@MSHS", SqlDbType.Int).Value = MSHS;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
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

        public DataTable getStudentForClass(int MALOP)
        {
            string query = "prd_HOCSINH_SelectMALOP";
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
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = student.HoTen;
                command.Parameters.Add("@NGSINH", SqlDbType.Date).Value = student.NgSinh;
                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = student.Email;
                command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = student.GioiTinh;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = student.DiaChi;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return check;

        }

        public bool deleteStudent(int MSHS)
        {
            bool check = false;
            string query = "prd_HOCSINH_DeleteID";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MSHS", SqlDbType.Int).Value = MSHS;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool updateStudent(Entities.HOCSINH student)
        {
            string query = "prd_HOCSINH_UpdateAll";
            bool check = false;
            using (connection = dataServices.getConnect())
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MSHS", SqlDbType.Int).Value = student.MSHS;
                    command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = student.HoTen;
                    command.Parameters.Add("@NGSINH", SqlDbType.Date).Value = student.NgSinh;
                    command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = student.Email;
                    command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = student.GioiTinh;
                    command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = student.DiaChi;
                    command.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
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

        public DataTable getClassAccordingID(int MALOP)
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

        public int getTotalOfClass(int MALOP)
        {
            int ss = new int();
            string query = "prd_LOP_GetSiSo";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                ss = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ss;
        }

        //==========================================================================================================
        //Subjects

        public int getSubjectsID(string subjectName)
        {
            string query = "SELECT MH.MAMH FROM MONHOC MH WHERE TENMH = @TENMH";
            int subjectID = new int();
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = subjectName;
                subjectID = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return subjectID;
        }

        public DataTable getSubjectNameAccordingClassID(int MALOP)
        {
            string query = "SELECT MH.TENMH FROM MONHOC MH, QLMONHOC QL WHERE MH.MAMH = QL.MAMH AND QL.MALOP = @MALOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            catch (Exception ex) { }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;
        }

        //==========================================================================================================
        //ScoreBoard

        public DataTable getAllScoreBoard()
        {
            string query = "prd_KETQUA_SelectAll";
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

        public DataTable getScoreBoardAccordingRequire(int MALOP, int MAMH)
        {
            string query = "prd_KETQUA_Select_MALOP_MONHOC";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = MAMH;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
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

        public bool deleteScoreBoardCell(int MAKQ)
        {
            bool check = false;
            string query = "prd_KETQUA_Delete";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAKQ", SqlDbType.Int).Value = MAKQ;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }
            return check;
        }
    }
}
