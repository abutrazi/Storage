namespace Storage.UC_s
{
    partial class UpdateOrder
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
            this.dgvorder = new System.Windows.Forms.DataGridView();
            this.dgvorderdeatils = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.tbqty = new System.Windows.Forms.TextBox();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbproductcode = new System.Windows.Forms.TextBox();
            this.tbproductname = new System.Windows.Forms.TextBox();
            this.btnaddtoorder = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.tbpayment = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblsupplier = new System.Windows.Forms.Label();
            this.tbsupplier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdeatils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvorder
            // 
            this.dgvorder.AllowUserToAddRows = false;
            this.dgvorder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorder.Location = new System.Drawing.Point(21, 42);
            this.dgvorder.Name = "dgvorder";
            this.dgvorder.ReadOnly = true;
            this.dgvorder.Size = new System.Drawing.Size(349, 286);
            this.dgvorder.TabIndex = 0;
            this.dgvorder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorder_CellDoubleClick);
            // 
            // dgvorderdeatils
            // 
            this.dgvorderdeatils.AllowUserToAddRows = false;
            this.dgvorderdeatils.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderdeatils.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvorderdeatils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderdeatils.Location = new System.Drawing.Point(403, 42);
            this.dgvorderdeatils.Name = "dgvorderdeatils";
            this.dgvorderdeatils.ReadOnly = true;
            this.dgvorderdeatils.Size = new System.Drawing.Size(559, 286);
            this.dgvorderdeatils.TabIndex = 1;
            this.dgvorderdeatils.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderdeatils_CellDoubleClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(21, 561);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 26);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(17, 493);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(33, 20);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Qty";
            // 
            // tbqty
            // 
            this.tbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty.Location = new System.Drawing.Point(150, 493);
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(100, 22);
            this.tbqty.TabIndex = 4;
            // 
            // dgvproducts
            // 
            this.dgvproducts.AllowUserToAddRows = false;
            this.dgvproducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Location = new System.Drawing.Point(385, 390);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.Size = new System.Drawing.Size(577, 249);
            this.dgvproducts.TabIndex = 5;
            this.dgvproducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducts_CellDoubleClick);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(634, 360);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(61, 16);
            this.lblProducts.TabIndex = 6;
            this.lblProducts.Text = "Products";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(634, 26);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(87, 16);
            this.lblOrderDetails.TabIndex = 7;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(127, 26);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(42, 16);
            this.lblOrder.TabIndex = 8;
            this.lblOrder.Text = "Order";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(14, 421);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(106, 20);
            this.lblProductCode.TabIndex = 9;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(17, 457);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 20);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product Name";
            // 
            // tbproductcode
            // 
            this.tbproductcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproductcode.Location = new System.Drawing.Point(150, 421);
            this.tbproductcode.Name = "tbproductcode";
            this.tbproductcode.ReadOnly = true;
            this.tbproductcode.Size = new System.Drawing.Size(100, 22);
            this.tbproductcode.TabIndex = 11;
            // 
            // tbproductname
            // 
            this.tbproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproductname.Location = new System.Drawing.Point(150, 457);
            this.tbproductname.Name = "tbproductname";
            this.tbproductname.ReadOnly = true;
            this.tbproductname.Size = new System.Drawing.Size(100, 22);
            this.tbproductname.TabIndex = 12;
            // 
            // btnaddtoorder
            // 
            this.btnaddtoorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtoorder.ForeColor = System.Drawing.Color.Blue;
            this.btnaddtoorder.Location = new System.Drawing.Point(130, 561);
            this.btnaddtoorder.Name = "btnaddtoorder";
            this.btnaddtoorder.Size = new System.Drawing.Size(109, 26);
            this.btnaddtoorder.TabIndex = 13;
            this.btnaddtoorder.Text = "Add To Order";
            this.btnaddtoorder.UseVisualStyleBackColor = true;
            this.btnaddtoorder.Click += new System.EventHandler(this.btnaddtoorder_Click);
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.Red;
            this.btnsend.Location = new System.Drawing.Point(147, 605);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 26);
            this.btnsend.TabIndex = 14;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(756, 335);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(71, 20);
            this.lblPayment.TabIndex = 15;
            this.lblPayment.Text = "Payment";
            // 
            // tbpayment
            // 
            this.tbpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpayment.Location = new System.Drawing.Point(851, 335);
            this.tbpayment.Name = "tbpayment";
            this.tbpayment.ReadOnly = true;
            this.tbpayment.Size = new System.Drawing.Size(100, 22);
            this.tbpayment.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(261, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblsupplier
            // 
            this.lblsupplier.AutoSize = true;
            this.lblsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplier.Location = new System.Drawing.Point(17, 385);
            this.lblsupplier.Name = "lblsupplier";
            this.lblsupplier.Size = new System.Drawing.Size(71, 20);
            this.lblsupplier.TabIndex = 18;
            this.lblsupplier.Text = "Supplier ";
            // 
            // tbsupplier
            // 
            this.tbsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsupplier.Location = new System.Drawing.Point(150, 385);
            this.tbsupplier.Name = "tbsupplier";
            this.tbsupplier.ReadOnly = true;
            this.tbsupplier.Size = new System.Drawing.Size(100, 22);
            this.tbsupplier.TabIndex = 19;
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbsupplier);
            this.Controls.Add(this.lblsupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbpayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnaddtoorder);
            this.Controls.Add(this.tbproductname);
            this.Controls.Add(this.tbproductcode);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.dgvproducts);
            this.Controls.Add(this.tbqty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvorderdeatils);
            this.Controls.Add(this.dgvorder);
            this.Name = "UpdateOrder";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdeatils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvorder;
        private System.Windows.Forms.DataGridView dgvorderdeatils;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox tbqty;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbproductcode;
        private System.Windows.Forms.TextBox tbproductname;
        private System.Windows.Forms.Button btnaddtoorder;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox tbpayment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblsupplier;
        private System.Windows.Forms.TextBox tbsupplier;
    }
}
