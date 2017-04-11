using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements
{
    public partial class TeachingDivision : Form
    {
        private Entities.GIAOVIEN teacher;

        internal Entities.GIAOVIEN Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        public TeachingDivision()
        {
            InitializeComponent();
            grd_ClassList.DataSource = BLL.ClassBLL.Instance.getAllClass();
            if (grd_ClassList_View.SelectedRowsCount > 0)
                grd_SubjectsList.DataSource = BLL.ClassBLL.Instance.getSubjectForClass(int.Parse(BLL.ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
        }

        public delegate void DcallBack();
        public DcallBack callBack;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!BLL.ClassBLL.Instance.IsNotEmpty(panelControl1))
            {
                return;
            }
            Entities.GIANGDAY teaching;
            Entities.GIAOVIEN newTeacher = new Entities.GIAOVIEN(txt_TeacherName_TeachingDivision.Text, (cb_TeacherSex_TeachingDivision.Text.Equals("Nam")) ? true : false, cb_TeacherDateOfBirth_TeachingDivision.DateTime, txt_TeacherQualification_TeachingDivision.Text, int.Parse(txt_TeacherExperience_TeachingDivision.Text));
            if (this.teacher.CompareTo(newTeacher) == 1)//Nếu giáo viên mình đang thao tác là đã có trong danh sách giáo viên
                teaching = new Entities.GIANGDAY(this.Teacher.MaGV, int.Parse(BLL.ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")), int.Parse(BLL.ClassBLL.Instance.getTextFromGridControl(grd_SubjectsList_View, "MAMH")));
            else//Còn nếu chưa có thì phải insert vô danh sách giáo viên trước rồi mới thay đổi phân công
            {
                BLL.ClassBLL.Instance.insertTeacher(newTeacher);
                teaching = new Entities.GIANGDAY(BLL.ClassBLL.Instance.getTeacherIDLast(), int.Parse(BLL.ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")), int.Parse(BLL.ClassBLL.Instance.getTextFromGridControl(grd_SubjectsList_View, "MAMH")));
            }
            if (!BLL.ClassBLL.Instance.insertTeaching(teaching))//Nếu không Insert được tức là môn đó đã có người dạy => ta phải update chứ ko phải là insert
                BLL.ClassBLL.Instance.updateTeaching(teaching);
            showSubject();//Hiển thị lại danh sách sau khi sửa
        }

        private void updateTeacher()
        {
            txt_TeacherName_TeachingDivision.Text = this.Teacher.HoTen;
            cb_TeacherSex_TeachingDivision.SelectedItem = (this.Teacher.GioiTinh == true) ? "Nam" : "Nữ";
            cb_TeacherDateOfBirth_TeachingDivision.DateTime = this.Teacher.NgaySinh;
            txt_TeacherExperience_TeachingDivision.Text = this.Teacher.NamKinhNghiem.ToString(); ;
            txt_TeacherQualification_TeachingDivision.Text = this.Teacher.HocHam;
        }

        private void TeachingDivision_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow row = BLL.ClassBLL.Instance.getTeacherFromID((int)grd_SubjectsList_View.GetDataRow(grd_SubjectsList_View.GetSelectedRows().First())["MAGV"]);
                this.Teacher = new Entities.GIAOVIEN(int.Parse(row["MAGV"].ToString()), row["HOTEN"].ToString(), bool.Parse(row["GIOITINH"].ToString()), (DateTime)row["NGSINH"], row["HOCHAM"].ToString(), (int)row["NAMKINHNGHIEM"]);
                updateTeacher();
            }
            catch (Exception ex)
            {
                BLL.ClassBLL.Instance.formatControls(panelControl1);
            }
        }

        void showSubject()
        {
            grd_SubjectsList.DataSource = null;
            grd_SubjectsList.DataSource = BLL.ClassBLL.Instance.getSubjectForClass(int.Parse(BLL.ClassBLL.Instance.getTextFromGridControl(grd_ClassList_View, "MALOP")));
            grd_SubjectsList_View.ClearSelection();
            changeSubject();
        }

        private void grd_ClassList_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            showSubject();
        }

        private void changeSubject()
        {
            try
            {
                DataRow row = BLL.ClassBLL.Instance.getTeacherFromID((int)grd_SubjectsList_View.GetDataRow(grd_SubjectsList_View.GetSelectedRows().First())["MAGV"]);
                this.Teacher = new Entities.GIAOVIEN(int.Parse(row["MAGV"].ToString()), row["HOTEN"].ToString(), bool.Parse(row["GIOITINH"].ToString()), (DateTime)row["NGSINH"], row["HOCHAM"].ToString(), (int)row["NAMKINHNGHIEM"]);
                updateTeacher();
            }
            catch (Exception ex)
            {
                BLL.ClassBLL.Instance.formatControls(panelControl1);
            }
        }

        private void grd_SubjectsList_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            changeSubject();
        }

        public void processData(DataRow row)
        {
            //DateTime.ParseExact(row["NGSINH"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
            DateTime NGSINH = (DateTime)row["NGSINH"];
            int MAGV = int.Parse(row["MAGV"].ToString());
            string HOTEN = row["HOTEN"].ToString();
            bool GIOITINH = (row["GIOITINH"].ToString().Equals("Nam")) ? true : false;
            string HOCHAM = row["HOCHAM"].ToString();
            int NAMKINHNGHIEM = (int)row["NAMKINHNGHIEM"];
            this.Teacher = new Entities.GIAOVIEN(MAGV, HOTEN, GIOITINH, NGSINH, HOCHAM, NAMKINHNGHIEM);
            updateTeacher();

        }

        private void link_SelectTeacher_Click(object sender, EventArgs e)
        {
            TeacherListForm frm = new TeacherListForm();
            frm.giveData = new TeacherListForm.DgiveData(processData);
            frm.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeachingDivision_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBack != null)
                callBack();
        }

    }
}
