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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Home_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddStudent_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddClass_Main = new DevExpress.XtraBars.BarButtonItem();
            this.btn_FindStudents_Main = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Students_Actions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Class_Actions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_ScoreBoard_Actions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
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
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem1,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 9;
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
            this.btn_FindStudents_Main.Caption = "Find Students";
            this.btn_FindStudents_Main.Id = 4;
            this.btn_FindStudents_Main.LargeGlyph = global::StudentManagements.Properties.Resources.findStudentIcon;
            this.btn_FindStudents_Main.Name = "btn_FindStudents_Main";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Add Report";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.LargeGlyph = global::StudentManagements.Properties.Resources.reportIcon;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Change Rules";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.LargeGlyph = global::StudentManagements.Properties.Resources.changeRulesIcon;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 8;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_FindStudents_Main);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1, true);
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
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
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
            // 
            // btn_Class_Actions
            // 
            this.btn_Class_Actions.Name = "btn_Class_Actions";
            this.btn_Class_Actions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Class_Actions.Text = "Class";
            // 
            // btn_ScoreBoard_Actions
            // 
            this.btn_ScoreBoard_Actions.Name = "btn_ScoreBoard_Actions";
            this.btn_ScoreBoard_Actions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_ScoreBoard_Actions.Text = "Score Board";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.navigationFrame1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(248, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 643);
            this.panel2.TabIndex = 2;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(1190, 643);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1190, 643);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1190, 643);
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
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
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.BarButtonItem btn_FindStudents_Main;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Students_Actions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Class_Actions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_ScoreBoard_Actions;
    }
}

