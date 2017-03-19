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
        private static ClassDAL instance;

        internal static ClassDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassDAL();
                return ClassDAL.instance;
            }
        }
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

        public DataTable getStudentForAddClass()
        {
            string query = "prd_HOCSINH_SelectHOCSINHTIMLOP";
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

        public int getClassID(string TENLOP, int NAMHOC)
        {
            int MALOP = new int();
            string query = "SELECT LOP.MALOP FROM LOP WHERE TENLOP = @TENLOP AND NAMHOC = @NAMHOC";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = TENLOP;
                command.Parameters.Add("@NAMHOC", SqlDbType.Int).Value = NAMHOC;
                MALOP = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return MALOP;
        }

        public bool insertClass(Entities.LOP myClass)
        {
            bool check = false;
            string query = "prd_LOP_Insert";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = myClass.TenLop;
                command.Parameters.Add("@SISO", SqlDbType.Int).Value = myClass.SiSo;
                command.Parameters.Add("@NAMHOC", SqlDbType.Int).Value = myClass.NamHoc;
                command.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = (myClass.GhiChu == null) ? "" : myClass.GhiChu;
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

        public bool insertStudentForClass(int MSHS, int MALOP)
        {
            bool check = false;
            string query = "prd_QLLOPHOC_Insert";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MSHS", SqlDbType.Int).Value = MSHS;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
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

        public bool insertSubjectForClass(int MAMH, int MALOP)
        {
            bool check = false;
            string query = "INSERT INTO QLMONHOC(MAMH, MALOP) VALUES(@MAMH, @MALOP)";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = MAMH;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
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

        public bool updateClassTotal(int MALOP, int SISO)
        {
            bool check = false;
            string query = "prd_LOP_Update_SISO";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                command.Parameters.Add("@SISO", SqlDbType.Int).Value = SISO;
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

        public bool updateClassNameAndClassYear(string TENLOP, int NAMHOC, int MALOP)
        {
            bool check = false;
            string query = "UPDATE LOP SET TENLOP = @TENLOP, NAMHOC = @NAMHOC WHERE MALOP = @MALOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = TENLOP;
                command.Parameters.Add("@NAMHOC", SqlDbType.Int).Value = NAMHOC;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
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

        public bool deleteClass(int MALOP)
        {
            string query = "prd_LOP_DeleteID";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
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

        public bool deleteStudentInClass(int MSHS, int MALOP)
        {
            bool check = false;
            string query = "prd_QLLOPHOC_DeleteStudentInClass";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MSHS", SqlDbType.Int).Value = MSHS;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
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

        public DataTable getSubjectForClass(int MALOP)
        {
            string query = "SELECT MH.MAMH, MH.TENMH FROM MONHOC MH, QLMONHOC QL WHERE MH.MAMH = QL.MAMH AND QL.MALOP = @MALOP";
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

        public DataTable getAllSubject()
        {
            string query = "SELECT MONHOC.MAMH, MONHOC.TENMH FROM MONHOC";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
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

        public bool deleteSubjectInClass(int MAMH, int MALOP)
        {
            bool check = false;
            string query = "DELETE QLMONHOC WHERE MAMH = @MAMH AND MALOP = @MALOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = MAMH;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
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

        public DataTable getScoreBoardAccordingRequire(int MALOP, int MAMH, int HOCKY)
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
                command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = HOCKY;
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

        public bool insertScoreBoard(Entities.KETQUA kq)
        {
            bool check = false;
            string query = "prd_KETQUA_Insert";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@MSHS", SqlDbType.Int).Value = kq.MSHS;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = kq.MaMH;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = kq.MaLop;
                command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = kq.HocKy;
                command.Parameters.Add("@DIEM15", SqlDbType.Int).Value = kq.Diem15;
                command.Parameters.Add("@DIEM1TIET", SqlDbType.Int).Value = kq.Diem1Tiet;
                command.Parameters.Add("@DIEMCUOIKY", SqlDbType.Int).Value = kq.DiemCuoiKy;
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

        public bool deleteScoreBoardClass(int MALOP)
        {
            bool check = false;
            string query = "DELETE KETQUA WHERE MALOP = @MALOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                command.ExecuteNonQuery();
                check = true;
            }
            catch(Exception ex)
            {
                connection.Close();
            }
            return check;
        }

        public bool updateScoreBoardCell(Entities.KETQUA kq)
        {
            bool check = false;
            string query = "prd_KETQUA_Update";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAKQ", SqlDbType.Int).Value = kq.MaKQ;
                command.Parameters.Add("@DIEM15", SqlDbType.Float).Value = kq.Diem15;
                command.Parameters.Add("@DIEM1TIET", SqlDbType.Float).Value = kq.Diem1Tiet;
                command.Parameters.Add("@DIEMCUOIKY", SqlDbType.Float).Value = kq.DiemCuoiKy;
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
    }
}
