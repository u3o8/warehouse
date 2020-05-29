namespace CustomerApp
{
    partial class History
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
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.AutoGenerateColumns = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.dateTimeDataGridViewTextBoxColumn});
            this.orderGrid.DataSource = this.orderBindingSource;
            this.orderGrid.Location = new System.Drawing.Point(30, 112);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersWidth = 51;
            this.orderGrid.RowTemplate.Height = 24;
            this.orderGrid.Size = new System.Drawing.Size(392, 450);
            this.orderGrid.TabIndex = 39;
            this.orderGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellClick);
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
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.orderLabel.Location = new System.Drawing.Point(160, 48);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(128, 46);
            this.orderLabel.TabIndex = 40;
            this.orderLabel.Text = "Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(593, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 46);
            this.label1.TabIndex = 42;
            this.label1.Text = "Products";
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.AutoGenerateColumns = false;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProductDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.productGrid.DataSource = this.portionBindingSource;
            this.productGrid.Location = new System.Drawing.Point(463, 112);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersWidth = 51;
            this.productGrid.RowTemplate.Height = 24;
            this.productGrid.Size = new System.Drawing.Size(392, 450);
            this.productGrid.TabIndex = 41;
            this.productGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGrid_CellClick);
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameProductDataGridViewTextBoxColumn.Width = 125;
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
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(WarehouseLibrary.Models.Portion);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.Info;
            this.okButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.okButton.Location = new System.Drawing.Point(1200, 474);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(139, 62);
            this.okButton.TabIndex = 92;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.productLabel.Location = new System.Drawing.Point(1021, 72);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(272, 46);
            this.productLabel.TabIndex = 91;
            this.productLabel.Text = "Current Product";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.idNumericUpDown.Enabled = false;
            this.idNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumericUpDown.Location = new System.Drawing.Point(1029, 225);
            this.idNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(310, 38);
            this.idNumericUpDown.TabIndex = 90;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.amountNumericUpDown.DecimalPlaces = 1;
            this.amountNumericUpDown.Enabled = false;
            this.amountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Location = new System.Drawing.Point(1029, 416);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.ReadOnly = true;
            this.amountNumericUpDown.Size = new System.Drawing.Size(310, 38);
            this.amountNumericUpDown.TabIndex = 89;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Enabled = false;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(1029, 353);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.ReadOnly = true;
            this.priceNumericUpDown.Size = new System.Drawing.Size(310, 38);
            this.priceNumericUpDown.TabIndex = 88;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.amountLabel.Location = new System.Drawing.Point(904, 418);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(118, 35);
            this.amountLabel.TabIndex = 87;
            this.amountLabel.Text = "Amount:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.priceLabel.Location = new System.Drawing.Point(941, 353);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 35);
            this.priceLabel.TabIndex = 86;
            this.priceLabel.Text = "Price:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.unitTextBox.Enabled = false;
            this.unitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextBox.Location = new System.Drawing.Point(1029, 287);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.ReadOnly = true;
            this.unitTextBox.Size = new System.Drawing.Size(310, 38);
            this.unitTextBox.TabIndex = 85;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.unitLabel.Location = new System.Drawing.Point(949, 290);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(73, 35);
            this.unitLabel.TabIndex = 84;
            this.unitLabel.Text = "Unit:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.idLabel.Location = new System.Drawing.Point(977, 227);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 35);
            this.idLabel.TabIndex = 83;
            this.idLabel.Text = "Id:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(1029, 160);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(310, 38);
            this.nameTextBox.TabIndex = 82;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.nameLabel.Location = new System.Drawing.Point(930, 163);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 35);
            this.nameLabel.TabIndex = 81;
            this.nameLabel.Text = "Name:";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1395, 593);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.orderGrid);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}