﻿using System;
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
    public partial class uc_Report_Semester : UserControl
    {
        private int HocKy;
        public uc_Report_Semester()
        {
            InitializeComponent();
            cb_Semester.SelectedIndex = 0;
        }

        private void cb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Semester.SelectedIndex == 0)
            {
                grd_Report.DataSource = null;
                return;
            }
            this.HocKy = int.Parse(cb_Semester.SelectedItem.ToString());
            grd_Report.DataSource = BLL.ClassBLL.Instance.getReport_HOCKY(HocKy);
        }
    }
}