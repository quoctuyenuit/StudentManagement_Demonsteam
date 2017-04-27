using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StudentManagements.Properties;

namespace StudentManagements.Teacher
{
    public partial class uc_TeacherDetail : UserControl
    {
        DataRow row = null;
        private string urlImage;//Đường dẫn của ảnh giáo viên

        public uc_TeacherDetail(DataRow getRow)
        {
            InitializeComponent();
            row = getRow;
        }
        public uc_TeacherDetail()
        {
            InitializeComponent();
        }

        private void uc_TeacherDetail_Load(object sender, EventArgs e)
        {
            pic_ImageTeacher.Image = Resources.StudentIcon;
            pic_ImageTeacher.BackColor = Color.CornflowerBlue;
            link_EditImage_TeacherDetail.Hide();
            btn_Apply.Visible = false;
            btn_Edit.Visible = true;
            navFrame.SelectedPage = nav_PageDetail;
            if (row != null)
            {
                txt_TeacherName.Text = row["HOTEN"].ToString();
                txt_TeacherID.Text = row["MAGV"].ToString();
                txt_TeacherSex.Text = row["GIOITINH"].ToString();
                txt_TeacherQualification.Text = row["HOCHAM"].ToString();
                txt_TeacherExperience.Text = row["NAMKINHNGHIEM"].ToString();

                cb_TeacherDateOfBirth_Edit.DateTime = (DateTime)row["NGSINH"];//Làm cầu nối để hiển thị lên Texbox đúng chuẩn dd/MM/yyyy
                txt_TeacherDateOfBith.Text = cb_TeacherDateOfBirth_Edit.Text;

                if (!String.IsNullOrEmpty(row["ANH"].ToString()))
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(row["ANH"]);
                    MemoryStream mem = new MemoryStream(data);
                    pic_ImageTeacher.Image = Image.FromStream(mem);
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            link_EditImage_TeacherDetail.Show();
            navFrame.SelectedPage = nav_PageDetail_Edit;
            btn_Apply.Visible = true;
            btn_Edit.Visible = false;
            txt_TeacherName_Edit.Text = txt_TeacherName.Text;
            txt_TeacherID_Edit.Text = txt_TeacherID.Text;
            cb_TeacherSex_Edit.SelectedItem = txt_TeacherSex.Text;
            txt_TeacherQualification_Edit.Text = txt_TeacherQualification.Text;
            txt_TeacherExperience_Edit.Text = txt_TeacherExperience.Text;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            navFrame.SelectedPage = nav_PageDetail;
            link_EditImage_TeacherDetail.Hide();
            btn_Apply.Visible = false;
            btn_Edit.Visible = true;
            Entities.GIAOVIEN teacher = new Entities.GIAOVIEN((int)row["MAGV"], txt_TeacherName_Edit.Text, cb_TeacherSex_Edit.Text.Equals("Nam"), cb_TeacherDateOfBirth_Edit.DateTime, txt_TeacherQualification_Edit.Text, int.Parse(txt_TeacherExperience_Edit.Text), urlImage);
            if (!BLL.ClassBLL.Instance.updateTeacher(teacher))
                MessageBox.Show("Insert failure!, Please check again");
            else
            {
                txt_TeacherName.Text = txt_TeacherName_Edit.Text;
                txt_TeacherID.Text = txt_TeacherID_Edit.Text;
                txt_TeacherSex.Text = cb_TeacherSex_Edit.Text;
                txt_TeacherQualification.Text = txt_TeacherQualification_Edit.Text;
                txt_TeacherExperience.Text = txt_TeacherExperience_Edit.Text;
                txt_TeacherDateOfBith.Text = cb_TeacherDateOfBirth_Edit.Text;
            }
        }

        private void link_EditImage_TeacherDetail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" + "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pic_ImageTeacher.Image = Image.FromFile(dialog.FileName);
                    this.urlImage = dialog.FileName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error");
                    return;
                }
            }
        }
    }
}
