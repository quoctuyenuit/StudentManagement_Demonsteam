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

        //Biến nhận biết để insert hay update dữ liệu
        bool isNew;

        public PermissionForm(string userName)
        {
            InitializeComponent();

            user = new Entities.NGUOIDUNG();

            //Lấy tên đăng nhập
            this.user.TenDangNhap = userName;
            
            //Lấy mã phân quyền
            this.user.MaPQ = BLL.ClassBLL.Instance.getPermissionID(this.user.TenDangNhap);

            grd_User.DataSource = BLL.ClassBLL.Instance.getAllUser();
            
            //Lấy danh sách các phân quyền cho vào Combobox
            cb_Permission.DataSource = BLL.ClassBLL.Instance.getPermissionName();

            process();

        }

        private void grd_User_View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());

            process();

            isNew = false;
        }

        //Hàm xử lý hiển thị theo phân quyền
        void process()
        {
            //Lấy dữ liệu của hàng đang được chọn
            DataRow row = grd_User_View.GetDataRow(grd_User_View.GetSelectedRows().First());

            if (user.MaPQ != 1)//Nếu là thành viên thì ko được xem mật khẩu của người khác (Mã phân quyền bằng 1 tương ứng với member)
            {
                //Ẩn cột mật khẩu trong DataGridView
                grdColumn_Password.Visible = false;

                //Ẩn cột email trong DataGridView
                grdColumn_Email.Visible = false;

                btn_NewUser.Hide();

                btn_Delete.Hide();

                cb_Permission.Enabled = false;

                //Cho người dùng tự xem và sửa được mật khẩu của mình
                if (user.TenDangNhap.Equals(row["TENDANGNHAP"].ToString()))
                {
                    labelEmail.Show();

                    txt_Email.Show();

                    labelPassword.Show();

                    txt_Password.Show();
                }
                else
                {
                    labelEmail.Hide();

                    txt_Email.Hide();

                    labelPassword.Hide();

                    txt_Password.Hide();
                }
            }
            else
            {
                //Ẩn cột mật khẩu trong DataGridView
                grdColumn_Password.Visible = true;

                //Ẩn cột email trong DataGridView
                grdColumn_Email.Visible = true;

                btn_NewUser.Show();

                btn_Delete.Show();

                cb_Permission.Enabled = true;

                labelEmail.Show();

                txt_Email.Show();

                labelPassword.Show();

                txt_Password.Show();
            }

            txt_Name.Text = row["TENNGUOIDUNG"].ToString();

            txt_UserName.Text = row["TENDANGNHAP"].ToString();

            cb_Permission.SelectedItem = row["TENPQ"].ToString();

            txt_Email.Text = row["EMAIL"].ToString();

            txt_Password.Text = row["MATKHAU"].ToString();

        }

        #region Button Event

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

            //Nếu đối tượng đang xét không phải là thêm mới thì sử dụng chức năng update, ngược lại là insert 
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

        #endregion
    }
}
