using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SISARASA
{
    public partial class FormProfile : Form
    {
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
                                pictureboxProfile.Image = new Bitmap(fileStream);
                            }
                        }
                    }
                    else
                    {
                        // Handle the error (e.g., set a default image or show an error message)
                        MessageBox.Show($"Failed to load image. Status code: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                        pictureboxProfile.Image = null; // or set a default image
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occurred while loading image: {ex.Message}");
                pictureboxProfile.Image = null; // or set a default image
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
