using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagements.BLL;

namespace StudentManagements.ScoreBoard
{
    public partial class uc_ScoreBoard : UserControl
    {
        public delegate void DgetFrameForLookUp(ScoreBoard.uc_ScoreBoardOfClass lookUp);
        
        public DgetFrameForLookUp getFrameForLookUp;

        public uc_ScoreBoard()
        {
            InitializeComponent();
            grd_ScoreBoardList.DataSource = BLL.ClassBLL.Instance.getAllClass();
        }

        private void btn_Delete_ScoreBoardList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ScoreBoard will deleted\nDo you want to delete?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ClassBLL.Instance.deleteScoreBoardClass((int)grd_ScoreBoardList_View.GetDataRow(grd_ScoreBoardList_View.GetSelectedRows().First())["MALOP"]);
                MessageBox.Show("Delete successful!");
            }
        }

        private void btn_LookUp_ScoreBoardList_Click(object sender, EventArgs e)
        {
            if (grd_ScoreBoardList_View.SelectedRowsCount <= 0)
                return;

            string TENLOP = ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoardList_View, "TENLOP");
            int MALOP = int.Parse(ClassBLL.Instance.getTextFromGridControl(grd_ScoreBoardList_View, "MALOP"));
            
            uc_ScoreBoardOfClass uc = new uc_ScoreBoardOfClass(TENLOP, MALOP);

            if (getFrameForLookUp != null)
                getFrameForLookUp(uc);
        }
    }
}
