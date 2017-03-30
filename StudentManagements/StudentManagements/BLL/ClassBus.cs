using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.BLL
{
    class ClassBus
    {
        private static ClassBus instance;

        internal static ClassBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassBus();
                return ClassBus.instance;
            }
        }
        public ClassBus()
        {

        }

        //========================================================================================================================
        //Action
        public void showStudentList(GridControl grd)
        {
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getAllStudents();
            grd.DataSource = table;
        }

        public void showClassList(GridControl grd)
        {
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getAllClass();
            grd.DataSource = table;
        }

        public void showScoreBoardList(GridControl grd)
        {
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getAllScoreBoard();
            grd.DataSource = table;
        }

        //========================================================================================================================
        public void showStudentForAddClass(GridControl grd)
        {
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getStudentForAddClass();
            grd.DataSource = table;
        }

        public void processClickAddStudentForClass_ClassInformation(int MALOP, GridView grd, GridControl grdSource)
        {
            int[] rows = grd.GetSelectedRows();
            foreach (int row in rows)
            {
                if (!ClassBLL.Instance.insertStudetForClass((int)grd.GetListSourceRowCellValue(row, "MSHS"), MALOP))
                {
                    MessageBox.Show("Quantity exceeds the limit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getStudentForClass(MALOP);
            grdSource.DataSource = table;
        }

        public bool saveAddClass(Panel addClassPanel, TextEdit txt_ClassTotal_AddClass, string className, int year)
        {

            StudentManagements.Entities.LOP newLOP = new Entities.LOP(className, 0, year);
            if (!ClassBLL.Instance.checkExistenceClass(newLOP))
            {
                MessageBox.Show("Class already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ClassBLL.Instance.insertClass(newLOP))
            {
                MessageBox.Show("Create Class successful!");
                return true;
            }
            else
            {
                MessageBox.Show("Create Class failure!");
                return false;
            }
        }

        public void deleteStudentInClass(GridView grd_StudentList_View, GridControl grd_StudentList, int MALOP)
        {
            int[] rows = grd_StudentList_View.GetSelectedRows();//Take rows of Table in GridControl StudentList
            foreach (int row in rows)
            {
                ClassBLL.Instance.deleteStudentInClass((int)grd_StudentList_View.GetListSourceRowCellValue(row, "MSHS"), MALOP);
            }
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getStudentForClass(MALOP);
            grd_StudentList.DataSource = table;
        }

        public void deleteSubjectInClass(GridView grd_SubjectList_View, GridControl grd_SubjectList, int MALOP)
        {
            int[] rows = grd_SubjectList_View.GetSelectedRows();
            foreach (int row in rows)
            {
                ClassBLL.Instance.deleteSubjectInClass((int)grd_SubjectList_View.GetListSourceRowCellValue(row, "MAMH"), MALOP);
            }
            DataTable table = new DataTable();
            table = ClassBLL.Instance.getSubjectForClass(MALOP);
            grd_SubjectList.DataSource = table;
        }


        //========================================================================================================================

        public void ExportFile(DataTable table, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;//Turn off the alert message

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range col1 = oSheet.get_Range("A3", "A3");

            col1.Value2 = "Mã Số";

            col1.ColumnWidth = 10;

            col1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range col2 = oSheet.get_Range("B3", "B3");

            col2.Value2 = "Họ Tên";

            col2.ColumnWidth = 26;

            Microsoft.Office.Interop.Excel.Range col3 = oSheet.get_Range("C3", "C3");

            col3.Value2 = "Ngày Sinh";

            col3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range col4 = oSheet.get_Range("D3", "D3");

            col4.Value2 = "Email";

            col4.ColumnWidth = 40;

            Microsoft.Office.Interop.Excel.Range col5 = oSheet.get_Range("E3", "E3");

            col5.Value2 = "Giới Tính";

            col5.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range col6 = oSheet.get_Range("F3", "F3");

            col6.Value2 = "Địa Chỉ";

            col6.ColumnWidth = 50;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[table.Rows.Count, table.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < table.Rows.Count; r++)
            {

                DataRow dr = table.Rows[r];

                for (int c = 0; c < table.Columns.Count; c++)
                {
                    if (dr[c] is DateTime)
                        dr[c] = (object)dr[c].ToString();
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + table.Rows.Count - 1;

            int columnEnd = table.Columns.Count;

            //Định dạng cột ngày sinh theo kiểu ngày tháng
            Microsoft.Office.Interop.Excel.Range cell1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, 3];
            Microsoft.Office.Interop.Excel.Range cell2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, 3];
            Microsoft.Office.Interop.Excel.Range rangeFormat = oSheet.get_Range(cell1, cell2);
            rangeFormat.NumberFormat = "DD/MM/YYYY";

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellStart = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellEnd = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(cellStart, cellEnd);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(cellStart, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;      
        }
    }
}
