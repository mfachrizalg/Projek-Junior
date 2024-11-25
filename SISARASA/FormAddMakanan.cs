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
    public partial class FormAddMakanan : Form
    {
        private string uploadedImageUrl;
        public FormAddMakanan()
        {
            InitializeComponent();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnUploadImageAddMakanan_Click(object sender, EventArgs e)
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
                        pictureBoxMakananAddMakanan.Image = Image.FromFile(filePath);
                        MessageBox.Show("Image uploaded successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to upload image.");
                    }
                }
            }

        }

        private void btnDoneAddMakanan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNamaMakanan.Text) ||
               string.IsNullOrWhiteSpace(txtBoxDeskripsiMakanan.Text) ||
               string.IsNullOrWhiteSpace(txtBoxHargaMakanan.Text) ||
               string.IsNullOrEmpty(uploadedImageUrl))
            {
                MessageBox.Show("Please fill in all fields and upload an image.");
                return;
            }

            if (!int.TryParse(txtBoxHargaMakanan.Text, out int harga))
            {
                MessageBox.Show("Please enter valid numeric values for Harga, Kuantitas, and User ID.");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var newMenu = new Menu
                    {
                        nama = txtBoxNamaMakanan.Text,
                        deskripsi = txtBoxDeskripsiMakanan.Text,
                        harga = harga,
                        gambar = uploadedImageUrl,
                        user_id = UserSession.Id
                    };

                    context.Menus.Add(newMenu);
                    context.SaveChanges();
                }

                MessageBox.Show("Menu item added successfully!");
                FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
                formDashboardSeller.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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
                            var uploadedUrl = $"{webDavUrl}/{System.IO.Path.GetFileName(filePath)}";
                            MessageBox.Show($"Image uploaded successfully. URL: {uploadedUrl}");
                            return uploadedUrl;
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

        private void btnCancelOnAddMakanan_Click(object sender, EventArgs e)
        {
            FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
            formDashboardSeller.Show();
            Visible = false;
        }
    }

}
