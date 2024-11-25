namespace SISARASA
{
    partial class FormCart
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
            picboxExitCart = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pnlunderdashonCart = new Panel();
            lblCartonCart = new Label();
            lblDashboardonCart = new Label();
            lblProfileonCart = new Label();
            sisarasaataskirionCart = new Label();
            lblkeranjangSaya = new Label();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            label1 = new Label();
            label2 = new Label();
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            userControlCheckOut1 = new UserControlCheckOut();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitCart).BeginInit();
            guna2Panel1.SuspendLayout();
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
            panel1.Controls.Add(picboxExitCart);
            panel1.Controls.Add(pnlunderdashonCart);
            panel1.Controls.Add(lblCartonCart);
            panel1.Controls.Add(lblDashboardonCart);
            panel1.Controls.Add(lblProfileonCart);
            panel1.Controls.Add(sisarasaataskirionCart);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 90);
            panel1.TabIndex = 2;
            // 
            // picboxExitCart
            // 
            picboxExitCart.Cursor = Cursors.Hand;
            picboxExitCart.Image = Properties.Resources.letter_x_9313434;
            picboxExitCart.ImageRotate = 0F;
            picboxExitCart.InitialImage = null;
            picboxExitCart.Location = new Point(1228, 12);
            picboxExitCart.Name = "picboxExitCart";
            picboxExitCart.ShadowDecoration.CustomizableEdges = customizableEdges5;
            picboxExitCart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picboxExitCart.Size = new Size(54, 57);
            picboxExitCart.SizeMode = PictureBoxSizeMode.Zoom;
            picboxExitCart.TabIndex = 10;
            picboxExitCart.TabStop = false;
            picboxExitCart.Click += picboxExitCart_Click;
            // 
            // pnlunderdashonCart
            // 
            pnlunderdashonCart.BackColor = Color.White;
            pnlunderdashonCart.Location = new Point(812, 62);
            pnlunderdashonCart.Name = "pnlunderdashonCart";
            pnlunderdashonCart.Size = new Size(50, 3);
            pnlunderdashonCart.TabIndex = 2;
            // 
            // lblCartonCart
            // 
            lblCartonCart.AutoSize = true;
            lblCartonCart.Cursor = Cursors.Hand;
            lblCartonCart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartonCart.ForeColor = Color.White;
            lblCartonCart.Location = new Point(812, 35);
            lblCartonCart.Name = "lblCartonCart";
            lblCartonCart.Size = new Size(50, 24);
            lblCartonCart.TabIndex = 1;
            lblCartonCart.Text = "Cart";
            // 
            // lblDashboardonCart
            // 
            lblDashboardonCart.AutoSize = true;
            lblDashboardonCart.Cursor = Cursors.Hand;
            lblDashboardonCart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardonCart.ForeColor = Color.White;
            lblDashboardonCart.Location = new Point(520, 35);
            lblDashboardonCart.Name = "lblDashboardonCart";
            lblDashboardonCart.Size = new Size(113, 24);
            lblDashboardonCart.TabIndex = 1;
            lblDashboardonCart.Text = "Dashboard";
            lblDashboardonCart.Click += lblDashboardonCart_Click;
            // 
            // lblProfileonCart
            // 
            lblProfileonCart.AutoSize = true;
            lblProfileonCart.Cursor = Cursors.Hand;
            lblProfileonCart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileonCart.ForeColor = Color.White;
            lblProfileonCart.Location = new Point(684, 35);
            lblProfileonCart.Name = "lblProfileonCart";
            lblProfileonCart.Size = new Size(71, 24);
            lblProfileonCart.TabIndex = 1;
            lblProfileonCart.Text = "Profile";
            lblProfileonCart.Click += lblProfileonCart_Click;
            // 
            // sisarasaataskirionCart
            // 
            sisarasaataskirionCart.AutoSize = true;
            sisarasaataskirionCart.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sisarasaataskirionCart.ForeColor = Color.White;
            sisarasaataskirionCart.Location = new Point(37, 18);
            sisarasaataskirionCart.Name = "sisarasaataskirionCart";
            sisarasaataskirionCart.Size = new Size(180, 45);
            sisarasaataskirionCart.TabIndex = 0;
            sisarasaataskirionCart.Text = "SISARASA";
            // 
            // lblkeranjangSaya
            // 
            lblkeranjangSaya.AutoSize = true;
            lblkeranjangSaya.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblkeranjangSaya.Location = new Point(108, 112);
            lblkeranjangSaya.Name = "lblkeranjangSaya";
            lblkeranjangSaya.Size = new Size(299, 44);
            lblkeranjangSaya.TabIndex = 3;
            lblkeranjangSaya.Text = "Keranjang Saya";
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
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(756, 639);
            label1.Name = "label1";
            label1.Size = new Size(81, 33);
            label1.TabIndex = 3;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 79, 24);
            label2.Location = new Point(983, 639);
            label2.Name = "label2";
            label2.Size = new Size(0, 33);
            label2.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 10;
            btnCheckOut.CustomizableEdges = customizableEdges3;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.FillColor = Color.FromArgb(255, 79, 24);
            btnCheckOut.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(983, 688);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCheckOut.Size = new Size(180, 40);
            btnCheckOut.TabIndex = 7;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.LightGray;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.BorderThickness = 5;
            guna2Panel1.Controls.Add(userControlCheckOut1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(68, 183);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1158, 411);
            guna2Panel1.TabIndex = 9;
            // 
            // userControlCheckOut1
            // 
            userControlCheckOut1.BackColor = Color.White;
            userControlCheckOut1.CheckoutHarga = 0;
            userControlCheckOut1.CheckOutText = "Nama Makanan";
            userControlCheckOut1.Location = new Point(40, 31);
            userControlCheckOut1.Name = "userControlCheckOut1";
            userControlCheckOut1.Size = new Size(804, 230);
            userControlCheckOut1.TabIndex = 9;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 740);
            Controls.Add(guna2Panel1);
            Controls.Add(btnCheckOut);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblkeranjangSaya);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxExitCart).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxExitCart;
        private Panel pnlunderdashonCart;
        private Label lblCartonCart;
        private Label lblDashboardonCart;
        private Label lblProfileonCart;
        private Label sisarasaataskirionCart;
        private Label lblkeranjangSaya;
        private Label label1;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UserControlCheckOut userControlCheckOut1;
    }
}