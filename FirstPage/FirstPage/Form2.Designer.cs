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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            btnRegister = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(133, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(90, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username  :";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(133, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password   :";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(80, 240);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(144, 20);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password  :";
            lblConfirmPassword.Click += lblConfirmPassword_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveCaptionText;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(225, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 37);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(225, 166);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(196, 27);
            tbUsername.TabIndex = 4;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(225, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(196, 27);
            tbPassword.TabIndex = 5;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            tbConfirmPassword.Location = new Point(225, 237);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(196, 27);
            tbConfirmPassword.TabIndex = 6;
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Microsoft Sans Serif", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(225, 100);
            label1.Name = "label1";
            label1.Size = new Size(232, 44);
            label1.TabIndex = 7;
            label1.Text = "SISA RASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 273);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Role :";
            label2.Click += lblConfirmPassword_Click;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.AllowDrop = true;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges1;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "Penjual", "Pembeli" });
            guna2ComboBox1.Location = new Point(225, 273);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox1.Size = new Size(196, 36);
            guna2ComboBox1.TabIndex = 2;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            ClientSize = new Size(631, 453);
            Controls.Add(guna2ComboBox1);
            Controls.Add(label1);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnRegister);
            Controls.Add(label2);
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
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}