using SISARASA.Class;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SISARASA
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            lblUsernameDashboard.Text = $"Hi, {UserSession.Username}";
            if (UserSession.Alamat != null)
            {
                lblAlamatOnDashboard.Text = UserSession.Alamat;
            }
            else
            {
                lblAlamatOnDashboard.Text = "Alamat belum diatur";
            }
            LoadMenuItems();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            string nama = lblUsernameDashboard.Text.Substring(4, lblUsernameDashboard.Text.Length - 4);
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void picboxExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }
        private void LoadMenuItems()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var menuItems = context.Menus.ToList();

                    guna2Panel1.Controls.Clear();
                    guna2Panel1.AutoScroll = true;

                    foreach (var menuItem in menuItems)
                    {
                        var menuControl = new UserControlKomponenMakanan
                        {
                            MenuId = menuItem.id,
                            MakananText = menuItem.nama,
                            Width = guna2Panel1.Width, // Adjust width to fit within the panel
                            Height = 650 // Set a fixed height for each control
                        };
                        menuControl.LoadImageFromUrl(menuItem.gambar);

                        guna2Panel1.Controls.Add(menuControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading menu items: {ex.Message}");
            }
        }
        private void userControlKomponenMakanan1_Click(object sender, EventArgs e)
        {
            var menuControl = sender as UserControlKomponenMakanan;
            if (menuControl != null)
            {
                int menuId = menuControl.MenuId; // Assuming UserControlKomponenMakanan has a MenuId property
                FormInfoMakanan1 formInfoMakanan = new FormInfoMakanan1(menuId);
                formInfoMakanan.Show();
                Visible = false;
            }
        }
    }
}