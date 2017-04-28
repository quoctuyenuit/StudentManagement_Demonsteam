using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagements.Properties;
using StudentManagements.BLL;
using System.Globalization;
using System.IO;

namespace StudentManagements.Students
{
    public partial class uc_DetailStudent : UserControl
    {
        private string urlImage_EditStudent;

        public uc_DetailStudent(string studentID)
        {
            InitializeComponent();

            btn_Edit_StudentInformation.Show();
            btn_Apply_StudentInformation.Hide();
            link_EditImage_StudentInformation.Hide();
            pic_StudentInformation.Image = Resources.StudentIcon;
            pic_StudentInformation.BackColor = Color.CornflowerBlue;
            navFrame_StudentInformation.SelectedPage = navPage_StudentDetail_StudentInformation;

            #region InitData
            ClassBLL.Instance.formatControls(navPage_StudentEdit_StudentInformation);

            txt_StudentID_StudentInformation_Detail.Text = studentID;

            DataRow row = ClassBLL.Instance.getStudentAccordingID(int.Parse(txt_StudentID_StudentInformation_Detail.Text)).Rows[0];

            txt_StudentName_StudentInformation_Detail.Text = row["HOTEN"].ToString();
            string[] temp = row["NGSINH"].ToString().Split(' ');
            temp = temp[0].Split('/');
            string day = (temp[1].Length == 1) ? "0" + temp[1] : temp[1];
            string month = (temp[0].Length == 1) ? "0" + temp[0] : temp[0];
            txt_StudentDateOfBirth_StudentInformation_Detail.Text = day + "/" + month + "/" + temp[2];
            txt_StudentEmail_StudentInformation_Detail.Text = row["EMAIL"].ToString();
            txt_StudentSex_StudentInformation_Detail.Text = row["GIOITINH"].ToString();
            txt_StudentAddress_StudentInformation_Detail.Text = row["DIACHI"].ToString();
            if (!String.IsNullOrEmpty(row["ANH"].ToString()))
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(row["ANH"]);
                MemoryStream mem = new MemoryStream(data);
                pic_StudentInformation.Image = Image.FromStream(mem);
            }
            #endregion

            
        }

        private void btn_Apply_StudentInformation_Click(object sender, EventArgs e)
        {
            link_EditImage_StudentInformation.Hide();
            if (!string.IsNullOrEmpty(txt_StudentEmail_StudentInformation_Edit.Text) && !ClassBLL.Instance.IsEmail(txt_StudentEmail_StudentInformation_Edit.Text))
            {
                MessageBox.Show("Invalid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_StudentEmail_StudentInformation_Edit.Focus();
                return;
            }
            Entities.HOCSINH student = new Entities.HOCSINH(int.Parse(txt_StudentID_StudentInformation_Edit.Text), txt_StudentName_StudentInformation_Edit.Text, txt_StudentEmail_StudentInformation_Edit.Text, cb_StudentDateOfBirth_StudentInformation_Edit.DateTime, cb_StudentSex_StudentInformation_Edit.SelectedIndex, txt_StudentAddress_StudentInformation_Edit.Text, urlImage_EditStudent);
            if (ClassBLL.Instance.updateStudent(student))//If updated successful -> Show message and update data for controls
            {
                txt_StudentID_StudentInformation_Detail.Text = txt_StudentID_StudentInformation_Edit.Text;
                txt_StudentName_StudentInformation_Detail.Text = txt_StudentName_StudentInformation_Edit.Text;
                txt_StudentDateOfBirth_StudentInformation_Detail.Text = cb_StudentDateOfBirth_StudentInformation_Edit.Text;
                txt_StudentEmail_StudentInformation_Detail.Text = txt_StudentEmail_StudentInformation_Edit.Text;
                txt_StudentSex_StudentInformation_Detail.Text = cb_StudentSex_StudentInformation_Edit.Text;
                txt_StudentAddress_StudentInformation_Detail.Text = txt_StudentAddress_StudentInformation_Edit.Text;
                navFrame_StudentInformation.SelectedPage = navPage_StudentDetail_StudentInformation;

                btn_Apply_StudentInformation.Hide();
                btn_Edit_StudentInformation.Show();
            }
            else
            {
                DataRow r = ClassBLL.Instance.getRulesStudentAge();
                MessageBox.Show("Insert fail!, Student Age must be between " + r[0] + " and " + r[1], "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_StudentDateOfBirth_StudentInformation_Edit.DateTime = DateTime.ParseExact(txt_StudentDateOfBirth_StudentInformation_Detail.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }

        private void btn_Edit_StudentInformation_Click(object sender, EventArgs e)
        {
            link_EditImage_StudentInformation.Show();//Hiển thị button để thay đổi ảnh
            navFrame_StudentInformation.SelectedPage = navPage_StudentEdit_StudentInformation;
            
            ClassBLL.Instance.formatControls(navPage_StudentEdit_StudentInformation);//Format controls
            //Set Text of Texboxs
            txt_StudentID_StudentInformation_Edit.Text = txt_StudentID_StudentInformation_Detail.Text;
            txt_StudentName_StudentInformation_Edit.Text = txt_StudentName_StudentInformation_Detail.Text;

            cb_StudentDateOfBirth_StudentInformation_Edit.DateTime = DateTime.ParseExact(txt_StudentDateOfBirth_StudentInformation_Detail.Text, "d/MM/yyyy", CultureInfo.InvariantCulture);

            txt_StudentAddress_StudentInformation_Edit.Text = txt_StudentAddress_StudentInformation_Detail.Text;
            cb_StudentSex_StudentInformation_Edit.SelectedIndex = (txt_StudentSex_StudentInformation_Detail.Text.Equals("Nam")) ? 1 : 0;
            txt_StudentEmail_StudentInformation_Edit.Text = txt_StudentEmail_StudentInformation_Detail.Text;

            btn_Apply_StudentInformation.Show();
            btn_Edit_StudentInformation.Hide();
        }

        private void link_EditImage_StudentInformation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" + "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pic_StudentInformation.Image = Image.FromFile(dialog.FileName);
                    this.urlImage_EditStudent = dialog.FileName;
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
