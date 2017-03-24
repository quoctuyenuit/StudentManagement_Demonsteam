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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
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
    }
}
