namespace StudentManagements.Teacher
{
    partial class uc_TeacherList
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
            this.grd_TeacherList = new DevExpress.XtraGrid.GridControl();
            this.grd_TeacherList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Detail = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TeacherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TeacherList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_TeacherList
            // 
            this.grd_TeacherList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_TeacherList.Location = new System.Drawing.Point(0, 204);
            this.grd_TeacherList.MainView = this.grd_TeacherList_View;
            this.grd_TeacherList.Name = "grd_TeacherList";
            this.grd_TeacherList.Size = new System.Drawing.Size(1188, 461);
            this.grd_TeacherList.TabIndex = 0;
            this.grd_TeacherList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_TeacherList_View});
            // 
            // grd_TeacherList_View
            // 
            this.grd_TeacherList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.grd_TeacherList_View.GridControl = this.grd_TeacherList;
            this.grd_TeacherList_View.Name = "grd_TeacherList_View";
            this.grd_TeacherList_View.OptionsBehavior.Editable = false;
            this.grd_TeacherList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_TeacherList_View.OptionsView.ShowGroupPanel = false;
            this.grd_TeacherList_View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grd_TeacherList_View_FocusedRowChanged);
            this.grd_TeacherList_View.DoubleClick += new System.EventHandler(this.grd_TeacherList_View_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã số";
            this.gridColumn1.FieldName = "MAGV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ Tên";
            this.gridColumn2.FieldName = "HOTEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 264;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giới Tính";
            this.gridColumn4.FieldName = "GIOITINH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 203;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Sinh";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "NGSINH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 200;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Học Hàm";
            this.gridColumn5.FieldName = "HOCHAM";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 207;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số Năm Kinh Nghiệm";
            this.gridColumn6.FieldName = "NAMKINHNGHIEM";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 201;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Anh";
            this.gridColumn7.FieldName = "ANH";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // btn_Detail
            // 
            this.btn_Detail.Enabled = false;
            this.btn_Detail.Location = new System.Drawing.Point(0, 165);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(91, 33);
            this.btn_Detail.TabIndex = 1;
            this.btn_Detail.Text = "Detail";
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(97, 165);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::StudentManagements.Properties.Resources.teacherList_title;
            this.pictureBox1.Location = new System.Drawing.Point(398, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // uc_TeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.grd_TeacherList);
            this.Name = "uc_TeacherList";
            this.Size = new System.Drawing.Size(1188, 665);
            ((System.ComponentModel.ISupportInitialize)(this.grd_TeacherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TeacherList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_TeacherList;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_TeacherList_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btn_Detail;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
