namespace CustomerApp
{
    partial class ProductWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.basketPictureBox = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.idNumericUpDown.Enabled = false;
            this.idNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumericUpDown.Location = new System.Drawing.Point(238, 150);
            this.idNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(310, 38);
            this.idNumericUpDown.TabIndex = 68;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.amountNumericUpDown.DecimalPlaces = 1;
            this.amountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Location = new System.Drawing.Point(238, 341);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(310, 38);
            this.amountNumericUpDown.TabIndex = 67;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Enabled = false;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(238, 278);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.ReadOnly = true;
            this.priceNumericUpDown.Size = new System.Drawing.Size(310, 38);
            this.priceNumericUpDown.TabIndex = 66;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Info;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.confirmButton.Location = new System.Drawing.Point(386, 410);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(162, 62);
            this.confirmButton.TabIndex = 65;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.amountLabel.Location = new System.Drawing.Point(113, 343);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(118, 35);
            this.amountLabel.TabIndex = 64;
            this.amountLabel.Text = "Amount:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.priceLabel.Location = new System.Drawing.Point(150, 278);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 35);
            this.priceLabel.TabIndex = 63;
            this.priceLabel.Text = "Price:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.unitTextBox.Enabled = false;
            this.unitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextBox.Location = new System.Drawing.Point(238, 212);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.ReadOnly = true;
            this.unitTextBox.Size = new System.Drawing.Size(310, 38);
            this.unitTextBox.TabIndex = 62;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.unitLabel.Location = new System.Drawing.Point(158, 215);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(73, 35);
            this.unitLabel.TabIndex = 61;
            this.unitLabel.Text = "Unit:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.idLabel.Location = new System.Drawing.Point(186, 152);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 35);
            this.idLabel.TabIndex = 60;
            this.idLabel.Text = "Id:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(238, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(310, 38);
            this.nameTextBox.TabIndex = 59;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.nameLabel.Location = new System.Drawing.Point(139, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 35);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Name:";
            // 
            // basketPictureBox
            // 
            this.basketPictureBox.ErrorImage = null;
            this.basketPictureBox.Image = global::CustomerApp.Properties.Resources.Basket;
            this.basketPictureBox.Location = new System.Drawing.Point(14, 394);
            this.basketPictureBox.Name = "basketPictureBox";
            this.basketPictureBox.Size = new System.Drawing.Size(90, 78);
            this.basketPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basketPictureBox.TabIndex = 69;
            this.basketPictureBox.TabStop = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.textLabel.Location = new System.Drawing.Point(48, 23);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(84, 46);
            this.textLabel.TabIndex = 70;
            this.textLabel.Text = "Text";
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(582, 497);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.basketPictureBox);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "ProductWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductWindow";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox basketPictureBox;
        protected System.Windows.Forms.NumericUpDown idNumericUpDown;
        protected System.Windows.Forms.NumericUpDown amountNumericUpDown;
        protected System.Windows.Forms.NumericUpDown priceNumericUpDown;
        protected System.Windows.Forms.Button confirmButton;
        protected System.Windows.Forms.TextBox unitTextBox;
        protected System.Windows.Forms.TextBox nameTextBox;
        protected System.Windows.Forms.Label amountLabel;
        protected System.Windows.Forms.Label priceLabel;
        protected System.Windows.Forms.Label unitLabel;
        protected System.Windows.Forms.Label idLabel;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.Label textLabel;
    }
}