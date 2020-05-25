namespace AdminApp
{
    partial class Home_Page
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
            this.warehouseProductsLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersLabel = new System.Windows.Forms.Label();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesLabel = new System.Windows.Forms.Label();
            this.purchasesInvoicesButton = new System.Windows.Forms.Button();
            this.buttonSalesInvoices = new System.Windows.Forms.Button();
            this.newSupplyButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.invoicesPictureBox = new System.Windows.Forms.PictureBox();
            this.customersPictureBox = new System.Windows.Forms.PictureBox();
            this.ordersPictureBox = new System.Windows.Forms.PictureBox();
            this.warehouseProductsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseProductsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // warehouseProductsLabel
            // 
            this.warehouseProductsLabel.AutoSize = true;
            this.warehouseProductsLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseProductsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.warehouseProductsLabel.Location = new System.Drawing.Point(153, 56);
            this.warehouseProductsLabel.Name = "warehouseProductsLabel";
            this.warehouseProductsLabel.Size = new System.Drawing.Size(346, 46);
            this.warehouseProductsLabel.TabIndex = 9;
            this.warehouseProductsLabel.Text = "Warehouse products";
            // 
            // productsGrid
            // 
            this.productsGrid.AutoGenerateColumns = false;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.productsGrid.DataSource = this.productBindingSource;
            this.productsGrid.Location = new System.Drawing.Point(26, 121);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.RowTemplate.Height = 24;
            this.productsGrid.Size = new System.Drawing.Size(581, 439);
            this.productsGrid.TabIndex = 10;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WarehouseLibrary.Models.Product);
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ordersLabel.Location = new System.Drawing.Point(755, 56);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(128, 46);
            this.ordersLabel.TabIndex = 11;
            this.ordersLabel.Text = "Orders";
            // 
            // ordersGrid
            // 
            this.ordersGrid.AutoGenerateColumns = false;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.ordersGrid.DataSource = this.orderBindingSource;
            this.ordersGrid.Location = new System.Drawing.Point(644, 121);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowTemplate.Height = 24;
            this.ordersGrid.Size = new System.Drawing.Size(351, 439);
            this.ordersGrid.TabIndex = 12;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WarehouseLibrary.Models.Order);
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.customersLabel.Location = new System.Drawing.Point(1113, 56);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(187, 46);
            this.customersLabel.TabIndex = 13;
            this.customersLabel.Text = "Customers";
            // 
            // customersGrid
            // 
            this.customersGrid.AutoGenerateColumns = false;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.customersGrid.DataSource = this.customerBindingSource;
            this.customersGrid.Location = new System.Drawing.Point(1029, 121);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.RowHeadersWidth = 51;
            this.customersGrid.RowTemplate.Height = 24;
            this.customersGrid.Size = new System.Drawing.Size(345, 200);
            this.customersGrid.TabIndex = 14;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(WarehouseLibrary.Models.Customer);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 30);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // invoicesLabel
            // 
            this.invoicesLabel.AutoSize = true;
            this.invoicesLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.invoicesLabel.Location = new System.Drawing.Point(1138, 429);
            this.invoicesLabel.Name = "invoicesLabel";
            this.invoicesLabel.Size = new System.Drawing.Size(146, 46);
            this.invoicesLabel.TabIndex = 17;
            this.invoicesLabel.Text = "Invoices";
            // 
            // purchasesInvoicesButton
            // 
            this.purchasesInvoicesButton.BackColor = System.Drawing.SystemColors.Info;
            this.purchasesInvoicesButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasesInvoicesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.purchasesInvoicesButton.Location = new System.Drawing.Point(1029, 572);
            this.purchasesInvoicesButton.Name = "purchasesInvoicesButton";
            this.purchasesInvoicesButton.Size = new System.Drawing.Size(345, 57);
            this.purchasesInvoicesButton.TabIndex = 18;
            this.purchasesInvoicesButton.Text = "Purchase_Invoices";
            this.purchasesInvoicesButton.UseVisualStyleBackColor = false;
            // 
            // buttonSalesInvoices
            // 
            this.buttonSalesInvoices.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSalesInvoices.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.buttonSalesInvoices.Location = new System.Drawing.Point(1029, 503);
            this.buttonSalesInvoices.Name = "buttonSalesInvoices";
            this.buttonSalesInvoices.Size = new System.Drawing.Size(345, 57);
            this.buttonSalesInvoices.TabIndex = 19;
            this.buttonSalesInvoices.Text = "Sales Invoices";
            this.buttonSalesInvoices.UseVisualStyleBackColor = false;
            // 
            // newSupplyButton
            // 
            this.newSupplyButton.BackColor = System.Drawing.SystemColors.Info;
            this.newSupplyButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSupplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.newSupplyButton.Location = new System.Drawing.Point(290, 572);
            this.newSupplyButton.Name = "newSupplyButton";
            this.newSupplyButton.Size = new System.Drawing.Size(317, 57);
            this.newSupplyButton.TabIndex = 20;
            this.newSupplyButton.Text = "New supply";
            this.newSupplyButton.UseVisualStyleBackColor = false;
            // 
            // detailsButton
            // 
            this.detailsButton.BackColor = System.Drawing.SystemColors.Info;
            this.detailsButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.detailsButton.Location = new System.Drawing.Point(644, 572);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(168, 57);
            this.detailsButton.TabIndex = 21;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Info;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.confirmButton.Location = new System.Drawing.Point(827, 572);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(168, 57);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.deleteButton.Location = new System.Drawing.Point(1029, 337);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 54);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.Info;
            this.editButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.editButton.Location = new System.Drawing.Point(1146, 337);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(111, 54);
            this.editButton.TabIndex = 26;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Info;
            this.addButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.addButton.Location = new System.Drawing.Point(1263, 337);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 54);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // invoicesPictureBox
            // 
            this.invoicesPictureBox.Image = global::AdminApp.Properties.Resources.Invoices;
            this.invoicesPictureBox.Location = new System.Drawing.Point(1033, 413);
            this.invoicesPictureBox.Name = "invoicesPictureBox";
            this.invoicesPictureBox.Size = new System.Drawing.Size(107, 71);
            this.invoicesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invoicesPictureBox.TabIndex = 31;
            this.invoicesPictureBox.TabStop = false;
            // 
            // customersPictureBox
            // 
            this.customersPictureBox.Image = global::AdminApp.Properties.Resources.Customers;
            this.customersPictureBox.Location = new System.Drawing.Point(1020, 42);
            this.customersPictureBox.Name = "customersPictureBox";
            this.customersPictureBox.Size = new System.Drawing.Size(97, 73);
            this.customersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customersPictureBox.TabIndex = 30;
            this.customersPictureBox.TabStop = false;
            // 
            // ordersPictureBox
            // 
            this.ordersPictureBox.Image = global::AdminApp.Properties.Resources.Orders;
            this.ordersPictureBox.Location = new System.Drawing.Point(667, 42);
            this.ordersPictureBox.Name = "ordersPictureBox";
            this.ordersPictureBox.Size = new System.Drawing.Size(92, 73);
            this.ordersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ordersPictureBox.TabIndex = 29;
            this.ordersPictureBox.TabStop = false;
            // 
            // warehouseProductsPictureBox
            // 
            this.warehouseProductsPictureBox.Image = global::AdminApp.Properties.Resources.Warehouse_products;
            this.warehouseProductsPictureBox.Location = new System.Drawing.Point(12, 29);
            this.warehouseProductsPictureBox.Name = "warehouseProductsPictureBox";
            this.warehouseProductsPictureBox.Size = new System.Drawing.Size(147, 91);
            this.warehouseProductsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.warehouseProductsPictureBox.TabIndex = 28;
            this.warehouseProductsPictureBox.TabStop = false;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1410, 663);
            this.Controls.Add(this.invoicesPictureBox);
            this.Controls.Add(this.customersPictureBox);
            this.Controls.Add(this.ordersPictureBox);
            this.Controls.Add(this.warehouseProductsPictureBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.newSupplyButton);
            this.Controls.Add(this.buttonSalesInvoices);
            this.Controls.Add(this.purchasesInvoicesButton);
            this.Controls.Add(this.invoicesLabel);
            this.Controls.Add(this.customersGrid);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.warehouseProductsLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home_Page";
            this.Text = "Home_Page";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseProductsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label warehouseProductsLabel;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label invoicesLabel;
        private System.Windows.Forms.Button purchasesInvoicesButton;
        private System.Windows.Forms.Button buttonSalesInvoices;
        private System.Windows.Forms.Button newSupplyButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox warehouseProductsPictureBox;
        private System.Windows.Forms.PictureBox ordersPictureBox;
        private System.Windows.Forms.PictureBox customersPictureBox;
        private System.Windows.Forms.PictureBox invoicesPictureBox;
    }
}