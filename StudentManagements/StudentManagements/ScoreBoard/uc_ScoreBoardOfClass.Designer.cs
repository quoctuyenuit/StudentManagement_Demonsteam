namespace StudentManagements.ScoreBoard
{
    partial class uc_ScoreBoardOfClass
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
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grd_ScoreBoard = new DevExpress.XtraGrid.GridControl();
            this.grd_ScoreBoard_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ClassName = new DevExpress.XtraEditors.LabelControl();
            this.cbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = global::StudentManagements.Properties.Resources.scoreBoardListTitle;
            this.pictureBox9.Location = new System.Drawing.Point(353, 33);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(482, 44);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl17.Location = new System.Drawing.Point(490, 102);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(137, 30);
            this.labelControl17.TabIndex = 20;
            this.labelControl17.Text = "Class Name:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grd_ScoreBoard);
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 460);
            this.panel1.TabIndex = 22;
            // 
            // grd_ScoreBoard
            // 
            this.grd_ScoreBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ScoreBoard.Location = new System.Drawing.Point(0, 0);
            this.grd_ScoreBoard.MainView = this.grd_ScoreBoard_View;
            this.grd_ScoreBoard.Name = "grd_ScoreBoard";
            this.grd_ScoreBoard.Size = new System.Drawing.Size(1188, 460);
            this.grd_ScoreBoard.TabIndex = 0;
            this.grd_ScoreBoard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ScoreBoard_View});
            // 
            // grd_ScoreBoard_View
            // 
            this.grd_ScoreBoard_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn9,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.grd_ScoreBoard_View.GridControl = this.grd_ScoreBoard;
            this.grd_ScoreBoard_View.Name = "grd_ScoreBoard_View";
            this.grd_ScoreBoard_View.OptionsFind.AlwaysVisible = true;
            this.grd_ScoreBoard_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_ScoreBoard_View.OptionsView.ShowGroupPanel = false;
            this.grd_ScoreBoard_View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grd_ScoreBoard_View_FocusedRowChanged);
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
            this.gridColumn2.Caption = "Mã số";
            this.gridColumn2.FieldName = "MSHS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 110;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Họ Tên";
            this.gridColumn3.FieldName = "HOTEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 262;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điểm miệng 1";
            this.gridColumn4.FieldName = "DIEMMIENG1";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 133;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Điểm miệng 2";
            this.gridColumn9.FieldName = "DIEMMIENG2";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 142;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điểm 15 phút";
            this.gridColumn5.FieldName = "DIEM15";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 132;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Điểm 1 tiết";
            this.gridColumn6.FieldName = "DIEM1TIET";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 107;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Điểm Cuối Kỳ";
            this.gridColumn7.FieldName = "DIEMCUOIKY";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 117;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Điểm Trung Bình";
            this.gridColumn8.FieldName = "DIEMTB";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 165;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(0, 166);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 33);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(97, 166);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ClassName.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_ClassName.Location = new System.Drawing.Point(633, 102);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(57, 30);
            this.txt_ClassName.TabIndex = 20;
            this.txt_ClassName.Text = "10A1";
            // 
            // cbSubject
            // 
            this.cbSubject.Location = new System.Drawing.Point(200, 175);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSubject.Properties.Appearance.Options.UseFont = true;
            this.cbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSubject.Size = new System.Drawing.Size(158, 24);
            this.cbSubject.TabIndex = 27;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // cbSemester
            // 
            this.cbSemester.Location = new System.Drawing.Point(364, 175);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSemester.Properties.Appearance.Options.UseFont = true;
            this.cbSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSemester.Size = new System.Drawing.Size(97, 24);
            this.cbSemester.TabIndex = 28;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(200, 154);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 21);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Subject";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(364, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 21);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Semester";
            // 
            // uc_ScoreBoardOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ClassName);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.pictureBox9);
            this.Name = "uc_ScoreBoardOfClass";
            this.Size = new System.Drawing.Size(1188, 665);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoard_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //
        //
        //
        private System.Windows.Forms.PictureBox pictureBox9;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grd_ScoreBoard;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ScoreBoard_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.LabelControl txt_ClassName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.ComboBoxEdit cbSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cbSemester;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
