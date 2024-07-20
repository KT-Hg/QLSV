namespace QLSV
{
    partial class fManager
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
            this.lblManager = new System.Windows.Forms.Label();

            this.gpbInfomation = new System.Windows.Forms.GroupBox();

            this.pnlId = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();

            this.pnlName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();

            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();

            this.pnlSalary = new System.Windows.Forms.Panel();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txbSalary = new System.Windows.Forms.TextBox();

            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();

            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();

            this.pnlManager = new System.Windows.Forms.Panel();

            this.pnlDataField = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();

            this.pnlButtonField = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.gpbInfomation.SuspendLayout();
            this.pnlDataField.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();

            this.pnlManager.SuspendLayout();
            this.pnlButtonField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManager
            // 
            this.lblManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(250, 25);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(300, 50);
            this.lblManager.TabIndex = 0;
            this.lblManager.Text = "DANH MỤC NHÂN VIÊN";
            this.lblManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbInfomation
            // 
            this.gpbInfomation.Controls.Add(this.pnlPassword);
            this.gpbInfomation.Controls.Add(this.pnlUsername);
            this.gpbInfomation.Controls.Add(this.pnlSalary);
            this.gpbInfomation.Controls.Add(this.pnlEmail);
            this.gpbInfomation.Controls.Add(this.pnlName);
            this.gpbInfomation.Controls.Add(this.pnlId);
            this.gpbInfomation.Location = new System.Drawing.Point(25, 100);
            this.gpbInfomation.Name = "gpbInfomation";
            this.gpbInfomation.Size = new System.Drawing.Size(750, 135);
            this.gpbInfomation.TabIndex = 1;
            this.gpbInfomation.TabStop = false;
            this.gpbInfomation.Text = "Thông tin nhân viên";
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.txbId);
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Location = new System.Drawing.Point(25, 25);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(300, 25);
            this.pnlId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(10, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(95, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Mã NV";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(115, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(175, 20);
            this.txbId.TabIndex = 4;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txbName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Location = new System.Drawing.Point(425, 25);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(300, 25);
            this.pnlName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(10, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Họ Tên";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(115, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 20);
            this.txbName.TabIndex = 7;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.txbEmail);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Location = new System.Drawing.Point(25, 55);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(300, 25);
            this.pnlEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(10, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(115, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(175, 20);
            this.txbEmail.TabIndex = 11;
            // 
            // pnlSalary
            // 
            this.pnlSalary.Controls.Add(this.txbSalary);
            this.pnlSalary.Controls.Add(this.lblSalary);
            this.pnlSalary.Location = new System.Drawing.Point(425, 55);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(300, 25);
            this.pnlSalary.TabIndex = 12;
            // 
            // lblSalary
            // 
            this.lblSalary.Location = new System.Drawing.Point(10, 5);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(95, 15);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Lương";
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(115, 2);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(175, 20);
            this.txbSalary.TabIndex = 14;
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.txbUsername);
            this.pnlUsername.Controls.Add(this.lblUsername);
            this.pnlUsername.Location = new System.Drawing.Point(25, 85);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(300, 25);
            this.pnlUsername.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(10, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 15);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(115, 2);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(175, 20);
            this.txbUsername.TabIndex = 17;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.txbPassword);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Location = new System.Drawing.Point(425, 85);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(300, 25);
            this.pnlPassword.TabIndex = 18;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(10, 5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 15);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(115, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(175, 20);
            this.txbPassword.TabIndex = 20;
            // 
            // pnlManager
            // 
            this.pnlManager.Controls.Add(this.pnlButtonField);
            this.pnlManager.Controls.Add(this.pnlDataField);
            this.pnlManager.Location = new System.Drawing.Point(25, 250);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(750, 215);
            this.pnlManager.TabIndex = 21;
            // 
            // pnlDataField
            // 
            this.pnlDataField.Controls.Add(this.dgvEmployee);
            this.pnlDataField.Location = new System.Drawing.Point(25, 10);
            this.pnlDataField.Name = "pnlDataField";
            this.pnlDataField.Size = new System.Drawing.Size(700, 150);
            this.pnlDataField.TabIndex = 22;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(5, 5);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(690, 140);
            this.dgvEmployee.TabIndex = 23;
            // 
            // pnlButtonField
            // 
            this.pnlButtonField.Controls.Add(this.btnExit);
            this.pnlButtonField.Controls.Add(this.btnCancel);
            this.pnlButtonField.Controls.Add(this.btnSave);
            this.pnlButtonField.Controls.Add(this.btnUpdate);
            this.pnlButtonField.Controls.Add(this.btnDelete);
            this.pnlButtonField.Controls.Add(this.btnInsert);
            this.pnlButtonField.Location = new System.Drawing.Point(25, 170);
            this.pnlButtonField.Name = "pnlButtonField";
            this.pnlButtonField.Size = new System.Drawing.Size(700, 35);
            this.pnlButtonField.TabIndex = 24;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(5, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(247, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(368, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ghi/Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(489, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Không";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(620, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlManager);
            this.Controls.Add(this.gpbInfomation);
            this.Controls.Add(this.lblManager);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên";
            this.gpbInfomation.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlSalary.ResumeLayout(false);
            this.pnlSalary.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlManager.ResumeLayout(false);
            this.pnlButtonField.ResumeLayout(false);
            this.pnlDataField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblManager;
        
        private System.Windows.Forms.GroupBox gpbInfomation;

        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;

        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;

        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;

        private System.Windows.Forms.Panel pnlSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txbSalary;

        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbUsername;

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;

        private System.Windows.Forms.Panel pnlManager;

        private System.Windows.Forms.Panel pnlDataField;
        private System.Windows.Forms.DataGridView dgvEmployee;

        private System.Windows.Forms.Panel pnlButtonField;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}