namespace StudentManagements.ScoreBoard
{
    partial class uc_ScoreBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Delete_ScoreBoardList = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LookUp_ScoreBoardList = new DevExpress.XtraEditors.SimpleButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grd_ScoreBoardList = new DevExpress.XtraGrid.GridControl();
            this.grd_ScoreBoardList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete_ScoreBoardList
            // 
            this.btn_Delete_ScoreBoardList.Location = new System.Drawing.Point(99, 165);
            this.btn_Delete_ScoreBoardList.Name = "btn_Delete_ScoreBoardList";
            this.btn_Delete_ScoreBoardList.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_ScoreBoardList.TabIndex = 12;
            this.btn_Delete_ScoreBoardList.Text = "Delete";
            this.btn_Delete_ScoreBoardList.Click += new System.EventHandler(this.btn_Delete_ScoreBoardList_Click);
            // 
            // btn_LookUp_ScoreBoardList
            // 
            this.btn_LookUp_ScoreBoardList.Location = new System.Drawing.Point(2, 165);
            this.btn_LookUp_ScoreBoardList.Name = "btn_LookUp_ScoreBoardList";
            this.btn_LookUp_ScoreBoardList.Size = new System.Drawing.Size(91, 33);
            this.btn_LookUp_ScoreBoardList.TabIndex = 13;
            this.btn_LookUp_ScoreBoardList.Text = "Look up";
            this.btn_LookUp_ScoreBoardList.Click += new System.EventHandler(this.btn_LookUp_ScoreBoardList_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.grd_ScoreBoardList);
            this.panel9.Location = new System.Drawing.Point(2, 205);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1122, 460);
            this.panel9.TabIndex = 11;
            // 
            // grd_ScoreBoardList
            // 
            this.grd_ScoreBoardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ScoreBoardList.Location = new System.Drawing.Point(0, 0);
            this.grd_ScoreBoardList.MainView = this.grd_ScoreBoardList_View;
            this.grd_ScoreBoardList.Name = "grd_ScoreBoardList";
            this.grd_ScoreBoardList.Size = new System.Drawing.Size(1122, 460);
            this.grd_ScoreBoardList.TabIndex = 0;
            this.grd_ScoreBoardList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ScoreBoardList_View});
            // 
            // grd_ScoreBoardList_View
            // 
            this.grd_ScoreBoardList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22});
            this.grd_ScoreBoardList_View.GridControl = this.grd_ScoreBoardList;
            this.grd_ScoreBoardList_View.Name = "grd_ScoreBoardList_View";
            this.grd_ScoreBoardList_View.OptionsBehavior.Editable = false;
            this.grd_ScoreBoardList_View.OptionsFind.AlwaysVisible = true;
            this.grd_ScoreBoardList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_ScoreBoardList_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "MALOP";
            this.gridColumn18.FieldName = "MALOP";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Tên Lớp";
            this.gridColumn19.FieldName = "TENLOP";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.FixedWidth = true;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 180;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Sỉ Số";
            this.gridColumn20.FieldName = "SISO";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.FixedWidth = true;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 168;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Năm Học";
            this.gridColumn21.FieldName = "NAMHOC";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.FixedWidth = true;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            this.gridColumn21.Width = 170;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Ghi Chú";
            this.gridColumn22.FieldName = "GHICHU";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 3;
            this.gridColumn22.Width = 650;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox7.Image = global::StudentManagements.Properties.Resources.scoreBoardListTitle;
            this.pictureBox7.Location = new System.Drawing.Point(322, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(482, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // uc_ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Delete_ScoreBoardList);
            this.Controls.Add(this.btn_LookUp_ScoreBoardList);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox7);
            this.Name = "uc_ScoreBoard";
            this.Size = new System.Drawing.Size(1122, 665);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Delete_ScoreBoardList;
        private DevExpress.XtraEditors.SimpleButton btn_LookUp_ScoreBoardList;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraGrid.GridControl grd_ScoreBoardList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ScoreBoardList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}
