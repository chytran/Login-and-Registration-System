namespace Login_and_Registration_System
{
    partial class Registration
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
            this.user = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(237, 64);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(88, 13);
            this.user.TabIndex = 0;
            this.user.Text = "Enter User Name";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(365, 61);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(155, 20);
            this.userNameTxt.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(237, 107);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 13);
            this.password.TabIndex = 0;
            this.password.Text = "Enter Password";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(365, 104);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(155, 20);
            this.passwordText.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(237, 161);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(91, 13);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(365, 158);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(155, 20);
            this.confirmPassword.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Have Account ? Login Now";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}