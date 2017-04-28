namespace StudentManagements.Class
{
    partial class uc_ClassInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ClassInformation));
            this.panel14 = new System.Windows.Forms.Panel();
            this.grd_SubjectList_ClassInformation = new DevExpress.XtraGrid.GridControl();
            this.grd_SubjectList_ClassInformation_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColumn_SubjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColumn_SubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grd_StudentList_ClassInformation = new DevExpress.XtraGrid.GridControl();
            this.grd_StudentList_ClassInformation_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.navFrame_ClassInformation = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPage_ClassDetail = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txt_Year_ClassInformation = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassTotal_ClassInformation = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassName_ClassInformation = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.navPage_ClassDetail_Edit = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txt_Year_ClassInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.txt_ClassTotal_ClassInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassName_ClassInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddSubjectsForClass_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddStudentForClass_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DeleteStudent_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_Edit_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_ClassInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_ClassInformation_View)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_ClassInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_ClassInformation_View)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_ClassInformation)).BeginInit();
            this.navFrame_ClassInformation.SuspendLayout();
            this.navPage_ClassDetail.SuspendLayout();
            this.navPage_ClassDetail_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Year_ClassInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_ClassInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_ClassInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.Controls.Add(this.grd_SubjectList_ClassInformation);
            this.panel14.Location = new System.Drawing.Point(832, 205);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(356, 460);
            this.panel14.TabIndex = 16;
            // 
            // grd_SubjectList_ClassInformation
            // 
            this.grd_SubjectList_ClassInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_SubjectList_ClassInformation.Location = new System.Drawing.Point(0, 0);
            this.grd_SubjectList_ClassInformation.MainView = this.grd_SubjectList_ClassInformation_View;
            this.grd_SubjectList_ClassInformation.Name = "grd_SubjectList_ClassInformation";
            this.grd_SubjectList_ClassInformation.Size = new System.Drawing.Size(356, 460);
            this.grd_SubjectList_ClassInformation.TabIndex = 0;
            this.grd_SubjectList_ClassInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_SubjectList_ClassInformation_View});
            // 
            // grd_SubjectList_ClassInformation_View
            // 
            this.grd_SubjectList_ClassInformation_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColumn_SubjectID,
            this.grdColumn_SubjectName,
            this.gridColumn3});
            this.grd_SubjectList_ClassInformation_View.GridControl = this.grd_SubjectList_ClassInformation;
            this.grd_SubjectList_ClassInformation_View.Name = "grd_SubjectList_ClassInformation_View";
            this.grd_SubjectList_ClassInformation_View.OptionsBehavior.Editable = false;
            this.grd_SubjectList_ClassInformation_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_SubjectList_ClassInformation_View.OptionsView.ShowGroupPanel = false;
            this.grd_SubjectList_ClassInformation_View.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grd_SubjectList_ClassInformation_View_SelectionChanged);
            // 
            // grdColumn_SubjectID
            // 
            this.grdColumn_SubjectID.Caption = "gridColumn3";
            this.grdColumn_SubjectID.FieldName = "MAMH";
            this.grdColumn_SubjectID.Name = "grdColumn_SubjectID";
            // 
            // grdColumn_SubjectName
            // 
            this.grdColumn_SubjectName.Caption = "Tên Môn Học";
            this.grdColumn_SubjectName.FieldName = "TENMH";
            this.grdColumn_SubjectName.Name = "grdColumn_SubjectName";
            this.grdColumn_SubjectName.Visible = true;
            this.grdColumn_SubjectName.VisibleIndex = 0;
            this.grdColumn_SubjectName.Width = 131;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giáo Viên";
            this.gridColumn3.FieldName = "HOTEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 205;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.grd_StudentList_ClassInformation);
            this.panel8.Location = new System.Drawing.Point(-1, 205);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(833, 460);
            this.panel8.TabIndex = 10;
            // 
            // grd_StudentList_ClassInformation
            // 
            this.grd_StudentList_ClassInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList_ClassInformation.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList_ClassInformation.MainView = this.grd_StudentList_ClassInformation_View;
            this.grd_StudentList_ClassInformation.Name = "grd_StudentList_ClassInformation";
            this.grd_StudentList_ClassInformation.Size = new System.Drawing.Size(833, 460);
            this.grd_StudentList_ClassInformation.TabIndex = 2;
            this.grd_StudentList_ClassInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_StudentList_ClassInformation_View});
            // 
            // grd_StudentList_ClassInformation_View
            // 
            this.grd_StudentList_ClassInformation_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.grd_StudentList_ClassInformation_View.GridControl = this.grd_StudentList_ClassInformation;
            this.grd_StudentList_ClassInformation_View.Name = "grd_StudentList_ClassInformation_View";
            this.grd_StudentList_ClassInformation_View.OptionsBehavior.Editable = false;
            this.grd_StudentList_ClassInformation_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelect = true;
            this.grd_StudentList_ClassInformation_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grd_StudentList_ClassInformation_View.OptionsView.ShowGroupPanel = false;
            this.grd_StudentList_ClassInformation_View.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grd_StudentList_ClassInformation_View_SelectionChanged);
            this.grd_StudentList_ClassInformation_View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grd_StudentList_ClassInformation_View_FocusedRowChanged);
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "MSHS";
            this.gridColumn12.FieldName = "MSHS";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.FixedWidth = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 63;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Họ Tên";
            this.gridColumn13.FieldName = "HOTEN";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.FixedWidth = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 178;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Ngày Sinh";
            this.gridColumn14.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn14.FieldName = "NGSINH";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.FixedWidth = true;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 134;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Email";
            this.gridColumn15.FieldName = "EMAIL";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 144;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Giới Tính";
            this.gridColumn16.FieldName = "GIOITINH";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.FixedWidth = true;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            this.gridColumn16.Width = 79;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Địa Chỉ";
            this.gridColumn17.FieldName = "DIACHI";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 6;
            this.gridColumn17.Width = 263;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.navFrame_ClassInformation);
            this.panel7.Location = new System.Drawing.Point(-1, 154);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(590, 45);
            this.panel7.TabIndex = 11;
            // 
            // navFrame_ClassInformation
            // 
            this.navFrame_ClassInformation.Controls.Add(this.navPage_ClassDetail);
            this.navFrame_ClassInformation.Controls.Add(this.navPage_ClassDetail_Edit);
            this.navFrame_ClassInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame_ClassInformation.Location = new System.Drawing.Point(0, 0);
            this.navFrame_ClassInformation.Name = "navFrame_ClassInformation";
            this.navFrame_ClassInformation.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPage_ClassDetail,
            this.navPage_ClassDetail_Edit});
            this.navFrame_ClassInformation.SelectedPage = this.navPage_ClassDetail;
            this.navFrame_ClassInformation.Size = new System.Drawing.Size(588, 43);
            this.navFrame_ClassInformation.TabIndex = 0;
            this.navFrame_ClassInformation.Text = "navigationFrame1";
            this.navFrame_ClassInformation.TransitionAnimationProperties.FrameCount = 0;
            this.navFrame_ClassInformation.TransitionAnimationProperties.FrameInterval = 0;
            // 
            // navPage_ClassDetail
            // 
            this.navPage_ClassDetail.Caption = "navPage_ClassDetail";
            this.navPage_ClassDetail.Controls.Add(this.txt_Year_ClassInformation);
            this.navPage_ClassDetail.Controls.Add(this.labelControl25);
            this.navPage_ClassDetail.Controls.Add(this.labelControl12);
            this.navPage_ClassDetail.Controls.Add(this.txt_ClassTotal_ClassInformation);
            this.navPage_ClassDetail.Controls.Add(this.txt_ClassName_ClassInformation);
            this.navPage_ClassDetail.Controls.Add(this.labelControl10);
            this.navPage_ClassDetail.Name = "navPage_ClassDetail";
            this.navPage_ClassDetail.Size = new System.Drawing.Size(588, 43);
            // 
            // txt_Year_ClassInformation
            // 
            this.txt_Year_ClassInformation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Year_ClassInformation.Location = new System.Drawing.Point(484, 12);
            this.txt_Year_ClassInformation.Name = "txt_Year_ClassInformation";
            this.txt_Year_ClassInformation.Size = new System.Drawing.Size(36, 21);
            this.txt_Year_ClassInformation.TabIndex = 0;
            this.txt_Year_ClassInformation.Text = "2017";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl25.Location = new System.Drawing.Point(394, 12);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(71, 21);
            this.labelControl25.TabIndex = 0;
            this.labelControl25.Text = "Năm học:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Location = new System.Drawing.Point(242, 12);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(41, 21);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Sỉ số:";
            // 
            // txt_ClassTotal_ClassInformation
            // 
            this.txt_ClassTotal_ClassInformation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassTotal_ClassInformation.Location = new System.Drawing.Point(305, 12);
            this.txt_ClassTotal_ClassInformation.Name = "txt_ClassTotal_ClassInformation";
            this.txt_ClassTotal_ClassInformation.Size = new System.Drawing.Size(18, 21);
            this.txt_ClassTotal_ClassInformation.TabIndex = 0;
            this.txt_ClassTotal_ClassInformation.Text = "45";
            // 
            // txt_ClassName_ClassInformation
            // 
            this.txt_ClassName_ClassInformation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassName_ClassInformation.Location = new System.Drawing.Point(109, 12);
            this.txt_ClassName_ClassInformation.Name = "txt_ClassName_ClassInformation";
            this.txt_ClassName_ClassInformation.Size = new System.Drawing.Size(38, 21);
            this.txt_ClassName_ClassInformation.TabIndex = 0;
            this.txt_ClassName_ClassInformation.Text = "10A1";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Location = new System.Drawing.Point(19, 12);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 21);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Tên lớp:";
            // 
            // navPage_ClassDetail_Edit
            // 
            this.navPage_ClassDetail_Edit.Caption = "navPage_ClassDetail_Edit";
            this.navPage_ClassDetail_Edit.Controls.Add(this.txt_Year_ClassInformation_Edit);
            this.navPage_ClassDetail_Edit.Controls.Add(this.txt_ClassTotal_ClassInformation_Edit);
            this.navPage_ClassDetail_Edit.Controls.Add(this.labelControl26);
            this.navPage_ClassDetail_Edit.Controls.Add(this.txt_ClassName_ClassInformation_Edit);
            this.navPage_ClassDetail_Edit.Controls.Add(this.labelControl14);
            this.navPage_ClassDetail_Edit.Controls.Add(this.labelControl15);
            this.navPage_ClassDetail_Edit.Name = "navPage_ClassDetail_Edit";
            this.navPage_ClassDetail_Edit.Size = new System.Drawing.Size(588, 43);
            // 
            // txt_Year_ClassInformation_Edit
            // 
            this.txt_Year_ClassInformation_Edit.Location = new System.Drawing.Point(471, 9);
            this.txt_Year_ClassInformation_Edit.Name = "txt_Year_ClassInformation_Edit";
            this.txt_Year_ClassInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Year_ClassInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_Year_ClassInformation_Edit.Size = new System.Drawing.Size(100, 28);
            this.txt_Year_ClassInformation_Edit.TabIndex = 3;
            // 
            // txt_ClassTotal_ClassInformation_Edit
            // 
            this.txt_ClassTotal_ClassInformation_Edit.Enabled = false;
            this.txt_ClassTotal_ClassInformation_Edit.Location = new System.Drawing.Point(289, 9);
            this.txt_ClassTotal_ClassInformation_Edit.Name = "txt_ClassTotal_ClassInformation_Edit";
            this.txt_ClassTotal_ClassInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassTotal_ClassInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassTotal_ClassInformation_Edit.Size = new System.Drawing.Size(85, 28);
            this.txt_ClassTotal_ClassInformation_Edit.TabIndex = 3;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl26.Location = new System.Drawing.Point(394, 12);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(71, 21);
            this.labelControl26.TabIndex = 1;
            this.labelControl26.Text = "Năm học:";
            // 
            // txt_ClassName_ClassInformation_Edit
            // 
            this.txt_ClassName_ClassInformation_Edit.Location = new System.Drawing.Point(98, 9);
            this.txt_ClassName_ClassInformation_Edit.Name = "txt_ClassName_ClassInformation_Edit";
            this.txt_ClassName_ClassInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassName_ClassInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassName_ClassInformation_Edit.Size = new System.Drawing.Size(107, 28);
            this.txt_ClassName_ClassInformation_Edit.TabIndex = 3;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl14.Location = new System.Drawing.Point(242, 12);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(41, 21);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "Sỉ số:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl15.Location = new System.Drawing.Point(19, 12);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(61, 21);
            this.labelControl15.TabIndex = 2;
            this.labelControl15.Text = "Tên lớp:";
            // 
            // btn_AddSubjectsForClass_ClassInformation
            // 
            this.btn_AddSubjectsForClass_ClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddSubjectsForClass_ClassInformation.Image")));
            this.btn_AddSubjectsForClass_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_AddSubjectsForClass_ClassInformation.Location = new System.Drawing.Point(838, 154);
            this.btn_AddSubjectsForClass_ClassInformation.Name = "btn_AddSubjectsForClass_ClassInformation";
            this.btn_AddSubjectsForClass_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_AddSubjectsForClass_ClassInformation.TabIndex = 17;
            this.btn_AddSubjectsForClass_ClassInformation.Click += new System.EventHandler(this.btn_AddSubjectsForClass_ClassInformation_Click);
            // 
            // btn_AddStudentForClass_ClassInformation
            // 
            this.btn_AddStudentForClass_ClassInformation.Image = global::StudentManagements.Properties.Resources.addStudentIcon;
            this.btn_AddStudentForClass_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_AddStudentForClass_ClassInformation.Location = new System.Drawing.Point(757, 154);
            this.btn_AddStudentForClass_ClassInformation.Name = "btn_AddStudentForClass_ClassInformation";
            this.btn_AddStudentForClass_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_AddStudentForClass_ClassInformation.TabIndex = 15;
            this.btn_AddStudentForClass_ClassInformation.Click += new System.EventHandler(this.btn_AddStudentForClass_ClassInformation_Click);
            // 
            // btn_DeleteStudent_ClassInformation
            // 
            this.btn_DeleteStudent_ClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteStudent_ClassInformation.Image")));
            this.btn_DeleteStudent_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_DeleteStudent_ClassInformation.Location = new System.Drawing.Point(676, 154);
            this.btn_DeleteStudent_ClassInformation.Name = "btn_DeleteStudent_ClassInformation";
            this.btn_DeleteStudent_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_DeleteStudent_ClassInformation.TabIndex = 14;
            this.btn_DeleteStudent_ClassInformation.Click += new System.EventHandler(this.btn_DeleteStudent_ClassInformation_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = global::StudentManagements.Properties.Resources.classInformationTitle;
            this.pictureBox6.Location = new System.Drawing.Point(322, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(543, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // btn_Edit_ClassInformation
            // 
            this.btn_Edit_ClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit_ClassInformation.Image")));
            this.btn_Edit_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Edit_ClassInformation.Location = new System.Drawing.Point(595, 153);
            this.btn_Edit_ClassInformation.Name = "btn_Edit_ClassInformation";
            this.btn_Edit_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Edit_ClassInformation.TabIndex = 13;
            this.btn_Edit_ClassInformation.Click += new System.EventHandler(this.btn_Edit_ClassInformation_Click);
            // 
            // btn_Save_ClassInformation
            // 
            this.btn_Save_ClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_ClassInformation.Image")));
            this.btn_Save_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Save_ClassInformation.Location = new System.Drawing.Point(595, 154);
            this.btn_Save_ClassInformation.Name = "btn_Save_ClassInformation";
            this.btn_Save_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Save_ClassInformation.TabIndex = 12;
            this.btn_Save_ClassInformation.Click += new System.EventHandler(this.btn_Save_ClassInformation_Click);
            // 
            // uc_ClassInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_AddSubjectsForClass_ClassInformation);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.btn_AddStudentForClass_ClassInformation);
            this.Controls.Add(this.btn_DeleteStudent_ClassInformation);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btn_Edit_ClassInformation);
            this.Controls.Add(this.btn_Save_ClassInformation);
            this.Name = "uc_ClassInformation";
            this.Size = new System.Drawing.Size(1188, 665);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_ClassInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectList_ClassInformation_View)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_ClassInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_ClassInformation_View)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_ClassInformation)).EndInit();
            this.navFrame_ClassInformation.ResumeLayout(false);
            this.navPage_ClassDetail.ResumeLayout(false);
            this.navPage_ClassDetail.PerformLayout();
            this.navPage_ClassDetail_Edit.ResumeLayout(false);
            this.navPage_ClassDetail_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Year_ClassInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_ClassInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_ClassInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_AddSubjectsForClass_ClassInformation;
        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraGrid.GridControl grd_SubjectList_ClassInformation;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_SubjectList_ClassInformation_View;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_SubjectID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_SubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_AddStudentForClass_ClassInformation;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteStudent_ClassInformation;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraGrid.GridControl grd_StudentList_ClassInformation;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_ClassInformation_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame_ClassInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail;
        private DevExpress.XtraEditors.LabelControl txt_Year_ClassInformation;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl txt_ClassTotal_ClassInformation;
        private DevExpress.XtraEditors.LabelControl txt_ClassName_ClassInformation;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail_Edit;
        private DevExpress.XtraEditors.TextEdit txt_Year_ClassInformation_Edit;
        private DevExpress.XtraEditors.TextEdit txt_ClassTotal_ClassInformation_Edit;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txt_ClassName_ClassInformation_Edit;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_ClassInformation;
        private DevExpress.XtraEditors.SimpleButton btn_Save_ClassInformation;
    }
}
