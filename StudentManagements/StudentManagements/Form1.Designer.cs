namespace StudentManagements
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Home_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddStudent_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddClass_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_FindStudents_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddReport_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChangeRules_Main = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.skinButton = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btn_FindStudent_Main = new DevExpress.XtraBars.BarSubItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Students_Actions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Class_Actions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_ScoreBoard_Actions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navFrame_Main = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPage_StudentsList = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grd_StudentList = new DevExpress.XtraGrid.GridControl();
            this.grd_StudentList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Delete_StudentList = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Detail_StudentList = new DevExpress.XtraEditors.SimpleButton();
            this.navPage_ClassList = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Delete_ClassList = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Detail_ClassList = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grd_ClassList = new DevExpress.XtraGrid.GridControl();
            this.grd_ClassList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navPage_StudentInformation = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btn_Edit_StudentInformation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save_StudentInformation = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.navFrame_StudentInformation = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPage_StudentEdit_StudentInformation = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cb_StudentSex_StudentInformation_Edit = new System.Windows.Forms.ComboBox();
            this.txt_StudentEmail_StudentInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.txt_StudentAddress_StudentInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.txt_StudentName_StudentInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.txt_StudentID_StudentInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.cb_StudentDateOfBirth_StudentInformation_Edit = new DevExpress.XtraEditors.DateEdit();
            this.navPage_StudentDetail_StudentInformation = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txt_StudentSex_StudentInformation_Detail = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentAddress_StudentInformation_Detail = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentEmail_StudentInformation_Detail = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentDateOfBirth_StudentInformation_Detail = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentName_StudentInformation_Detail = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentID_StudentInformation_Detail = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.navPage_ClassInformation = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btn_Edit_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save_ClassInformation = new DevExpress.XtraEditors.SimpleButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grd_ClassInformation = new DevExpress.XtraGrid.GridControl();
            this.grd_ClassInformation_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.navFrame_ClassInformation = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPage_ClassDetail = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassTotal_ClassInformation = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassName_ClassInformation = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.navPage_ClassDetail_Edit = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txt_ClassTotal_ClassInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.txt_ClassName_ClassInformation_Edit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.navPage_ScoreBoardList = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btn_All_ScoreBoardList = new DevExpress.XtraEditors.SimpleButton();
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
            this.navPage_ScoreBoardDetail = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btn_Delete_ScoreBoardDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New_ScoreBoardDetail = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grd_ScoreBoardDetail = new DevExpress.XtraGrid.GridControl();
            this.grd_ScoreBoardDetail_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.navPage_AddStudent = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btn_Done_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.studentInformationPanel = new System.Windows.Forms.Panel();
            this.cb_StudentSex_AddStudent = new System.Windows.Forms.ComboBox();
            this.txt_StudentAddress_AddStudent = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentEmail_AddStudent = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentName_AddStudent = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cb_StudentDateOfBirth_AddStudent = new DevExpress.XtraEditors.DateEdit();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.navPage_CreateReports = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navPage_AddClass = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navPage_Home = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navPage_FindStudents = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navPage_ScoreBoardDetail2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cb_SelectSubject_ScoreBoardDetail = new System.Windows.Forms.ComboBox();
            this.txt_ClassID = new System.Windows.Forms.Label();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassName_ScoreBoardDetail2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save_ScoreBoardDetail2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete_ScoreBoardDetail2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.grd_ScoreBoardDetail2 = new DevExpress.XtraGrid.GridControl();
            this.grd_ScoreBoardDetail2_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.txt_ClassTotal_AddClass = new DevExpress.XtraEditors.TextEdit();
            this.txt_ClassName_AddClass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btn_AddStudentForClass_AddClass = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_Main)).BeginInit();
            this.navFrame_Main.SuspendLayout();
            this.navPage_StudentsList.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navPage_ClassList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList_View)).BeginInit();
            this.navPage_StudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_StudentInformation)).BeginInit();
            this.navFrame_StudentInformation.SuspendLayout();
            this.navPage_StudentEdit_StudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentEmail_StudentInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentAddress_StudentInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName_StudentInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID_StudentInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties)).BeginInit();
            this.navPage_StudentDetail_StudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.navPage_ClassInformation.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassInformation_View)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_ClassInformation)).BeginInit();
            this.navFrame_ClassInformation.SuspendLayout();
            this.navPage_ClassDetail.SuspendLayout();
            this.navPage_ClassDetail_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_ClassInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_ClassInformation_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.navPage_ScoreBoardList.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.navPage_ScoreBoardDetail.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.navPage_AddStudent.SuspendLayout();
            this.studentInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentEmail_AddStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName_AddStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.navPage_AddClass.SuspendLayout();
            this.navPage_FindStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.navPage_ScoreBoardDetail2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail2_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass_View)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_AddClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_AddClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_Home_Main,
            this.btn_AddStudent_Main,
            this.btn_AddClass_Main,
            this.btn_FindStudents_Main,
            this.btn_AddReport_Main,
            this.btn_ChangeRules_Main,
            this.barButtonItem1,
            this.skinButton,
            this.btn_FindStudent_Main,
            this.barWorkspaceMenuItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1438, 152);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btn_Home_Main
            // 
            this.btn_Home_Main.Caption = "Home";
            this.btn_Home_Main.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Home_Main.Glyph")));
            this.btn_Home_Main.Id = 1;
            this.btn_Home_Main.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Home_Main.LargeGlyph")));
            this.btn_Home_Main.Name = "btn_Home_Main";
            // 
            // btn_AddStudent_Main
            // 
            this.btn_AddStudent_Main.Caption = "Add Student";
            this.btn_AddStudent_Main.Id = 2;
            this.btn_AddStudent_Main.LargeGlyph = global::StudentManagements.Properties.Resources.addStudentIcon;
            this.btn_AddStudent_Main.Name = "btn_AddStudent_Main";
            this.btn_AddStudent_Main.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddStudent_Main_ItemClick);
            // 
            // btn_AddClass_Main
            // 
            this.btn_AddClass_Main.Caption = "Add Class";
            this.btn_AddClass_Main.Id = 3;
            this.btn_AddClass_Main.LargeGlyph = global::StudentManagements.Properties.Resources.addClassIcon;
            this.btn_AddClass_Main.Name = "btn_AddClass_Main";
            // 
            // btn_FindStudents_Main
            // 
            this.btn_FindStudents_Main.Id = 14;
            this.btn_FindStudents_Main.Name = "btn_FindStudents_Main";
            // 
            // btn_AddReport_Main
            // 
            this.btn_AddReport_Main.Caption = "Add Report";
            this.btn_AddReport_Main.Id = 5;
            this.btn_AddReport_Main.LargeGlyph = global::StudentManagements.Properties.Resources.reportIcon;
            this.btn_AddReport_Main.Name = "btn_AddReport_Main";
            // 
            // btn_ChangeRules_Main
            // 
            this.btn_ChangeRules_Main.Caption = "Change Rules";
            this.btn_ChangeRules_Main.Id = 6;
            this.btn_ChangeRules_Main.LargeGlyph = global::StudentManagements.Properties.Resources.changeRulesIcon;
            this.btn_ChangeRules_Main.Name = "btn_ChangeRules_Main";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // skinButton
            // 
            this.skinButton.Caption = "skinRibbonGalleryBarItem1";
            this.skinButton.Id = 8;
            this.skinButton.Name = "skinButton";
            // 
            // btn_FindStudent_Main
            // 
            this.btn_FindStudent_Main.Id = 15;
            this.btn_FindStudent_Main.Name = "btn_FindStudent_Main";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 13;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Home_Main);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AddStudent_Main, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AddClass_Main);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AddReport_Main);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ChangeRules_Main);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinButton, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accordionControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 643);
            this.panel1.TabIndex = 1;
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.ShowGroupExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(248, 643);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_Students_Actions,
            this.btn_Class_Actions,
            this.btn_ScoreBoard_Actions});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Actions";
            // 
            // btn_Students_Actions
            // 
            this.btn_Students_Actions.Name = "btn_Students_Actions";
            this.btn_Students_Actions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Students_Actions.Text = "Students";
            this.btn_Students_Actions.Click += new System.EventHandler(this.btn_Students_Actions_Click);
            // 
            // btn_Class_Actions
            // 
            this.btn_Class_Actions.Name = "btn_Class_Actions";
            this.btn_Class_Actions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Class_Actions.Text = "Class";
            this.btn_Class_Actions.Click += new System.EventHandler(this.btn_Class_Actions_Click);
            // 
            // btn_ScoreBoard_Actions
            // 
            this.btn_ScoreBoard_Actions.Name = "btn_ScoreBoard_Actions";
            this.btn_ScoreBoard_Actions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_ScoreBoard_Actions.Text = "ScoreBoard";
            this.btn_ScoreBoard_Actions.Click += new System.EventHandler(this.btn_ScoreBoard_Actions_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.navFrame_Main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(248, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 643);
            this.panel2.TabIndex = 2;
            // 
            // navFrame_Main
            // 
            this.navFrame_Main.Controls.Add(this.navPage_StudentsList);
            this.navFrame_Main.Controls.Add(this.navPage_ClassList);
            this.navFrame_Main.Controls.Add(this.navPage_StudentInformation);
            this.navFrame_Main.Controls.Add(this.navPage_ClassInformation);
            this.navFrame_Main.Controls.Add(this.navPage_ScoreBoardList);
            this.navFrame_Main.Controls.Add(this.navPage_ScoreBoardDetail);
            this.navFrame_Main.Controls.Add(this.navPage_AddStudent);
            this.navFrame_Main.Controls.Add(this.navPage_AddClass);
            this.navFrame_Main.Controls.Add(this.navPage_CreateReports);
            this.navFrame_Main.Controls.Add(this.navPage_Home);
            this.navFrame_Main.Controls.Add(this.navPage_FindStudents);
            this.navFrame_Main.Controls.Add(this.navPage_ScoreBoardDetail2);
            this.navFrame_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame_Main.Location = new System.Drawing.Point(0, 0);
            this.navFrame_Main.Name = "navFrame_Main";
            this.navFrame_Main.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPage_Home,
            this.navPage_StudentsList,
            this.navPage_ClassList,
            this.navPage_StudentInformation,
            this.navPage_ClassInformation,
            this.navPage_ScoreBoardList,
            this.navPage_ScoreBoardDetail,
            this.navPage_ScoreBoardDetail2,
            this.navPage_AddStudent,
            this.navPage_AddClass,
            this.navPage_CreateReports,
            this.navPage_FindStudents});
            this.navFrame_Main.SelectedPage = this.navPage_ClassList;
            this.navFrame_Main.Size = new System.Drawing.Size(1188, 641);
            this.navFrame_Main.TabIndex = 0;
            this.navFrame_Main.Text = "navigationFrame1";
            this.navFrame_Main.TransitionAnimationProperties.FrameCount = 0;
            this.navFrame_Main.TransitionAnimationProperties.FrameInterval = 0;
            // 
            // navPage_StudentsList
            // 
            this.navPage_StudentsList.Controls.Add(this.panel3);
            this.navPage_StudentsList.Controls.Add(this.pictureBox1);
            this.navPage_StudentsList.Controls.Add(this.btn_Delete_StudentList);
            this.navPage_StudentsList.Controls.Add(this.btn_Detail_StudentList);
            this.navPage_StudentsList.Name = "navPage_StudentsList";
            this.navPage_StudentsList.Size = new System.Drawing.Size(1188, 641);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.grd_StudentList);
            this.panel3.Location = new System.Drawing.Point(0, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 447);
            this.panel3.TabIndex = 4;
            // 
            // grd_StudentList
            // 
            this.grd_StudentList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grd_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList.MainView = this.grd_StudentList_View;
            this.grd_StudentList.Name = "grd_StudentList";
            this.grd_StudentList.Size = new System.Drawing.Size(1188, 447);
            this.grd_StudentList.TabIndex = 0;
            this.grd_StudentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_StudentList_View});
            this.grd_StudentList.Click += new System.EventHandler(this.grd_StudentList_Click);
            // 
            // grd_StudentList_View
            // 
            this.grd_StudentList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grd_StudentList_View.GridControl = this.grd_StudentList;
            this.grd_StudentList_View.Name = "grd_StudentList_View";
            this.grd_StudentList_View.OptionsBehavior.Editable = false;
            this.grd_StudentList_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MSHS";
            this.gridColumn1.FieldName = "MSHS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ Tên";
            this.gridColumn2.FieldName = "HOTEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 214;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Sinh";
            this.gridColumn3.FieldName = "NGSINH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 152;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Email";
            this.gridColumn4.FieldName = "EMAIL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 246;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giới Tính";
            this.gridColumn5.FieldName = "GIOITINH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 97;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa Chỉ";
            this.gridColumn6.FieldName = "DIACHI";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 461;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::StudentManagements.Properties.Resources.studentsListTitle;
            this.pictureBox1.Location = new System.Drawing.Point(397, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Delete_StudentList
            // 
            this.btn_Delete_StudentList.Location = new System.Drawing.Point(97, 155);
            this.btn_Delete_StudentList.Name = "btn_Delete_StudentList";
            this.btn_Delete_StudentList.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_StudentList.TabIndex = 6;
            this.btn_Delete_StudentList.Text = "Delete";
            this.btn_Delete_StudentList.Click += new System.EventHandler(this.btn_Delete_StudentList_Click);
            // 
            // btn_Detail_StudentList
            // 
            this.btn_Detail_StudentList.Location = new System.Drawing.Point(0, 155);
            this.btn_Detail_StudentList.Name = "btn_Detail_StudentList";
            this.btn_Detail_StudentList.Size = new System.Drawing.Size(91, 33);
            this.btn_Detail_StudentList.TabIndex = 7;
            this.btn_Detail_StudentList.Text = "Detail";
            this.btn_Detail_StudentList.Click += new System.EventHandler(this.btn_Detail_StudentList_Click);
            // 
            // navPage_ClassList
            // 
            this.navPage_ClassList.Controls.Add(this.pictureBox2);
            this.navPage_ClassList.Controls.Add(this.btn_Delete_ClassList);
            this.navPage_ClassList.Controls.Add(this.btn_Detail_ClassList);
            this.navPage_ClassList.Controls.Add(this.panel4);
            this.navPage_ClassList.Name = "navPage_ClassList";
            this.navPage_ClassList.Size = new System.Drawing.Size(1188, 641);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::StudentManagements.Properties.Resources.classListTitle;
            this.pictureBox2.Location = new System.Drawing.Point(454, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Delete_ClassList
            // 
            this.btn_Delete_ClassList.Location = new System.Drawing.Point(97, 155);
            this.btn_Delete_ClassList.Name = "btn_Delete_ClassList";
            this.btn_Delete_ClassList.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_ClassList.TabIndex = 6;
            this.btn_Delete_ClassList.Text = "Delete";
            // 
            // btn_Detail_ClassList
            // 
            this.btn_Detail_ClassList.Location = new System.Drawing.Point(0, 155);
            this.btn_Detail_ClassList.Name = "btn_Detail_ClassList";
            this.btn_Detail_ClassList.Size = new System.Drawing.Size(91, 33);
            this.btn_Detail_ClassList.TabIndex = 7;
            this.btn_Detail_ClassList.Text = "Detail";
            this.btn_Detail_ClassList.Click += new System.EventHandler(this.btn_Detail_ClassList_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.grd_ClassList);
            this.panel4.Location = new System.Drawing.Point(0, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1188, 447);
            this.panel4.TabIndex = 5;
            // 
            // grd_ClassList
            // 
            this.grd_ClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ClassList.Location = new System.Drawing.Point(0, 0);
            this.grd_ClassList.MainView = this.grd_ClassList_View;
            this.grd_ClassList.Name = "grd_ClassList";
            this.grd_ClassList.Size = new System.Drawing.Size(1188, 447);
            this.grd_ClassList.TabIndex = 1;
            this.grd_ClassList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ClassList_View});
            this.grd_ClassList.Click += new System.EventHandler(this.grd_ClassList_Click);
            // 
            // grd_ClassList_View
            // 
            this.grd_ClassList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.grd_ClassList_View.GridControl = this.grd_ClassList;
            this.grd_ClassList_View.Name = "grd_ClassList_View";
            this.grd_ClassList_View.OptionsBehavior.Editable = false;
            this.grd_ClassList_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "MALOP";
            this.gridColumn7.FieldName = "MALOP";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên Lớp";
            this.gridColumn8.FieldName = "TENLOP";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 194;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Sỉ Số";
            this.gridColumn9.FieldName = "SISO";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 126;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Năm Học";
            this.gridColumn10.FieldName = "NAMHOC";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.FixedWidth = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 150;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ghi Chú";
            this.gridColumn11.FieldName = "GHICHU";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            this.gridColumn11.Width = 650;
            // 
            // navPage_StudentInformation
            // 
            this.navPage_StudentInformation.Controls.Add(this.btn_Edit_StudentInformation);
            this.navPage_StudentInformation.Controls.Add(this.btn_Save_StudentInformation);
            this.navPage_StudentInformation.Controls.Add(this.pictureBox4);
            this.navPage_StudentInformation.Controls.Add(this.panel5);
            this.navPage_StudentInformation.Controls.Add(this.pictureBox3);
            this.navPage_StudentInformation.Name = "navPage_StudentInformation";
            this.navPage_StudentInformation.Size = new System.Drawing.Size(1188, 641);
            // 
            // btn_Edit_StudentInformation
            // 
            this.btn_Edit_StudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Edit_StudentInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit_StudentInformation.Image")));
            this.btn_Edit_StudentInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Edit_StudentInformation.Location = new System.Drawing.Point(867, 241);
            this.btn_Edit_StudentInformation.Name = "btn_Edit_StudentInformation";
            this.btn_Edit_StudentInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Edit_StudentInformation.TabIndex = 4;
            this.btn_Edit_StudentInformation.Click += new System.EventHandler(this.btn_Edit_StudentInformation_Click);
            // 
            // btn_Save_StudentInformation
            // 
            this.btn_Save_StudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save_StudentInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_StudentInformation.Image")));
            this.btn_Save_StudentInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Save_StudentInformation.Location = new System.Drawing.Point(866, 242);
            this.btn_Save_StudentInformation.Name = "btn_Save_StudentInformation";
            this.btn_Save_StudentInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Save_StudentInformation.TabIndex = 4;
            this.btn_Save_StudentInformation.Click += new System.EventHandler(this.btn_Save_StudentInformation_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::StudentManagements.Properties.Resources.StudentIcon;
            this.pictureBox4.Location = new System.Drawing.Point(540, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.navFrame_StudentInformation);
            this.panel5.Location = new System.Drawing.Point(248, 292);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(694, 267);
            this.panel5.TabIndex = 1;
            // 
            // navFrame_StudentInformation
            // 
            this.navFrame_StudentInformation.Controls.Add(this.navPage_StudentEdit_StudentInformation);
            this.navFrame_StudentInformation.Controls.Add(this.navPage_StudentDetail_StudentInformation);
            this.navFrame_StudentInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame_StudentInformation.Location = new System.Drawing.Point(0, 0);
            this.navFrame_StudentInformation.Name = "navFrame_StudentInformation";
            this.navFrame_StudentInformation.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPage_StudentEdit_StudentInformation,
            this.navPage_StudentDetail_StudentInformation});
            this.navFrame_StudentInformation.SelectedPage = this.navPage_StudentDetail_StudentInformation;
            this.navFrame_StudentInformation.Size = new System.Drawing.Size(692, 265);
            this.navFrame_StudentInformation.TabIndex = 0;
            this.navFrame_StudentInformation.Text = "navigationFrame1";
            this.navFrame_StudentInformation.TransitionAnimationProperties.FrameCount = 0;
            this.navFrame_StudentInformation.TransitionAnimationProperties.FrameInterval = 0;
            // 
            // navPage_StudentEdit_StudentInformation
            // 
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.cb_StudentSex_StudentInformation_Edit);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.txt_StudentEmail_StudentInformation_Edit);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.txt_StudentAddress_StudentInformation_Edit);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.txt_StudentName_StudentInformation_Edit);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.txt_StudentID_StudentInformation_Edit);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.labelControl18);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.labelControl19);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.labelControl20);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.labelControl21);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.labelControl22);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.labelControl23);
            this.navPage_StudentEdit_StudentInformation.Controls.Add(this.cb_StudentDateOfBirth_StudentInformation_Edit);
            this.navPage_StudentEdit_StudentInformation.Name = "navPage_StudentEdit_StudentInformation";
            this.navPage_StudentEdit_StudentInformation.Size = new System.Drawing.Size(692, 265);
            // 
            // cb_StudentSex_StudentInformation_Edit
            // 
            this.cb_StudentSex_StudentInformation_Edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StudentSex_StudentInformation_Edit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cb_StudentSex_StudentInformation_Edit.FormattingEnabled = true;
            this.cb_StudentSex_StudentInformation_Edit.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cb_StudentSex_StudentInformation_Edit.Location = new System.Drawing.Point(488, 38);
            this.cb_StudentSex_StudentInformation_Edit.Name = "cb_StudentSex_StudentInformation_Edit";
            this.cb_StudentSex_StudentInformation_Edit.Size = new System.Drawing.Size(121, 29);
            this.cb_StudentSex_StudentInformation_Edit.TabIndex = 8;
            // 
            // txt_StudentEmail_StudentInformation_Edit
            // 
            this.txt_StudentEmail_StudentInformation_Edit.Location = new System.Drawing.Point(488, 87);
            this.txt_StudentEmail_StudentInformation_Edit.Name = "txt_StudentEmail_StudentInformation_Edit";
            this.txt_StudentEmail_StudentInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentEmail_StudentInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentEmail_StudentInformation_Edit.Size = new System.Drawing.Size(185, 28);
            this.txt_StudentEmail_StudentInformation_Edit.TabIndex = 7;
            // 
            // txt_StudentAddress_StudentInformation_Edit
            // 
            this.txt_StudentAddress_StudentInformation_Edit.Location = new System.Drawing.Point(155, 193);
            this.txt_StudentAddress_StudentInformation_Edit.Name = "txt_StudentAddress_StudentInformation_Edit";
            this.txt_StudentAddress_StudentInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentAddress_StudentInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentAddress_StudentInformation_Edit.Size = new System.Drawing.Size(518, 28);
            this.txt_StudentAddress_StudentInformation_Edit.TabIndex = 7;
            // 
            // txt_StudentName_StudentInformation_Edit
            // 
            this.txt_StudentName_StudentInformation_Edit.Location = new System.Drawing.Point(155, 91);
            this.txt_StudentName_StudentInformation_Edit.Name = "txt_StudentName_StudentInformation_Edit";
            this.txt_StudentName_StudentInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentName_StudentInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentName_StudentInformation_Edit.Size = new System.Drawing.Size(205, 28);
            this.txt_StudentName_StudentInformation_Edit.TabIndex = 7;
            // 
            // txt_StudentID_StudentInformation_Edit
            // 
            this.txt_StudentID_StudentInformation_Edit.Enabled = false;
            this.txt_StudentID_StudentInformation_Edit.Location = new System.Drawing.Point(155, 41);
            this.txt_StudentID_StudentInformation_Edit.MenuManager = this.ribbonControl1;
            this.txt_StudentID_StudentInformation_Edit.Name = "txt_StudentID_StudentInformation_Edit";
            this.txt_StudentID_StudentInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentID_StudentInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentID_StudentInformation_Edit.Size = new System.Drawing.Size(205, 28);
            this.txt_StudentID_StudentInformation_Edit.TabIndex = 7;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl18.Location = new System.Drawing.Point(399, 41);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(71, 21);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "Giới Tính:";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl19.Location = new System.Drawing.Point(51, 200);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(59, 21);
            this.labelControl19.TabIndex = 2;
            this.labelControl19.Text = "Địa Chỉ:";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl20.Location = new System.Drawing.Point(399, 94);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(47, 21);
            this.labelControl20.TabIndex = 3;
            this.labelControl20.Text = "Email:";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl21.Location = new System.Drawing.Point(51, 147);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(79, 21);
            this.labelControl21.TabIndex = 4;
            this.labelControl21.Text = "Ngày Sinh:";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl22.Location = new System.Drawing.Point(51, 94);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(59, 21);
            this.labelControl22.TabIndex = 5;
            this.labelControl22.Text = "Họ Tên:";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl23.Location = new System.Drawing.Point(51, 41);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(53, 21);
            this.labelControl23.TabIndex = 6;
            this.labelControl23.Text = "MSHS: ";
            // 
            // cb_StudentDateOfBirth_StudentInformation_Edit
            // 
            this.cb_StudentDateOfBirth_StudentInformation_Edit.EditValue = null;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Location = new System.Drawing.Point(155, 144);
            this.cb_StudentDateOfBirth_StudentInformation_Edit.MenuManager = this.ribbonControl1;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Name = "cb_StudentDateOfBirth_StudentInformation_Edit";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.DisplayFormat.FormatString = "";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.EditFormat.FormatString = "";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Mask.EditMask = "";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Size = new System.Drawing.Size(205, 28);
            this.cb_StudentDateOfBirth_StudentInformation_Edit.TabIndex = 5;
            // 
            // navPage_StudentDetail_StudentInformation
            // 
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.txt_StudentSex_StudentInformation_Detail);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.txt_StudentAddress_StudentInformation_Detail);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.txt_StudentEmail_StudentInformation_Detail);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.txt_StudentDateOfBirth_StudentInformation_Detail);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.txt_StudentName_StudentInformation_Detail);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.txt_StudentID_StudentInformation_Detail);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.labelControl11);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.labelControl13);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.labelControl7);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.labelControl5);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.labelControl3);
            this.navPage_StudentDetail_StudentInformation.Controls.Add(this.labelControl1);
            this.navPage_StudentDetail_StudentInformation.Name = "navPage_StudentDetail_StudentInformation";
            this.navPage_StudentDetail_StudentInformation.Size = new System.Drawing.Size(692, 265);
            // 
            // txt_StudentSex_StudentInformation_Detail
            // 
            this.txt_StudentSex_StudentInformation_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentSex_StudentInformation_Detail.Location = new System.Drawing.Point(508, 41);
            this.txt_StudentSex_StudentInformation_Detail.Name = "txt_StudentSex_StudentInformation_Detail";
            this.txt_StudentSex_StudentInformation_Detail.Size = new System.Drawing.Size(34, 21);
            this.txt_StudentSex_StudentInformation_Detail.TabIndex = 0;
            this.txt_StudentSex_StudentInformation_Detail.Text = "Nam";
            // 
            // txt_StudentAddress_StudentInformation_Detail
            // 
            this.txt_StudentAddress_StudentInformation_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentAddress_StudentInformation_Detail.Location = new System.Drawing.Point(160, 200);
            this.txt_StudentAddress_StudentInformation_Detail.Name = "txt_StudentAddress_StudentInformation_Detail";
            this.txt_StudentAddress_StudentInformation_Detail.Size = new System.Drawing.Size(31, 21);
            this.txt_StudentAddress_StudentInformation_Detail.TabIndex = 0;
            this.txt_StudentAddress_StudentInformation_Detail.Text = "ABC";
            // 
            // txt_StudentEmail_StudentInformation_Detail
            // 
            this.txt_StudentEmail_StudentInformation_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentEmail_StudentInformation_Detail.Location = new System.Drawing.Point(508, 86);
            this.txt_StudentEmail_StudentInformation_Detail.Name = "txt_StudentEmail_StudentInformation_Detail";
            this.txt_StudentEmail_StudentInformation_Detail.Size = new System.Drawing.Size(117, 21);
            this.txt_StudentEmail_StudentInformation_Detail.TabIndex = 0;
            this.txt_StudentEmail_StudentInformation_Detail.Text = "anv@gmail.com";
            // 
            // txt_StudentDateOfBirth_StudentInformation_Detail
            // 
            this.txt_StudentDateOfBirth_StudentInformation_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentDateOfBirth_StudentInformation_Detail.Location = new System.Drawing.Point(160, 147);
            this.txt_StudentDateOfBirth_StudentInformation_Detail.Name = "txt_StudentDateOfBirth_StudentInformation_Detail";
            this.txt_StudentDateOfBirth_StudentInformation_Detail.Size = new System.Drawing.Size(86, 21);
            this.txt_StudentDateOfBirth_StudentInformation_Detail.TabIndex = 0;
            this.txt_StudentDateOfBirth_StudentInformation_Detail.Text = "26/06/1997";
            // 
            // txt_StudentName_StudentInformation_Detail
            // 
            this.txt_StudentName_StudentInformation_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentName_StudentInformation_Detail.Location = new System.Drawing.Point(160, 94);
            this.txt_StudentName_StudentInformation_Detail.Name = "txt_StudentName_StudentInformation_Detail";
            this.txt_StudentName_StudentInformation_Detail.Size = new System.Drawing.Size(104, 21);
            this.txt_StudentName_StudentInformation_Detail.TabIndex = 0;
            this.txt_StudentName_StudentInformation_Detail.Text = "Nguyễn Văn A";
            // 
            // txt_StudentID_StudentInformation_Detail
            // 
            this.txt_StudentID_StudentInformation_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentID_StudentInformation_Detail.Location = new System.Drawing.Point(160, 41);
            this.txt_StudentID_StudentInformation_Detail.Name = "txt_StudentID_StudentInformation_Detail";
            this.txt_StudentID_StudentInformation_Detail.Size = new System.Drawing.Size(18, 21);
            this.txt_StudentID_StudentInformation_Detail.TabIndex = 0;
            this.txt_StudentID_StudentInformation_Detail.Text = "12";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Location = new System.Drawing.Point(399, 41);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(71, 21);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Giới Tính:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl13.Location = new System.Drawing.Point(51, 200);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 21);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Địa Chỉ:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Location = new System.Drawing.Point(399, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 21);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Email:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(51, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 21);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Ngày Sinh:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(51, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Họ Tên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(51, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MSHS: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::StudentManagements.Properties.Resources.studentInformationTitle;
            this.pictureBox3.Location = new System.Drawing.Point(284, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(621, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // navPage_ClassInformation
            // 
            this.navPage_ClassInformation.Controls.Add(this.btn_Edit_ClassInformation);
            this.navPage_ClassInformation.Controls.Add(this.btn_Save_ClassInformation);
            this.navPage_ClassInformation.Controls.Add(this.panel8);
            this.navPage_ClassInformation.Controls.Add(this.panel7);
            this.navPage_ClassInformation.Controls.Add(this.pictureBox6);
            this.navPage_ClassInformation.Name = "navPage_ClassInformation";
            this.navPage_ClassInformation.Size = new System.Drawing.Size(1188, 641);
            // 
            // btn_Edit_ClassInformation
            // 
            this.btn_Edit_ClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit_ClassInformation.Image")));
            this.btn_Edit_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Edit_ClassInformation.Location = new System.Drawing.Point(596, 144);
            this.btn_Edit_ClassInformation.Name = "btn_Edit_ClassInformation";
            this.btn_Edit_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Edit_ClassInformation.TabIndex = 4;
            this.btn_Edit_ClassInformation.Click += new System.EventHandler(this.btn_Edit_ClassInformation_Click);
            // 
            // btn_Save_ClassInformation
            // 
            this.btn_Save_ClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_ClassInformation.Image")));
            this.btn_Save_ClassInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Save_ClassInformation.Location = new System.Drawing.Point(596, 144);
            this.btn_Save_ClassInformation.Name = "btn_Save_ClassInformation";
            this.btn_Save_ClassInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Save_ClassInformation.TabIndex = 3;
            this.btn_Save_ClassInformation.Click += new System.EventHandler(this.btn_Save_ClassInformation_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.grd_ClassInformation);
            this.panel8.Location = new System.Drawing.Point(0, 195);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1188, 447);
            this.panel8.TabIndex = 1;
            // 
            // grd_ClassInformation
            // 
            this.grd_ClassInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ClassInformation.Location = new System.Drawing.Point(0, 0);
            this.grd_ClassInformation.MainView = this.grd_ClassInformation_View;
            this.grd_ClassInformation.MenuManager = this.ribbonControl1;
            this.grd_ClassInformation.Name = "grd_ClassInformation";
            this.grd_ClassInformation.Size = new System.Drawing.Size(1188, 447);
            this.grd_ClassInformation.TabIndex = 2;
            this.grd_ClassInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ClassInformation_View});
            // 
            // grd_ClassInformation_View
            // 
            this.grd_ClassInformation_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.grd_ClassInformation_View.GridControl = this.grd_ClassInformation;
            this.grd_ClassInformation_View.Name = "grd_ClassInformation_View";
            this.grd_ClassInformation_View.OptionsBehavior.Editable = false;
            this.grd_ClassInformation_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "MSHS";
            this.gridColumn12.FieldName = "MSHS";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.FixedWidth = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 86;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Họ Tên";
            this.gridColumn13.FieldName = "HOTEN";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.FixedWidth = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 221;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Ngày Sinh";
            this.gridColumn14.FieldName = "NGSINH";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.FixedWidth = true;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn14.Width = 164;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Email";
            this.gridColumn15.FieldName = "EMAIL";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 3;
            this.gridColumn15.Width = 229;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Giới Tính";
            this.gridColumn16.FieldName = "GIOITINH";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.FixedWidth = true;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 80;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Địa Chỉ";
            this.gridColumn17.FieldName = "DIACHI";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            this.gridColumn17.Width = 388;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.navFrame_ClassInformation);
            this.panel7.Location = new System.Drawing.Point(0, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(590, 45);
            this.panel7.TabIndex = 1;
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
            this.navPage_ClassDetail.Controls.Add(this.labelControl12);
            this.navPage_ClassDetail.Controls.Add(this.txt_ClassTotal_ClassInformation);
            this.navPage_ClassDetail.Controls.Add(this.txt_ClassName_ClassInformation);
            this.navPage_ClassDetail.Controls.Add(this.labelControl10);
            this.navPage_ClassDetail.Name = "navPage_ClassDetail";
            this.navPage_ClassDetail.Size = new System.Drawing.Size(588, 43);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Location = new System.Drawing.Point(385, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(41, 21);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Sỉ số:";
            // 
            // txt_ClassTotal_ClassInformation
            // 
            this.txt_ClassTotal_ClassInformation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassTotal_ClassInformation.Location = new System.Drawing.Point(447, 13);
            this.txt_ClassTotal_ClassInformation.Name = "txt_ClassTotal_ClassInformation";
            this.txt_ClassTotal_ClassInformation.Size = new System.Drawing.Size(18, 21);
            this.txt_ClassTotal_ClassInformation.TabIndex = 0;
            this.txt_ClassTotal_ClassInformation.Text = "45";
            // 
            // txt_ClassName_ClassInformation
            // 
            this.txt_ClassName_ClassInformation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassName_ClassInformation.Location = new System.Drawing.Point(109, 13);
            this.txt_ClassName_ClassInformation.Name = "txt_ClassName_ClassInformation";
            this.txt_ClassName_ClassInformation.Size = new System.Drawing.Size(38, 21);
            this.txt_ClassName_ClassInformation.TabIndex = 0;
            this.txt_ClassName_ClassInformation.Text = "10A1";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Location = new System.Drawing.Point(19, 13);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 21);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Tên lớp:";
            // 
            // navPage_ClassDetail_Edit
            // 
            this.navPage_ClassDetail_Edit.Controls.Add(this.txt_ClassTotal_ClassInformation_Edit);
            this.navPage_ClassDetail_Edit.Controls.Add(this.txt_ClassName_ClassInformation_Edit);
            this.navPage_ClassDetail_Edit.Controls.Add(this.labelControl14);
            this.navPage_ClassDetail_Edit.Controls.Add(this.labelControl15);
            this.navPage_ClassDetail_Edit.Name = "navPage_ClassDetail_Edit";
            this.navPage_ClassDetail_Edit.Size = new System.Drawing.Size(588, 43);
            // 
            // txt_ClassTotal_ClassInformation_Edit
            // 
            this.txt_ClassTotal_ClassInformation_Edit.Location = new System.Drawing.Point(440, 10);
            this.txt_ClassTotal_ClassInformation_Edit.Name = "txt_ClassTotal_ClassInformation_Edit";
            this.txt_ClassTotal_ClassInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassTotal_ClassInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassTotal_ClassInformation_Edit.Size = new System.Drawing.Size(108, 28);
            this.txt_ClassTotal_ClassInformation_Edit.TabIndex = 3;
            // 
            // txt_ClassName_ClassInformation_Edit
            // 
            this.txt_ClassName_ClassInformation_Edit.Location = new System.Drawing.Point(98, 10);
            this.txt_ClassName_ClassInformation_Edit.MenuManager = this.ribbonControl1;
            this.txt_ClassName_ClassInformation_Edit.Name = "txt_ClassName_ClassInformation_Edit";
            this.txt_ClassName_ClassInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassName_ClassInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassName_ClassInformation_Edit.Size = new System.Drawing.Size(190, 28);
            this.txt_ClassName_ClassInformation_Edit.TabIndex = 3;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl14.Location = new System.Drawing.Point(385, 13);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(41, 21);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "Sỉ số:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl15.Location = new System.Drawing.Point(19, 13);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(61, 21);
            this.labelControl15.TabIndex = 2;
            this.labelControl15.Text = "Tên lớp:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = global::StudentManagements.Properties.Resources.classInformationTitle;
            this.pictureBox6.Location = new System.Drawing.Point(323, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(543, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // navPage_ScoreBoardList
            // 
            this.navPage_ScoreBoardList.Controls.Add(this.btn_All_ScoreBoardList);
            this.navPage_ScoreBoardList.Controls.Add(this.btn_Delete_ScoreBoardList);
            this.navPage_ScoreBoardList.Controls.Add(this.btn_LookUp_ScoreBoardList);
            this.navPage_ScoreBoardList.Controls.Add(this.panel9);
            this.navPage_ScoreBoardList.Controls.Add(this.pictureBox7);
            this.navPage_ScoreBoardList.Name = "navPage_ScoreBoardList";
            this.navPage_ScoreBoardList.Size = new System.Drawing.Size(1188, 641);
            // 
            // btn_All_ScoreBoardList
            // 
            this.btn_All_ScoreBoardList.Location = new System.Drawing.Point(194, 155);
            this.btn_All_ScoreBoardList.Name = "btn_All_ScoreBoardList";
            this.btn_All_ScoreBoardList.Size = new System.Drawing.Size(91, 33);
            this.btn_All_ScoreBoardList.TabIndex = 8;
            this.btn_All_ScoreBoardList.Text = "All";
            this.btn_All_ScoreBoardList.Click += new System.EventHandler(this.btn_All_ScoreBoardList_Click);
            // 
            // btn_Delete_ScoreBoardList
            // 
            this.btn_Delete_ScoreBoardList.Location = new System.Drawing.Point(97, 155);
            this.btn_Delete_ScoreBoardList.Name = "btn_Delete_ScoreBoardList";
            this.btn_Delete_ScoreBoardList.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_ScoreBoardList.TabIndex = 8;
            this.btn_Delete_ScoreBoardList.Text = "Delete";
            // 
            // btn_LookUp_ScoreBoardList
            // 
            this.btn_LookUp_ScoreBoardList.Location = new System.Drawing.Point(0, 155);
            this.btn_LookUp_ScoreBoardList.Name = "btn_LookUp_ScoreBoardList";
            this.btn_LookUp_ScoreBoardList.Size = new System.Drawing.Size(91, 33);
            this.btn_LookUp_ScoreBoardList.TabIndex = 9;
            this.btn_LookUp_ScoreBoardList.Text = "Look up";
            this.btn_LookUp_ScoreBoardList.Click += new System.EventHandler(this.btn_LookUp_ScoreBoardList_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.grd_ScoreBoardList);
            this.panel9.Location = new System.Drawing.Point(0, 195);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1188, 447);
            this.panel9.TabIndex = 2;
            // 
            // grd_ScoreBoardList
            // 
            this.grd_ScoreBoardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ScoreBoardList.Location = new System.Drawing.Point(0, 0);
            this.grd_ScoreBoardList.MainView = this.grd_ScoreBoardList_View;
            this.grd_ScoreBoardList.MenuManager = this.ribbonControl1;
            this.grd_ScoreBoardList.Name = "grd_ScoreBoardList";
            this.grd_ScoreBoardList.Size = new System.Drawing.Size(1188, 447);
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
            this.pictureBox7.Location = new System.Drawing.Point(353, 23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(482, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // navPage_ScoreBoardDetail
            // 
            this.navPage_ScoreBoardDetail.Controls.Add(this.btn_Delete_ScoreBoardDetail);
            this.navPage_ScoreBoardDetail.Controls.Add(this.btn_New_ScoreBoardDetail);
            this.navPage_ScoreBoardDetail.Controls.Add(this.panel6);
            this.navPage_ScoreBoardDetail.Controls.Add(this.pictureBox8);
            this.navPage_ScoreBoardDetail.Name = "navPage_ScoreBoardDetail";
            this.navPage_ScoreBoardDetail.Size = new System.Drawing.Size(1188, 641);
            // 
            // btn_Delete_ScoreBoardDetail
            // 
            this.btn_Delete_ScoreBoardDetail.Location = new System.Drawing.Point(97, 155);
            this.btn_Delete_ScoreBoardDetail.Name = "btn_Delete_ScoreBoardDetail";
            this.btn_Delete_ScoreBoardDetail.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_ScoreBoardDetail.TabIndex = 12;
            this.btn_Delete_ScoreBoardDetail.Text = "Delete";
            // 
            // btn_New_ScoreBoardDetail
            // 
            this.btn_New_ScoreBoardDetail.Location = new System.Drawing.Point(0, 155);
            this.btn_New_ScoreBoardDetail.Name = "btn_New_ScoreBoardDetail";
            this.btn_New_ScoreBoardDetail.Size = new System.Drawing.Size(91, 33);
            this.btn_New_ScoreBoardDetail.TabIndex = 13;
            this.btn_New_ScoreBoardDetail.Text = "New";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.grd_ScoreBoardDetail);
            this.panel6.Location = new System.Drawing.Point(0, 195);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1188, 447);
            this.panel6.TabIndex = 11;
            // 
            // grd_ScoreBoardDetail
            // 
            this.grd_ScoreBoardDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ScoreBoardDetail.Location = new System.Drawing.Point(0, 0);
            this.grd_ScoreBoardDetail.MainView = this.grd_ScoreBoardDetail_View;
            this.grd_ScoreBoardDetail.MenuManager = this.ribbonControl1;
            this.grd_ScoreBoardDetail.Name = "grd_ScoreBoardDetail";
            this.grd_ScoreBoardDetail.Size = new System.Drawing.Size(1188, 447);
            this.grd_ScoreBoardDetail.TabIndex = 0;
            this.grd_ScoreBoardDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ScoreBoardDetail_View});
            // 
            // grd_ScoreBoardDetail_View
            // 
            this.grd_ScoreBoardDetail_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn33,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30});
            this.grd_ScoreBoardDetail_View.GridControl = this.grd_ScoreBoardDetail;
            this.grd_ScoreBoardDetail_View.Name = "grd_ScoreBoardDetail_View";
            this.grd_ScoreBoardDetail_View.OptionsBehavior.Editable = false;
            this.grd_ScoreBoardDetail_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "gridColumn33";
            this.gridColumn33.FieldName = "MAKQ";
            this.gridColumn33.Name = "gridColumn33";
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Họ Tên";
            this.gridColumn23.FieldName = "HOTEN";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 0;
            this.gridColumn23.Width = 257;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Tên Lớp";
            this.gridColumn24.FieldName = "TENLOP";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.FixedWidth = true;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 1;
            this.gridColumn24.Width = 127;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Tên Môn";
            this.gridColumn25.FieldName = "TENMH";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.FixedWidth = true;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 2;
            this.gridColumn25.Width = 127;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Học Kỳ";
            this.gridColumn26.FieldName = "HOCKY";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.FixedWidth = true;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 3;
            this.gridColumn26.Width = 127;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Điểm 15 phút";
            this.gridColumn27.FieldName = "DIEM15";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.FixedWidth = true;
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 4;
            this.gridColumn27.Width = 142;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Điểm 1 tiết";
            this.gridColumn28.FieldName = "DIEM1TIET";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.FixedWidth = true;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 5;
            this.gridColumn28.Width = 132;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "Điểm Cuối Kỳ";
            this.gridColumn29.FieldName = "DIEMCUOIKY";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.OptionsColumn.FixedWidth = true;
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 6;
            this.gridColumn29.Width = 124;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Điểm Trung Bình";
            this.gridColumn30.FieldName = "DIEMTB";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.OptionsColumn.FixedWidth = true;
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 7;
            this.gridColumn30.Width = 132;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.Image = global::StudentManagements.Properties.Resources.scoreBoardListTitle;
            this.pictureBox8.Location = new System.Drawing.Point(353, 23);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(482, 44);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // navPage_AddStudent
            // 
            this.navPage_AddStudent.Controls.Add(this.btn_Done_AddStudent);
            this.navPage_AddStudent.Controls.Add(this.studentInformationPanel);
            this.navPage_AddStudent.Controls.Add(this.pictureBox5);
            this.navPage_AddStudent.Name = "navPage_AddStudent";
            this.navPage_AddStudent.Size = new System.Drawing.Size(1188, 641);
            // 
            // btn_Done_AddStudent
            // 
            this.btn_Done_AddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Done_AddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btn_Done_AddStudent.Image")));
            this.btn_Done_AddStudent.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Done_AddStudent.Location = new System.Drawing.Point(952, 180);
            this.btn_Done_AddStudent.Name = "btn_Done_AddStudent";
            this.btn_Done_AddStudent.Size = new System.Drawing.Size(75, 45);
            this.btn_Done_AddStudent.TabIndex = 2;
            this.btn_Done_AddStudent.Click += new System.EventHandler(this.btn_Done_AddStudent_Click);
            // 
            // studentInformationPanel
            // 
            this.studentInformationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentInformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInformationPanel.Controls.Add(this.cb_StudentSex_AddStudent);
            this.studentInformationPanel.Controls.Add(this.txt_StudentAddress_AddStudent);
            this.studentInformationPanel.Controls.Add(this.labelControl9);
            this.studentInformationPanel.Controls.Add(this.labelControl8);
            this.studentInformationPanel.Controls.Add(this.txt_StudentEmail_AddStudent);
            this.studentInformationPanel.Controls.Add(this.labelControl6);
            this.studentInformationPanel.Controls.Add(this.labelControl4);
            this.studentInformationPanel.Controls.Add(this.txt_StudentName_AddStudent);
            this.studentInformationPanel.Controls.Add(this.labelControl2);
            this.studentInformationPanel.Controls.Add(this.cb_StudentDateOfBirth_AddStudent);
            this.studentInformationPanel.Location = new System.Drawing.Point(162, 231);
            this.studentInformationPanel.Name = "studentInformationPanel";
            this.studentInformationPanel.Size = new System.Drawing.Size(865, 229);
            this.studentInformationPanel.TabIndex = 1;
            // 
            // cb_StudentSex_AddStudent
            // 
            this.cb_StudentSex_AddStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StudentSex_AddStudent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cb_StudentSex_AddStudent.FormattingEnabled = true;
            this.cb_StudentSex_AddStudent.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cb_StudentSex_AddStudent.Location = new System.Drawing.Point(557, 41);
            this.cb_StudentSex_AddStudent.Name = "cb_StudentSex_AddStudent";
            this.cb_StudentSex_AddStudent.Size = new System.Drawing.Size(121, 29);
            this.cb_StudentSex_AddStudent.TabIndex = 1;
            // 
            // txt_StudentAddress_AddStudent
            // 
            this.txt_StudentAddress_AddStudent.Location = new System.Drawing.Point(557, 89);
            this.txt_StudentAddress_AddStudent.Name = "txt_StudentAddress_AddStudent";
            this.txt_StudentAddress_AddStudent.Size = new System.Drawing.Size(268, 83);
            this.txt_StudentAddress_AddStudent.TabIndex = 4;
            this.txt_StudentAddress_AddStudent.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Location = new System.Drawing.Point(472, 96);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 21);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Địa Chỉ:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Location = new System.Drawing.Point(472, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 21);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Giới Tính:";
            // 
            // txt_StudentEmail_AddStudent
            // 
            this.txt_StudentEmail_AddStudent.Location = new System.Drawing.Point(131, 144);
            this.txt_StudentEmail_AddStudent.Name = "txt_StudentEmail_AddStudent";
            this.txt_StudentEmail_AddStudent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentEmail_AddStudent.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentEmail_AddStudent.Size = new System.Drawing.Size(235, 28);
            this.txt_StudentEmail_AddStudent.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(46, 147);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 21);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Email:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(46, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày Sinh:";
            // 
            // txt_StudentName_AddStudent
            // 
            this.txt_StudentName_AddStudent.EditValue = "";
            this.txt_StudentName_AddStudent.Location = new System.Drawing.Point(131, 42);
            this.txt_StudentName_AddStudent.MenuManager = this.ribbonControl1;
            this.txt_StudentName_AddStudent.Name = "txt_StudentName_AddStudent";
            this.txt_StudentName_AddStudent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentName_AddStudent.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentName_AddStudent.Size = new System.Drawing.Size(235, 28);
            this.txt_StudentName_AddStudent.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(46, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Họ Tên: ";
            // 
            // cb_StudentDateOfBirth_AddStudent
            // 
            this.cb_StudentDateOfBirth_AddStudent.EditValue = null;
            this.cb_StudentDateOfBirth_AddStudent.Location = new System.Drawing.Point(131, 93);
            this.cb_StudentDateOfBirth_AddStudent.MenuManager = this.ribbonControl1;
            this.cb_StudentDateOfBirth_AddStudent.Name = "cb_StudentDateOfBirth_AddStudent";
            this.cb_StudentDateOfBirth_AddStudent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cb_StudentDateOfBirth_AddStudent.Properties.Appearance.Options.UseFont = true;
            this.cb_StudentDateOfBirth_AddStudent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_AddStudent.Properties.DisplayFormat.FormatString = "";
            this.cb_StudentDateOfBirth_AddStudent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_AddStudent.Properties.EditFormat.FormatString = "";
            this.cb_StudentDateOfBirth_AddStudent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_AddStudent.Properties.Mask.EditMask = "";
            this.cb_StudentDateOfBirth_AddStudent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cb_StudentDateOfBirth_AddStudent.Size = new System.Drawing.Size(235, 28);
            this.cb_StudentDateOfBirth_AddStudent.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Image = global::StudentManagements.Properties.Resources.studentInformationTitle;
            this.pictureBox5.Location = new System.Drawing.Point(285, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(621, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // navPage_CreateReports
            // 
            this.navPage_CreateReports.Name = "navPage_CreateReports";
            this.navPage_CreateReports.Size = new System.Drawing.Size(1188, 641);
            // 
            // navPage_AddClass
            // 
            this.navPage_AddClass.Controls.Add(this.btn_AddStudentForClass_AddClass);
            this.navPage_AddClass.Controls.Add(this.btn_Save_AddClass);
            this.navPage_AddClass.Controls.Add(this.panel12);
            this.navPage_AddClass.Controls.Add(this.panel13);
            this.navPage_AddClass.Controls.Add(this.pictureBox11);
            this.navPage_AddClass.Name = "navPage_AddClass";
            this.navPage_AddClass.Size = new System.Drawing.Size(1188, 641);
            // 
            // navPage_Home
            // 
            this.navPage_Home.Name = "navPage_Home";
            this.navPage_Home.Size = new System.Drawing.Size(1188, 641);
            // 
            // navPage_FindStudents
            // 
            this.navPage_FindStudents.Controls.Add(this.pictureBox10);
            this.navPage_FindStudents.Controls.Add(this.panel11);
            this.navPage_FindStudents.Name = "navPage_FindStudents";
            this.navPage_FindStudents.Size = new System.Drawing.Size(1188, 641);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox10.Image = global::StudentManagements.Properties.Resources.findStudentTitle1;
            this.pictureBox10.Location = new System.Drawing.Point(405, 34);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(379, 49);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.gridControl1);
            this.panel11.Location = new System.Drawing.Point(0, 194);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1188, 447);
            this.panel11.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1188, 447);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // navPage_ScoreBoardDetail2
            // 
            this.navPage_ScoreBoardDetail2.AccessibleDescription = "";
            this.navPage_ScoreBoardDetail2.Controls.Add(this.cb_SelectSubject_ScoreBoardDetail);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.txt_ClassID);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.labelControl16);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.labelControl17);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.txt_ClassName_ScoreBoardDetail2);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.btn_Save_ScoreBoardDetail2);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.btn_Delete_ScoreBoardDetail2);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.simpleButton4);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.panel10);
            this.navPage_ScoreBoardDetail2.Controls.Add(this.pictureBox9);
            this.navPage_ScoreBoardDetail2.Name = "navPage_ScoreBoardDetail2";
            this.navPage_ScoreBoardDetail2.Size = new System.Drawing.Size(1188, 641);
            // 
            // cb_SelectSubject_ScoreBoardDetail
            // 
            this.cb_SelectSubject_ScoreBoardDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_SelectSubject_ScoreBoardDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_SelectSubject_ScoreBoardDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SelectSubject_ScoreBoardDetail.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cb_SelectSubject_ScoreBoardDetail.FormattingEnabled = true;
            this.cb_SelectSubject_ScoreBoardDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_SelectSubject_ScoreBoardDetail.Items.AddRange(new object[] {
            "Select Subject"});
            this.cb_SelectSubject_ScoreBoardDetail.Location = new System.Drawing.Point(353, 162);
            this.cb_SelectSubject_ScoreBoardDetail.Name = "cb_SelectSubject_ScoreBoardDetail";
            this.cb_SelectSubject_ScoreBoardDetail.Size = new System.Drawing.Size(142, 26);
            this.cb_SelectSubject_ScoreBoardDetail.TabIndex = 21;
            this.cb_SelectSubject_ScoreBoardDetail.SelectedIndexChanged += new System.EventHandler(this.cb_SelectSubject_ScoreBoardDetail_SelectedIndexChanged);
            // 
            // txt_ClassID
            // 
            this.txt_ClassID.AutoSize = true;
            this.txt_ClassID.Location = new System.Drawing.Point(840, 171);
            this.txt_ClassID.Name = "txt_ClassID";
            this.txt_ClassID.Size = new System.Drawing.Size(0, 17);
            this.txt_ClassID.TabIndex = 20;
            this.txt_ClassID.Visible = false;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl16.Location = new System.Drawing.Point(292, 163);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(55, 21);
            this.labelControl16.TabIndex = 19;
            this.labelControl16.Text = "Subject";
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl17.Location = new System.Drawing.Point(490, 92);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(137, 30);
            this.labelControl17.TabIndex = 19;
            this.labelControl17.Text = "Class Name:";
            // 
            // txt_ClassName_ScoreBoardDetail2
            // 
            this.txt_ClassName_ScoreBoardDetail2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ClassName_ScoreBoardDetail2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_ClassName_ScoreBoardDetail2.Location = new System.Drawing.Point(642, 92);
            this.txt_ClassName_ScoreBoardDetail2.Name = "txt_ClassName_ScoreBoardDetail2";
            this.txt_ClassName_ScoreBoardDetail2.Size = new System.Drawing.Size(57, 30);
            this.txt_ClassName_ScoreBoardDetail2.TabIndex = 19;
            this.txt_ClassName_ScoreBoardDetail2.Text = "10A1";
            // 
            // btn_Save_ScoreBoardDetail2
            // 
            this.btn_Save_ScoreBoardDetail2.Location = new System.Drawing.Point(194, 155);
            this.btn_Save_ScoreBoardDetail2.Name = "btn_Save_ScoreBoardDetail2";
            this.btn_Save_ScoreBoardDetail2.Size = new System.Drawing.Size(91, 33);
            this.btn_Save_ScoreBoardDetail2.TabIndex = 16;
            this.btn_Save_ScoreBoardDetail2.Text = "Save";
            // 
            // btn_Delete_ScoreBoardDetail2
            // 
            this.btn_Delete_ScoreBoardDetail2.Location = new System.Drawing.Point(97, 155);
            this.btn_Delete_ScoreBoardDetail2.Name = "btn_Delete_ScoreBoardDetail2";
            this.btn_Delete_ScoreBoardDetail2.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_ScoreBoardDetail2.TabIndex = 16;
            this.btn_Delete_ScoreBoardDetail2.Text = "Delete";
            this.btn_Delete_ScoreBoardDetail2.Click += new System.EventHandler(this.btn_Delete_ScoreBoardDetail2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(0, 155);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(91, 33);
            this.simpleButton4.TabIndex = 17;
            this.simpleButton4.Text = "New";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.grd_ScoreBoardDetail2);
            this.panel10.Location = new System.Drawing.Point(0, 195);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1188, 447);
            this.panel10.TabIndex = 15;
            // 
            // grd_ScoreBoardDetail2
            // 
            this.grd_ScoreBoardDetail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ScoreBoardDetail2.Location = new System.Drawing.Point(0, 0);
            this.grd_ScoreBoardDetail2.MainView = this.grd_ScoreBoardDetail2_View;
            this.grd_ScoreBoardDetail2.MenuManager = this.ribbonControl1;
            this.grd_ScoreBoardDetail2.Name = "grd_ScoreBoardDetail2";
            this.grd_ScoreBoardDetail2.Size = new System.Drawing.Size(1188, 447);
            this.grd_ScoreBoardDetail2.TabIndex = 0;
            this.grd_ScoreBoardDetail2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ScoreBoardDetail2_View});
            this.grd_ScoreBoardDetail2.Click += new System.EventHandler(this.grd_ScoreBoardDetail2_Click);
            // 
            // grd_ScoreBoardDetail2_View
            // 
            this.grd_ScoreBoardDetail2_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn32,
            this.gridColumn31,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38});
            this.grd_ScoreBoardDetail2_View.GridControl = this.grd_ScoreBoardDetail2;
            this.grd_ScoreBoardDetail2_View.Name = "grd_ScoreBoardDetail2_View";
            this.grd_ScoreBoardDetail2_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "MAKQ";
            this.gridColumn32.FieldName = "MAKQ";
            this.gridColumn32.Name = "gridColumn32";
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Họ Tên";
            this.gridColumn31.FieldName = "HOTEN";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.ReadOnly = true;
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 0;
            this.gridColumn31.Width = 312;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Học Kỳ";
            this.gridColumn34.FieldName = "HOCKY";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 1;
            this.gridColumn34.Width = 164;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Điểm 15 phút";
            this.gridColumn35.FieldName = "DIEM15";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 2;
            this.gridColumn35.Width = 183;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Điểm 1 tiết";
            this.gridColumn36.FieldName = "DIEM1TIET";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 3;
            this.gridColumn36.Width = 171;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Điểm Cuối Kỳ";
            this.gridColumn37.FieldName = "DIEMCUOIKY";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 4;
            this.gridColumn37.Width = 161;
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "Điểm Trung Bình";
            this.gridColumn38.FieldName = "DIEMTB";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 5;
            this.gridColumn38.Width = 177;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = global::StudentManagements.Properties.Resources.scoreBoardListTitle;
            this.pictureBox9.Location = new System.Drawing.Point(353, 23);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(482, 44);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // btn_Save_AddClass
            // 
            this.btn_Save_AddClass.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_AddClass.Image")));
            this.btn_Save_AddClass.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Save_AddClass.Location = new System.Drawing.Point(596, 143);
            this.btn_Save_AddClass.Name = "btn_Save_AddClass";
            this.btn_Save_AddClass.Size = new System.Drawing.Size(75, 45);
            this.btn_Save_AddClass.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.grd_StudentList_AddClass);
            this.panel12.Location = new System.Drawing.Point(0, 194);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1188, 447);
            this.panel12.TabIndex = 6;
            // 
            // grd_StudentList_AddClass
            // 
            this.grd_StudentList_AddClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList_AddClass.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList_AddClass.MainView = this.grd_StudentList_AddClass_View;
            this.grd_StudentList_AddClass.MenuManager = this.ribbonControl1;
            this.grd_StudentList_AddClass.Name = "grd_StudentList_AddClass";
            this.grd_StudentList_AddClass.Size = new System.Drawing.Size(1188, 447);
            this.grd_StudentList_AddClass.TabIndex = 2;
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
            this.grd_StudentList_AddClass_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn39
            // 
            this.gridColumn39.Caption = "MSHS";
            this.gridColumn39.FieldName = "MSHS";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.OptionsColumn.FixedWidth = true;
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 0;
            this.gridColumn39.Width = 86;
            // 
            // gridColumn40
            // 
            this.gridColumn40.Caption = "Họ Tên";
            this.gridColumn40.FieldName = "HOTEN";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.OptionsColumn.FixedWidth = true;
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 1;
            this.gridColumn40.Width = 221;
            // 
            // gridColumn41
            // 
            this.gridColumn41.Caption = "Ngày Sinh";
            this.gridColumn41.FieldName = "NGSINH";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.OptionsColumn.FixedWidth = true;
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 2;
            this.gridColumn41.Width = 164;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "Email";
            this.gridColumn42.FieldName = "EMAIL";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 3;
            this.gridColumn42.Width = 229;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "Giới Tính";
            this.gridColumn43.FieldName = "GIOITINH";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.OptionsColumn.FixedWidth = true;
            this.gridColumn43.Visible = true;
            this.gridColumn43.VisibleIndex = 4;
            this.gridColumn43.Width = 80;
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "Địa Chỉ";
            this.gridColumn44.FieldName = "DIACHI";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.Visible = true;
            this.gridColumn44.VisibleIndex = 5;
            this.gridColumn44.Width = 388;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txt_ClassTotal_AddClass);
            this.panel13.Controls.Add(this.txt_ClassName_AddClass);
            this.panel13.Controls.Add(this.labelControl29);
            this.panel13.Controls.Add(this.labelControl28);
            this.panel13.Location = new System.Drawing.Point(0, 143);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(590, 45);
            this.panel13.TabIndex = 7;
            // 
            // txt_ClassTotal_AddClass
            // 
            this.txt_ClassTotal_AddClass.Location = new System.Drawing.Point(431, 10);
            this.txt_ClassTotal_AddClass.Name = "txt_ClassTotal_AddClass";
            this.txt_ClassTotal_AddClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassTotal_AddClass.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassTotal_AddClass.Size = new System.Drawing.Size(108, 28);
            this.txt_ClassTotal_AddClass.TabIndex = 3;
            // 
            // txt_ClassName_AddClass
            // 
            this.txt_ClassName_AddClass.Location = new System.Drawing.Point(98, 10);
            this.txt_ClassName_AddClass.MenuManager = this.ribbonControl1;
            this.txt_ClassName_AddClass.Name = "txt_ClassName_AddClass";
            this.txt_ClassName_AddClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ClassName_AddClass.Properties.Appearance.Options.UseFont = true;
            this.txt_ClassName_AddClass.Size = new System.Drawing.Size(190, 28);
            this.txt_ClassName_AddClass.TabIndex = 3;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl28.Location = new System.Drawing.Point(384, 13);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(41, 21);
            this.labelControl28.TabIndex = 1;
            this.labelControl28.Text = "Sỉ số:";
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl29.Location = new System.Drawing.Point(19, 13);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(61, 21);
            this.labelControl29.TabIndex = 2;
            this.labelControl29.Text = "Tên lớp:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox11.Image = global::StudentManagements.Properties.Resources.classInformationTitle;
            this.pictureBox11.Location = new System.Drawing.Point(323, 22);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(543, 44);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 5;
            this.pictureBox11.TabStop = false;
            // 
            // btn_AddStudentForClass_AddClass
            // 
            this.btn_AddStudentForClass_AddClass.Image = global::StudentManagements.Properties.Resources.addStudentIcon;
            this.btn_AddStudentForClass_AddClass.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_AddStudentForClass_AddClass.Location = new System.Drawing.Point(677, 143);
            this.btn_AddStudentForClass_AddClass.Name = "btn_AddStudentForClass_AddClass";
            this.btn_AddStudentForClass_AddClass.Size = new System.Drawing.Size(75, 45);
            this.btn_AddStudentForClass_AddClass.TabIndex = 8;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_Main)).EndInit();
            this.navFrame_Main.ResumeLayout(false);
            this.navPage_StudentsList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navPage_ClassList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList_View)).EndInit();
            this.navPage_StudentInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_StudentInformation)).EndInit();
            this.navFrame_StudentInformation.ResumeLayout(false);
            this.navPage_StudentEdit_StudentInformation.ResumeLayout(false);
            this.navPage_StudentEdit_StudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentEmail_StudentInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentAddress_StudentInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName_StudentInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID_StudentInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties)).EndInit();
            this.navPage_StudentDetail_StudentInformation.ResumeLayout(false);
            this.navPage_StudentDetail_StudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.navPage_ClassInformation.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassInformation_View)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navFrame_ClassInformation)).EndInit();
            this.navFrame_ClassInformation.ResumeLayout(false);
            this.navPage_ClassDetail.ResumeLayout(false);
            this.navPage_ClassDetail.PerformLayout();
            this.navPage_ClassDetail_Edit.ResumeLayout(false);
            this.navPage_ClassDetail_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_ClassInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_ClassInformation_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.navPage_ScoreBoardList.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.navPage_ScoreBoardDetail.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.navPage_AddStudent.ResumeLayout(false);
            this.studentInformationPanel.ResumeLayout(false);
            this.studentInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentEmail_AddStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName_AddStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.navPage_AddClass.ResumeLayout(false);
            this.navPage_FindStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.navPage_ScoreBoardDetail2.ResumeLayout(false);
            this.navPage_ScoreBoardDetail2.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ScoreBoardDetail2_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_AddClass_View)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassTotal_AddClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassName_AddClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_Home_Main;
        private DevExpress.XtraBars.BarButtonItem btn_AddStudent_Main;
        private DevExpress.XtraBars.BarButtonItem btn_AddClass_Main;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarButtonItem btn_FindStudents_Main;
        private DevExpress.XtraBars.BarButtonItem btn_AddReport_Main;
        private DevExpress.XtraBars.BarButtonItem btn_ChangeRules_Main;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Students_Actions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Class_Actions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_ScoreBoard_Actions;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame_Main;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_Home;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentsList;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassList;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardList;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardDetail;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_AddStudent;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_AddClass;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_CreateReports;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_FindStudents;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grd_StudentList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_StudentList;
        private DevExpress.XtraEditors.SimpleButton btn_Detail_StudentList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_ClassList;
        private DevExpress.XtraEditors.SimpleButton btn_Detail_ClassList;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl grd_ClassList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ClassList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame_StudentInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentEdit_StudentInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentDetail_StudentInformation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevExpress.XtraEditors.LabelControl txt_StudentSex_StudentInformation_Detail;
        private DevExpress.XtraEditors.LabelControl txt_StudentAddress_StudentInformation_Detail;
        private DevExpress.XtraEditors.LabelControl txt_StudentEmail_StudentInformation_Detail;
        private DevExpress.XtraEditors.LabelControl txt_StudentDateOfBirth_StudentInformation_Detail;
        private DevExpress.XtraEditors.LabelControl txt_StudentName_StudentInformation_Detail;
        private DevExpress.XtraEditors.LabelControl txt_StudentID_StudentInformation_Detail;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel studentInformationPanel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_StudentEmail_AddStudent;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_StudentName_AddStudent;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit cb_StudentDateOfBirth_AddStudent;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RichTextBox txt_StudentAddress_AddStudent;
        private DevExpress.XtraEditors.SimpleButton btn_Done_AddStudent;
        private DevExpress.XtraGrid.GridControl grd_ClassInformation;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ClassInformation_View;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cb_StudentSex_AddStudent;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_StudentInformation;
        private DevExpress.XtraEditors.SimpleButton btn_Save_StudentInformation;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_ClassInformation;
        private DevExpress.XtraEditors.SimpleButton btn_Save_ClassInformation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame_ClassInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl txt_ClassTotal_ClassInformation;
        private DevExpress.XtraEditors.LabelControl txt_ClassName_ClassInformation;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ClassDetail_Edit;
        private DevExpress.XtraEditors.TextEdit txt_ClassTotal_ClassInformation_Edit;
        private DevExpress.XtraEditors.TextEdit txt_ClassName_ClassInformation_Edit;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraGrid.GridControl grd_ScoreBoardList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ScoreBoardList_View;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_ScoreBoardList;
        private DevExpress.XtraEditors.SimpleButton btn_LookUp_ScoreBoardList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_ScoreBoardDetail;
        private DevExpress.XtraEditors.SimpleButton btn_New_ScoreBoardDetail;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl grd_ScoreBoardDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ScoreBoardDetail_View;
        private System.Windows.Forms.PictureBox pictureBox8;
        private DevExpress.XtraEditors.SimpleButton btn_All_ScoreBoardList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_ScoreBoardDetail2;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl txt_ClassName_ScoreBoardDetail2;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_ScoreBoardDetail2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraGrid.GridControl grd_ScoreBoardDetail2;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ScoreBoardDetail2_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label txt_ClassID;
        private System.Windows.Forms.ComboBox cb_SelectSubject_ScoreBoardDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SimpleButton btn_Save_ScoreBoardDetail2;
        private System.Windows.Forms.ComboBox cb_StudentSex_StudentInformation_Edit;
        private DevExpress.XtraEditors.TextEdit txt_StudentEmail_StudentInformation_Edit;
        private DevExpress.XtraEditors.TextEdit txt_StudentAddress_StudentInformation_Edit;
        private DevExpress.XtraEditors.TextEdit txt_StudentName_StudentInformation_Edit;
        private DevExpress.XtraEditors.TextEdit txt_StudentID_StudentInformation_Edit;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.DateEdit cb_StudentDateOfBirth_StudentInformation_Edit;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private DevExpress.XtraBars.BarSubItem btn_FindStudent_Main;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraEditors.TextEdit txt_ClassTotal_AddClass;
        private DevExpress.XtraEditors.TextEdit txt_ClassName_AddClass;
        private DevExpress.XtraEditors.SimpleButton btn_Save_AddClass;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraGrid.GridControl grd_StudentList_AddClass;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_AddClass_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox pictureBox11;
        private DevExpress.XtraEditors.SimpleButton btn_AddStudentForClass_AddClass;
    }
}

