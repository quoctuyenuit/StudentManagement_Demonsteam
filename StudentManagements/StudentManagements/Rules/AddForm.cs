using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Form thêm một tên mới khi thêm lớp hoặc môn học trong ChangeRules
 */
namespace StudentManagements.Rules
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        //Delegate trả kết quả về và gọi hàm hiển thị ở form gọi nó

        public delegate void returnData(string data);
        public returnData getData;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.getData(txt_Data.Text);
            this.txt_Data.Focus();
            this.txt_Data.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
