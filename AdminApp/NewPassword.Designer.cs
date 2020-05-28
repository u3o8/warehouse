namespace AdminApp
{
    partial class NewPassword
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newPasswordButton = new System.Windows.Forms.Button();
            this.currentPasswordButton = new System.Windows.Forms.Button();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.messagePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Info;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.confirmButton.Location = new System.Drawing.Point(426, 234);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(139, 62);
            this.confirmButton.TabIndex = 36;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(257, 164);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(308, 38);
            this.newPasswordTextBox.TabIndex = 40;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(38, 164);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(193, 35);
            this.newPasswordLabel.TabIndex = 39;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.currentPasswordLabel.Location = new System.Drawing.Point(5, 100);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(229, 35);
            this.currentPasswordLabel.TabIndex = 38;
            this.currentPasswordLabel.Text = "Current Password:";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTextBox.Location = new System.Drawing.Point(257, 100);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(308, 38);
            this.currentPasswordTextBox.TabIndex = 37;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(257, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 62);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.passwordLabel.Location = new System.Drawing.Point(249, 23);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(251, 46);
            this.passwordLabel.TabIndex = 42;
            this.passwordLabel.Text = "New Password";
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.BackColor = System.Drawing.SystemColors.Info;
            this.newPasswordButton.BackgroundImage = global::AdminApp.Properties.Resources.Password;
            this.newPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newPasswordButton.Location = new System.Drawing.Point(582, 164);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(38, 38);
            this.newPasswordButton.TabIndex = 45;
            this.newPasswordButton.UseVisualStyleBackColor = false;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // currentPasswordButton
            // 
            this.currentPasswordButton.BackColor = System.Drawing.SystemColors.Info;
            this.currentPasswordButton.BackgroundImage = global::AdminApp.Properties.Resources.Password;
            this.currentPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.currentPasswordButton.Location = new System.Drawing.Point(582, 100);
            this.currentPasswordButton.Name = "currentPasswordButton";
            this.currentPasswordButton.Size = new System.Drawing.Size(38, 38);
            this.currentPasswordButton.TabIndex = 44;
            this.currentPasswordButton.UseVisualStyleBackColor = false;
            this.currentPasswordButton.Click += new System.EventHandler(this.currentPasswordButton_Click);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Image = global::AdminApp.Properties.Resources.NewPassword;
            this.passwordPictureBox.Location = new System.Drawing.Point(120, 6);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(134, 93);
            this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPictureBox.TabIndex = 43;
            this.passwordPictureBox.TabStop = false;
            // 
            // messagePictureBox
            // 
            this.messagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagePictureBox.Image = global::AdminApp.Properties.Resources.Message;
            this.messagePictureBox.Location = new System.Drawing.Point(559, 24);
            this.messagePictureBox.Name = "messagePictureBox";
            this.messagePictureBox.Size = new System.Drawing.Size(45, 45);
            this.messagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messagePictureBox.TabIndex = 46;
            this.messagePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.messagePictureBox, "The login must be no shorter than three characters and no longer than sixteen. \r\n" +
        "Password must be no shorter than six characters and no longer than fourteen.\r\nOn" +
        "ly letters and numbers are allowed.\r\n");
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
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(636, 339);
            this.Controls.Add(this.messagePictureBox);
            this.Controls.Add(this.newPasswordButton);
            this.Controls.Add(this.currentPasswordButton);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.confirmButton);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.Button currentPasswordButton;
        private System.Windows.Forms.Button newPasswordButton;
        private System.Windows.Forms.PictureBox messagePictureBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}