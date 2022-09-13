namespace Storage.UC_s
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbcode = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.rbimport = new System.Windows.Forms.RadioButton();
            this.rbexport = new System.Windows.Forms.RadioButton();
            this.lblamount = new System.Windows.Forms.Label();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.lblSearchby = new System.Windows.Forms.Label();
            this.cbBy = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(97, 27);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 20);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(357, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(615, 27);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // tbcode
            // 
            this.tbcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcode.Location = new System.Drawing.Point(182, 27);
            this.tbcode.Name = "tbcode";
            this.tbcode.ReadOnly = true;
            this.tbcode.Size = new System.Drawing.Size(138, 22);
            this.tbcode.TabIndex = 4;
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(443, 27);
            this.tbname.Name = "tbname";
            this.tbname.ReadOnly = true;
            this.tbname.Size = new System.Drawing.Size(138, 22);
            this.tbname.TabIndex = 4;
            // 
            // tbsize
            // 
            this.tbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsize.Location = new System.Drawing.Point(696, 27);
            this.tbsize.Name = "tbsize";
            this.tbsize.ReadOnly = true;
            this.tbsize.Size = new System.Drawing.Size(138, 22);
            this.tbsize.TabIndex = 4;
            // 
            // rbimport
            // 
            this.rbimport.AutoSize = true;
            this.rbimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbimport.ForeColor = System.Drawing.Color.Blue;
            this.rbimport.Location = new System.Drawing.Point(372, 58);
            this.rbimport.Name = "rbimport";
            this.rbimport.Size = new System.Drawing.Size(56, 24);
            this.rbimport.TabIndex = 6;
            this.rbimport.TabStop = true;
            this.rbimport.Text = "Add";
            this.rbimport.UseVisualStyleBackColor = true;
            // 
            // rbexport
            // 
            this.rbexport.AutoSize = true;
            this.rbexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbexport.ForeColor = System.Drawing.Color.Red;
            this.rbexport.Location = new System.Drawing.Point(538, 58);
            this.rbexport.Name = "rbexport";
            this.rbexport.Size = new System.Drawing.Size(92, 24);
            this.rbexport.TabIndex = 7;
            this.rbexport.TabStop = true;
            this.rbexport.Text = "Take Out";
            this.rbexport.UseVisualStyleBackColor = true;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(330, 90);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(65, 20);
            this.lblamount.TabIndex = 8;
            this.lblamount.Text = "Amount";
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.Location = new System.Drawing.Point(417, 90);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(138, 22);
            this.tbamount.TabIndex = 9;
            // 
            // dgvproduct
            // 
            this.dgvproduct.AllowUserToAddRows = false;
            this.dgvproduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(50, 205);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.ReadOnly = true;
            this.dgvproduct.Size = new System.Drawing.Size(909, 426);
            this.dgvproduct.TabIndex = 10;
            this.dgvproduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellDoubleClick);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnsubmit.Location = new System.Drawing.Point(603, 88);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 25);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.Location = new System.Drawing.Point(446, 161);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(209, 22);
            this.tbsearch.TabIndex = 14;
            // 
            // lblSearchby
            // 
            this.lblSearchby.AutoSize = true;
            this.lblSearchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchby.Location = new System.Drawing.Point(189, 161);
            this.lblSearchby.Name = "lblSearchby";
            this.lblSearchby.Size = new System.Drawing.Size(80, 20);
            this.lblSearchby.TabIndex = 13;
            this.lblSearchby.Text = "Search by";
            // 
            // cbBy
            // 
            this.cbBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBy.FormattingEnabled = true;
            this.cbBy.Items.AddRange(new object[] {
            "Code",
            "Name"});
            this.cbBy.Location = new System.Drawing.Point(287, 160);
            this.cbBy.Name = "cbBy";
            this.cbBy.Size = new System.Drawing.Size(121, 24);
            this.cbBy.TabIndex = 12;
            this.cbBy.Text = "Choose option";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.Blue;
            this.btnShowAll.Location = new System.Drawing.Point(837, 155);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 28);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.TabStop = false;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(710, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lblSearchby);
            this.Controls.Add(this.cbBy);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.rbexport);
            this.Controls.Add(this.rbimport);
            this.Controls.Add(this.tbsize);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbcode);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbcode;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbsize;
        private System.Windows.Forms.RadioButton rbimport;
        private System.Windows.Forms.RadioButton rbexport;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label lblSearchby;
        private System.Windows.Forms.ComboBox cbBy;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
    }
}
