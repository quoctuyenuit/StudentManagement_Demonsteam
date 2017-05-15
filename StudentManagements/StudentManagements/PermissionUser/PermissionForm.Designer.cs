namespace StudentManagements.PermissionUser
{
    partial class PermissionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grd_User = new DevExpress.XtraGrid.GridControl();
            this.grd_User_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColumn_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColumn_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_NewUser = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.labelEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbPermission = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_User_View)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPermission.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grd_User);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Delete);
            this.splitContainer1.Panel2.Controls.Add(this.btn_NewUser);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Save);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1268, 415);
            this.splitContainer1.SplitterDistance = 749;
            this.splitContainer1.TabIndex = 0;
            // 
            // grd_User
            // 
            this.grd_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_User.Location = new System.Drawing.Point(0, 0);
            this.grd_User.MainView = this.grd_User_View;
            this.grd_User.Name = "grd_User";
            this.grd_User.Size = new System.Drawing.Size(749, 415);
            this.grd_User.TabIndex = 0;
            this.grd_User.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_User_View});
            // 
            // grd_User_View
            // 
            this.grd_User_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.grdColumn_Password,
            this.grdColumn_Email,
            this.gridColumn5});
            this.grd_User_View.GridControl = this.grd_User;
            this.grd_User_View.Name = "grd_User_View";
            this.grd_User_View.OptionsBehavior.Editable = false;
            this.grd_User_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grd_User_View.OptionsView.ShowGroupPanel = false;
            this.grd_User_View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grd_User_View_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ Tên";
            this.gridColumn1.FieldName = "TENNGUOIDUNG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 165;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Phân Quyền";
            this.gridColumn2.FieldName = "TENPQ";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 105;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Đăng Nhập";
            this.gridColumn3.FieldName = "TENDANGNHAP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 119;
            // 
            // grdColumn_Password
            // 
            this.grdColumn_Password.Caption = "Mật Khẩu";
            this.grdColumn_Password.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.grdColumn_Password.FieldName = "MATKHAU";
            this.grdColumn_Password.Name = "grdColumn_Password";
            this.grdColumn_Password.Visible = true;
            this.grdColumn_Password.VisibleIndex = 3;
            this.grdColumn_Password.Width = 98;
            // 
            // grdColumn_Email
            // 
            this.grdColumn_Email.Caption = "Email";
            this.grdColumn_Email.FieldName = "EMAIL";
            this.grdColumn_Email.Name = "grdColumn_Email";
            this.grdColumn_Email.Visible = true;
            this.grdColumn_Email.VisibleIndex = 4;
            this.grdColumn_Email.Width = 242;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "MAND";
            this.gridColumn5.FieldName = "MAND";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(244, 281);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 35);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.Location = new System.Drawing.Point(325, 281);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(75, 35);
            this.btn_NewUser.TabIndex = 0;
            this.btn_NewUser.Text = "New User";
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(406, 281);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbPermission);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Location = new System.Drawing.Point(30, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 244);
            this.panel1.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(177, 144);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_Email.Properties.Appearance.Options.UseFont = true;
            this.txt_Email.Size = new System.Drawing.Size(236, 24);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(177, 180);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_Password.Properties.Appearance.Options.UseFont = true;
            this.txt_Password.Size = new System.Drawing.Size(236, 24);
            this.txt_Password.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelEmail.Location = new System.Drawing.Point(33, 147);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 18);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelPassword.Location = new System.Drawing.Point(33, 183);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Mật Khẩu:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(177, 108);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_UserName.Properties.Appearance.Options.UseFont = true;
            this.txt_UserName.Size = new System.Drawing.Size(236, 24);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(177, 36);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_Name.Properties.Appearance.Options.UseFont = true;
            this.txt_Name.Size = new System.Drawing.Size(236, 24);
            this.txt_Name.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(33, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Phân quyền:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(33, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ Tên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(33, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên đăng nhập:";
            // 
            // cbPermission
            // 
            this.cbPermission.Location = new System.Drawing.Point(177, 72);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbPermission.Properties.Appearance.Options.UseFont = true;
            this.cbPermission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPermission.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPermission.Size = new System.Drawing.Size(236, 24);
            this.cbPermission.TabIndex = 5;
            // 
            // PermissionForm
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 415);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PermissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PermissionForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_User_View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPermission.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grd_User;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_User_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_Password;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txt_UserName;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.SimpleButton btn_NewUser;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn_Email;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.LabelControl labelEmail;
        private DevExpress.XtraEditors.ComboBoxEdit cbPermission;

    }
}