namespace SISARASA
{
    partial class UserControlKomponenMakanan
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
            pictBoxMakanan = new Guna.UI2.WinForms.Guna2PictureBox();
            lblMakananUserControl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictBoxMakanan).BeginInit();
            SuspendLayout();
            // 
            // pictBoxMakanan
            // 
            pictBoxMakanan.Cursor = Cursors.Hand;
            pictBoxMakanan.CustomizableEdges = customizableEdges1;
            pictBoxMakanan.Image = Properties.Resources.add_button_15600739;
            pictBoxMakanan.ImageRotate = 0F;
            pictBoxMakanan.Location = new Point(27, 18);
            pictBoxMakanan.Name = "pictBoxMakanan";
            pictBoxMakanan.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictBoxMakanan.Size = new Size(175, 180);
            pictBoxMakanan.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxMakanan.TabIndex = 0;
            pictBoxMakanan.TabStop = false;
            pictBoxMakanan.Click += pictBoxMakanan_Click;
            // 
            // lblMakananUserControl
            // 
            lblMakananUserControl.AutoSize = true;
            lblMakananUserControl.Cursor = Cursors.Hand;
            lblMakananUserControl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakananUserControl.Location = new Point(37, 223);
            lblMakananUserControl.Name = "lblMakananUserControl";
            lblMakananUserControl.Size = new Size(154, 24);
            lblMakananUserControl.TabIndex = 1;
            lblMakananUserControl.Text = "Nama Makanan";
            lblMakananUserControl.Click += lblMakananUserControl_Click;
            // 
            // UserControlKomponenMakanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblMakananUserControl);
            Controls.Add(pictBoxMakanan);
            Name = "UserControlKomponenMakanan";
            Size = new Size(233, 261);
            ((System.ComponentModel.ISupportInitialize)pictBoxMakanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictBoxMakanan;
        private Label lblMakananUserControl;
    }
}
