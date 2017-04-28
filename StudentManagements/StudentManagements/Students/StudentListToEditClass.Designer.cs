namespace StudentManagements.Students
{
    partial class StudentListToEditClass
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
            this.btn_OK_AddStudentForClass = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.grd_AddStudentForClass = new DevExpress.XtraGrid.GridControl();
            this.grd_AddStudentForClass_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AddStudentForClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AddStudentForClass_View)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK_AddStudentForClass
            // 
            this.btn_OK_AddStudentForClass.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK_AddStudentForClass.Location = new System.Drawing.Point(1, 158);
            this.btn_OK_AddStudentForClass.Name = "btn_OK_AddStudentForClass";
            this.btn_OK_AddStudentForClass.Size = new System.Drawing.Size(91, 33);
            this.btn_OK_AddStudentForClass.TabIndex = 15;
            this.btn_OK_AddStudentForClass.Text = "OK";
            this.btn_OK_AddStudentForClass.Click += new System.EventHandler(this.btn_OK_AddStudentForClass_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::StudentManagements.Properties.Resources.studentsListTitle;
            this.pictureBox10.Location = new System.Drawing.Point(397, 24);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(396, 45);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.grd_AddStudentForClass);
            this.panel11.Location = new System.Drawing.Point(1, 197);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1193, 495);
            this.panel11.TabIndex = 13;
            // 
            // grd_AddStudentForClass
            // 
            this.grd_AddStudentForClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_AddStudentForClass.Location = new System.Drawing.Point(0, 0);
            this.grd_AddStudentForClass.MainView = this.grd_AddStudentForClass_View;
            this.grd_AddStudentForClass.Name = "grd_AddStudentForClass";
            this.grd_AddStudentForClass.Size = new System.Drawing.Size(1193, 495);
            this.grd_AddStudentForClass.TabIndex = 2;
            this.grd_AddStudentForClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_AddStudentForClass_View});
            // 
            // grd_AddStudentForClass_View
            // 
            this.grd_AddStudentForClass_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn45,
            this.gridColumn46,
            this.gridColumn47,
            this.gridColumn48,
            this.gridColumn49,
            this.gridColumn50});
            this.grd_AddStudentForClass_View.GridControl = this.grd_AddStudentForClass;
            this.grd_AddStudentForClass_View.Name = "grd_AddStudentForClass_View";
            this.grd_AddStudentForClass_View.OptionsBehavior.Editable = false;
            this.grd_AddStudentForClass_View.OptionsFind.AlwaysVisible = true;
            this.grd_AddStudentForClass_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_AddStudentForClass_View.OptionsSelection.MultiSelect = true;
            this.grd_AddStudentForClass_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grd_AddStudentForClass_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "MSHS";
            this.gridColumn45.FieldName = "MSHS";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.OptionsColumn.FixedWidth = true;
            this.gridColumn45.Visible = true;
            this.gridColumn45.VisibleIndex = 1;
            this.gridColumn45.Width = 86;
            // 
            // gridColumn46
            // 
            this.gridColumn46.Caption = "Họ Tên";
            this.gridColumn46.FieldName = "HOTEN";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.OptionsColumn.FixedWidth = true;
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 2;
            this.gridColumn46.Width = 221;
            // 
            // gridColumn47
            // 
            this.gridColumn47.Caption = "Ngày Sinh";
            this.gridColumn47.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn47.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn47.FieldName = "NGSINH";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.OptionsColumn.FixedWidth = true;
            this.gridColumn47.Visible = true;
            this.gridColumn47.VisibleIndex = 3;
            this.gridColumn47.Width = 164;
            // 
            // gridColumn48
            // 
            this.gridColumn48.Caption = "Email";
            this.gridColumn48.FieldName = "EMAIL";
            this.gridColumn48.Name = "gridColumn48";
            this.gridColumn48.Visible = true;
            this.gridColumn48.VisibleIndex = 4;
            this.gridColumn48.Width = 229;
            // 
            // gridColumn49
            // 
            this.gridColumn49.Caption = "Giới Tính";
            this.gridColumn49.FieldName = "GIOITINH";
            this.gridColumn49.Name = "gridColumn49";
            this.gridColumn49.OptionsColumn.FixedWidth = true;
            this.gridColumn49.Visible = true;
            this.gridColumn49.VisibleIndex = 5;
            this.gridColumn49.Width = 80;
            // 
            // gridColumn50
            // 
            this.gridColumn50.Caption = "Địa Chỉ";
            this.gridColumn50.FieldName = "DIACHI";
            this.gridColumn50.Name = "gridColumn50";
            this.gridColumn50.Visible = true;
            this.gridColumn50.VisibleIndex = 6;
            this.gridColumn50.Width = 388;
            // 
            // StudentListToEditClass
            // 
            this.AcceptButton = this.btn_OK_AddStudentForClass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 692);
            this.Controls.Add(this.btn_OK_AddStudentForClass);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.panel11);
            this.Name = "StudentListToEditClass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentListToEditClass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_AddStudentForClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AddStudentForClass_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_OK_AddStudentForClass;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraGrid.GridControl grd_AddStudentForClass;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_AddStudentForClass_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;

    }
}