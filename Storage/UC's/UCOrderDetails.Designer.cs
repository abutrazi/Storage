namespace Storage.UC_s
{
    partial class UCOrderDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbProductinfo = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbprodqty = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.tbproductname = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.tbproductcode = new System.Windows.Forms.TextBox();
            this.lblProdCode = new System.Windows.Forms.Label();
            this.dgvorder = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvorderproductList = new System.Windows.Forms.DataGridView();
            this.lblProductsList = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cbsupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.tbpayment = new System.Windows.Forms.TextBox();
            this.gbProductinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderproductList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductinfo
            // 
            this.gbProductinfo.Controls.Add(this.btnUpdate);
            this.gbProductinfo.Controls.Add(this.btnDelete);
            this.gbProductinfo.Controls.Add(this.btnAdd);
            this.gbProductinfo.Controls.Add(this.tbprodqty);
            this.gbProductinfo.Controls.Add(this.lblProdQty);
            this.gbProductinfo.Controls.Add(this.tbproductname);
            this.gbProductinfo.Controls.Add(this.lblProdName);
            this.gbProductinfo.Controls.Add(this.tbproductcode);
            this.gbProductinfo.Controls.Add(this.lblProdCode);
            this.gbProductinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductinfo.Location = new System.Drawing.Point(9, 116);
            this.gbProductinfo.Name = "gbProductinfo";
            this.gbProductinfo.Size = new System.Drawing.Size(237, 310);
            this.gbProductinfo.TabIndex = 2;
            this.gbProductinfo.TabStop = false;
            this.gbProductinfo.Text = "Product Info";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(75, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(136, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(6, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbprodqty
            // 
            this.tbprodqty.Location = new System.Drawing.Point(127, 123);
            this.tbprodqty.Name = "tbprodqty";
            this.tbprodqty.Size = new System.Drawing.Size(104, 22);
            this.tbprodqty.TabIndex = 5;
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdQty.Location = new System.Drawing.Point(6, 123);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(59, 20);
            this.lblProdQty.TabIndex = 4;
            this.lblProdQty.Text = "Quntity";
            // 
            // tbproductname
            // 
            this.tbproductname.Location = new System.Drawing.Point(127, 79);
            this.tbproductname.Name = "tbproductname";
            this.tbproductname.ReadOnly = true;
            this.tbproductname.Size = new System.Drawing.Size(104, 22);
            this.tbproductname.TabIndex = 3;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(3, 79);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(110, 20);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Product Name";
            // 
            // tbproductcode
            // 
            this.tbproductcode.Location = new System.Drawing.Point(127, 35);
            this.tbproductcode.Name = "tbproductcode";
            this.tbproductcode.ReadOnly = true;
            this.tbproductcode.Size = new System.Drawing.Size(104, 22);
            this.tbproductcode.TabIndex = 1;
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCode.Location = new System.Drawing.Point(3, 35);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(106, 20);
            this.lblProdCode.TabIndex = 0;
            this.lblProdCode.Text = "Product Code";
            // 
            // dgvorder
            // 
            this.dgvorder.AllowUserToAddRows = false;
            this.dgvorder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvorder.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvorder.Location = new System.Drawing.Point(630, 54);
            this.dgvorder.Name = "dgvorder";
            this.dgvorder.ReadOnly = true;
            this.dgvorder.Size = new System.Drawing.Size(350, 476);
            this.dgvorder.TabIndex = 3;
            this.dgvorder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorder_CellDoubleClick);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Red;
            this.btnSend.Location = new System.Drawing.Point(84, 474);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 27);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvorderproductList
            // 
            this.dgvorderproductList.AllowUserToAddRows = false;
            this.dgvorderproductList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderproductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvorderproductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderproductList.Location = new System.Drawing.Point(255, 54);
            this.dgvorderproductList.Name = "dgvorderproductList";
            this.dgvorderproductList.ReadOnly = true;
            this.dgvorderproductList.Size = new System.Drawing.Size(350, 476);
            this.dgvorderproductList.TabIndex = 5;
            this.dgvorderproductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderproductList_CellDoubleClick);
            // 
            // lblProductsList
            // 
            this.lblProductsList.AutoSize = true;
            this.lblProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsList.Location = new System.Drawing.Point(358, 29);
            this.lblProductsList.Name = "lblProductsList";
            this.lblProductsList.Size = new System.Drawing.Size(84, 16);
            this.lblProductsList.TabIndex = 6;
            this.lblProductsList.Text = "Products List";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(789, 29);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(42, 16);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "Order";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // cbsupplier
            // 
            this.cbsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsupplier.FormattingEnabled = true;
            this.cbsupplier.Location = new System.Drawing.Point(99, 54);
            this.cbsupplier.Name = "cbsupplier";
            this.cbsupplier.Size = new System.Drawing.Size(131, 24);
            this.cbsupplier.TabIndex = 8;
            this.cbsupplier.Text = "Choose Supplier";
            this.cbsupplier.SelectedIndexChanged += new System.EventHandler(this.cbsupplier_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(6, 54);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 20);
            this.lblSupplier.TabIndex = 9;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.Location = new System.Drawing.Point(760, 584);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(71, 20);
            this.lblpayment.TabIndex = 10;
            this.lblpayment.Text = "Payment";
            // 
            // tbpayment
            // 
            this.tbpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpayment.Location = new System.Drawing.Point(866, 582);
            this.tbpayment.Name = "tbpayment";
            this.tbpayment.ReadOnly = true;
            this.tbpayment.Size = new System.Drawing.Size(100, 22);
            this.tbpayment.TabIndex = 11;
            // 
            // UCOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbpayment);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cbsupplier);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblProductsList);
            this.Controls.Add(this.dgvorderproductList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvorder);
            this.Controls.Add(this.gbProductinfo);
            this.Name = "UCOrderDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1000, 650);
            this.gbProductinfo.ResumeLayout(false);
            this.gbProductinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderproductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbProductinfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbprodqty;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.TextBox tbproductname;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox tbproductcode;
        private System.Windows.Forms.Label lblProdCode;
        private System.Windows.Forms.DataGridView dgvorder;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dgvorderproductList;
        private System.Windows.Forms.Label lblProductsList;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbsupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.TextBox tbpayment;
    }
}
