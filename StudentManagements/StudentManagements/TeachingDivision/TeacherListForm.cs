using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.TeachingDivision
{
    public partial class TeacherListForm : Form
    {
        public TeacherListForm()
        {
            InitializeComponent();
        }

        public delegate DataRow DgetRow();

        public delegate void DgiveData(DataRow row);

        public DgiveData giveData;

        public DgetRow getRow;

        public void getDelegate(DgetRow getRow)
        {
            this.getRow = getRow;
        }

        public DataTable getTeacherList()
        {
            return BLL.ClassBLL.Instance.getTeacherList();
        }

        void detailTeacher()
        {
            this.Controls.Clear();
            Teacher.uc_TeacherDetail uc = new Teacher.uc_TeacherDetail();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            Teacher.uc_TeacherList uc = new Teacher.uc_TeacherList();
            uc.Dock = DockStyle.Fill;
            uc.detail = new Teacher.uc_TeacherList.Ddetail(detailTeacher);
            uc.getTable = new Teacher.uc_TeacherList.DgetTable(getTeacherList);
            uc.giveRow = new Teacher.uc_TeacherList.DgiveRow(getDelegate);
            uc.returnData = new Teacher.uc_TeacherList.DreturnData(btn_OK_Click);//Hàm trả về kết quả sau cùng, khi người dùng double click sẽ tương đương với nhấn ok để trả về kết quả
            panel1.Controls.Add(uc);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (getRow != null && giveData != null)
            {
                giveData(getRow());
                this.Close();
            }
        }
    }
}
