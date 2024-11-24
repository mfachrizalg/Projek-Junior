using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISARASA
{
    public partial class FormProfile : Form
    {
        private async void LoadImageFromUrl(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        pictureboxProfile.Image = new Bitmap(stream);
                    }
                }
                else
                {
                    // Handle the error (e.g., set a default image or show an error message)
                    pictureboxProfile.Image = null; // or set a default image
                }
            }
        }
        public FormProfile()
        {
            InitializeComponent();
            lblUsernameOnProfile.Text = UserSession.Username;
            txtboxUsernameOnEditProfile.Text = UserSession.Username;
            if (UserSession.Alamat != null)
            {
                txtboxAlamatOnEditProfile.Text = UserSession.Alamat;
            }
            if (UserSession.NoTelephone != null)
            {
                txtBoxNoTelephone.Text = UserSession.NoTelephone;
            }

            if (!string.IsNullOrEmpty(UserSession.Image))
            {
                LoadImageFromUrl(UserSession.Image);
            }
        }

        private void lblProfileonProfile_Click(object sender, EventArgs e)
        {

        }

        private void picboxExitProfile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCartonProfile_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
        }

        private void lblDashboardonProfile_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            Visible = false;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.Show();
            Visible = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.Show();
            Visible = false;
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAlamat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
