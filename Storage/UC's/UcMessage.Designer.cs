namespace Storage.UC_s
{
    partial class UcMessage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvmsgs = new System.Windows.Forms.DataGridView();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblordercode = new System.Windows.Forms.Label();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.lblsuppliername = new System.Windows.Forms.Label();
            this.tbordercode = new System.Windows.Forms.TextBox();
            this.tborderdate = new System.Windows.Forms.TextBox();
            this.tbsuppliername = new System.Windows.Forms.TextBox();
            this.dgvorderdtls = new System.Windows.Forms.DataGridView();
            this.btnok = new System.Windows.Forms.Button();
            this.lblpayment = new System.Windows.Forms.Label();
            this.tbpayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmsgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdtls)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmsgs
            // 
            this.dgvmsgs.AllowUserToAddRows = false;
            this.dgvmsgs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmsgs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmsgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmsgs.Location = new System.Drawing.Point(12, 83);
            this.dgvmsgs.Name = "dgvmsgs";
            this.dgvmsgs.ReadOnly = true;
            this.dgvmsgs.Size = new System.Drawing.Size(293, 434);
            this.dgvmsgs.TabIndex = 0;
            this.dgvmsgs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmsgs_CellDoubleClick);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(99, 51);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(72, 16);
            this.lblmsg.TabIndex = 1;
            this.lblmsg.Text = "Messages";
            // 
            // lblordercode
            // 
            this.lblordercode.AutoSize = true;
            this.lblordercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordercode.Location = new System.Drawing.Point(325, 83);
            this.lblordercode.Name = "lblordercode";
            this.lblordercode.Size = new System.Drawing.Size(91, 20);
            this.lblordercode.TabIndex = 2;
            this.lblordercode.Text = "Order Code";
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.Location = new System.Drawing.Point(539, 83);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(88, 20);
            this.lblorderdate.TabIndex = 3;
            this.lblorderdate.Text = "Order Date";
            // 
            // lblsuppliername
            // 
            this.lblsuppliername.AutoSize = true;
            this.lblsuppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuppliername.Location = new System.Drawing.Point(752, 83);
            this.lblsuppliername.Name = "lblsuppliername";
            this.lblsuppliername.Size = new System.Drawing.Size(113, 20);
            this.lblsuppliername.TabIndex = 4;
            this.lblsuppliername.Text = "Supplier Name";
            // 
            // tbordercode
            // 
            this.tbordercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbordercode.Location = new System.Drawing.Point(422, 81);
            this.tbordercode.Name = "tbordercode";
            this.tbordercode.ReadOnly = true;
            this.tbordercode.Size = new System.Drawing.Size(100, 22);
            this.tbordercode.TabIndex = 5;
            // 
            // tborderdate
            // 
            this.tborderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborderdate.Location = new System.Drawing.Point(633, 81);
            this.tborderdate.Name = "tborderdate";
            this.tborderdate.ReadOnly = true;
            this.tborderdate.Size = new System.Drawing.Size(100, 22);
            this.tborderdate.TabIndex = 6;
            // 
            // tbsuppliername
            // 
            this.tbsuppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsuppliername.Location = new System.Drawing.Point(882, 81);
            this.tbsuppliername.Name = "tbsuppliername";
            this.tbsuppliername.ReadOnly = true;
            this.tbsuppliername.Size = new System.Drawing.Size(100, 22);
            this.tbsuppliername.TabIndex = 7;
            // 
            // dgvorderdtls
            // 
            this.dgvorderdtls.AllowUserToAddRows = false;
            this.dgvorderdtls.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderdtls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvorderdtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvorderdtls.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvorderdtls.Location = new System.Drawing.Point(358, 125);
            this.dgvorderdtls.Name = "dgvorderdtls";
            this.dgvorderdtls.Size = new System.Drawing.Size(624, 392);
            this.dgvorderdtls.TabIndex = 8;
            this.dgvorderdtls.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderdtls_CellDoubleClick);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.Red;
            this.btnok.Location = new System.Drawing.Point(868, 605);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 28);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.Location = new System.Drawing.Point(725, 554);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(71, 20);
            this.lblpayment.TabIndex = 10;
            this.lblpayment.Text = "Payment";
            // 
            // tbpayment
            // 
            this.tbpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpayment.Location = new System.Drawing.Point(843, 552);
            this.tbpayment.Name = "tbpayment";
            this.tbpayment.ReadOnly = true;
            this.tbpayment.Size = new System.Drawing.Size(100, 22);
            this.tbpayment.TabIndex = 11;
            // 
            // UcMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbpayment);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.dgvorderdtls);
            this.Controls.Add(this.tbsuppliername);
            this.Controls.Add(this.tborderdate);
            this.Controls.Add(this.tbordercode);
            this.Controls.Add(this.lblsuppliername);
            this.Controls.Add(this.lblorderdate);
            this.Controls.Add(this.lblordercode);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dgvmsgs);
            this.Name = "UcMessage";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmsgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdtls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmsgs;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblordercode;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.Label lblsuppliername;
        private System.Windows.Forms.TextBox tbordercode;
        private System.Windows.Forms.TextBox tborderdate;
        private System.Windows.Forms.TextBox tbsuppliername;
        private System.Windows.Forms.DataGridView dgvorderdtls;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.TextBox tbpayment;
    }
}
