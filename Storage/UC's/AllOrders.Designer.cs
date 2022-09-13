namespace Storage.UC_s
{
    partial class AllOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvorders = new System.Windows.Forms.DataGridView();
            this.dgvorderdetails = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.lblorder = new System.Windows.Forms.Label();
            this.lblorderdetails = new System.Windows.Forms.Label();
            this.lblreport1 = new System.Windows.Forms.Label();
            this.btnOrderM = new System.Windows.Forms.Button();
            this.lblmonth = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.DateTimePicker();
            this.tbmonth = new System.Windows.Forms.TextBox();
            this.reports = new System.Windows.Forms.GroupBox();
            this.dtorderdetailsreporty = new System.Windows.Forms.DateTimePicker();
            this.lblreport2 = new System.Windows.Forms.Label();
            this.btnOrderY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).BeginInit();
            this.reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvorders
            // 
            this.dgvorders.AllowUserToAddRows = false;
            this.dgvorders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorders.Location = new System.Drawing.Point(22, 70);
            this.dgvorders.Name = "dgvorders";
            this.dgvorders.ReadOnly = true;
            this.dgvorders.Size = new System.Drawing.Size(400, 417);
            this.dgvorders.TabIndex = 0;
            this.dgvorders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorders_CellDoubleClick);
            // 
            // dgvorderdetails
            // 
            this.dgvorderdetails.AllowUserToAddRows = false;
            this.dgvorderdetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvorderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderdetails.Location = new System.Drawing.Point(500, 66);
            this.dgvorderdetails.Name = "dgvorderdetails";
            this.dgvorderdetails.ReadOnly = true;
            this.dgvorderdetails.Size = new System.Drawing.Size(485, 420);
            this.dgvorderdetails.TabIndex = 1;
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.Red;
            this.btnPdf.Location = new System.Drawing.Point(910, 492);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Save Pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorder.Location = new System.Drawing.Point(169, 51);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(49, 16);
            this.lblorder.TabIndex = 3;
            this.lblorder.Text = "Orders";
            // 
            // lblorderdetails
            // 
            this.lblorderdetails.AutoSize = true;
            this.lblorderdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdetails.Location = new System.Drawing.Point(682, 30);
            this.lblorderdetails.Name = "lblorderdetails";
            this.lblorderdetails.Size = new System.Drawing.Size(87, 16);
            this.lblorderdetails.TabIndex = 4;
            this.lblorderdetails.Text = "Order Details";
            // 
            // lblreport1
            // 
            this.lblreport1.AutoSize = true;
            this.lblreport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreport1.Location = new System.Drawing.Point(38, 557);
            this.lblreport1.Name = "lblreport1";
            this.lblreport1.Size = new System.Drawing.Size(180, 20);
            this.lblreport1.TabIndex = 6;
            this.lblreport1.Text = "Orders Details Of Month";
            // 
            // btnOrderM
            // 
            this.btnOrderM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderM.ForeColor = System.Drawing.Color.Blue;
            this.btnOrderM.Location = new System.Drawing.Point(367, 554);
            this.btnOrderM.Name = "btnOrderM";
            this.btnOrderM.Size = new System.Drawing.Size(86, 23);
            this.btnOrderM.TabIndex = 8;
            this.btnOrderM.Text = "Save PDF";
            this.btnOrderM.UseVisualStyleBackColor = true;
            this.btnOrderM.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(66, 17);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(54, 20);
            this.lblmonth.TabIndex = 10;
            this.lblmonth.Text = "Month";
            // 
            // month
            // 
            this.month.CustomFormat = "MM/yyyy";
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month.Location = new System.Drawing.Point(172, 15);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(103, 22);
            this.month.TabIndex = 11;
            this.month.ValueChanged += new System.EventHandler(this.month_ValueChanged);
            // 
            // tbmonth
            // 
            this.tbmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmonth.Location = new System.Drawing.Point(224, 555);
            this.tbmonth.Name = "tbmonth";
            this.tbmonth.ReadOnly = true;
            this.tbmonth.Size = new System.Drawing.Size(116, 22);
            this.tbmonth.TabIndex = 12;
            // 
            // reports
            // 
            this.reports.Controls.Add(this.dtorderdetailsreporty);
            this.reports.Controls.Add(this.lblreport2);
            this.reports.Controls.Add(this.btnOrderY);
            this.reports.Location = new System.Drawing.Point(22, 527);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(963, 96);
            this.reports.TabIndex = 13;
            this.reports.TabStop = false;
            this.reports.Text = "Reports";
            // 
            // dtorderdetailsreporty
            // 
            this.dtorderdetailsreporty.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtorderdetailsreporty.CustomFormat = "yyyy";
            this.dtorderdetailsreporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtorderdetailsreporty.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtorderdetailsreporty.Location = new System.Drawing.Point(207, 65);
            this.dtorderdetailsreporty.Name = "dtorderdetailsreporty";
            this.dtorderdetailsreporty.Size = new System.Drawing.Size(103, 22);
            this.dtorderdetailsreporty.TabIndex = 11;
            // 
            // lblreport2
            // 
            this.lblreport2.AutoSize = true;
            this.lblreport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreport2.Location = new System.Drawing.Point(12, 63);
            this.lblreport2.Name = "lblreport2";
            this.lblreport2.Size = new System.Drawing.Size(166, 20);
            this.lblreport2.TabIndex = 10;
            this.lblreport2.Text = "Orders Details of Year";
            // 
            // btnOrderY
            // 
            this.btnOrderY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderY.ForeColor = System.Drawing.Color.Blue;
            this.btnOrderY.Location = new System.Drawing.Point(345, 67);
            this.btnOrderY.Name = "btnOrderY";
            this.btnOrderY.Size = new System.Drawing.Size(86, 23);
            this.btnOrderY.TabIndex = 9;
            this.btnOrderY.Text = "Save PDF";
            this.btnOrderY.UseVisualStyleBackColor = true;
            this.btnOrderY.Click += new System.EventHandler(this.btnOrderY_Click);
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOrderM);
            this.Controls.Add(this.tbmonth);
            this.Controls.Add(this.lblreport1);
            this.Controls.Add(this.month);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lblorderdetails);
            this.Controls.Add(this.lblorder);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dgvorderdetails);
            this.Controls.Add(this.dgvorders);
            this.Controls.Add(this.reports);
            this.Name = "AllOrders";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).EndInit();
            this.reports.ResumeLayout(false);
            this.reports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvorders;
        private System.Windows.Forms.DataGridView dgvorderdetails;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.Label lblorderdetails;
        private System.Windows.Forms.Label lblreport1;
        private System.Windows.Forms.Button btnOrderM;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.DateTimePicker month;
        private System.Windows.Forms.TextBox tbmonth;
        private System.Windows.Forms.GroupBox reports;
        private System.Windows.Forms.DateTimePicker dtorderdetailsreporty;
        private System.Windows.Forms.Label lblreport2;
        private System.Windows.Forms.Button btnOrderY;
    }
}
