namespace Storage
{
    partial class Management
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
            this.components = new System.ComponentModel.Container();
            this.msActions = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDelUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importexportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDelUpdateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucSupplierManagement = new Storage.UC_s.UCSupplierManagement();
            this.allOrders = new Storage.UC_s.AllOrders();
            this.updateOrder = new Storage.UC_s.UpdateOrder();
            this.ucMessage = new Storage.UC_s.UcMessage();
            this.actions = new Storage.UC_s.Actions();
            this.products = new Storage.UC_s.Products();
            this.login = new Storage.UC_s.Login();
            this.register = new Storage.UC_s.Register();
            this.ucProductManagement = new Storage.UC_s.UCProductManagement();
            this.ucEmployeeManagement = new Storage.UC_s.UCEmployeeManagement();
            this.orderDetails = new Storage.UC_s.UCOrderDetails();
            this.settings = new Storage.UC_s.Settings();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statics = new Storage.UC_s.Statics();
            this.msActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // msActions
            // 
            this.msActions.BackColor = System.Drawing.SystemColors.Control;
            this.msActions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.msActions.Location = new System.Drawing.Point(0, 0);
            this.msActions.Name = "msActions";
            this.msActions.Size = new System.Drawing.Size(1003, 25);
            this.msActions.TabIndex = 16;
            this.msActions.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDelUpdateToolStripMenuItem,
            this.importexportToolStripMenuItem,
            this.staticsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addDelUpdateToolStripMenuItem
            // 
            this.addDelUpdateToolStripMenuItem.Name = "addDelUpdateToolStripMenuItem";
            this.addDelUpdateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addDelUpdateToolStripMenuItem.Text = "Add/Del/Update";
            this.addDelUpdateToolStripMenuItem.Click += new System.EventHandler(this.addDelUpdateToolStripMenuItem_Click);
            // 
            // importexportToolStripMenuItem
            // 
            this.importexportToolStripMenuItem.Name = "importexportToolStripMenuItem";
            this.importexportToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.importexportToolStripMenuItem.Text = "import/export";
            this.importexportToolStripMenuItem.Click += new System.EventHandler(this.importexportToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.staticsToolStripMenuItem.Text = "Statics";
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.updateOrderToolStripMenuItem,
            this.allOrdersToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // updateOrderToolStripMenuItem
            // 
            this.updateOrderToolStripMenuItem.Name = "updateOrderToolStripMenuItem";
            this.updateOrderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.updateOrderToolStripMenuItem.Text = "Update Order";
            this.updateOrderToolStripMenuItem.Click += new System.EventHandler(this.updateOrderToolStripMenuItem_Click);
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.allOrdersToolStripMenuItem.Text = "All Orders";
            this.allOrdersToolStripMenuItem.Click += new System.EventHandler(this.allOrdersToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDelUpdateToolStripMenuItem1});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // addDelUpdateToolStripMenuItem1
            // 
            this.addDelUpdateToolStripMenuItem1.Name = "addDelUpdateToolStripMenuItem1";
            this.addDelUpdateToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.addDelUpdateToolStripMenuItem1.Text = "Add/Del/Update";
            this.addDelUpdateToolStripMenuItem1.Click += new System.EventHandler(this.addDelUpdateToolStripMenuItem1_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.messagesToolStripMenuItem.Text = "Messages";
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.messagesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ucSupplierManagement
            // 
            this.ucSupplierManagement.Location = new System.Drawing.Point(0, 27);
            this.ucSupplierManagement.Name = "ucSupplierManagement";
            this.ucSupplierManagement.Size = new System.Drawing.Size(1000, 650);
            this.ucSupplierManagement.TabIndex = 10;
            // 
            // allOrders
            // 
            this.allOrders.Location = new System.Drawing.Point(0, 28);
            this.allOrders.Name = "allOrders";
            this.allOrders.Size = new System.Drawing.Size(1000, 650);
            this.allOrders.TabIndex = 21;
            // 
            // updateOrder
            // 
            this.updateOrder.Location = new System.Drawing.Point(0, 27);
            this.updateOrder.Name = "updateOrder";
            this.updateOrder.Size = new System.Drawing.Size(1000, 650);
            this.updateOrder.TabIndex = 18;
            // 
            // ucMessage
            // 
            this.ucMessage.Location = new System.Drawing.Point(0, 27);
            this.ucMessage.Name = "ucMessage";
            this.ucMessage.Size = new System.Drawing.Size(1000, 650);
            this.ucMessage.TabIndex = 17;
            // 
            // actions
            // 
            this.actions.AutoSize = true;
            this.actions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actions.Location = new System.Drawing.Point(0, 27);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(1000, 650);
            this.actions.TabIndex = 9;
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.SystemColors.Control;
            this.products.Location = new System.Drawing.Point(0, 27);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(1000, 650);
            this.products.TabIndex = 6;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login.Location = new System.Drawing.Point(0, 27);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1000, 650);
            this.login.TabIndex = 4;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(0, 27);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(1000, 650);
            this.register.TabIndex = 3;
            // 
            // ucProductManagement
            // 
            this.ucProductManagement.Location = new System.Drawing.Point(0, 27);
            this.ucProductManagement.Name = "ucProductManagement";
            this.ucProductManagement.Size = new System.Drawing.Size(1000, 650);
            this.ucProductManagement.TabIndex = 2;
            // 
            // ucEmployeeManagement
            // 
            this.ucEmployeeManagement.Location = new System.Drawing.Point(0, 27);
            this.ucEmployeeManagement.Name = "ucEmployeeManagement";
            this.ucEmployeeManagement.Size = new System.Drawing.Size(1000, 650);
            this.ucEmployeeManagement.TabIndex = 1;
            // 
            // orderDetails
            // 
            this.orderDetails.Location = new System.Drawing.Point(0, 27);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderDetails.Size = new System.Drawing.Size(1000, 650);
            this.orderDetails.TabIndex = 15;
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(3, 28);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1000, 650);
            this.settings.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Interval = 1800000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statics
            // 
            this.statics.Location = new System.Drawing.Point(-9, 28);
            this.statics.Name = "statics";
            this.statics.Size = new System.Drawing.Size(1009, 650);
            this.statics.TabIndex = 23;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1003, 677);
            this.Controls.Add(this.statics);
            this.Controls.Add(this.msActions);
            this.Controls.Add(this.products);
            this.Controls.Add(this.login);
            this.Controls.Add(this.register);
            this.Controls.Add(this.ucProductManagement);
            this.Controls.Add(this.ucEmployeeManagement);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.ucSupplierManagement);
            this.Controls.Add(this.allOrders);
            this.Controls.Add(this.updateOrder);
            this.Controls.Add(this.ucMessage);
            this.Controls.Add(this.actions);
            this.MaximizeBox = false;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Storage";
            this.Load += new System.EventHandler(this.Management_Load);
            this.msActions.ResumeLayout(false);
            this.msActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UC_s.UCEmployeeManagement ucEmployeeManagement;
        private UC_s.UCProductManagement ucProductManagement;
        private UC_s.Register register;
        private UC_s.Login login;
        private UC_s.Products products;
        private UC_s.Actions actions;
        private UC_s.UCSupplierManagement ucSupplierManagement;
        private UC_s.UCOrderDetails orderDetails;
        private System.Windows.Forms.MenuStrip msActions;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDelUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importexportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDelUpdateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private UC_s.UcMessage ucMessage;
        private System.Windows.Forms.ToolStripMenuItem updateOrderToolStripMenuItem;
        private UC_s.UpdateOrder updateOrder;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
        private UC_s.AllOrders allOrders;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private UC_s.Settings settings;
        private System.Windows.Forms.Timer timer1;
        private UC_s.Statics statics;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
    }
}