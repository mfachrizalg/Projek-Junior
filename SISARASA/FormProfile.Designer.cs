namespace SISARASA
{
    partial class FormProfile
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            picboxExitProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pnlunderdashonprofile = new Panel();
            lblCartonProfile = new Label();
            lblDashboardonProfile = new Label();
            lblProfileonProfile = new Label();
            sisarasaataskirionprofile = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitProfile).BeginInit();
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
            panel1.Controls.Add(picboxExitProfile);
            panel1.Controls.Add(pnlunderdashonprofile);
            panel1.Controls.Add(lblCartonProfile);
            panel1.Controls.Add(lblDashboardonProfile);
            panel1.Controls.Add(lblProfileonProfile);
            panel1.Controls.Add(sisarasaataskirionprofile);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 90);
            panel1.TabIndex = 1;
            // 
            // picboxExitProfile
            // 
            picboxExitProfile.Cursor = Cursors.Hand;
            picboxExitProfile.Image = Properties.Resources.letter_x_9313434;
            picboxExitProfile.ImageRotate = 0F;
            picboxExitProfile.InitialImage = null;
            picboxExitProfile.Location = new Point(1228, 12);
            picboxExitProfile.Name = "picboxExitProfile";
            picboxExitProfile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picboxExitProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picboxExitProfile.Size = new Size(54, 57);
            picboxExitProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picboxExitProfile.TabIndex = 10;
            picboxExitProfile.TabStop = false;
            picboxExitProfile.Click += picboxExitProfile_Click;
            // 
            // pnlunderdashonprofile
            // 
            pnlunderdashonprofile.BackColor = Color.White;
            pnlunderdashonprofile.Location = new Point(694, 62);
            pnlunderdashonprofile.Name = "pnlunderdashonprofile";
            pnlunderdashonprofile.Size = new Size(50, 3);
            pnlunderdashonprofile.TabIndex = 2;
            // 
            // lblCartonProfile
            // 
            lblCartonProfile.AutoSize = true;
            lblCartonProfile.Cursor = Cursors.Hand;
            lblCartonProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartonProfile.ForeColor = Color.White;
            lblCartonProfile.Location = new Point(812, 35);
            lblCartonProfile.Name = "lblCartonProfile";
            lblCartonProfile.Size = new Size(50, 24);
            lblCartonProfile.TabIndex = 1;
            lblCartonProfile.Text = "Cart";
            lblCartonProfile.Click += lblCartonProfile_Click;
            // 
            // lblDashboardonProfile
            // 
            lblDashboardonProfile.AutoSize = true;
            lblDashboardonProfile.Cursor = Cursors.Hand;
            lblDashboardonProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardonProfile.ForeColor = Color.White;
            lblDashboardonProfile.Location = new Point(520, 35);
            lblDashboardonProfile.Name = "lblDashboardonProfile";
            lblDashboardonProfile.Size = new Size(113, 24);
            lblDashboardonProfile.TabIndex = 1;
            lblDashboardonProfile.Text = "Dashboard";
            lblDashboardonProfile.Click += lblDashboardonProfile_Click;
            // 
            // lblProfileonProfile
            // 
            lblProfileonProfile.AutoSize = true;
            lblProfileonProfile.Cursor = Cursors.Hand;
            lblProfileonProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileonProfile.ForeColor = Color.White;
            lblProfileonProfile.Location = new Point(684, 35);
            lblProfileonProfile.Name = "lblProfileonProfile";
            lblProfileonProfile.Size = new Size(71, 24);
            lblProfileonProfile.TabIndex = 1;
            lblProfileonProfile.Text = "Profile";
            lblProfileonProfile.Click += lblProfileonProfile_Click;
            // 
            // sisarasaataskirionprofile
            // 
            sisarasaataskirionprofile.AutoSize = true;
            sisarasaataskirionprofile.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sisarasaataskirionprofile.ForeColor = Color.White;
            sisarasaataskirionprofile.Location = new Point(37, 18);
            sisarasaataskirionprofile.Name = "sisarasaataskirionprofile";
            sisarasaataskirionprofile.Size = new Size(180, 45);
            sisarasaataskirionprofile.TabIndex = 0;
            sisarasaataskirionprofile.Text = "SISARASA";
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 740);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Panel pnlunderdashonprofile;
        private Label lblCartonProfile;
        private Label lblDashboardonProfile;
        private Label lblProfileonProfile;
        private Label sisarasaataskirionprofile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxExitProfile;
    }
}