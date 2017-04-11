using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements
{
    public partial class PermissionForm : Form
    {
        Entities.NGUOIDUNG user;
        bool isNew;

        public PermissionForm(string userName)
        {
            InitializeComponent();
            user = new Entities.NGUOIDUNG();
            this.user.TenDangNhap = userName;
            this.user.MaPQ = BLL.ClassBLL.Instance.getPermissionID(this.user.TenDangNhap);

            grd_User.DataSource = BLL.ClassBLL.Instance.getAllUser();
            cb_Permission.DataSource = BLL.ClassBLL.Instance.getPermissionName();


            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());

            

            process();

        }

        private void grd_User_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());

            process();
            isNew = false;
        }

        void process()
        {
            

            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());

            if (row["TENDANGNHAP"].ToString().Equals(user.TenDangNhap))//Người dùng không được phép tự xóa bản thân
                btn_Delete.Enabled = false;
            else
                btn_Delete.Enabled = true;

            if (user.MaPQ != 1)//Nếu là thành viên thì ko được xem mật khẩu của người khác
            {
                grdColumn_Password.Visible = false;

                labelPassword.Hide();
                txt_Password.Hide();

                btn_NewUser.Hide();
                btn_Delete.Hide();

                cb_Permission.Enabled = false;
            }
            else
            {
                grdColumn_Password.Visible = true;
                labelPassword.Show();
                txt_Password.Show();
                btn_NewUser.Show();
                btn_Delete.Show();

                cb_Permission.Enabled = true;
            }

            if (user.TenDangNhap.Equals(row["TENDANGNHAP"].ToString()))
            {
                txt_Name.Enabled = true;
                txt_UserName.Enabled = true;
                txt_Email.Enabled = true;
                txt_Password.Enabled = true;
            }
            else
            {
                txt_Name.Enabled = false;
                txt_UserName.Enabled = false;
                txt_Email.Enabled = false;
                txt_Password.Enabled = false;
            }

            txt_Name.Text = row["TENNGUOIDUNG"].ToString();

            txt_UserName.Text = row["TENDANGNHAP"].ToString();
            cb_Permission.SelectedItem = row["TENPQ"].ToString();
            txt_Email.Text = row["EMAIL"].ToString();
            txt_Password.Text = row["MATKHAU"].ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());

            if (!BLL.ClassBLL.Instance.IsNotEmpty(panel1, txt_Email))
            {
                process();
                return;
            }

            if (!string.IsNullOrEmpty(txt_Email.Text) && !BLL.ClassBLL.Instance.IsEmail(txt_Email.Text))
            {
                MessageBox.Show("Invalid email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Text = row["EMAIL"].ToString();
                return;
            }


            Entities.NGUOIDUNG _user = new Entities.NGUOIDUNG(int.Parse(grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First())["MAND"].ToString()), txt_Name.Text, txt_UserName.Text, txt_Password.Text, cb_Permission.Text, txt_Email.Text);

            if (!cb_Permission.Text.Equals(row["TENPQ"].ToString()) && cb_Permission.Text.Equals("Admin") && BLL.ClassBLL.Instance.coutAdmin() == 1)
            {
                MessageBox.Show("Only one administrator is allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                process();
                return;
            }

            if (!isNew)
                BLL.ClassBLL.Instance.updateUserInformation(_user);
            else
                BLL.ClassBLL.Instance.insertUser(_user);

            if (BLL.ClassBLL.Instance.coutAdmin() == 0)//Nếu chưa có ai là admin thì vẫn cho phép người này có quyền admin để thay đổi người khác làm admin
                this.user.MaPQ = 1;
            else
                this.user.MaPQ = BLL.ClassBLL.Instance.getPermissionID(this.user.TenDangNhap);

            grd_User.DataSource = BLL.ClassBLL.Instance.getAllUser();

            cb_Permission.DataSource = BLL.ClassBLL.Instance.getPermissionName();

            process();

            isNew = false;

        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            BLL.ClassBLL.Instance.formatControls(panel1);
            txt_Name.Enabled = true;
            txt_UserName.Enabled = true;
            cb_Permission.Enabled = true;
            txt_Password.Enabled = true;
            txt_Name.Focus();
            isNew = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());
            BLL.ClassBLL.Instance.deleteUser((int)row["MAND"]);
            grd_User_View.DeleteSelectedRows();
        }
    }
}
