namespace AdminApp
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
            this.textbox_Login = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_Login
            // 
            this.textbox_Login.BackColor = System.Drawing.SystemColors.Info;
            this.textbox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Login.Location = new System.Drawing.Point(196, 49);
            this.textbox_Login.Name = "textbox_Login";
            this.textbox_Login.Size = new System.Drawing.Size(308, 38);
            this.textbox_Login.TabIndex = 0;
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
            // textbox_Password
            // 
            this.textbox_Password.BackColor = System.Drawing.SystemColors.Info;
            this.textbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password.Location = new System.Drawing.Point(196, 116);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(308, 38);
            this.textbox_Password.TabIndex = 4;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.SystemColors.Info;
            this.button_Cancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.button_Cancel.Location = new System.Drawing.Point(365, 203);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(139, 62);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.Info;
            this.button_OK.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.button_OK.Location = new System.Drawing.Point(196, 203);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(139, 62);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(575, 340);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textbox_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Login;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
    }
}

