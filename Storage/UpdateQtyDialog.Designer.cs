namespace Storage
{
    partial class UpdateQtyDialog
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
            this.lblnewQty = new System.Windows.Forms.Label();
            this.tbnewqty = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnewQty
            // 
            this.lblnewQty.AutoSize = true;
            this.lblnewQty.Location = new System.Drawing.Point(73, 75);
            this.lblnewQty.Name = "lblnewQty";
            this.lblnewQty.Size = new System.Drawing.Size(48, 13);
            this.lblnewQty.TabIndex = 0;
            this.lblnewQty.Text = "New Qty";
            // 
            // tbnewqty
            // 
            this.tbnewqty.Location = new System.Drawing.Point(148, 67);
            this.tbnewqty.Name = "tbnewqty";
            this.tbnewqty.Size = new System.Drawing.Size(100, 20);
            this.tbnewqty.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(148, 135);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // UpdateQtyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 180);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.tbnewqty);
            this.Controls.Add(this.lblnewQty);
            this.Name = "UpdateQtyDialog";
            this.Text = "UpdateQtyDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnewQty;
        private System.Windows.Forms.TextBox tbnewqty;
        private System.Windows.Forms.Button btnok;
    }
}