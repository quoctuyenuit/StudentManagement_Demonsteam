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
    public partial class ChangeRules : Form
    {
        public ChangeRules()
        {
            InitializeComponent();
        }
        void Exit()
        {
            this.Close();
        }
        private void ChangeRules_Load(object sender, EventArgs e)
        {
            GUI.uc_ChageRules uc = new GUI.uc_ChageRules();
            uc.Dock = DockStyle.Fill;
            uc.Exit = new GUI.uc_ChageRules.exit(Exit);
            this.Controls.Clear();
            this.Controls.Add(uc);
        }
    }
}
