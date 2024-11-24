namespace SISARASA
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            picboxExitDashboard = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pnlunderdash = new Panel();
            lblCart = new Label();
            lblDashboard = new Label();
            lblProfile = new Label();
            sisarasaataskiri = new Label();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            userControlKomponenMakanan4 = new UserControlKomponenMakanan();
            userControlKomponenMakanan3 = new UserControlKomponenMakanan();
            userControlKomponenMakanan2 = new UserControlKomponenMakanan();
            userControlKomponenMakanan1 = new UserControlKomponenMakanan();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblUsernameDashboard = new Label();
            lblAlamatOnDashboard = new Label();
            gunaAreaDataset2 = new Guna.Charts.WinForms.GunaAreaDataset();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 79, 24);
            panel1.Controls.Add(picboxExitDashboard);
            panel1.Controls.Add(pnlunderdash);
            panel1.Controls.Add(lblCart);
            panel1.Controls.Add(lblDashboard);
            panel1.Controls.Add(lblProfile);
            panel1.Controls.Add(sisarasaataskiri);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 90);
            panel1.TabIndex = 0;
            // 
            // picboxExitDashboard
            // 
            picboxExitDashboard.Cursor = Cursors.Hand;
            picboxExitDashboard.Image = Properties.Resources.letter_x_9313434;
            picboxExitDashboard.ImageRotate = 0F;
            picboxExitDashboard.InitialImage = null;
            picboxExitDashboard.Location = new Point(1232, 12);
            picboxExitDashboard.Name = "picboxExitDashboard";
            picboxExitDashboard.ShadowDecoration.CustomizableEdges = customizableEdges5;
            picboxExitDashboard.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picboxExitDashboard.Size = new Size(54, 57);
            picboxExitDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picboxExitDashboard.TabIndex = 10;
            picboxExitDashboard.TabStop = false;
            picboxExitDashboard.Click += picboxExitDashboard_Click;
            // 
            // pnlunderdash
            // 
            pnlunderdash.BackColor = Color.White;
            pnlunderdash.Location = new Point(551, 62);
            pnlunderdash.Name = "pnlunderdash";
            pnlunderdash.Size = new Size(50, 3);
            pnlunderdash.TabIndex = 2;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Cursor = Cursors.Hand;
            lblCart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCart.ForeColor = Color.White;
            lblCart.Location = new Point(812, 35);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(50, 24);
            lblCart.TabIndex = 1;
            lblCart.Text = "Cart";
            lblCart.Click += lblCart_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Cursor = Cursors.Hand;
            lblDashboard.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(520, 35);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(113, 24);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblProfile_Click;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Cursor = Cursors.Hand;
            lblProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.ForeColor = Color.White;
            lblProfile.Location = new Point(684, 35);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(71, 24);
            lblProfile.TabIndex = 1;
            lblProfile.Text = "Profile";
            lblProfile.Click += lblProfile_Click;
            // 
            // sisarasaataskiri
            // 
            sisarasaataskiri.AutoSize = true;
            sisarasaataskiri.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sisarasaataskiri.ForeColor = Color.White;
            sisarasaataskiri.Location = new Point(37, 18);
            sisarasaataskiri.Name = "sisarasaataskiri";
            sisarasaataskiri.Size = new Size(180, 45);
            sisarasaataskiri.TabIndex = 0;
            sisarasaataskiri.Text = "SISARASA";
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 125);
            label1.Name = "label1";
            label1.Size = new Size(208, 53);
            label1.TabIndex = 0;
            label1.Text = "SISARASA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.breakfast_2144670_1;
            pictureBox1.Location = new Point(936, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.diet_706133_1;
            pictureBox2.Location = new Point(1003, 501);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 244);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.LightGray;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.BorderThickness = 5;
            guna2Panel1.Controls.Add(userControlKomponenMakanan4);
            guna2Panel1.Controls.Add(userControlKomponenMakanan3);
            guna2Panel1.Controls.Add(userControlKomponenMakanan2);
            guna2Panel1.Controls.Add(userControlKomponenMakanan1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(77, 359);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1158, 325);
            guna2Panel1.TabIndex = 4;
            // 
            // userControlKomponenMakanan4
            // 
            userControlKomponenMakanan4.BackColor = Color.White;
            userControlKomponenMakanan4.Location = new Point(886, 24);
            userControlKomponenMakanan4.Name = "userControlKomponenMakanan4";
            userControlKomponenMakanan4.Size = new Size(228, 278);
            userControlKomponenMakanan4.TabIndex = 0;
            // 
            // userControlKomponenMakanan3
            // 
            userControlKomponenMakanan3.BackColor = Color.White;
            userControlKomponenMakanan3.Location = new Point(603, 24);
            userControlKomponenMakanan3.Name = "userControlKomponenMakanan3";
            userControlKomponenMakanan3.Size = new Size(228, 278);
            userControlKomponenMakanan3.TabIndex = 0;
            // 
            // userControlKomponenMakanan2
            // 
            userControlKomponenMakanan2.BackColor = Color.White;
            userControlKomponenMakanan2.Location = new Point(308, 24);
            userControlKomponenMakanan2.Name = "userControlKomponenMakanan2";
            userControlKomponenMakanan2.Size = new Size(228, 278);
            userControlKomponenMakanan2.TabIndex = 0;
            // 
            // userControlKomponenMakanan1
            // 
            userControlKomponenMakanan1.BackColor = Color.White;
            userControlKomponenMakanan1.Cursor = Cursors.Hand;
            userControlKomponenMakanan1.Location = new Point(23, 24);
            userControlKomponenMakanan1.Name = "userControlKomponenMakanan1";
            userControlKomponenMakanan1.Size = new Size(228, 278);
            userControlKomponenMakanan1.TabIndex = 0;
            userControlKomponenMakanan1.Load += userControlKomponenMakanan1_Click;
            userControlKomponenMakanan1.Click += lblCart_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.IoLocation;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(43, 223);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(24, 24);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 12;
            guna2PictureBox1.TabStop = false;
            // 
            // lblUsernameDashboard
            // 
            lblUsernameDashboard.AutoSize = true;
            lblUsernameDashboard.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameDashboard.ForeColor = Color.Black;
            lblUsernameDashboard.Location = new Point(43, 178);
            lblUsernameDashboard.Name = "lblUsernameDashboard";
            lblUsernameDashboard.Size = new Size(124, 27);
            lblUsernameDashboard.TabIndex = 0;
            lblUsernameDashboard.Text = "Hi, Yodha!";
            // 
            // lblAlamatOnDashboard
            // 
            lblAlamatOnDashboard.AutoSize = true;
            lblAlamatOnDashboard.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlamatOnDashboard.ForeColor = Color.Black;
            lblAlamatOnDashboard.Location = new Point(73, 223);
            lblAlamatOnDashboard.Name = "lblAlamatOnDashboard";
            lblAlamatOnDashboard.Size = new Size(34, 24);
            lblAlamatOnDashboard.TabIndex = 0;
            lblAlamatOnDashboard.Text = "....";
            // 
            // gunaAreaDataset2
            // 
            gunaAreaDataset2.BorderColor = Color.Empty;
            gunaAreaDataset2.FillColor = Color.Empty;
            gunaAreaDataset2.Label = "Area2";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 740);
            Controls.Add(guna2PictureBox1);
            Controls.Add(guna2Panel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(lblAlamatOnDashboard);
            Controls.Add(lblUsernameDashboard);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Label lblCart;
        private Label lblProfile;
        private Label sisarasaataskiri;
        private Panel pnlunderdash;
        private Label lblDashboard;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxExitDashboard;
        private Label label1;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label lblUsernameDashboard;
        private Label lblAlamatOnDashboard;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset2;
        private UserControlKomponenMakanan userControlKomponenMakanan4;
        private UserControlKomponenMakanan userControlKomponenMakanan3;
        private UserControlKomponenMakanan userControlKomponenMakanan2;
        private UserControlKomponenMakanan userControlKomponenMakanan1;
    }
}