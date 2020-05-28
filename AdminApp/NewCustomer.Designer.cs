namespace AdminApp
{
    partial class NewCustomer
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.customerPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.messagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.loginLabel.Location = new System.Drawing.Point(300, 100);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(77, 35);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.Location = new System.Drawing.Point(390, 97);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(308, 38);
            this.loginTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.passwordLabel.Location = new System.Drawing.Point(251, 214);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(126, 35);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // adressTextBox
            // 
            this.adressTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(390, 155);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(308, 38);
            this.adressTextBox.TabIndex = 11;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.adressLabel.Location = new System.Drawing.Point(284, 158);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(93, 35);
            this.adressLabel.TabIndex = 14;
            this.adressLabel.Text = "Adress";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(390, 214);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(308, 38);
            this.passwordTextBox.TabIndex = 13;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Info;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.confirmButton.Location = new System.Drawing.Point(559, 291);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(139, 62);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // customerPictureBox
            // 
            this.customerPictureBox.Image = global::AdminApp.Properties.Resources.Customer;
            this.customerPictureBox.Location = new System.Drawing.Point(45, 97);
            this.customerPictureBox.Name = "customerPictureBox";
            this.customerPictureBox.Size = new System.Drawing.Size(180, 155);
            this.customerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerPictureBox.TabIndex = 0;
            this.customerPictureBox.TabStop = false;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 23;
            this.toolTip.AutoPopDelay = 999999999;
            this.toolTip.InitialDelay = 23;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 4;
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip.ToolTipTitle = "Warning";
            // 
            // messagePictureBox
            // 
            this.messagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagePictureBox.Image = global::AdminApp.Properties.Resources.Message;
            this.messagePictureBox.Location = new System.Drawing.Point(703, 34);
            this.messagePictureBox.Name = "messagePictureBox";
            this.messagePictureBox.Size = new System.Drawing.Size(45, 45);
            this.messagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messagePictureBox.TabIndex = 16;
            this.messagePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.messagePictureBox, "The login must be no shorter than three characters and no longer than sixteen. \r\n" +
        "Password must be no shorter than six characters and no longer than fourteen.\r\nOn" +
        "ly letters and numbers are allowed.");
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(769, 452);
            this.Controls.Add(this.messagePictureBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.customerPictureBox);
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox customerPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox messagePictureBox;
    }
}