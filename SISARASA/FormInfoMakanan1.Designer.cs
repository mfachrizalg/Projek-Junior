namespace SISARASA
{
    partial class FormInfoMakanan1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitDashboard).BeginInit();
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 90);
            panel1.TabIndex = 1;
            // 
            // picboxExitDashboard
            // 
            picboxExitDashboard.Cursor = Cursors.Hand;
            picboxExitDashboard.Image = Properties.Resources.letter_x_9313434;
            picboxExitDashboard.ImageRotate = 0F;
            picboxExitDashboard.InitialImage = null;
            picboxExitDashboard.Location = new Point(1232, 12);
            picboxExitDashboard.Name = "picboxExitDashboard";
            picboxExitDashboard.ShadowDecoration.CustomizableEdges = customizableEdges3;
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
            lblDashboard.Click += lblDashboard_Click;
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
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.Silver;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 5;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(520, 109);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(762, 619);
            guna2Panel1.TabIndex = 2;
            // 
            // FormInfoMakanan1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 740);
            Controls.Add(guna2Panel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInfoMakanan1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInfoMakanan1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxExitDashboard;
        private Panel pnlunderdash;
        private Label lblCart;
        private Label lblDashboard;
        private Label lblProfile;
        private Label sisarasaataskiri;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}