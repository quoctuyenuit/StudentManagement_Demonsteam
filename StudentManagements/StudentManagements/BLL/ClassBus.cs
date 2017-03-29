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

    }
}
