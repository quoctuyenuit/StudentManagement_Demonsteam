using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements.GUI
{
    public partial class uc_LookUpStudent : UserControl
    {
        public uc_LookUpStudent()
        {
            InitializeComponent();
        }

        private void uc_LookUpStudent_Load(object sender, EventArgs e)
        {
            grd_StudentList.DataSource = BLL.ClassBLL.Instance.getStudentForLookUp();
        }
    }
}
