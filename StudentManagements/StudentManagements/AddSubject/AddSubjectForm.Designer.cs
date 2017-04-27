namespace StudentManagements.AddSubject
{
    partial class AddSubjectForm
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
            this.grd_Subjects = new DevExpress.XtraGrid.GridControl();
            this.grd_Subjects_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColumn_MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColumn_TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_OK_AddSubjectForm = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel_AddSubjectForm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Subjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Subjects_View)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Subjects
            // 
            this.grd_Subjects.Location = new System.Drawing.Point(12, 12);
            this.grd_Subjects.MainView = this.grd_Subjects_View;
            this.grd_Subjects.Name = "grd_Subjects";
            this.grd_Subjects.Size = new System.Drawing.Size(342, 405);
            this.grd_Subjects.TabIndex = 0;
            this.grd_Subjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_Subjects_View});
            // 
            // grd_Subjects_View
            // 
            this.grd_Subjects_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColumn_MAMH,
            this.grdColumn_TENMH});
            this.grd_Subjects_View.GridControl = this.grd_Subjects;
            this.grd_Subjects_View.Name = "grd_Subjects_View";
            this.grd_Subjects_View.OptionsBehavior.Editable = false;
            this.grd_Subjects_View.OptionsSelection.MultiSelect = true;
            this.grd_Subjects_View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grd_Subjects_View.OptionsView.ShowGroupPanel = false;
            // 
            // grdColumn_MAMH
            // 
            this.grdColumn_MAMH.Caption = "MAMH";
            this.grdColumn_MAMH.FieldName = "MAMH";
            this.grdColumn_MAMH.Name = "grdColumn_MAMH";
            // 
            // grdColumn_TENMH
            // 
            this.grdColumn_TENMH.Caption = "Tên Môn Học";
            this.grdColumn_TENMH.FieldName = "TENMH";
            this.grdColumn_TENMH.Name = "grdColumn_TENMH";
            this.grdColumn_TENMH.Visible = true;
            this.grdColumn_TENMH.VisibleIndex = 1;
            // 
            // btn_OK_AddSubjectForm
            // 
            this.btn_OK_AddSubjectForm.Location = new System.Drawing.Point(204, 436);
            this.btn_OK_AddSubjectForm.Name = "btn_OK_AddSubjectForm";
            this.btn_OK_AddSubjectForm.Size = new System.Drawing.Size(72, 39);
            this.btn_OK_AddSubjectForm.TabIndex = 1;
            this.btn_OK_AddSubjectForm.Text = "OK";
            this.btn_OK_AddSubjectForm.Click += new System.EventHandler(this.btn_OK_AddSubjectForm_Click);
            // 
            // btn_Cancel_AddSubjectForm
            // 
            this.btn_Cancel_AddSubjectForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel_AddSubjectForm.Location = new System.Drawing.Point(282, 436);
            this.btn_Cancel_AddSubjectForm.Name = "btn_Cancel_AddSubjectForm";
            this.btn_Cancel_AddSubjectForm.Size = new System.Drawing.Size(72, 39);
            this.btn_Cancel_AddSubjectForm.TabIndex = 1;
            this.btn_Cancel_AddSubjectForm.Text = "Cancel";
            this.btn_Cancel_AddSubjectForm.Click += new System.EventHandler(this.btn_Cancel_AddSubjectForm_Click);
            // 
            // AddSubjectForm
            // 
            this.AcceptButton = this.btn_OK_AddSubjectForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel_AddSubjectForm;
            this.ClientSize = new System.Drawing.Size(366, 487);
            this.Controls.Add(this.btn_Cancel_AddSubjectForm);
            this.Controls.Add(this.btn_OK_AddSubjectForm);
            this.Controls.Add(this.grd_Subjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Subjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Subjects_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Subjects;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_Subjects_View;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_TENMH;
        private DevExpress.XtraEditors.SimpleButton btn_OK_AddSubjectForm;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel_AddSubjectForm;
    }
}