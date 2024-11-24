namespace SISARASA
{
    partial class UserControlCheckOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            txtBoxOnCheckOutUserControl = new Guna.UI2.WinForms.Guna2TextBox();
            pictBoxOnCheckoutUserControl = new Guna.UI2.WinForms.Guna2PictureBox();
            lblNamaMakananUserControlCheckOut = new Label();
            lblHargaOnUserControl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxOnCheckoutUserControl).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IoReaderOutline;
            pictureBox1.Location = new Point(219, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtBoxOnCheckOutUserControl
            // 
            txtBoxOnCheckOutUserControl.BackColor = Color.Transparent;
            txtBoxOnCheckOutUserControl.BorderColor = Color.Gray;
            txtBoxOnCheckOutUserControl.BorderRadius = 20;
            txtBoxOnCheckOutUserControl.BorderThickness = 3;
            txtBoxOnCheckOutUserControl.Cursor = Cursors.IBeam;
            txtBoxOnCheckOutUserControl.CustomizableEdges = customizableEdges1;
            txtBoxOnCheckOutUserControl.DefaultText = "";
            txtBoxOnCheckOutUserControl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxOnCheckOutUserControl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxOnCheckOutUserControl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxOnCheckOutUserControl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxOnCheckOutUserControl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxOnCheckOutUserControl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOnCheckOutUserControl.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxOnCheckOutUserControl.Location = new Point(247, 64);
            txtBoxOnCheckOutUserControl.Margin = new Padding(3, 4, 3, 4);
            txtBoxOnCheckOutUserControl.Name = "txtBoxOnCheckOutUserControl";
            txtBoxOnCheckOutUserControl.PasswordChar = '\0';
            txtBoxOnCheckOutUserControl.PlaceholderText = "";
            txtBoxOnCheckOutUserControl.SelectedText = "";
            txtBoxOnCheckOutUserControl.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBoxOnCheckOutUserControl.Size = new Size(322, 124);
            txtBoxOnCheckOutUserControl.TabIndex = 11;
            // 
            // pictBoxOnCheckoutUserControl
            // 
            pictBoxOnCheckoutUserControl.BorderRadius = 40;
            pictBoxOnCheckoutUserControl.CustomizableEdges = customizableEdges3;
            pictBoxOnCheckoutUserControl.Image = Properties.Resources.add_button_15600739;
            pictBoxOnCheckoutUserControl.ImageRotate = 0F;
            pictBoxOnCheckoutUserControl.Location = new Point(17, 17);
            pictBoxOnCheckoutUserControl.Name = "pictBoxOnCheckoutUserControl";
            pictBoxOnCheckoutUserControl.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pictBoxOnCheckoutUserControl.Size = new Size(197, 193);
            pictBoxOnCheckoutUserControl.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxOnCheckoutUserControl.TabIndex = 10;
            pictBoxOnCheckoutUserControl.TabStop = false;
            // 
            // lblNamaMakananUserControlCheckOut
            // 
            lblNamaMakananUserControlCheckOut.AutoSize = true;
            lblNamaMakananUserControlCheckOut.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaMakananUserControlCheckOut.Location = new Point(236, 37);
            lblNamaMakananUserControlCheckOut.Name = "lblNamaMakananUserControlCheckOut";
            lblNamaMakananUserControlCheckOut.Size = new Size(147, 23);
            lblNamaMakananUserControlCheckOut.TabIndex = 9;
            lblNamaMakananUserControlCheckOut.Text = "Nama Makanan";
            // 
            // lblHargaOnUserControl
            // 
            lblHargaOnUserControl.AutoSize = true;
            lblHargaOnUserControl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaOnUserControl.ForeColor = Color.FromArgb(255, 79, 24);
            lblHargaOnUserControl.Location = new Point(653, 106);
            lblHargaOnUserControl.Name = "lblHargaOnUserControl";
            lblHargaOnUserControl.Size = new Size(146, 27);
            lblHargaOnUserControl.TabIndex = 13;
            lblHargaOnUserControl.Text = "Rp50.000,00";
            // 
            // UserControlCheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblHargaOnUserControl);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxOnCheckOutUserControl);
            Controls.Add(pictBoxOnCheckoutUserControl);
            Controls.Add(lblNamaMakananUserControlCheckOut);
            Name = "UserControlCheckOut";
            Size = new Size(814, 230);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxOnCheckoutUserControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxOnCheckOutUserControl;
        private Guna.UI2.WinForms.Guna2PictureBox pictBoxOnCheckoutUserControl;
        private Label lblNamaMakananUserControlCheckOut;
        private Label lblHargaOnUserControl;
    }
}
