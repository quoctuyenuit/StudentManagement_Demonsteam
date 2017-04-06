namespace StudentManagements
{
    partial class TeachingDivision
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
            this.grd_ClassList = new DevExpress.XtraGrid.GridControl();
            this.grd_ClassList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.link_SelectTeacher = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_TeacherQualification_TeachingDivision = new DevExpress.XtraEditors.TextEdit();
            this.cb_TeacherSex_TeachingDivision = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TeacherExperience_TeachingDivision = new DevExpress.XtraEditors.TextEdit();
            this.txt_TeacherName_TeachingDivision = new DevExpress.XtraEditors.TextEdit();
            this.cb_TeacherDateOfBirth_TeachingDivision = new DevExpress.XtraEditors.DateEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grd_SubjectsList = new DevExpress.XtraGrid.GridControl();
            this.grd_SubjectsList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList_View)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherQualification_TeachingDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherExperience_TeachingDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherName_TeachingDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_TeacherDateOfBirth_TeachingDivision.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_TeacherDateOfBirth_TeachingDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectsList_View)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_ClassList
            // 
            this.grd_ClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ClassList.Location = new System.Drawing.Point(0, 0);
            this.grd_ClassList.MainView = this.grd_ClassList_View;
            this.grd_ClassList.Name = "grd_ClassList";
            this.grd_ClassList.Size = new System.Drawing.Size(673, 418);
            this.grd_ClassList.TabIndex = 0;
            this.grd_ClassList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ClassList_View});
            // 
            // grd_ClassList_View
            // 
            this.grd_ClassList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.grd_ClassList_View.GridControl = this.grd_ClassList;
            this.grd_ClassList_View.Name = "grd_ClassList_View";
            this.grd_ClassList_View.OptionsBehavior.Editable = false;
            this.grd_ClassList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_ClassList_View.OptionsView.ShowGroupPanel = false;
            this.grd_ClassList_View.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grd_ClassList_View_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Lớp";
            this.gridColumn1.FieldName = "MALOP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 79;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Lớp";
            this.gridColumn2.FieldName = "TENLOP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 260;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sỉ Số";
            this.gridColumn3.FieldName = "SISO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 122;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Năm Học";
            this.gridColumn4.FieldName = "NAMHOC";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 112;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 207);
            this.panel2.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.link_SelectTeacher);
            this.panelControl1.Controls.Add(this.txt_TeacherQualification_TeachingDivision);
            this.panelControl1.Controls.Add(this.cb_TeacherSex_TeachingDivision);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_TeacherExperience_TeachingDivision);
            this.panelControl1.Controls.Add(this.txt_TeacherName_TeachingDivision);
            this.panelControl1.Controls.Add(this.cb_TeacherDateOfBirth_TeachingDivision);
            this.panelControl1.Location = new System.Drawing.Point(12, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1017, 149);
            this.panelControl1.TabIndex = 3;
            // 
            // link_SelectTeacher
            // 
            this.link_SelectTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_SelectTeacher.Location = new System.Drawing.Point(41, 5);
            this.link_SelectTeacher.Name = "link_SelectTeacher";
            this.link_SelectTeacher.Size = new System.Drawing.Size(135, 16);
            this.link_SelectTeacher.TabIndex = 6;
            this.link_SelectTeacher.Text = "Chọn giáo viên có sẵn";
            this.link_SelectTeacher.Click += new System.EventHandler(this.link_SelectTeacher_Click);
            // 
            // txt_TeacherQualification_TeachingDivision
            // 
            this.txt_TeacherQualification_TeachingDivision.Location = new System.Drawing.Point(434, 86);
            this.txt_TeacherQualification_TeachingDivision.Name = "txt_TeacherQualification_TeachingDivision";
            this.txt_TeacherQualification_TeachingDivision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_TeacherQualification_TeachingDivision.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherQualification_TeachingDivision.Size = new System.Drawing.Size(140, 24);
            this.txt_TeacherQualification_TeachingDivision.TabIndex = 3;
            // 
            // cb_TeacherSex_TeachingDivision
            // 
            this.cb_TeacherSex_TeachingDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TeacherSex_TeachingDivision.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cb_TeacherSex_TeachingDivision.FormattingEnabled = true;
            this.cb_TeacherSex_TeachingDivision.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cb_TeacherSex_TeachingDivision.Location = new System.Drawing.Point(434, 38);
            this.cb_TeacherSex_TeachingDivision.Name = "cb_TeacherSex_TeachingDivision";
            this.cb_TeacherSex_TeachingDivision.Size = new System.Drawing.Size(140, 26);
            this.cb_TeacherSex_TeachingDivision.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Location = new System.Drawing.Point(354, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Học Hàm:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Location = new System.Drawing.Point(643, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(143, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Số Năm Kinh Nghiệm:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(41, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày Sinh:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(354, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Giới Tính:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(41, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ Tên:";
            // 
            // txt_TeacherExperience_TeachingDivision
            // 
            this.txt_TeacherExperience_TeachingDivision.Location = new System.Drawing.Point(802, 83);
            this.txt_TeacherExperience_TeachingDivision.Name = "txt_TeacherExperience_TeachingDivision";
            this.txt_TeacherExperience_TeachingDivision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_TeacherExperience_TeachingDivision.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherExperience_TeachingDivision.Size = new System.Drawing.Size(158, 24);
            this.txt_TeacherExperience_TeachingDivision.TabIndex = 4;
            // 
            // txt_TeacherName_TeachingDivision
            // 
            this.txt_TeacherName_TeachingDivision.Location = new System.Drawing.Point(132, 38);
            this.txt_TeacherName_TeachingDivision.Name = "txt_TeacherName_TeachingDivision";
            this.txt_TeacherName_TeachingDivision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_TeacherName_TeachingDivision.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherName_TeachingDivision.Size = new System.Drawing.Size(173, 24);
            this.txt_TeacherName_TeachingDivision.TabIndex = 0;
            // 
            // cb_TeacherDateOfBirth_TeachingDivision
            // 
            this.cb_TeacherDateOfBirth_TeachingDivision.EditValue = null;
            this.cb_TeacherDateOfBirth_TeachingDivision.Location = new System.Drawing.Point(132, 83);
            this.cb_TeacherDateOfBirth_TeachingDivision.Name = "cb_TeacherDateOfBirth_TeachingDivision";
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.Appearance.Options.UseFont = true;
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.EditFormat.FormatString = "";
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.cb_TeacherDateOfBirth_TeachingDivision.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cb_TeacherDateOfBirth_TeachingDivision.Size = new System.Drawing.Size(173, 24);
            this.cb_TeacherDateOfBirth_TeachingDivision.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(873, 166);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 29);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grd_ClassList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grd_SubjectsList);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 418);
            this.splitContainer1.SplitterDistance = 673;
            this.splitContainer1.TabIndex = 2;
            // 
            // grd_SubjectsList
            // 
            this.grd_SubjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_SubjectsList.Location = new System.Drawing.Point(0, 0);
            this.grd_SubjectsList.MainView = this.grd_SubjectsList_View;
            this.grd_SubjectsList.Name = "grd_SubjectsList";
            this.grd_SubjectsList.Size = new System.Drawing.Size(364, 418);
            this.grd_SubjectsList.TabIndex = 0;
            this.grd_SubjectsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_SubjectsList_View});
            // 
            // grd_SubjectsList_View
            // 
            this.grd_SubjectsList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn5});
            this.grd_SubjectsList_View.GridControl = this.grd_SubjectsList;
            this.grd_SubjectsList_View.Name = "grd_SubjectsList_View";
            this.grd_SubjectsList_View.OptionsBehavior.Editable = false;
            this.grd_SubjectsList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_SubjectsList_View.OptionsView.ShowGroupPanel = false;
            this.grd_SubjectsList_View.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grd_SubjectsList_View_RowClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên Môn Học";
            this.gridColumn6.FieldName = "TENMH";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 131;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên Giáo Viên";
            this.gridColumn7.FieldName = "HOTEN";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 193;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "MAMH";
            this.gridColumn8.FieldName = "MAMH";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "MAGV";
            this.gridColumn5.FieldName = "MAGV";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(954, 166);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 29);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // TeachingDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 625);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "TeachingDivision";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teaching Division";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeachingDivision_FormClosed);
            this.Load += new System.EventHandler(this.TeachingDivision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList_View)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherQualification_TeachingDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherExperience_TeachingDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherName_TeachingDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_TeacherDateOfBirth_TeachingDivision.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_TeacherDateOfBirth_TeachingDivision.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SubjectsList_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_ClassList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ClassList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grd_SubjectsList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_SubjectsList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_TeacherName_TeachingDivision;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cb_TeacherSex_TeachingDivision;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit cb_TeacherDateOfBirth_TeachingDivision;
        private DevExpress.XtraEditors.TextEdit txt_TeacherExperience_TeachingDivision;
        private DevExpress.XtraEditors.TextEdit txt_TeacherQualification_TeachingDivision;
        private DevExpress.XtraEditors.HyperlinkLabelControl link_SelectTeacher;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_Close;

    }
}