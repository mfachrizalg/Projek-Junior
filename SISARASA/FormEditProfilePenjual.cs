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
    public partial class FormEditProfilePenjual : Form
    {
        private string uploadedImageUrl;
        public FormEditProfilePenjual()
        {
            InitializeComponent();
            lblUsernameOnProfilePenjual.Text = UserSession.Username;
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnUploadImageOnEditProfilPenjual_Click(object sender, EventArgs e)
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
                        pictureboxProfileonEditProfilePenjual.Image = Image.FromFile(filePath);
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

        private void btnCancelOnEditProfilPenjual_Click(object sender, EventArgs e)
        {
            FormProfileSeller formProfileSeller = new FormProfileSeller();
            formProfileSeller.Show();
            Visible = false;
        }

        private void btnDoneOnEditProfilPenjual_Click(object sender, EventArgs e)
        {
            FormConfirmPasswordAfterEdit confirmPasswordForm = new FormConfirmPasswordAfterEdit();
            if (confirmPasswordForm.ShowDialog() == DialogResult.OK)
            {
                using (var context = new AppDbContext())
                {
                    var user = context.Users.SingleOrDefault(u => u.id == UserSession.Id);
                    if (user != null)
                    {
                        if (!string.IsNullOrEmpty(txtboxUsernameOnEditProfilPenjual.Text))
                        {
                            user.username = txtboxUsernameOnEditProfilPenjual.Text;
                        }
                        if (!string.IsNullOrEmpty(txtboxAlamatOnEditProfilPenjual.Text))
                        {
                            user.alamat = txtboxAlamatOnEditProfilPenjual.Text;
                        }
                        if (!string.IsNullOrEmpty(txtBoxNoTelephoneEditProfilePenjual.Text))
                        {
                            user.telephone = txtBoxNoTelephoneEditProfilePenjual.Text;
                        }
                        if (!string.IsNullOrEmpty(txtBoxNamaTokoOnEditProfileSeller.Text))
                        {
                            user.toko = txtBoxNamaTokoOnEditProfileSeller.Text;
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
                        UserSession.Toko = user.toko;

                        MessageBox.Show("Update Profil Berhasil!");

                        // Navigate back to the profile form
                        FormProfileSeller formProfileSeller = new FormProfileSeller();
                        formProfileSeller.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Password anda salah!");
                    }
                }
            }
        }

        private void txtBoxNamaTokoOnEditProfileSeller_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxUsernameOnEditProfilPenjual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAlamatOnEditProfilPenjual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNoTelephoneEditProfilePenjual_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsernameOnProfilePenjual_Click(object sender, EventArgs e)
        {

        }
    }
}

