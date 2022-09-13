namespace Storage.UC_s
{
    partial class UCEmployeeManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbempinfo = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.tbEmpPassword = new System.Windows.Forms.TextBox();
            this.tbEmpUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbEmpAddress = new System.Windows.Forms.TextBox();
            this.tbEmpEmail = new System.Windows.Forms.TextBox();
            this.tbEmpTel = new System.Windows.Forms.TextBox();
            this.tbEmpLname = new System.Windows.Forms.TextBox();
            this.tbEmpFname = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.btnResetF = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.storageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbempinfo.SuspendLayout();
            this.Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbempinfo
            // 
            this.gbempinfo.Controls.Add(this.lblRole);
            this.gbempinfo.Controls.Add(this.cbrole);
            this.gbempinfo.Controls.Add(this.tbEmpPassword);
            this.gbempinfo.Controls.Add(this.tbEmpUsername);
            this.gbempinfo.Controls.Add(this.lblPassword);
            this.gbempinfo.Controls.Add(this.lblUsername);
            this.gbempinfo.Controls.Add(this.tbEmpAddress);
            this.gbempinfo.Controls.Add(this.tbEmpEmail);
            this.gbempinfo.Controls.Add(this.tbEmpTel);
            this.gbempinfo.Controls.Add(this.tbEmpLname);
            this.gbempinfo.Controls.Add(this.tbEmpFname);
            this.gbempinfo.Controls.Add(this.tbEmpID);
            this.gbempinfo.Controls.Add(this.label6);
            this.gbempinfo.Controls.Add(this.label5);
            this.gbempinfo.Controls.Add(this.label4);
            this.gbempinfo.Controls.Add(this.label3);
            this.gbempinfo.Controls.Add(this.label2);
            this.gbempinfo.Controls.Add(this.label1);
            this.gbempinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbempinfo.Location = new System.Drawing.Point(4, 4);
            this.gbempinfo.Name = "gbempinfo";
            this.gbempinfo.Size = new System.Drawing.Size(819, 163);
            this.gbempinfo.TabIndex = 0;
            this.gbempinfo.TabStop = false;
            this.gbempinfo.Text = "Employee Info";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(613, 51);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 17;
            this.lblRole.Text = "Role";
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "Secretary",
            "Storekeeper"});
            this.cbrole.Location = new System.Drawing.Point(680, 50);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(121, 24);
            this.cbrole.TabIndex = 16;
            this.cbrole.Text = "Choose Role";
            // 
            // tbEmpPassword
            // 
            this.tbEmpPassword.Location = new System.Drawing.Point(544, 126);
            this.tbEmpPassword.Name = "tbEmpPassword";
            this.tbEmpPassword.Size = new System.Drawing.Size(138, 22);
            this.tbEmpPassword.TabIndex = 15;
            this.tbEmpPassword.UseSystemPasswordChar = true;
            // 
            // tbEmpUsername
            // 
            this.tbEmpUsername.Location = new System.Drawing.Point(225, 126);
            this.tbEmpUsername.Name = "tbEmpUsername";
            this.tbEmpUsername.Size = new System.Drawing.Size(138, 22);
            this.tbEmpUsername.TabIndex = 14;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(433, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(116, 128);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 20);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "UserName";
            // 
            // tbEmpAddress
            // 
            this.tbEmpAddress.Location = new System.Drawing.Point(437, 91);
            this.tbEmpAddress.Name = "tbEmpAddress";
            this.tbEmpAddress.Size = new System.Drawing.Size(141, 22);
            this.tbEmpAddress.TabIndex = 11;
            // 
            // tbEmpEmail
            // 
            this.tbEmpEmail.Location = new System.Drawing.Point(437, 63);
            this.tbEmpEmail.Name = "tbEmpEmail";
            this.tbEmpEmail.Size = new System.Drawing.Size(141, 22);
            this.tbEmpEmail.TabIndex = 10;
            // 
            // tbEmpTel
            // 
            this.tbEmpTel.Location = new System.Drawing.Point(437, 35);
            this.tbEmpTel.Name = "tbEmpTel";
            this.tbEmpTel.Size = new System.Drawing.Size(141, 22);
            this.tbEmpTel.TabIndex = 9;
            // 
            // tbEmpLname
            // 
            this.tbEmpLname.Location = new System.Drawing.Point(137, 91);
            this.tbEmpLname.Name = "tbEmpLname";
            this.tbEmpLname.Size = new System.Drawing.Size(151, 22);
            this.tbEmpLname.TabIndex = 8;
            // 
            // tbEmpFname
            // 
            this.tbEmpFname.Location = new System.Drawing.Point(137, 63);
            this.tbEmpFname.Name = "tbEmpFname";
            this.tbEmpFname.Size = new System.Drawing.Size(151, 22);
            this.tbEmpFname.TabIndex = 7;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(137, 35);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(151, 22);
            this.tbEmpID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.btnResetF);
            this.Actions.Controls.Add(this.btnDeleteEmployee);
            this.Actions.Controls.Add(this.btnUpdateEmployee);
            this.Actions.Controls.Add(this.btnInsertEmployee);
            this.Actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actions.Location = new System.Drawing.Point(829, 169);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(168, 462);
            this.Actions.TabIndex = 1;
            this.Actions.TabStop = false;
            this.Actions.Text = "Actions";
            // 
            // btnResetF
            // 
            this.btnResetF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetF.ForeColor = System.Drawing.Color.Red;
            this.btnResetF.Location = new System.Drawing.Point(43, 322);
            this.btnResetF.Name = "btnResetF";
            this.btnResetF.Size = new System.Drawing.Size(75, 29);
            this.btnResetF.TabIndex = 3;
            this.btnResetF.Text = "Reset Filed";
            this.btnResetF.UseVisualStyleBackColor = true;
            this.btnResetF.Click += new System.EventHandler(this.btnResetF_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(43, 254);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(43, 184);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateEmployee.TabIndex = 1;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnInsertEmployee.Location = new System.Drawing.Point(43, 112);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(75, 34);
            this.btnInsertEmployee.TabIndex = 0;
            this.btnInsertEmployee.Text = "Add";
            this.btnInsertEmployee.UseVisualStyleBackColor = true;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.Location = new System.Drawing.Point(4, 173);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.Size = new System.Drawing.Size(819, 460);
            this.dgvEmp.TabIndex = 2;
            this.dgvEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellDoubleClick);
            // 
            // UCEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.gbempinfo);
            this.Name = "UCEmployeeManagement";
            this.Size = new System.Drawing.Size(1000, 650);
            this.gbempinfo.ResumeLayout(false);
            this.gbempinfo.PerformLayout();
            this.Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbempinfo;
        private System.Windows.Forms.TextBox tbEmpAddress;
        private System.Windows.Forms.TextBox tbEmpEmail;
        private System.Windows.Forms.TextBox tbEmpTel;
        private System.Windows.Forms.TextBox tbEmpLname;
        private System.Windows.Forms.TextBox tbEmpFname;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.BindingSource storageDataSetBindingSource;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnResetF;
        private System.Windows.Forms.TextBox tbEmpPassword;
        private System.Windows.Forms.TextBox tbEmpUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label lblRole;
    }
}
