using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RefreshControls()
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
            txt_UserName.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            WaitDialogForm f = new WaitDialogForm();
            f.Show();
            if (!BLL.ClassBLL.Instance.checkUser(new Entities.NGUOIDUNG(txt_UserName.Text, txt_Password.Text)))
            {
                f.Close();
                MessageBox.Show("UserName or Password is not exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            f.Close();
            this.Hide();
            Form1 frm = new Form1(txt_UserName.Text);
            frm.ShowDialog();
            RefreshControls();
            this.Show();
            txt_UserName.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void link_ForgotPassword_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navPage_ForgotPassword;
            txt_Email.Focus();
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Back)
            {
                txt_UserName.Text = "";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text) || !BLL.ClassBLL.Instance.IsEmail(txt_Email.Text))
            {
                errorProvider1.SetError(txt_Email, "The email is valid");
                txt_Email.Focus();
                return;
            }

            string userName = BLL.ClassBLL.Instance.getUserNameFromEmail(txt_Email.Text);

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("The Email is not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                return;
            }

            try
            {
                string mailFrom = "quoctuyen9aht@gmail.com";

                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);

                mailclient.EnableSsl = true;

                mailclient.Credentials = new NetworkCredential(mailFrom, "fbi11023007");

                MailMessage message = new MailMessage(mailFrom, txt_Email.Text);

                message.Subject = "Forgot Password";

                Random rand = new Random();

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                string newPass = new string(Enumerable.Repeat(chars, 6).Select(s => s[rand.Next(s.Length)]).ToArray());

                message.Body = "Forgot Password for Student Management App\n\nYour username: " + userName + "\nYour Password: " + newPass;

                BLL.ClassBLL.Instance.updateUserPassword(newPass, userName);

                Cursor = Cursors.AppStarting;

                mailclient.Send(message);

                MessageBox.Show("New password was sent to " + txt_Email.Text, "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_Back_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sent failure!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor = Cursors.Arrow;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navPage_Login;
        }

    }
}
