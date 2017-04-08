using DevExpress.Utils;
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
            WaitDialogForm f = new WaitDialogForm();
            f.Show();
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
            f.Close();
            return table;
        }

        public DataTable getStudentAccordingID(int MSHS)
        {
            WaitDialogForm f = new WaitDialogForm();
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
            f.Close();
            return table;
        }

        public DataTable getStudentForClass(int MALOP)
        {
            WaitDialogForm f = new WaitDialogForm();
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
            f.Close();
            return table;
        }

        public DataTable getStudentForAddClass(int NAMHOC)
        {
            WaitDialogForm f = new WaitDialogForm();
            string query = "prd_HOCSINH_SelectHOCSINHTIMLOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@NAMHOC", SqlDbType.Int).Value = NAMHOC;
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
            f.Close();
            return table;
        }

        public DataTable getStudentForLookUp()
        {
            WaitDialogForm f = new WaitDialogForm();
            string query = "prd_HOCSINH_Select_ForLookUpStudent";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
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
            f.Close();
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
                command.Parameters.Add("@ANH", SqlDbType.NVarChar).Value = student.UrlAnh;
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
                    command.Parameters.Add("@ANH", SqlDbType.NVarChar).Value = (student.UrlAnh ==null)? "":student.UrlAnh;
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
            WaitDialogForm f = new WaitDialogForm();
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
            f.Close();
            return table;
        }

        public DataTable getClassAccordingID(int MALOP)
        {
            WaitDialogForm f = new WaitDialogForm();
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
            f.Close();
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

        public string getClassName(int MALOP)
        {
            string TENLOP = "";
            string query = "SELECT TENLOP FROM LOP WHERE MALOP = @MALOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = MALOP;
                TENLOP = (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return TENLOP;
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
            WaitDialogForm f = new WaitDialogForm();
            string query = "prd_MONHOC_GIAOVIEN_Select";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
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
            f.Close();
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

        public bool insertSubject(string TenMH)
        {
            string query = "prd_MONHOC_Insert";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TenMH", SqlDbType.NVarChar).Value = TenMH;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool updateSubject(string TenMH1, string TenMH2)
        {
            string query = "UPDATE MONHOC SET TENMH = @TenMH1 WHERE TENMH = @TenMH2";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TenMH1", SqlDbType.NVarChar).Value = TenMH1;
                command.Parameters.Add("@TenMH2", SqlDbType.NVarChar).Value = TenMH2;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool deleteSubject(string TenLop)
        {
            string query = "DELETE MONHOC WHERE TENMH = @TenLop";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = TenLop;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
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
            WaitDialogForm f = new WaitDialogForm();
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
            f.Close();
            return table;
        }

        public DataTable getScoreBoardAccordingRequire(int MALOP, int MAMH, int HOCKY)
        {
            WaitDialogForm f = new WaitDialogForm();
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
            f.Close();
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
                command.Parameters.Add("@DIEMMIENG1", SqlDbType.Float).Value = kq.DiemMieng1;
                command.Parameters.Add("@DIEMMIENG2", SqlDbType.Float).Value = kq.DiemMieng1;
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
                command.Parameters.Add("@DIEMMIENG1", SqlDbType.Float).Value = kq.DiemMieng1;
                command.Parameters.Add("@DIEMMIENG2", SqlDbType.Float).Value = kq.DiemMieng2;
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
        //==========================================================================================================
        //Report

        public DataTable getReport_MONHOC(int MAMH, int HOCKY)
        {
            WaitDialogForm f = new WaitDialogForm();
            string query = "prd_KETQUA_Select_MONHOC";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = MAMH;
                command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = HOCKY;
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
            f.Close();
            return table;
        }

        public DataTable getReport_HOCKY(int HOCKY)
        {
            WaitDialogForm f = new WaitDialogForm();
            string query = "prd_KETQUA_Select_HocKy";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
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
            f.Close();
            return table;
        }

        //==========================================================================================================
        //ChangeRules
        //
        //Rules StudentAge
        //
        public DataRow getRulesStudentAge()
        {
            string query = "SELECT TuoiToiThieu, TuoiToiDa FROM QD1 WHERE MAQD = 1";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
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
            
            DataRow row = table.Rows[0];
            return row;
        }

        public bool updateRulesStudentAge(int MinAge, int MaxAge)
        {
            bool check = false;
            string query = "UPDATE QD1 SET TuoiToiThieu = @MinAge, TuoiToiDa = @MaxAge WHERE MAQD = 1";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MinAge", SqlDbType.Int).Value = MinAge;
                command.Parameters.Add("@MaxAge", SqlDbType.Int).Value = MaxAge;
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
        //
        //Rules Score
        //
        public DataRow getRulesScore()
        {
            string query = "SELECT DiemDatMon FROM QD5 WHERE MAQD = 1";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
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
            return table.Rows[0];
        }

        public bool updateRulesScore(float MinScore)
        {
            bool check = false;
            string query = "UPDATE QD5 SET DIEMDATMON = @MinScore WHERE MAQD = 1";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MinScore", SqlDbType.Float).Value = MinScore;
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
        //
        //Rules Class
        //
        public int getRulesClassSize()
        {
            int classSize = new int();
            string query = "SELECT SISO FROM QD2_SISO WHERE MAQD = 1";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                classSize = (int)command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return classSize;
        }

        public DataTable getRulesAllClass()
        {
            string query = "SELECT TENLOP FROM QD2_LOP";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            catch {}
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;

        }

        public bool updateRulesClassSize(int classSize)
        {
            bool check = false;
            string query = "UPDATE QD2_SISO SET SISO = @SISO WHERE MAQD = 1";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@SISO", SqlDbType.Int).Value = classSize;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool updateRulesClassName(string newClassName, string oldClassName)
        {
            bool check = false;
            string query = "UPDATE QD2_LOP SET TENLOP = @newClassName WHERE TENLOP = @oldClassName";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@newClassName", SqlDbType.NVarChar).Value = newClassName;
                command.Parameters.Add("@oldClassName", SqlDbType.NVarChar).Value = oldClassName;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }
        
        public bool insertRulesClass(string TenLop)
        {
            bool check = false;
            string query = "INSERT INTO QD2_LOP VALUES(@TenLop)";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = TenLop;
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

        public bool updateRulesCLass(string TenLop, int MaQD)
        {
            bool check = false;
            string query = "UPDATE QD2_LOP SET TENLOP = @TenLop WHERE MaQD = @MaQD";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = TenLop;
                command.Parameters.Add("@MaQD", SqlDbType.Int).Value = MaQD;
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

        public bool deleteRulesClass(string TenLop)
        {
            bool check = false;
            string query = "DELETE QD2_LOP WHERE TenLop = @TenLop";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = TenLop;
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
        //
        //Rules Subjects
        //
        //==========================================================================================================
        //Teaching

        public DataRow getTeacherFromID(int MAGV)
        {
            string query = "SELECT GV.MAGV, HOTEN, GIOITINH, NGSINH, NAMKINHNGHIEM, HOCHAM FROM GIAOVIEN GV WHERE GV.MAGV = @MAGV";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MAGV", SqlDbType.Int).Value = MAGV;
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
            if (table.Rows.Count == 0)
                return null;
            return table.Rows[0];
        }

        public DataTable getTeacherList()
        {
            string query = "SELECT MAGV, HOTEN, NGSINH, CASE WHEN GIOITINH = 1 THEN 'Nam' WHEN GIOITINH = 0 THEN N'Nữ' END AS GIOITINH, HOCHAM, NAMKINHNGHIEM, ANH FROM GIAOVIEN";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            catch (Exception ex)
            { }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
            return table;
        }

        public int getTeacherIDLast()
        {
            int teacherID = new int();
            string query = "SELECT TOP 1 MAGV FROM GIAOVIEN ORDER BY MAGV DESC";
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                teacherID = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return teacherID;
        }

        public bool updateTeacher(Entities.GIAOVIEN teacher)
        {
            string query = "prd_GIAOVIEN_Update";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAGV", SqlDbType.Int).Value = teacher.MaGV;
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = teacher.HoTen;
                command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = teacher.GioiTinh;
                command.Parameters.Add("@NGSINH", SqlDbType.Date).Value = teacher.NgaySinh;
                command.Parameters.Add("@NAMKINHNGHIEM", SqlDbType.Int).Value = teacher.NamKinhNghiem;
                command.Parameters.Add("@HOCHAM", SqlDbType.NVarChar).Value = teacher.HocHam;
                command.Parameters.Add("@URLANH", SqlDbType.NVarChar).Value = (teacher.UrlAnh == null) ? "" : teacher.UrlAnh;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }
        
        public bool insertTeacher(Entities.GIAOVIEN teacher)
        {
            string query = "INSERT INTO GIAOVIEN(HOTEN, GIOITINH, NGSINH, HOCHAM, NAMKINHNGHIEM) VALUES(@HOTEN, @GIOITINH, @NGSINH, @HOCHAM, @NAMKINHNGHIEM)";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = teacher.HoTen;
                command.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = teacher.GioiTinh;
                command.Parameters.Add("@NGSINH", SqlDbType.Date).Value = teacher.NgaySinh;
                command.Parameters.Add("@HOCHAM", SqlDbType.NVarChar).Value = teacher.HocHam;
                command.Parameters.Add("@NAMKINHNGHIEM", SqlDbType.Int).Value = teacher.NamKinhNghiem;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool insertTeaching(Entities.GIANGDAY teaching)
        {
            string query = "INSERT INTO GIANGDAY(MAGV, MALOP, MAMH) VALUES(@MAGV, @MALOP, @MAMH)";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MAGV", SqlDbType.Int).Value = teaching.MaGV;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = teaching.MaLop;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = teaching.MaMH;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool updateTeaching(Entities.GIANGDAY teaching)
        {
            string query = "UPDATE GIANGDAY SET MAGV = @MAGV WHERE MALOP = @MALOP AND MAMH = @MAMH";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@MAGV", SqlDbType.Int).Value = teaching.MaGV;
                command.Parameters.Add("@MALOP", SqlDbType.Int).Value = teaching.MaLop;
                command.Parameters.Add("@MAMH", SqlDbType.Int).Value = teaching.MaMH;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }

        public bool deleteTeacher(int MAGV)
        {
            string query = "prd_GIAOVIEN_Delete";
            bool check = false;
            try
            {
                connection = dataServices.getConnect();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAGV", SqlDbType.Int).Value = MAGV;
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return check;
        }
    }
}
