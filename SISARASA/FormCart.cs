using SISARASA.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Ensure you have the Guna.UI2.WinForms namespace

namespace SISARASA
{
    public partial class FormCart : Form
    {
        private UserControlCheckOut userControlCheckOut;

        public FormCart()
        {
            InitializeComponent();
            userControlCheckOut = new UserControlCheckOut();
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var userId = UserSession.Id;
                    var cartItems = context.Carts
                        .Where(c => c.user_id == userId)
                        .Join(context.Menus,
                              cart => cart.menu_id,
                              menu => menu.id,
                              (cart, menu) => new
                              {
                                  menu.id,
                                  menu.nama,
                                  menu.harga,
                                  menu.gambar
                              })
                        .ToList();

                    guna2Panel1.Controls.Clear();
                    guna2Panel1.AutoScroll = true;

                    foreach (var item in cartItems)
                    {
                        var cartControl = new UserControlCheckOut
                        {
                            CheckOutText = item.nama,
                            CheckoutHarga = item.harga,
                            Width = guna2Panel1.Width, // Adjust width to fit within the panel

                            Height = 650 // Set a fixed height for each control
                        };
                        label2.Text += cartControl.CheckoutHarga;
                        cartControl.LoadImageFromUrl(item.gambar);

                        guna2Panel1.Controls.Add(cartControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading cart items: {ex.Message}");
            }
        }

        private void lblDashboardonCart_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            Visible = false;
        }

        private void lblProfileonCart_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void picboxExitCart_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            userControlCheckOut.Visible = true;

            try
            {
                using (var context = new AppDbContext())
                {
                    var userId = UserSession.Id;
                    var cartItems = context.Carts.Where(c => c.user_id == userId).ToList();

                    context.Carts.RemoveRange(cartItems);
                    context.SaveChanges();

                    MessageBox.Show("Checkout successful and cart items deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during checkout: {ex.Message}");
            }

            LoadCartItems(); // Refresh the cart items after deletion
        }
    }
}