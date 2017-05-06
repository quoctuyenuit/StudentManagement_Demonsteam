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

namespace StudentManagements.Students
{
    public partial class uc_AddStudent : UserControl
    {
        private string urlImage;
        public uc_AddStudent()
        {
            InitializeComponent();

            pic_StudentInformation_AddStudent.Image = Resources.StudentIcon;
            pic_StudentInformation_AddStudent.BackColor = Color.CornflowerBlue;
            ClassBLL.Instance.formatControls(studentInformationPanel);
            txt_StudentName_AddStudent.Focus();
        }

        private void uc_AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void link_EditImage_AddStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" + "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pic_StudentInformation_AddStudent.Image = Image.FromFile(dialog.FileName);
                    this.urlImage = dialog.FileName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error");
                    return;
                }
            }
        }

        private void btn_Done_AddStudent_Click(object sender, EventArgs e)
        {
            if (!ClassBLL.Instance.IsNotEmpty(studentInformationPanel, txt_StudentEmail_AddStudent))
                return;

            if (!string.IsNullOrEmpty(txt_StudentEmail_AddStudent.Text) && !ClassBLL.Instance.IsEmail(txt_StudentEmail_AddStudent.Text))
            {
                MessageBox.Show("Invalid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClassBLL.Instance.insertStudent(new Entities.HOCSINH(txt_StudentName_AddStudent.Text, txt_StudentEmail_AddStudent.Text, cb_StudentDateOfBirth_AddStudent.DateTime, cb_StudentSex_AddStudent.SelectedIndex, txt_StudentAddress_AddStudent.Text, urlImage)))
            {
                //If insert successful
                ClassBLL.Instance.formatControls(studentInformationPanel);
                MessageBox.Show("Insert into database successful!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                DataRow r = ClassBLL.Instance.getRulesStudentAge();
                MessageBox.Show("Insert fail!", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_StudentDateOfBirth_AddStudent.Focus();
            }
        }
    }
}
