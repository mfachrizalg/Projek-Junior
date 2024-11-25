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
    public partial class FormProfileSeller : Form
    {
        public FormProfileSeller()
        {
            InitializeComponent();
            lblNamaPenjualOnProfilePenjual.Text = $"Halo, {UserSession.Username}!";
            txtboxUsernameOnEditProfilePenjual.Text = UserSession.Username;
            if (UserSession.Image != null)
            {
                LoadImageFromUrl(UserSession.Image);
            }
            if (UserSession.NoTelephone != null)
            {
                txtBoxNoTelephonePenjual.Text = UserSession.NoTelephone;
            }
            if (UserSession.Alamat != null)
            {
                txtboxAlamatOnEditProfilePenjual.Text = UserSession.Alamat;
            }
        }
        private async void LoadImageFromUrl(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string username = "ugm-214312";
                    string password = "yR3Qe-7AF5G-4zRxn-EzYY7-qgkGm";
                    var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var contentType = response.Content.Headers.ContentType.ToString();
                        var contentLength = response.Content.Headers.ContentLength;

                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            // Save the stream to a file for inspection
                            var tempFilePath = Path.Combine(Path.GetTempPath(), "tempImage.jpg");
                            using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                            {
                                await stream.CopyToAsync(fileStream);
                            }

                            // Reload the stream from the file
                            using (var fileStream = new FileStream(tempFilePath, FileMode.Open, FileAccess.Read))
                            {
                                pictBoxProfileSeller.Image = new Bitmap(fileStream);
                            }
                        }
                    }
                    else
                    {
                        // Handle the error (e.g., set a default image or show an error message)
                        MessageBox.Show($"Failed to load image. Status code: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                        pictBoxProfileSeller.Image = null; // or set a default image
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occurred while loading image: {ex.Message}");
                pictBoxProfileSeller.Image = null; // or set a default image
            }
        }
        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNotifSelleronProfilePage_Click(object sender, EventArgs e)
        {
            FormNotificationSeller formNotificationSeller = new FormNotificationSeller();
            formNotificationSeller.Show();
            Visible = false;
        }

        private void lblDashboardSelleronProfilePage_Click(object sender, EventArgs e)
        {
            FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
            formDashboardSeller.Show();
            Visible = false;
        }

        private void lblNotifTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfilePenjual_Click(object sender, EventArgs e)
        {
            FormEditProfilePenjual formEditProfile = new FormEditProfilePenjual();
            formEditProfile.Show();
            Visible = false;
        }

        private void btnChangePasswordPenjual_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.Show();
            Visible = false;
        }

        private void lblNamaPenjualOnProfilePenjual_Click(object sender, EventArgs e)
        {

        }
    }
}
