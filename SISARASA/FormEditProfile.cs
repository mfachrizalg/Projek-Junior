using SISARASA.Class;
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
    public partial class FormEditProfile : Form
    {
        private string uploadedImageUrl;
        public FormEditProfile()
        {
            InitializeComponent();
            lblUsernameOnProfile.Text = UserSession.Username;
        }

        private void picboxExitProfile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDashboardonProfile_Click(object sender, EventArgs e)
        {

        }

        private async void btnDone_Click(object sender, EventArgs e)
        {
            // Show the password confirmation form
            FormConfirmPasswordAfterEdit confirmPasswordForm = new FormConfirmPasswordAfterEdit();
            if (confirmPasswordForm.ShowDialog() == DialogResult.OK)
            {
                using (var context = new AppDbContext())
                {
                    var user = context.Users.SingleOrDefault(u => u.id == UserSession.Id);
                    if (user != null)
                    {
                        if (!string.IsNullOrEmpty(txtboxUsername.Text))
                        {
                            user.username = txtboxUsername.Text;
                        }
                        if (!string.IsNullOrEmpty(txtboxAlamat.Text))
                        {
                            user.alamat = txtboxAlamat.Text;
                        }
                        if (!string.IsNullOrEmpty(txtBoxNoTelephoneEditProfile.Text))
                        {
                            user.telephone = txtBoxNoTelephoneEditProfile.Text;
                        }
                        if (!string.IsNullOrEmpty(uploadedImageUrl))
                        {
                            user.image = uploadedImageUrl;
                        }
                        context.SaveChanges();

                        // Update UserSession
                        UserSession.Username = user.username;
                        UserSession.Alamat = user.alamat;
                        UserSession.NoTelephone = user.telephone;
                        UserSession.Image = user.image;

                        MessageBox.Show("Update Profil Berhasil!");

                        // Navigate back to the profile form
                        FormProfile formProfile = new FormProfile();
                        formProfile.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Password anda salah!");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private async void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Upload the image to WebDAV
                    uploadedImageUrl = await UploadImageToWebDAV(filePath);

                    if (!string.IsNullOrEmpty(uploadedImageUrl))
                    {
                        // Load the image into a picture box or handle it as needed
                        pictureboxProfileonEditProfile.Image = Image.FromFile(filePath);
                        MessageBox.Show("Image uploaded successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to upload image.");
                    }
                }
            }
        }

        private async Task<string> UploadImageToWebDAV(string filePath)
        {
            string webDavUrl = "https://diska.ugm.ac.id/remote.php/dav/files/ugm-214312";
            string username = "ugm-214312";
            string password = "yR3Qe-7AF5G-4zRxn-EzYY7-qgkGm";

            using (var client = new HttpClient())
            {
                var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                using (var fileStream = System.IO.File.OpenRead(filePath))
                {
                    var content = new StreamContent(fileStream);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    try
                    {
                        var response = await client.PutAsync(webDavUrl + "/" + System.IO.Path.GetFileName(filePath), content);
                        if (response.IsSuccessStatusCode)
                        {
                            return $"{webDavUrl}/{System.IO.Path.GetFileName(filePath)}";
                        }
                        else
                        {
                            MessageBox.Show($"Failed to upload image. Status code: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Exception occurred while uploading image: {ex.Message}");
                    }
                }
            }
            return null;
        }
    }
}
