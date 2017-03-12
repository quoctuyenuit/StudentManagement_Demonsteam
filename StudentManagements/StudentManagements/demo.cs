using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagements
{
    public partial class demo : UserControl
    {
        public demo()
        {
            InitializeComponent();
        }

        private void demo_Load(object sender, EventArgs e)
        {

        }

        public delegate void activeForm(object sender, EventArgs e);
        public activeForm actionActive;

        private void button1_Click(object sender, EventArgs e)
        {
            if (actionActive!=null)
            {
                actionActive(sender,e);
            }
        }
    }
}
