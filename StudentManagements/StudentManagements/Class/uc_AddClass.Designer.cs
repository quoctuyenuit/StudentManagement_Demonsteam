namespace StudentManagements.Class
{
    partial class uc_AddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_AddClass));
            this.panel15 = new System.Windows.Forms.Panel();
            this.grd_SubjectList_AddClass = new DevExpress.XtraGrid.GridControl();
            this.grd_SubjectList_AddClass_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColumn_MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_AddSubjectsForClass_AddClass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DeleteStudentInClass_AddClass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddStudentForClass_AddClass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save_AddClass = new DevExpress.XtraEditors.SimpleButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.grd_StudentList_AddClass = new DevExpress.XtraGrid.GridControl();
            this.grd_StudentList_AddClass_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addClassPanel = new System.Windows.Forms.Panel();
            this.txt_Year_AddClass = new DevExpress.XtraEditors.TextEdit();
            this.txt_ClassTotal_AddClass = new DevExpress.XtraEditors.TextEdit();
            this.txt_ClassName_AddClass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_AddClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_AddClass_View)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass_View)).BeginInit();
            this.addClassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Year_AddClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_AddClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_AddClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.Controls.Add(this.grd_SubjectList_AddClass);
            this.panel15.Location = new System.Drawing.Point(931, 216);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(258, 469);
            this.panel15.TabIndex = 18;
            // 
            // grd_SubjectList_AddClass
            // 
            this.grd_SubjectList_AddClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_SubjectList_AddClass.Location = new System.Drawing.Point(0, 0);
            this.grd_SubjectList_AddClass.MainView = this.grd_SubjectList_AddClass_View;
            this.grd_SubjectList_AddClass.Name = "grd_SubjectList_AddClass";
            this.grd_SubjectList_AddClass.Size = new System.Drawing.Size(258, 469);
            this.grd_SubjectList_AddClass.TabIndex = 0;
            this.grd_SubjectList_AddClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_SubjectList_AddClass_View});
            // 
            // grd_SubjectList_AddClass_View
            // 
            this.grd_SubjectList_AddClass_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColumn_MAMH,
            this.gridColumn57});
            this.grd_SubjectList_AddClass_View.GridControl = this.grd_SubjectList_AddClass;
            this.grd_SubjectList_AddClass_View.Name = "grd_SubjectList_AddClass_View";
            this.grd_SubjectList_AddClass_View.OptionsBehavior.Editable = false;
            this.grd_SubjectList_AddClass_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_SubjectList_AddClass_View.OptionsSelection.MultiSelect = true;
            this.grd_SubjectList_AddClass_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grd_SubjectList_AddClass_View.OptionsView.ShowGroupPanel = false;
            this.grd_SubjectList_AddClass_View.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grd_SubjectList_AddClass_View_SelectionChanged);
            // 
            // grdColumn_MAMH
            // 
            this.grdColumn_MAMH.Caption = "MAMH";
            this.grdColumn_MAMH.FieldName = "MAMH";
            this.grdColumn_MAMH.Name = "grdColumn_MAMH";
            // 
            // gridColumn57
            // 
            this.gridColumn57.Caption = "Tên môn học";
            this.gridColumn57.FieldName = "TENMH";
            this.gridColumn57.Name = "gridColumn57";
            this.gridColumn57.Visible = true;
            this.gridColumn57.VisibleIndex = 1;
            // 
            // btn_AddSubjectsForClass_AddClass
            // 
            this.btn_AddSubjectsForClass_AddClass.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddSubjectsForClass_AddClass.Image")));
            this.btn_AddSubjectsForClass_AddClass.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_AddSubjectsForClass_AddClass.Location = new System.Drawing.Point(938, 154);
            this.btn_AddSubjectsForClass_AddClass.Name = "btn_AddSubjectsForClass_AddClass";
            this.btn_AddSubjectsForClass_AddClass.Size = new System.Drawing.Size(75, 45);
            this.btn_AddSubjectsForClass_AddClass.TabIndex = 17;
            this.btn_AddSubjectsForClass_AddClass.Click += new System.EventHandler(this.btn_AddSubjectsForClass_AddClass_Click);
            // 
            // btn_DeleteStudentInClass_AddClass
            // 
            this.btn_DeleteStudentInClass_AddClass.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteStudentInClass_AddClass.Image")));
            this.btn_DeleteStudentInClass_AddClass.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_DeleteStudentInClass_AddClass.Location = new System.Drawing.Point(776, 155);
            this.btn_DeleteStudentInClass_AddClass.Name = "btn_DeleteStudentInClass_AddClass";
            this.btn_DeleteStudentInClass_AddClass.Size = new System.Drawing.Size(75, 45);
            this.btn_DeleteStudentInClass_AddClass.TabIndex = 16;
            this.btn_DeleteStudentInClass_AddClass.Click += new System.EventHandler(this.btn_DeleteStudentInClass_AddClass_Click);
            // 
            // btn_AddStudentForClass_AddClass
            // 
            this.btn_AddStudentForClass_AddClass.Image = global::StudentManagements.Properties.Resources.addStudentIcon;
            this.btn_AddStudentForClass_AddClass.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_AddStudentForClass_AddClass.Location = new System.Drawing.Point(857, 154);
            this.btn_AddStudentForClass_AddClass.Name = "btn_AddStudentForClass_AddClass";
            this.btn_AddStudentForClass_AddClass.Size = new System.Drawing.Size(75, 45);
            this.btn_AddStudentForClass_AddClass.TabIndex = 12;
            this.btn_AddStudentForClass_AddClass.Click += new System.EventHandler(this.btn_AddStudentForClass_AddClass_Click);
            // 
            // btn_Save_AddClass
            // 
            this.btn_Save_AddClass.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_AddClass.Image")));
            this.btn_Save_AddClass.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Save_AddClass.Location = new System.Drawing.Point(695, 155);
            this.btn_Save_AddClass.Name = "btn_Save_AddClass";
            this.btn_Save_AddClass.Size = new System.Drawing.Size(75, 45);
            this.btn_Save_AddClass.TabIndex = 11;
            this.btn_Save_AddClass.Click += new System.EventHandler(this.btn_Save_AddClass_Click);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.grd_StudentList_AddClass);
            this.panel12.Location = new System.Drawing.Point(0, 205);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(931, 480);
            this.panel12.TabIndex = 14;
            // 
            // grd_StudentList_AddClass
            // 
            this.grd_StudentList_AddClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList_AddClass.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList_AddClass.MainView = this.grd_StudentList_AddClass_View;
            this.grd_StudentList_AddClass.Name = "grd_StudentList_AddClass";
            this.grd_StudentList_AddClass.Size = new System.Drawing.Size(931, 480);
            this.grd_StudentList_AddClass.TabIndex = 0;
            this.grd_StudentList_AddClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_StudentList_AddClass_View});
            // 
            // grd_StudentList_AddClass_View
            // 
            this.grd_StudentList_AddClass_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn41,
            this.gridColumn42,
            this.gridColumn43,
            this.gridColumn44});
            this.grd_StudentList_AddClass_View.GridControl = this.grd_StudentList_AddClass;
            this.grd_StudentList_AddClass_View.Name = "grd_StudentList_AddClass_View";
            this.grd_StudentList_AddClass_View.OptionsBehavior.Editable = false;
            this.grd_StudentList_AddClass_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_StudentList_AddClass_View.OptionsSelection.MultiSelect = true;
            this.grd_StudentList_AddClass_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grd_StudentList_AddClass_View.OptionsView.ShowGroupPanel = false;
            this.grd_StudentList_AddClass_View.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grd_StudentList_AddClass_View_SelectionChanged);
            // 
            // gridColumn39
            // 
            this.gridColumn39.Caption = "MSHS";
            this.gridColumn39.FieldName = "MSHS";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.OptionsColumn.FixedWidth = true;
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 1;
            this.gridColumn39.Width = 86;
            // 
            // gridColumn40
            // 
            this.gridColumn40.Caption = "Họ Tên";
            this.gridColumn40.FieldName = "HOTEN";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.OptionsColumn.FixedWidth = true;
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 2;
            this.gridColumn40.Width = 221;
            // 
            // gridColumn41
            // 
            this.gridColumn41.Caption = "Ngày Sinh";
            this.gridColumn41.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn41.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn41.FieldName = "NGSINH";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.OptionsColumn.FixedWidth = true;
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 3;
            this.gridColumn41.Width = 164;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "Email";
            this.gridColumn42.FieldName = "EMAIL";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 4;
            this.gridColumn42.Width = 229;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "Giới Tính";
            this.gridColumn43.FieldName = "GIOITINH";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.OptionsColumn.FixedWidth = true;
            this.gridColumn43.Visible = true;
            this.gridColumn43.VisibleIndex = 5;
            this.gridColumn43.Width = 80;
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "Địa Chỉ";
            this.gridColumn44.FieldName = "DIACHI";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.Visible = true;
            this.gridColumn44.VisibleIndex = 6;
            this.gridColumn44.Width = 388;
            // 
            // addClassPanel
            // 
            this.addClassPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addClassPanel.Controls.Add(this.txt_Year_AddClass);
            this.addClassPanel.Controls.Add(this.txt_ClassTotal_AddClass);
            this.addClassPanel.Controls.Add(this.txt_ClassName_AddClass);
            this.addClassPanel.Controls.Add(this.labelControl29);
            this.addClassPanel.Controls.Add(this.labelControl24);
            this.addClassPanel.Controls.Add(this.labelControl28);
            this.addClassPanel.Location = new System.Drawing.Point(0, 154);
            this.addClassPanel.Name = "addClassPanel";
            this.addClassPanel.Size = new System.Drawing.Size(689, 45);
            this.addClassPanel.TabIndex = 15;
            // 
            // txt_Year_AddClass
            // 
            this.txt_Year_AddClass.Location = new System.Drawing.Point(535, 8);
            this.txt_Year_AddClass.Name = "txt_Year_AddClass";
            this.txt_Year_AddClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Year_AddClass.Properties.Appearance.Options.UseFont = true;
            this.txt_Year_AddClass.Size = new System.Drawing.Size(142, 28);
            this.txt_Year_AddClass.TabIndex = 1;
            this.txt_Year_AddClass.ToolTip = "2015-2016";
            // 
            // txt_ClassTotal_AddClass
            // 
            this.txt_ClassTotal_AddClass.Enabled = false;
            this.txt_ClassTotal_AddClass.Location = new System.Drawing.Point(325, 8);
            this.txt_ClassTotal_AddClass.Name = "txt_ClassTotal_AddClass";
            this.txt_ClassTotal_AddClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassTotal_AddClass.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassTotal_AddClass.Size = new System.Drawing.Size(108, 28);
            this.txt_ClassTotal_AddClass.TabIndex = 3;
            // 
            // txt_ClassName_AddClass
            // 
            this.txt_ClassName_AddClass.Location = new System.Drawing.Point(76, 8);
            this.txt_ClassName_AddClass.Name = "txt_ClassName_AddClass";
            this.txt_ClassName_AddClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassName_AddClass.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassName_AddClass.Size = new System.Drawing.Size(190, 28);
            this.txt_ClassName_AddClass.TabIndex = 0;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl29.Location = new System.Drawing.Point(3, 11);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(61, 21);
            this.labelControl29.TabIndex = 2;
            this.labelControl29.Text = "Tên lớp:";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl24.Location = new System.Drawing.Point(452, 11);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(73, 21);
            this.labelControl24.TabIndex = 1;
            this.labelControl24.Text = "Năm Học:";
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl28.Location = new System.Drawing.Point(278, 11);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(41, 21);
            this.labelControl28.TabIndex = 1;
            this.labelControl28.Text = "Sỉ số:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox11.Image = global::StudentManagements.Properties.Resources.addClassTitle;
            this.pictureBox11.Location = new System.Drawing.Point(453, 33);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(282, 44);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // uc_AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.btn_AddSubjectsForClass_AddClass);
            this.Controls.Add(this.btn_DeleteStudentInClass_AddClass);
            this.Controls.Add(this.btn_AddStudentForClass_AddClass);
            this.Controls.Add(this.btn_Save_AddClass);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.addClassPanel);
            this.Controls.Add(this.pictureBox11);
            this.Name = "uc_AddClass";
            this.Size = new System.Drawing.Size(1188, 685);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_AddClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_AddClass_View)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass_View)).EndInit();
            this.addClassPanel.ResumeLayout(false);
            this.addClassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Year_AddClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_AddClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_AddClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraGrid.GridControl grd_SubjectList_AddClass;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_SubjectList_AddClass_View;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn57;
        private DevExpress.XtraEditors.SimpleButton btn_AddSubjectsForClass_AddClass;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteStudentInClass_AddClass;
        private DevExpress.XtraEditors.SimpleButton btn_AddStudentForClass_AddClass;
        private DevExpress.XtraEditors.SimpleButton btn_Save_AddClass;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraGrid.GridControl grd_StudentList_AddClass;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_AddClass_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private System.Windows.Forms.Panel addClassPanel;
        private DevExpress.XtraEditors.TextEdit txt_Year_AddClass;
        private DevExpress.XtraEditors.TextEdit txt_ClassTotal_AddClass;
        private DevExpress.XtraEditors.TextEdit txt_ClassName_AddClass;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}
