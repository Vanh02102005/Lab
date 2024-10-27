namespace asm1_db
{
    partial class Employee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbEmployeeManagement = new System.Windows.Forms.TabPage();
            this.btnSeach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.tbListofEmployees = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAuthority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbEmployeeManagement.SuspendLayout();
            this.tbListofEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbEmployeeManagement);
            this.tabControl1.Controls.Add(this.tbListofEmployees);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tbEmployeeManagement
            // 
            this.tbEmployeeManagement.Controls.Add(this.btnSeach);
            this.tbEmployeeManagement.Controls.Add(this.button4);
            this.tbEmployeeManagement.Controls.Add(this.btnDelete);
            this.tbEmployeeManagement.Controls.Add(this.btnEdit);
            this.tbEmployeeManagement.Controls.Add(this.btnAdd);
            this.tbEmployeeManagement.Controls.Add(this.cbPosition);
            this.tbEmployeeManagement.Controls.Add(this.txtConfirmPassword);
            this.tbEmployeeManagement.Controls.Add(this.txtPassword);
            this.tbEmployeeManagement.Controls.Add(this.txtUsername);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeeName);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeeID);
            this.tbEmployeeManagement.Controls.Add(this.lbPassword);
            this.tbEmployeeManagement.Controls.Add(this.lbUsername);
            this.tbEmployeeManagement.Controls.Add(this.lbConfirmPassword);
            this.tbEmployeeManagement.Controls.Add(this.lbPosition);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeeName);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeeID);
            this.tbEmployeeManagement.Location = new System.Drawing.Point(4, 25);
            this.tbEmployeeManagement.Name = "tbEmployeeManagement";
            this.tbEmployeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmployeeManagement.Size = new System.Drawing.Size(768, 397);
            this.tbEmployeeManagement.TabIndex = 0;
            this.tbEmployeeManagement.Text = "Employee Management";
            this.tbEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(520, 297);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 18;
            this.btnSeach.Text = "Seach";
            this.btnSeach.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(630, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 297);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Admin",
            "Sales",
            "Warehouse"});
            this.cbPosition.Location = new System.Drawing.Point(125, 214);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(102, 24);
            this.cbPosition.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(490, 159);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(105, 22);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(490, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(104, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(490, 38);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(105, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(125, 93);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(109, 22);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(127, 38);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(112, 22);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(346, 94);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(346, 38);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username";
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(346, 162);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(115, 16);
            this.lbConfirmPassword.TabIndex = 4;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(29, 222);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(55, 16);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "Position";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(12, 96);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(109, 16);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "Employee Name";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(12, 38);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(85, 16);
            this.lbEmployeeID.TabIndex = 0;
            this.lbEmployeeID.Text = "Employee ID";
            // 
            // tbListofEmployees
            // 
            this.tbListofEmployees.Controls.Add(this.dataGridView1);
            this.tbListofEmployees.Location = new System.Drawing.Point(4, 25);
            this.tbListofEmployees.Name = "tbListofEmployees";
            this.tbListofEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbListofEmployees.Size = new System.Drawing.Size(768, 397);
            this.tbListofEmployees.TabIndex = 1;
            this.tbListofEmployees.Text = "List of Employees";
            this.tbListofEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvEmployeeID,
            this.gvEmployeeName,
            this.gvPosition,
            this.gvAuthority});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // gvEmployeeID
            // 
            this.gvEmployeeID.HeaderText = "EmployeeID";
            this.gvEmployeeID.MinimumWidth = 6;
            this.gvEmployeeID.Name = "gvEmployeeID";
            this.gvEmployeeID.Width = 125;
            // 
            // gvEmployeeName
            // 
            this.gvEmployeeName.HeaderText = "Employee Name";
            this.gvEmployeeName.MinimumWidth = 6;
            this.gvEmployeeName.Name = "gvEmployeeName";
            this.gvEmployeeName.Width = 125;
            // 
            // gvPosition
            // 
            this.gvPosition.HeaderText = "Position";
            this.gvPosition.MinimumWidth = 6;
            this.gvPosition.Name = "gvPosition";
            this.gvPosition.Width = 125;
            // 
            // gvAuthority
            // 
            this.gvAuthority.HeaderText = "Authority";
            this.gvAuthority.MinimumWidth = 6;
            this.gvAuthority.Name = "gvAuthority";
            this.gvAuthority.Width = 125;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbEmployeeManagement.ResumeLayout(false);
            this.tbEmployeeManagement.PerformLayout();
            this.tbListofEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbEmployeeManagement;
        private System.Windows.Forms.TabPage tbListofEmployees;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAuthority;
    }
}