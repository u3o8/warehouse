namespace AdminApp
{
    partial class SalesInvoices
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
            this.currentProductLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.portionGrid = new System.Windows.Forms.DataGridView();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.invoiceGrid = new System.Windows.Forms.DataGridView();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.idNumericUpDown.Enabled = false;
            this.idNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumericUpDown.Location = new System.Drawing.Point(871, 155);
            this.idNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(284, 38);
            this.idNumericUpDown.TabIndex = 69;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.amountNumericUpDown.DecimalPlaces = 1;
            this.amountNumericUpDown.Enabled = false;
            this.amountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Location = new System.Drawing.Point(871, 346);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.ReadOnly = true;
            this.amountNumericUpDown.Size = new System.Drawing.Size(284, 38);
            this.amountNumericUpDown.TabIndex = 68;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Enabled = false;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(871, 283);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.ReadOnly = true;
            this.priceNumericUpDown.Size = new System.Drawing.Size(284, 38);
            this.priceNumericUpDown.TabIndex = 67;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.amountLabel.Location = new System.Drawing.Point(746, 348);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(118, 35);
            this.amountLabel.TabIndex = 66;
            this.amountLabel.Text = "Amount:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.priceLabel.Location = new System.Drawing.Point(783, 283);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 35);
            this.priceLabel.TabIndex = 65;
            this.priceLabel.Text = "Price:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.unitTextBox.Enabled = false;
            this.unitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextBox.Location = new System.Drawing.Point(871, 217);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.ReadOnly = true;
            this.unitTextBox.Size = new System.Drawing.Size(284, 38);
            this.unitTextBox.TabIndex = 64;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.unitLabel.Location = new System.Drawing.Point(791, 220);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(73, 35);
            this.unitLabel.TabIndex = 63;
            this.unitLabel.Text = "Unit:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.idLabel.Location = new System.Drawing.Point(819, 157);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 35);
            this.idLabel.TabIndex = 62;
            this.idLabel.Text = "Id:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(871, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(284, 38);
            this.nameTextBox.TabIndex = 61;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.nameLabel.Location = new System.Drawing.Point(772, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 35);
            this.nameLabel.TabIndex = 60;
            this.nameLabel.Text = "Name:";
            // 
            // currentProductLabel
            // 
            this.currentProductLabel.AutoSize = true;
            this.currentProductLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.currentProductLabel.Location = new System.Drawing.Point(805, 20);
            this.currentProductLabel.Name = "currentProductLabel";
            this.currentProductLabel.Size = new System.Drawing.Size(282, 46);
            this.currentProductLabel.TabIndex = 59;
            this.currentProductLabel.Text = "Current Product:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.productLabel.Location = new System.Drawing.Point(483, 20);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(158, 46);
            this.productLabel.TabIndex = 58;
            this.productLabel.Text = "Products";
            // 
            // portionGrid
            // 
            this.portionGrid.AllowUserToAddRows = false;
            this.portionGrid.AllowUserToDeleteRows = false;
            this.portionGrid.AutoGenerateColumns = false;
            this.portionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn});
            this.portionGrid.DataSource = this.portionBindingSource;
            this.portionGrid.Location = new System.Drawing.Point(405, 69);
            this.portionGrid.Name = "portionGrid";
            this.portionGrid.ReadOnly = true;
            this.portionGrid.RowHeadersWidth = 51;
            this.portionGrid.RowTemplate.Height = 24;
            this.portionGrid.Size = new System.Drawing.Size(321, 315);
            this.portionGrid.TabIndex = 57;
            this.portionGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.portionGrid_CellClick);
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 125;
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
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // portionBindingSource
            // 
            this.portionBindingSource.DataSource = typeof(WarehouseLibrary.Models.Portion);
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.invoiceLabel.Location = new System.Drawing.Point(72, 20);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(220, 46);
            this.invoiceLabel.TabIndex = 56;
            this.invoiceLabel.Text = "Sales Invoice";
            // 
            // invoiceGrid
            // 
            this.invoiceGrid.AllowUserToAddRows = false;
            this.invoiceGrid.AllowUserToDeleteRows = false;
            this.invoiceGrid.AutoGenerateColumns = false;
            this.invoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice,
            this.dateTimeDataGridViewTextBoxColumn});
            this.invoiceGrid.DataSource = this.salesInvoiceBindingSource;
            this.invoiceGrid.Location = new System.Drawing.Point(43, 69);
            this.invoiceGrid.Name = "invoiceGrid";
            this.invoiceGrid.ReadOnly = true;
            this.invoiceGrid.RowHeadersWidth = 51;
            this.invoiceGrid.RowTemplate.Height = 24;
            this.invoiceGrid.Size = new System.Drawing.Size(311, 314);
            this.invoiceGrid.TabIndex = 55;
            this.invoiceGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceGrid_CellClick);
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.MinimumWidth = 6;
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Width = 125;
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
            // salesInvoiceBindingSource
            // 
            this.salesInvoiceBindingSource.DataSource = typeof(WarehouseLibrary.Models.SalesInvoice);
            // 
            // SalesInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1188, 441);
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
            this.Controls.Add(this.currentProductLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.portionGrid);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.invoiceGrid);
            this.Name = "SalesInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesInvoices";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label currentProductLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.DataGridView portionGrid;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.DataGridView invoiceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesInvoiceBindingSource;
    }
}