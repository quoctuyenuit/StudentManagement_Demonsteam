namespace StudentManagements.Students
{
    partial class uc_StudentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_StudentsList));
            this.panel3 = new System.Windows.Forms.Panel();
            this.grd_StudentList = new DevExpress.XtraGrid.GridControl();
            this.grd_StudentList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColumn_NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Delete_StudentList = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Detail_StudentList = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.grd_StudentList);
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1186, 471);
            this.panel3.TabIndex = 9;
            // 
            // grd_StudentList
            // 
            this.grd_StudentList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grd_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList.MainView = this.grd_StudentList_View;
            this.grd_StudentList.Name = "grd_StudentList";
            this.grd_StudentList.Size = new System.Drawing.Size(1186, 471);
            this.grd_StudentList.TabIndex = 0;
            this.grd_StudentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_StudentList_View});
            // 
            // grd_StudentList_View
            // 
            this.grd_StudentList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.grdColumn_NgaySinh,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grd_StudentList_View.GridControl = this.grd_StudentList;
            this.grd_StudentList_View.Name = "grd_StudentList_View";
            this.grd_StudentList_View.OptionsBehavior.Editable = false;
            this.grd_StudentList_View.OptionsFind.AlwaysVisible = true;
            this.grd_StudentList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_StudentList_View.OptionsView.ShowGroupPanel = false;
            this.grd_StudentList_View.DoubleClick += new System.EventHandler(this.grd_StudentList_View_DoubleClick);
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
            // grdColumn_NgaySinh
            // 
            this.grdColumn_NgaySinh.Caption = "Ngày Sinh";
            this.grdColumn_NgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.grdColumn_NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdColumn_NgaySinh.FieldName = "NGSINH";
            this.grdColumn_NgaySinh.Name = "grdColumn_NgaySinh";
            this.grdColumn_NgaySinh.OptionsColumn.FixedWidth = true;
            this.grdColumn_NgaySinh.Visible = true;
            this.grdColumn_NgaySinh.VisibleIndex = 2;
            this.grdColumn_NgaySinh.Width = 152;
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
            this.pictureBox1.Location = new System.Drawing.Point(469, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Delete_StudentList
            // 
            this.btn_Delete_StudentList.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete_StudentList.Image")));
            this.btn_Delete_StudentList.Location = new System.Drawing.Point(97, 162);
            this.btn_Delete_StudentList.Name = "btn_Delete_StudentList";
            this.btn_Delete_StudentList.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_StudentList.TabIndex = 10;
            this.btn_Delete_StudentList.Text = "Delete";
            this.btn_Delete_StudentList.Click += new System.EventHandler(this.btn_Delete_StudentList_Click);
            // 
            // btn_Detail_StudentList
            // 
            this.btn_Detail_StudentList.Image = ((System.Drawing.Image)(resources.GetObject("btn_Detail_StudentList.Image")));
            this.btn_Detail_StudentList.Location = new System.Drawing.Point(0, 162);
            this.btn_Detail_StudentList.Name = "btn_Detail_StudentList";
            this.btn_Detail_StudentList.Size = new System.Drawing.Size(91, 33);
            this.btn_Detail_StudentList.TabIndex = 11;
            this.btn_Detail_StudentList.Text = "Detail";
            this.btn_Detail_StudentList.Click += new System.EventHandler(this.btn_Detail_StudentList_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.Location = new System.Drawing.Point(194, 162);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(119, 33);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // uc_StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Delete_StudentList);
            this.Controls.Add(this.btn_Detail_StudentList);
            this.Name = "uc_StudentsList";
            this.Size = new System.Drawing.Size(1186, 672);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grd_StudentList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_StudentList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_StudentList;
        private DevExpress.XtraEditors.SimpleButton btn_Detail_StudentList;
        private DevExpress.XtraEditors.SimpleButton btnAddStudent;
    }
}
