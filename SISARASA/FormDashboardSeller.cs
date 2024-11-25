using SISARASA.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISARASA
{
    public partial class FormDashboardSeller : Form
    {
        public FormDashboardSeller()
        {
            InitializeComponent();
            lblNamaOnDashboardSeller.Text = UserSession.Username;
            if (UserSession.Alamat != null)
            {
                lblAlamatOnDashboardSeller.Text = UserSession.Alamat;
            }
            else
            {
                lblAlamatOnDashboardSeller.Text = "Alamat belum diatur";
            }
            LoadMenuItems();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProfileSeller_Click(object sender, EventArgs e)
        {
            FormProfileSeller formProfile = new();
            formProfile.Show();
            Visible = false;
        }

        private void lblNotifSeller_Click(object sender, EventArgs e)
        {
            FormNotificationSeller formNotificationSeller = new FormNotificationSeller();
            formNotificationSeller.Show();
            Visible = false;
        }

        private void lblNotifTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMakanan_Click(object sender, EventArgs e)
        {
            FormAddMakanan formAddMakanan = new FormAddMakanan();
            formAddMakanan.Show();
            Visible = false;
        }
        private void LoadMenuItems()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var menuItems = context.Menus
                        .Where(menu => menu.user_id == UserSession.Id)
                        .ToList();

                    guna2Panel1.Controls.Clear();
                    guna2Panel1.AutoScroll = true;

                    foreach (var menuItem in menuItems)
                    {
                        var menuControl = new UserControlKomponenMakanan
                        {
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
    }
}