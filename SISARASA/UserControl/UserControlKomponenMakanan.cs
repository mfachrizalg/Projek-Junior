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
    public partial class UserControlKomponenMakanan : UserControl
    {
        public UserControlKomponenMakanan()
        {
            InitializeComponent();
        }
        public string MakananText
        {
            get => lblMakananUserControl.Text;
            set => lblMakananUserControl.Text = value;
        }
        public int MenuId { get; set; }
        private void pictBoxMakanan_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Pembeli")
            {
                FormInfoMakanan1 formInfoMakanan1 = new FormInfoMakanan1();
                formInfoMakanan1.Show();
                Visible = false;
            }
            else
            {
                FormInformasiMakananPenjual formInfoMakanan1 = new();
                formInfoMakanan1.Show();
                Visible = false;
            }
        }

        private void lblMakananUserControl_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Pembeli")
            {
                FormInfoMakanan1 formInfoMakanan1 = new FormInfoMakanan1();
                formInfoMakanan1.Show();
                Visible = false;
            }
            else
            {
                FormInformasiMakananPenjual formInfoMakanan1 = new();
                formInfoMakanan1.Show();
                Visible = false;
            }
        }
        public async void LoadImageFromUrl(string url)
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
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            var tempFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "tempImage.jpg");
                            using (var fileStream = new System.IO.FileStream(tempFilePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                            {
                                await stream.CopyToAsync(fileStream);
                            }

                            using (var fileStream = new System.IO.FileStream(tempFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                            {
                                pictBoxMakanan.Image = new Bitmap(fileStream);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load image. Status code: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                        pictBoxMakanan.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occurred while loading image: {ex.Message}");
                pictBoxMakanan.Image = null;
            }
        }
    }
}
