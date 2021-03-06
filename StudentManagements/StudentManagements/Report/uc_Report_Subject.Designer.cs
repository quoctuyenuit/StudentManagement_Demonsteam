﻿namespace StudentManagements.Report
{
    partial class uc_Report_Subject
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grd_Report = new DevExpress.XtraGrid.GridControl();
            this.grd_Report_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Report_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grd_Report);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 481);
            this.panel1.TabIndex = 27;
            // 
            // grd_Report
            // 
            this.grd_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Report.Location = new System.Drawing.Point(0, 0);
            this.grd_Report.MainView = this.grd_Report_View;
            this.grd_Report.Name = "grd_Report";
            this.grd_Report.Size = new System.Drawing.Size(1188, 481);
            this.grd_Report.TabIndex = 0;
            this.grd_Report.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_Report_View});
            // 
            // grd_Report_View
            // 
            this.grd_Report_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grd_Report_View.GridControl = this.grd_Report;
            this.grd_Report_View.Name = "grd_Report_View";
            this.grd_Report_View.OptionsBehavior.Editable = false;
            this.grd_Report_View.OptionsView.ShowGroupPanel = false;
            this.grd_Report_View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grd_Report_View_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã số";
            this.gridColumn1.FieldName = "MALOP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 96;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Lớp";
            this.gridColumn2.FieldName = "TENLOP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 267;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sỉ Số";
            this.gridColumn3.FieldName = "SISO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 267;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng Đạt";
            this.gridColumn4.FieldName = "SOLUONGDAT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 267;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tỉ lệ";
            this.gridColumn5.FieldName = "TILE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 271;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester:";
            // 
            // cbSubject
            // 
            this.cbSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSubject.Location = new System.Drawing.Point(452, 5);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSubject.Properties.Appearance.Options.UseFont = true;
            this.cbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSubject.Size = new System.Drawing.Size(162, 24);
            this.cbSubject.TabIndex = 29;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // cbSemester
            // 
            this.cbSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSemester.Location = new System.Drawing.Point(698, 5);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSemester.Properties.Appearance.Options.UseFont = true;
            this.cbSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSemester.Size = new System.Drawing.Size(127, 24);
            this.cbSemester.TabIndex = 29;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // uc_Report_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_Report_Subject";
            this.Size = new System.Drawing.Size(1189, 519);
            this.Load += new System.EventHandler(this.uc_Report_Subject_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Report_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grd_Report;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_Report_View;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.ComboBoxEdit cbSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cbSemester;

    }
}
