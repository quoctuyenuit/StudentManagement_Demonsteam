namespace StudentManagements.Students
{
    partial class uc_AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_AddStudent));
            this.link_EditImage_AddStudent = new DevExpress.XtraEditors.HyperlinkLabelControl();
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
            this.pic_StudentInformation_AddStudent = new System.Windows.Forms.PictureBox();
            this.btn_Done_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.studentInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentEmail_AddStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName_AddStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StudentInformation_AddStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // link_EditImage_AddStudent
            // 
            this.link_EditImage_AddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_EditImage_AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_EditImage_AddStudent.Location = new System.Drawing.Point(673, 300);
            this.link_EditImage_AddStudent.Name = "link_EditImage_AddStudent";
            this.link_EditImage_AddStudent.Size = new System.Drawing.Size(21, 16);
            this.link_EditImage_AddStudent.TabIndex = 8;
            this.link_EditImage_AddStudent.Text = "Edit";
            this.link_EditImage_AddStudent.Click += new System.EventHandler(this.link_EditImage_AddStudent_Click);
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
            this.studentInformationPanel.Location = new System.Drawing.Point(162, 336);
            this.studentInformationPanel.Name = "studentInformationPanel";
            this.studentInformationPanel.Size = new System.Drawing.Size(865, 229);
            this.studentInformationPanel.TabIndex = 7;
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
            this.cb_StudentSex_AddStudent.TabIndex = 3;
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
            this.txt_StudentEmail_AddStudent.TabIndex = 2;
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
            this.txt_StudentName_AddStudent.Name = "txt_StudentName_AddStudent";
            this.txt_StudentName_AddStudent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StudentName_AddStudent.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentName_AddStudent.Size = new System.Drawing.Size(235, 28);
            this.txt_StudentName_AddStudent.TabIndex = 0;
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
            this.cb_StudentDateOfBirth_AddStudent.Name = "cb_StudentDateOfBirth_AddStudent";
            this.cb_StudentDateOfBirth_AddStudent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cb_StudentDateOfBirth_AddStudent.Properties.Appearance.Options.UseFont = true;
            this.cb_StudentDateOfBirth_AddStudent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.cb_StudentDateOfBirth_AddStudent.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cb_StudentDateOfBirth_AddStudent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_AddStudent.Properties.EditFormat.FormatString = "";
            this.cb_StudentDateOfBirth_AddStudent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_AddStudent.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.cb_StudentDateOfBirth_AddStudent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cb_StudentDateOfBirth_AddStudent.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.cb_StudentDateOfBirth_AddStudent.Size = new System.Drawing.Size(235, 28);
            this.cb_StudentDateOfBirth_AddStudent.TabIndex = 1;
            // 
            // pic_StudentInformation_AddStudent
            // 
            this.pic_StudentInformation_AddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_StudentInformation_AddStudent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pic_StudentInformation_AddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_StudentInformation_AddStudent.Image = global::StudentManagements.Properties.Resources.StudentIcon;
            this.pic_StudentInformation_AddStudent.Location = new System.Drawing.Point(524, 130);
            this.pic_StudentInformation_AddStudent.Name = "pic_StudentInformation_AddStudent";
            this.pic_StudentInformation_AddStudent.Size = new System.Drawing.Size(140, 186);
            this.pic_StudentInformation_AddStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_StudentInformation_AddStudent.TabIndex = 9;
            this.pic_StudentInformation_AddStudent.TabStop = false;
            // 
            // btn_Done_AddStudent
            // 
            this.btn_Done_AddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Done_AddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btn_Done_AddStudent.Image")));
            this.btn_Done_AddStudent.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Done_AddStudent.Location = new System.Drawing.Point(952, 285);
            this.btn_Done_AddStudent.Name = "btn_Done_AddStudent";
            this.btn_Done_AddStudent.Size = new System.Drawing.Size(75, 45);
            this.btn_Done_AddStudent.TabIndex = 5;
            this.btn_Done_AddStudent.Click += new System.EventHandler(this.btn_Done_AddStudent_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Image = global::StudentManagements.Properties.Resources.studentInformationTitle;
            this.pictureBox5.Location = new System.Drawing.Point(284, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(621, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // uc_AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_StudentInformation_AddStudent);
            this.Controls.Add(this.link_EditImage_AddStudent);
            this.Controls.Add(this.btn_Done_AddStudent);
            this.Controls.Add(this.studentInformationPanel);
            this.Controls.Add(this.pictureBox5);
            this.Name = "uc_AddStudent";
            this.Size = new System.Drawing.Size(1188, 665);
            this.Load += new System.EventHandler(this.uc_AddStudent_Load);
            this.studentInformationPanel.ResumeLayout(false);
            this.studentInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentEmail_AddStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName_AddStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_StudentDateOfBirth_AddStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StudentInformation_AddStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_StudentInformation_AddStudent;
        private DevExpress.XtraEditors.HyperlinkLabelControl link_EditImage_AddStudent;
        private DevExpress.XtraEditors.SimpleButton btn_Done_AddStudent;
        private System.Windows.Forms.Panel studentInformationPanel;
        private System.Windows.Forms.ComboBox cb_StudentSex_AddStudent;
        private System.Windows.Forms.RichTextBox txt_StudentAddress_AddStudent;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_StudentEmail_AddStudent;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_StudentName_AddStudent;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit cb_StudentDateOfBirth_AddStudent;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
