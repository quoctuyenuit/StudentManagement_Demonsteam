namespace StudentManagements.Students
{
    partial class uc_LookUpStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_LookUpStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grd_StudentList = new DevExpress.XtraGrid.GridControl();
            this.grd_StudentList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Detail = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.cbSchoolYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchoolYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grd_StudentList);
            this.panel1.Location = new System.Drawing.Point(2, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 460);
            this.panel1.TabIndex = 0;
            // 
            // grd_StudentList
            // 
            this.grd_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList.MainView = this.grd_StudentList_View;
            this.grd_StudentList.Name = "grd_StudentList";
            this.grd_StudentList.Size = new System.Drawing.Size(1188, 460);
            this.grd_StudentList.TabIndex = 0;
            this.grd_StudentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_StudentList_View});
            // 
            // grd_StudentList_View
            // 
            this.grd_StudentList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grd_StudentList_View.GridControl = this.grd_StudentList;
            this.grd_StudentList_View.Name = "grd_StudentList_View";
            this.grd_StudentList_View.OptionsBehavior.Editable = false;
            this.grd_StudentList_View.OptionsFind.AlwaysVisible = true;
            this.grd_StudentList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_StudentList_View.OptionsView.ShowGroupPanel = false;
            this.grd_StudentList_View.DoubleClick += new System.EventHandler(this.grd_StudentList_View_DoubleClick);
            this.grd_StudentList_View.DataSourceChanged += new System.EventHandler(this.grd_StudentList_View_DataSourceChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã số";
            this.gridColumn1.FieldName = "MSHS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 76;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ Tên";
            this.gridColumn2.FieldName = "HOTEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 270;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lớp";
            this.gridColumn3.FieldName = "TENLOP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 270;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "TB Học Kỳ I";
            this.gridColumn4.FieldName = "TBHK1";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 270;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "TB Học Kỳ II";
            this.gridColumn5.FieldName = "TBHK2";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 282;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::StudentManagements.Properties.Resources.studentsListTitle;
            this.pictureBox1.Location = new System.Drawing.Point(397, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Detail
            // 
            this.btn_Detail.Image = ((System.Drawing.Image)(resources.GetObject("btn_Detail.Image")));
            this.btn_Detail.Location = new System.Drawing.Point(2, 166);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(91, 33);
            this.btn_Detail.TabIndex = 5;
            this.btn_Detail.Text = "Detail";
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(99, 166);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.Location = new System.Drawing.Point(196, 175);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSchoolYear.Properties.Appearance.Options.UseFont = true;
            this.cbSchoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSchoolYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSchoolYear.Size = new System.Drawing.Size(194, 24);
            this.cbSchoolYear.TabIndex = 6;
            this.cbSchoolYear.SelectedIndexChanged += new System.EventHandler(this.cbSchoolYear_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(196, 151);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "School Year:";
            // 
            // uc_LookUpStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbSchoolYear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "uc_LookUpStudent";
            this.Size = new System.Drawing.Size(1188, 665);
            this.Load += new System.EventHandler(this.uc_LookUpStudent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchoolYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grd_StudentList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Detail;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.ComboBoxEdit cbSchoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
