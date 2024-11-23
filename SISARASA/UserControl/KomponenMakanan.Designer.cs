namespace SISARASA
{
    partial class KomponenMakanan
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pictBoxKomponen = new Guna.UI2.WinForms.Guna2PictureBox();
            lblKomponenNamaMakanan = new Label();
            ((System.ComponentModel.ISupportInitialize)pictBoxKomponen).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictBoxKomponen
            // 
            pictBoxKomponen.CustomizableEdges = customizableEdges1;
            pictBoxKomponen.Image = Properties.Resources.add_button_15600739;
            pictBoxKomponen.ImageRotate = 0F;
            pictBoxKomponen.Location = new Point(12, 12);
            pictBoxKomponen.Name = "pictBoxKomponen";
            pictBoxKomponen.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictBoxKomponen.Size = new Size(235, 186);
            pictBoxKomponen.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxKomponen.TabIndex = 0;
            pictBoxKomponen.TabStop = false;
            // 
            // lblKomponenNamaMakanan
            // 
            lblKomponenNamaMakanan.AutoSize = true;
            lblKomponenNamaMakanan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKomponenNamaMakanan.Location = new Point(53, 218);
            lblKomponenNamaMakanan.Name = "lblKomponenNamaMakanan";
            lblKomponenNamaMakanan.Size = new Size(154, 24);
            lblKomponenNamaMakanan.TabIndex = 1;
            lblKomponenNamaMakanan.Text = "Nama Makanan";
            // 
            // KomponenMakanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(259, 289);
            Controls.Add(lblKomponenNamaMakanan);
            Controls.Add(pictBoxKomponen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KomponenMakanan";
            Text = "KomponenMakanan";
            ((System.ComponentModel.ISupportInitialize)pictBoxKomponen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pictBoxKomponen;
        private Label lblKomponenNamaMakanan;
    }
}