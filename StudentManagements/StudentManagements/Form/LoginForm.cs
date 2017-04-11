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

namespace StudentManagements
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
            if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                MessageBox.Show("Please enter the username", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userEmail = BLL.ClassBLL.Instance.getEmail(txt_UserName.Text);

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Email is not exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string mailFrom = "quoctuyen9aht@gmail.com";
                
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                
                mailclient.EnableSsl = true;

                mailclient.Credentials = new NetworkCredential(mailFrom, "fbi11023007");

                MailMessage message = new MailMessage(mailFrom, userEmail);

                message.Subject = "Forgot Password";

                Random rand = new Random();

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                string newPass=  new string(Enumerable.Repeat(chars, 6).Select(s => s[rand.Next(s.Length)]).ToArray());

                message.Body = newPass;

                BLL.ClassBLL.Instance.updateUserPassword(newPass, txt_UserName.Text);

                mailclient.Send(message);

                MessageBox.Show("New password was sent to " + userEmail, "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sent failure!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
