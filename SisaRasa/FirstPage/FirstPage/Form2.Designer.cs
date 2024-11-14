namespace FirstPage
{
    partial class RegisterForm
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
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            btnRegister = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(74, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username  :";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(75, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password   :";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(22, 240);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(138, 20);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password  :";
            lblConfirmPassword.Click += lblConfirmPassword_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(225, 289);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(179, 166);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(183, 27);
            tbUsername.TabIndex = 4;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(179, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(183, 27);
            tbPassword.TabIndex = 5;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(179, 240);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(183, 27);
            tbConfirmPassword.TabIndex = 6;
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 453);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnRegister);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Button btnRegister;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
    }
}