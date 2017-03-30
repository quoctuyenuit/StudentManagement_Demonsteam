namespace StudentManagements.GUI
{
    partial class uc_ScoreBoardList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grd_ScoreBoard = new DevExpress.XtraGrid.GridControl();
            this.grd_ScoreBoard_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard_View)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::StudentManagements.Properties.Resources.scoreBoardListTitle;
            this.pictureBox1.Location = new System.Drawing.Point(353, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grd_ScoreBoard);
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 471);
            this.panel1.TabIndex = 1;
            // 
            // grd_ScoreBoard
            // 
            this.grd_ScoreBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grd_ScoreBoard.Location = new System.Drawing.Point(0, 0);
            this.grd_ScoreBoard.MainView = this.grd_ScoreBoard_View;
            this.grd_ScoreBoard.Name = "grd_ScoreBoard";
            this.grd_ScoreBoard.Size = new System.Drawing.Size(1188, 471);
            this.grd_ScoreBoard.TabIndex = 0;
            this.grd_ScoreBoard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ScoreBoard_View});
            this.grd_ScoreBoard.Load += new System.EventHandler(this.grd_ScoreBoard_Load);
            // 
            // grd_ScoreBoard_View
            // 
            this.grd_ScoreBoard_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.grd_ScoreBoard_View.GridControl = this.grd_ScoreBoard;
            this.grd_ScoreBoard_View.Name = "grd_ScoreBoard_View";
            this.grd_ScoreBoard_View.OptionsFind.AlwaysVisible = true;
            this.grd_ScoreBoard_View.OptionsView.ShowGroupPanel = false;
            this.grd_ScoreBoard_View.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grd_ScoreBoard_View_RowUpdated);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MAKQ";
            this.gridColumn1.FieldName = "MAKQ";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã số học sinh";
            this.gridColumn2.FieldName = "MSHS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Họ Tên";
            this.gridColumn3.FieldName = "HOTEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 244;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên lớp";
            this.gridColumn9.FieldName = "TENLOP";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 131;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tên Môn";
            this.gridColumn10.FieldName = "TENMH";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.FixedWidth = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 104;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Học kỳ";
            this.gridColumn4.FieldName = "HOCKY";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 73;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điểm 15 phút";
            this.gridColumn5.FieldName = "DIEM15";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 134;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Điểm 1 tiết";
            this.gridColumn6.FieldName = "DIEM1TIET";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 130;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Điểm cuối kỳ";
            this.gridColumn7.FieldName = "DIEMCUOIKY";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 125;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Điểm Trung bình";
            this.gridColumn8.FieldName = "DIEMTB";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 127;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(97, 155);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_ScoreBoardDetail_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(0, 155);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 33);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // uc_ScoreBoardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pictureBox1);
            this.Name = "uc_ScoreBoardList";
            this.Size = new System.Drawing.Size(1188, 665);
            this.Load += new System.EventHandler(this.uc_ScoreBoardList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraGrid.GridControl grd_ScoreBoard;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ScoreBoard_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}
