namespace CustomerApp
{
    partial class HomePage
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
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseProductsLabel = new System.Windows.Forms.Label();
            this.deleteBasketButton = new System.Windows.Forms.Button();
            this.basketGrid = new System.Windows.Forms.DataGridView();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basketLabel = new System.Windows.Forms.Label();
            this.editBasketButton = new System.Windows.Forms.Button();
            this.addBasketButton = new System.Windows.Forms.Button();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderLabel = new System.Windows.Forms.Label();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.checkHistoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.basketPictureBox = new System.Windows.Forms.PictureBox();
            this.warehouseProductsPictureBox = new System.Windows.Forms.PictureBox();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseProductsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.AutoGenerateColumns = false;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.productGrid.DataSource = this.productBindingSource;
            this.productGrid.Location = new System.Drawing.Point(30, 120);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersWidth = 51;
            this.productGrid.RowTemplate.Height = 24;
            this.productGrid.Size = new System.Drawing.Size(581, 508);
            this.productGrid.TabIndex = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date and time";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WarehouseLibrary.Models.Product);
            // 
            // warehouseProductsLabel
            // 
            this.warehouseProductsLabel.AutoSize = true;
            this.warehouseProductsLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseProductsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.warehouseProductsLabel.Location = new System.Drawing.Point(157, 55);
            this.warehouseProductsLabel.Name = "warehouseProductsLabel";
            this.warehouseProductsLabel.Size = new System.Drawing.Size(346, 46);
            this.warehouseProductsLabel.TabIndex = 29;
            this.warehouseProductsLabel.Text = "Warehouse products";
            // 
            // deleteBasketButton
            // 
            this.deleteBasketButton.BackColor = System.Drawing.SystemColors.Info;
            this.deleteBasketButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBasketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.deleteBasketButton.Location = new System.Drawing.Point(634, 508);
            this.deleteBasketButton.Name = "deleteBasketButton";
            this.deleteBasketButton.Size = new System.Drawing.Size(147, 57);
            this.deleteBasketButton.TabIndex = 35;
            this.deleteBasketButton.Text = "Delete";
            this.deleteBasketButton.UseVisualStyleBackColor = false;
            this.deleteBasketButton.Click += new System.EventHandler(this.deleteBasketButton_Click);
            // 
            // basketGrid
            // 
            this.basketGrid.AllowUserToAddRows = false;
            this.basketGrid.AutoGenerateColumns = false;
            this.basketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct,
            this.amountDataGridViewTextBoxColumn1});
            this.basketGrid.DataSource = this.portionBindingSource;
            this.basketGrid.Location = new System.Drawing.Point(633, 120);
            this.basketGrid.Name = "basketGrid";
            this.basketGrid.ReadOnly = true;
            this.basketGrid.RowHeadersWidth = 51;
            this.basketGrid.RowTemplate.Height = 24;
            this.basketGrid.Size = new System.Drawing.Size(455, 382);
            this.basketGrid.TabIndex = 34;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "Product";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn1.Width = 125;
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(WarehouseLibrary.Models.Portion);
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.basketLabel.Location = new System.Drawing.Point(763, 56);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(183, 46);
            this.basketLabel.TabIndex = 33;
            this.basketLabel.Text = "My basket";
            // 
            // editBasketButton
            // 
            this.editBasketButton.BackColor = System.Drawing.SystemColors.Info;
            this.editBasketButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBasketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.editBasketButton.Location = new System.Drawing.Point(787, 508);
            this.editBasketButton.Name = "editBasketButton";
            this.editBasketButton.Size = new System.Drawing.Size(147, 57);
            this.editBasketButton.TabIndex = 36;
            this.editBasketButton.Text = "Edit";
            this.editBasketButton.UseVisualStyleBackColor = false;
            this.editBasketButton.Click += new System.EventHandler(this.editBasketButton_Click);
            // 
            // addBasketButton
            // 
            this.addBasketButton.BackColor = System.Drawing.SystemColors.Info;
            this.addBasketButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBasketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.addBasketButton.Location = new System.Drawing.Point(940, 508);
            this.addBasketButton.Name = "addBasketButton";
            this.addBasketButton.Size = new System.Drawing.Size(147, 57);
            this.addBasketButton.TabIndex = 37;
            this.addBasketButton.Text = "Add";
            this.addBasketButton.UseVisualStyleBackColor = false;
            this.addBasketButton.Click += new System.EventHandler(this.addBasketButton_Click);
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.AutoGenerateColumns = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.TotalPrice,
            this.dateTimeDataGridViewTextBoxColumn1});
            this.orderGrid.DataSource = this.orderBindingSource;
            this.orderGrid.Location = new System.Drawing.Point(1111, 121);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersWidth = 51;
            this.orderGrid.RowTemplate.Height = 24;
            this.orderGrid.Size = new System.Drawing.Size(316, 287);
            this.orderGrid.TabIndex = 38;
            this.orderGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.orderGrid_RowPostPaint);
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 125;
            // 
            // dateTimeDataGridViewTextBoxColumn1
            // 
            this.dateTimeDataGridViewTextBoxColumn1.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn1.HeaderText = "Date time";
            this.dateTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn1.Name = "dateTimeDataGridViewTextBoxColumn1";
            this.dateTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WarehouseLibrary.Models.Order);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.orderLabel.Location = new System.Drawing.Point(1210, 55);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(182, 46);
            this.orderLabel.TabIndex = 39;
            this.orderLabel.Text = "My orders";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackColor = System.Drawing.SystemColors.Info;
            this.deleteOrderButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.deleteOrderButton.Location = new System.Drawing.Point(1274, 427);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(153, 57);
            this.deleteOrderButton.TabIndex = 41;
            this.deleteOrderButton.Text = "Delete";
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // checkHistoryButton
            // 
            this.checkHistoryButton.BackColor = System.Drawing.SystemColors.Info;
            this.checkHistoryButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.checkHistoryButton.Location = new System.Drawing.Point(1111, 571);
            this.checkHistoryButton.Name = "checkHistoryButton";
            this.checkHistoryButton.Size = new System.Drawing.Size(316, 57);
            this.checkHistoryButton.TabIndex = 42;
            this.checkHistoryButton.Text = "Check!";
            this.checkHistoryButton.UseVisualStyleBackColor = false;
            this.checkHistoryButton.Click += new System.EventHandler(this.checkHistoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(1128, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 46);
            this.label2.TabIndex = 43;
            this.label2.Text = "Purchase history";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1448, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Info;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.confirmButton.Location = new System.Drawing.Point(706, 571);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(316, 57);
            this.confirmButton.TabIndex = 46;
            this.confirmButton.Text = "Confirm order";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.SystemColors.Info;
            this.aboutButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.aboutButton.Location = new System.Drawing.Point(1111, 427);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(153, 57);
            this.aboutButton.TabIndex = 47;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // orderPictureBox
            // 
            this.orderPictureBox.Image = global::CustomerApp.Properties.Resources.Orders;
            this.orderPictureBox.InitialImage = global::CustomerApp.Properties.Resources.Warehouse_products;
            this.orderPictureBox.Location = new System.Drawing.Point(1085, 33);
            this.orderPictureBox.Name = "orderPictureBox";
            this.orderPictureBox.Size = new System.Drawing.Size(135, 86);
            this.orderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderPictureBox.TabIndex = 45;
            this.orderPictureBox.TabStop = false;
            // 
            // basketPictureBox
            // 
            this.basketPictureBox.Image = global::CustomerApp.Properties.Resources.Basket;
            this.basketPictureBox.InitialImage = global::CustomerApp.Properties.Resources.Warehouse_products;
            this.basketPictureBox.Location = new System.Drawing.Point(633, 33);
            this.basketPictureBox.Name = "basketPictureBox";
            this.basketPictureBox.Size = new System.Drawing.Size(135, 86);
            this.basketPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basketPictureBox.TabIndex = 44;
            this.basketPictureBox.TabStop = false;
            // 
            // warehouseProductsPictureBox
            // 
            this.warehouseProductsPictureBox.Image = global::CustomerApp.Properties.Resources.Warehouse_products;
            this.warehouseProductsPictureBox.InitialImage = global::CustomerApp.Properties.Resources.Warehouse_products;
            this.warehouseProductsPictureBox.Location = new System.Drawing.Point(16, 28);
            this.warehouseProductsPictureBox.Name = "warehouseProductsPictureBox";
            this.warehouseProductsPictureBox.Size = new System.Drawing.Size(147, 91);
            this.warehouseProductsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.warehouseProductsPictureBox.TabIndex = 32;
            this.warehouseProductsPictureBox.TabStop = false;
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1448, 673);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.orderPictureBox);
            this.Controls.Add(this.basketPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkHistoryButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.addBasketButton);
            this.Controls.Add(this.editBasketButton);
            this.Controls.Add(this.deleteBasketButton);
            this.Controls.Add(this.basketGrid);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.warehouseProductsPictureBox);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.warehouseProductsLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseProductsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox warehouseProductsPictureBox;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.Label warehouseProductsLabel;
        private System.Windows.Forms.Button deleteBasketButton;
        private System.Windows.Forms.DataGridView basketGrid;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.Button editBasketButton;
        private System.Windows.Forms.Button addBasketButton;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button checkHistoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.PictureBox basketPictureBox;
        private System.Windows.Forms.PictureBox orderPictureBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}