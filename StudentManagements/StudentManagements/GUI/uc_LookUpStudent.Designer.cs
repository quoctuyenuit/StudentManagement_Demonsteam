﻿namespace StudentManagements.GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grd_StudentList = new DevExpress.XtraGrid.GridControl();
            this.grd_StudentList_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grd_StudentList);
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 470);
            this.panel1.TabIndex = 0;
            // 
            // grd_StudentList
            // 
            this.grd_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StudentList.Location = new System.Drawing.Point(0, 0);
            this.grd_StudentList.MainView = this.grd_StudentList_View;
            this.grd_StudentList.Name = "grd_StudentList";
            this.grd_StudentList.Size = new System.Drawing.Size(1188, 470);
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
            this.grd_StudentList_View.OptionsView.ShowGroupPanel = false;
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
            this.pictureBox1.Location = new System.Drawing.Point(397, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // uc_LookUpStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "uc_LookUpStudent";
            this.Size = new System.Drawing.Size(1188, 665);
            this.Load += new System.EventHandler(this.uc_LookUpStudent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StudentList_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}
