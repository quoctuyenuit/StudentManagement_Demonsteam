namespace StudentManagements.Report
{
    partial class uc_Report
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
            this.tabPane_Reports = new DevExpress.XtraBars.Navigation.TabPane();
            this.tab_Subject = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tab_Semester = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane_Reports)).BeginInit();
            this.tabPane_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane_Reports
            // 
            this.tabPane_Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane_Reports.Controls.Add(this.tab_Subject);
            this.tabPane_Reports.Controls.Add(this.tab_Semester);
            this.tabPane_Reports.Location = new System.Drawing.Point(1, 138);
            this.tabPane_Reports.Name = "tabPane_Reports";
            this.tabPane_Reports.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tab_Subject,
            this.tab_Semester});
            this.tabPane_Reports.RegularSize = new System.Drawing.Size(1189, 527);
            this.tabPane_Reports.SelectedPage = this.tab_Subject;
            this.tabPane_Reports.Size = new System.Drawing.Size(1189, 527);
            this.tabPane_Reports.TabIndex = 2;
            this.tabPane_Reports.Text = "a";
            this.tabPane_Reports.TransitionAnimationProperties.FrameCount = 0;
            this.tabPane_Reports.TransitionAnimationProperties.FrameInterval = 0;
            this.tabPane_Reports.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane_Reports_SelectedPageChanged);
            // 
            // tab_Subject
            // 
            this.tab_Subject.Caption = "Subject";
            this.tab_Subject.Name = "tab_Subject";
            this.tab_Subject.Size = new System.Drawing.Size(1167, 471);
            // 
            // tab_Semester
            // 
            this.tab_Semester.Caption = "Semester";
            this.tab_Semester.Name = "tab_Semester";
            this.tab_Semester.Size = new System.Drawing.Size(1167, 464);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.Image = global::StudentManagements.Properties.Resources.reportTitle;
            this.pictureBox8.Location = new System.Drawing.Point(383, 33);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(424, 44);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // uc_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.tabPane_Reports);
            this.Name = "uc_Report";
            this.Size = new System.Drawing.Size(1188, 665);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane_Reports)).EndInit();
            this.tabPane_Reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private DevExpress.XtraBars.Navigation.TabPane tabPane_Reports;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_Subject;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_Semester;
    }
}
