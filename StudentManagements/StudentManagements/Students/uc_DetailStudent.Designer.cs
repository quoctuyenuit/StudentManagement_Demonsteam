namespace StudentManagements.Students
{
    partial class uc_DetailStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DetailStudent));
            this.link_EditImage_StudentInformation = new DevExpress.XtraEditors.HyperlinkLabelControl();
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
            this.pic_StudentInformation = new System.Windows.Forms.PictureBox();
            this.btn_Apply_StudentInformation = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Edit_StudentInformation = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_StudentInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // link_EditImage_StudentInformation
            // 
            this.link_EditImage_StudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_EditImage_StudentInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_EditImage_StudentInformation.Location = new System.Drawing.Point(673, 300);
            this.link_EditImage_StudentInformation.Name = "link_EditImage_StudentInformation";
            this.link_EditImage_StudentInformation.Size = new System.Drawing.Size(21, 16);
            this.link_EditImage_StudentInformation.TabIndex = 11;
            this.link_EditImage_StudentInformation.Text = "Edit";
            this.link_EditImage_StudentInformation.Click += new System.EventHandler(this.link_EditImage_StudentInformation_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.navFrame_StudentInformation);
            this.panel5.Location = new System.Drawing.Point(247, 336);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(694, 267);
            this.panel5.TabIndex = 7;
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
            this.navPage_StudentEdit_StudentInformation.Caption = "navPage_StudentEdit_StudentInformation";
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
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Name = "cb_StudentDateOfBirth_StudentInformation_Edit";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Appearance.Options.UseFont = true;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.EditFormat.FormatString = "";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cb_StudentDateOfBirth_StudentInformation_Edit.Size = new System.Drawing.Size(205, 28);
            this.cb_StudentDateOfBirth_StudentInformation_Edit.TabIndex = 5;
            // 
            // navPage_StudentDetail_StudentInformation
            // 
            this.navPage_StudentDetail_StudentInformation.Caption = "navPage_StudentDetail_StudentInformation";
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
            // pic_StudentInformation
            // 
            this.pic_StudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_StudentInformation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pic_StudentInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_StudentInformation.Image = global::StudentManagements.Properties.Resources.StudentIcon;
            this.pic_StudentInformation.Location = new System.Drawing.Point(524, 130);
            this.pic_StudentInformation.Name = "pic_StudentInformation";
            this.pic_StudentInformation.Size = new System.Drawing.Size(140, 186);
            this.pic_StudentInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_StudentInformation.TabIndex = 8;
            this.pic_StudentInformation.TabStop = false;
            // 
            // btn_Apply_StudentInformation
            // 
            this.btn_Apply_StudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Apply_StudentInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Apply_StudentInformation.Image")));
            this.btn_Apply_StudentInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Apply_StudentInformation.Location = new System.Drawing.Point(866, 285);
            this.btn_Apply_StudentInformation.Name = "btn_Apply_StudentInformation";
            this.btn_Apply_StudentInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Apply_StudentInformation.TabIndex = 9;
            this.btn_Apply_StudentInformation.Click += new System.EventHandler(this.btn_Apply_StudentInformation_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::StudentManagements.Properties.Resources.studentInformationTitle;
            this.pictureBox3.Location = new System.Drawing.Point(284, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(621, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Edit_StudentInformation
            // 
            this.btn_Edit_StudentInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Edit_StudentInformation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit_StudentInformation.Image")));
            this.btn_Edit_StudentInformation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Edit_StudentInformation.Location = new System.Drawing.Point(866, 285);
            this.btn_Edit_StudentInformation.Name = "btn_Edit_StudentInformation";
            this.btn_Edit_StudentInformation.Size = new System.Drawing.Size(75, 45);
            this.btn_Edit_StudentInformation.TabIndex = 10;
            this.btn_Edit_StudentInformation.Click += new System.EventHandler(this.btn_Edit_StudentInformation_Click);
            // 
            // uc_DetailStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_StudentInformation);
            this.Controls.Add(this.link_EditImage_StudentInformation);
            this.Controls.Add(this.btn_Apply_StudentInformation);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_Edit_StudentInformation);
            this.Name = "uc_DetailStudent";
            this.Size = new System.Drawing.Size(1188, 665);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_StudentInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_StudentInformation;
        private DevExpress.XtraEditors.HyperlinkLabelControl link_EditImage_StudentInformation;
        private DevExpress.XtraEditors.SimpleButton btn_Apply_StudentInformation;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame_StudentInformation;
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentEdit_StudentInformation;
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
        private DevExpress.XtraBars.Navigation.NavigationPage navPage_StudentDetail_StudentInformation;
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_StudentInformation;
    }
}
