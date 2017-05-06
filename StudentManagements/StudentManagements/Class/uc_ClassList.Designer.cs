namespace StudentManagements.Class
{
    partial class uc_ClassList
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList_View)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::StudentManagements.Properties.Resources.classListTitle;
            this.pictureBox2.Location = new System.Drawing.Point(454, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Delete_ClassList
            // 
            this.btn_Delete_ClassList.Location = new System.Drawing.Point(97, 165);
            this.btn_Delete_ClassList.Name = "btn_Delete_ClassList";
            this.btn_Delete_ClassList.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete_ClassList.TabIndex = 10;
            this.btn_Delete_ClassList.Text = "Delete";
            this.btn_Delete_ClassList.Click += new System.EventHandler(this.btn_Delete_ClassList_Click);
            // 
            // btn_Detail_ClassList
            // 
            this.btn_Detail_ClassList.Location = new System.Drawing.Point(0, 165);
            this.btn_Detail_ClassList.Name = "btn_Detail_ClassList";
            this.btn_Detail_ClassList.Size = new System.Drawing.Size(91, 33);
            this.btn_Detail_ClassList.TabIndex = 11;
            this.btn_Detail_ClassList.Text = "Detail";
            this.btn_Detail_ClassList.Click += new System.EventHandler(this.btn_Detail_ClassList_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.grd_ClassList);
            this.panel4.Location = new System.Drawing.Point(0, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1188, 458);
            this.panel4.TabIndex = 9;
            // 
            // grd_ClassList
            // 
            this.grd_ClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ClassList.Location = new System.Drawing.Point(0, 0);
            this.grd_ClassList.MainView = this.grd_ClassList_View;
            this.grd_ClassList.Name = "grd_ClassList";
            this.grd_ClassList.Size = new System.Drawing.Size(1188, 458);
            this.grd_ClassList.TabIndex = 1;
            this.grd_ClassList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ClassList_View});
            // 
            // grd_ClassList_View
            // 
            this.grd_ClassList_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn1,
            this.gridColumn11});
            this.grd_ClassList_View.GridControl = this.grd_ClassList;
            this.grd_ClassList_View.Name = "grd_ClassList_View";
            this.grd_ClassList_View.OptionsBehavior.Editable = false;
            this.grd_ClassList_View.OptionsFind.AlwaysVisible = true;
            this.grd_ClassList_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_ClassList_View.OptionsView.ShowGroupPanel = false;
            this.grd_ClassList_View.DoubleClick += new System.EventHandler(this.grd_ClassList_View_DoubleClick);
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
            this.gridColumn10.Width = 139;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Giáo viên chủ nhiệm";
            this.gridColumn1.FieldName = "GVCN";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 155;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ghi Chú";
            this.gridColumn11.FieldName = "GHICHU";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 554;
            // 
            // uc_ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Delete_ClassList);
            this.Controls.Add(this.btn_Detail_ClassList);
            this.Controls.Add(this.panel4);
            this.Name = "uc_ClassList";
            this.Size = new System.Drawing.Size(1188, 665);
            this.Load += new System.EventHandler(this.uc_ClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ClassList_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
