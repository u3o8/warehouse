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
            this.Login = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Info;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(196, 49);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(308, 38);
            this.Login.TabIndex = 0;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.label_Login.Location = new System.Drawing.Point(103, 52);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(77, 35);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Login";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.label_Password.Location = new System.Drawing.Point(54, 116);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(126, 35);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Info;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(196, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(308, 38);
            this.Password.TabIndex = 4;
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.SystemColors.Info;
            this.Cancel_button.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.Cancel_button.Location = new System.Drawing.Point(365, 203);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(139, 62);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            // 
            // OK_button
            // 
            this.OK_button.BackColor = System.Drawing.SystemColors.Info;
            this.OK_button.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.OK_button.Location = new System.Drawing.Point(196, 203);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(139, 62);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = false;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(575, 340);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.Login);
            this.Name = "Home_Page";
            this.Text = "Home_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button OK_button;
    }
}

