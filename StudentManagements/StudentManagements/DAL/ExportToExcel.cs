using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentManagements.DAL
{
    class ExportToExcel
    {
        static private ExportToExcel instance;

        public static ExportToExcel Instance
        {
            get
            {
                if (instance == null)
                    instance = new ExportToExcel();
                return ExportToExcel.instance;
            }
            set { ExportToExcel.instance = value; }
        }

        public void Export_ScoreBoard(System.Data.DataTable table, string ClassName, string SubjectName, int Semester, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = true;//Turn On the alert message

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range cellHead = oSheet.Cells[1, table.Columns.Count - 1];
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", cellHead);

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range col1 = oSheet.get_Range("A5", "A5");

            col1.Value2 = "STT";

            col1.ColumnWidth = 5;

            Microsoft.Office.Interop.Excel.Range col2 = oSheet.get_Range("B5", "B5");

            col2.Value2 = "Họ Tên";

            col2.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range col3 = oSheet.get_Range("C5", "C5");

            col3.Value2 = "Điểm 15'";

            col3.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range col4 = oSheet.get_Range("D5", "D5");

            col4.Value2 = "Điểm 1 Tiết";

            col4.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col5 = oSheet.get_Range("E5", "E5");

            col5.Value2 = "Điểm Cuối Kỳ";

            col5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col6 = oSheet.get_Range("F5", "F5");

            col6.Value2 = "Điểm TB";

            col6.ColumnWidth = 15;

            //-----------------------------------------------------
            //-----------------------------------------------------

            Microsoft.Office.Interop.Excel.Range colClass = oSheet.get_Range("A2", "B2");

            colClass.MergeCells = true;

            colClass.Value2 = "Lớp:     " + ClassName;

            //colClass.ColumnWidth = 15;
            //-----------------------------------------------------
            Microsoft.Office.Interop.Excel.Range colSubject = oSheet.get_Range("C2", "D2");

            colSubject.MergeCells = true;

            colSubject.Value2 = "Môn:    " + SubjectName;

            //colSubject.ColumnWidth = 15;
            //-----------------------------------------------------
            Microsoft.Office.Interop.Excel.Range colSemester = oSheet.get_Range("A3", "B3");

            colSemester.MergeCells = true;

            colSemester.Value2 = "Học Kỳ:    " + Semester;

            // colSemester.ColumnWidth = 15;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A5", "F5");

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
            int rowIndex = 0;
            for (int r = 0; r < table.Rows.Count; r++)
            {
                int columnIndex = 0;
                DataRow dr = table.Rows[r];
                arr[rowIndex, columnIndex++] = null;
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    if (table.Columns[c].ColumnName != "MSHS" && table.Columns[c].ColumnName != "MAKQ")
                        arr[rowIndex, columnIndex++] = dr[c];
                }
                rowIndex++;
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 6;

            int columnStart = 1;

            int rowEnd = rowStart + table.Rows.Count - 1;

            int columnEnd = table.Columns.Count - 1;//Trường hợp ở đây đặc biệt, vì dữ liệu trong bảng dư so với những thứ cần xuất, nên phải bỏ bớt những cột ko cần thiết

            

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellStart = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellEnd = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(cellStart, cellEnd);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //Căn trái cho cột họ tên

            Microsoft.Office.Interop.Excel.Range cellHT1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, 2];
            Microsoft.Office.Interop.Excel.Range cellHT2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, 2];
            Microsoft.Office.Interop.Excel.Range rangeHT = oSheet.get_Range(cellHT1, cellHT2);
            rangeHT.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            //Đánh số cho cột STT

            for (int i = rowStart; i <= rowEnd; i++)
            {
                oSheet.Cells[i, 1] = i - rowStart + 1;
            }

        }

        public void Export_Report_Semester(System.Data.DataTable table, int semester, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = true;//Turn On the alert message

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range cellHead = oSheet.Cells[1, table.Columns.Count];
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", cellHead);

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range col1 = oSheet.get_Range("A4", "A4");

            col1.Value2 = "Mã Số";

            col1.ColumnWidth = 10;

            col1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range col2 = oSheet.get_Range("B4", "B4");

            col2.Value2 = "Tên Lớp";

            col2.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col3 = oSheet.get_Range("C4", "C4");

            col3.Value2 = "Sỉ Số";

            col3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col4 = oSheet.get_Range("D4", "D4");

            col4.Value2 = "Số Lượng Đạt";

            col4.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col5 = oSheet.get_Range("E4", "E4");

            col5.Value2 = "Tỉ Lệ";

            col5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range colSemester = oSheet.get_Range("A2", "D2");

            colSemester.MergeCells = true;

            colSemester.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            colSemester.Value2 = "Học Kỳ:    " + semester;

            colSemester.ColumnWidth = 15;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "E4");

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
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 5;

            int columnStart = 1;

            int rowEnd = rowStart + table.Rows.Count - 1;

            int columnEnd = table.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellStart = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellEnd = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(cellStart, cellEnd);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }

        public void Export_Report_Subject(System.Data.DataTable table, string SubjectName, int semester, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = true;//Turn On the alert message

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range cellHead = oSheet.Cells[1, table.Columns.Count];
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", cellHead);

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range col1 = oSheet.get_Range("A4", "A4");

            col1.Value2 = "Mã Số";

            col1.ColumnWidth = 10;

            col1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range col2 = oSheet.get_Range("B4", "B4");

            col2.Value2 = "Tên Lớp";

            col2.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col3 = oSheet.get_Range("C4", "C4");

            col3.Value2 = "Sỉ Số";

            col3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col4 = oSheet.get_Range("D4", "D4");

            col4.Value2 = "Số Lượng Đạt";

            col4.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col5 = oSheet.get_Range("E4", "E4");

            col5.Value2 = "Tỉ Lệ";

            col5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range colSubject = oSheet.get_Range("A2", "B2");

            colSubject.MergeCells = true;

            colSubject.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            colSubject.Value2 = "Môn Học:     " + SubjectName;

            colSubject.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range colSemester = oSheet.get_Range("C2", "D2");

            colSemester.MergeCells = true;

            colSemester.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            colSemester.Value2 = "Học Kỳ:    " + semester;

            colSemester.ColumnWidth = 15;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "E4");

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
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 5;

            int columnStart = 1;

            int rowEnd = rowStart + table.Rows.Count - 1;

            int columnEnd = table.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellStart = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range cellEnd = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(cellStart, cellEnd);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }

        public void Export_Student(System.Data.DataTable table, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = true;//Turn On the alert message

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range cellHead = oSheet.Cells[1, table.Columns.Count];
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", cellHead);

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

            col3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range col4 = oSheet.get_Range("D3", "D3");

            col4.Value2 = "Email";

            col4.ColumnWidth = 35;

            Microsoft.Office.Interop.Excel.Range col5 = oSheet.get_Range("E3", "E3");

            col5.Value2 = "Giới Tính";

            col5.ColumnWidth = 8;

            Microsoft.Office.Interop.Excel.Range col6 = oSheet.get_Range("F3", "F3");

            col6.Value2 = "Địa Chỉ";

            col6.ColumnWidth = 40;



            //Định dạng cột ngày sinh theo kiểu ngày tháng
            Microsoft.Office.Interop.Excel.Range cell1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[4, 3];
            Microsoft.Office.Interop.Excel.Range cell2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[table.Rows.Count + 3, 3];
            Microsoft.Office.Interop.Excel.Range rangeFormat = oSheet.get_Range(cell1, cell2);
            rangeFormat.NumberFormat = "DD/MM/YYYY";

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
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + table.Rows.Count - 1;

            int columnEnd = table.Columns.Count;

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
