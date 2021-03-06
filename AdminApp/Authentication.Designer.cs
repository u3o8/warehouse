﻿namespace AdminApp
{
    partial class Authentication
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.authenticationPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.Info;
            this.okButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.okButton.Location = new System.Drawing.Point(209, 246);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(139, 62);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Info;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.cancelButton.Location = new System.Drawing.Point(378, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 62);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(209, 159);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(308, 38);
            this.passwordTextBox.TabIndex = 17;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.labelPassword.Location = new System.Drawing.Point(67, 159);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 35);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.labelLogin.Location = new System.Drawing.Point(116, 95);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(77, 35);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.Location = new System.Drawing.Point(209, 92);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(308, 38);
            this.loginTextBox.TabIndex = 14;
            // 
            // authenticationPictureBox
            // 
            this.authenticationPictureBox.Image = global::AdminApp.Properties.Resources.Authentication;
            this.authenticationPictureBox.Location = new System.Drawing.Point(23, 16);
            this.authenticationPictureBox.Name = "authenticationPictureBox";
            this.authenticationPictureBox.Size = new System.Drawing.Size(116, 76);
            this.authenticationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.authenticationPictureBox.TabIndex = 20;
            this.authenticationPictureBox.TabStop = false;
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.SystemColors.Info;
            this.passwordButton.BackgroundImage = global::AdminApp.Properties.Resources.Password;
            this.passwordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordButton.Location = new System.Drawing.Point(525, 159);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(38, 38);
            this.passwordButton.TabIndex = 21;
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(595, 352);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.authenticationPictureBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            ((System.ComponentModel.ISupportInitialize)(this.authenticationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.PictureBox authenticationPictureBox;
        private System.Windows.Forms.Button passwordButton;
    }
}

