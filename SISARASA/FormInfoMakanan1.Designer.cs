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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BorderRadius = 10;
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.CustomizableEdges = customizableEdges1;
            btnAddToCart.DisabledState.BorderColor = Color.DarkGray;
            btnAddToCart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddToCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddToCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddToCart.FillColor = Color.FromArgb(255, 79, 24);
            btnAddToCart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(32, 36);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddToCart.Size = new Size(151, 45);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // FormInfoMakanan1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(208, 114);
            Controls.Add(btnAddToCart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInfoMakanan1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInfoMakanan1";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
    }
}