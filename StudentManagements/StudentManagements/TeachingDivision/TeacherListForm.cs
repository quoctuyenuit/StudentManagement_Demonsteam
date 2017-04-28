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
        private Teacher.uc_TeacherList uc;


        public TeacherListForm()
        {
            InitializeComponent();
        }

        private void getFrameForDetail(Teacher.uc_TeacherDetail detail)
        {
            Teacher.uc_TeacherDetail uc = new Teacher.uc_TeacherDetail();
            uc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            uc = new Teacher.uc_TeacherList();
            uc.Dock = DockStyle.Fill;
            uc.getFrameForDetail = new Teacher.uc_TeacherList.DgetFrameForDetail(getFrameForDetail);
            uc.returnData = new Teacher.uc_TeacherList.DreturnData(btn_OK_Click);//Hàm trả về kết quả sau cùng, khi người dùng double click sẽ tương đương với nhấn ok để trả về kết quả
            
            panel1.Controls.Add(uc);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.row = uc.row;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public DataRow row { get; set; }
    }
}
