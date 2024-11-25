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
    public partial class UserControlCheckOut : UserControl
    {
        public UserControlCheckOut()
        {
            InitializeComponent();
        }

        public string CheckOutText
        {
            get => lblNamaMakananUserControlCheckOut.Text;
            set => lblNamaMakananUserControlCheckOut.Text = value;
        }
        public int CheckoutHarga
        {
            get => int.TryParse(lblHargaOnUserControl.Text, out int harga) ? harga : 0;
            set => lblHargaOnUserControl.Text = value.ToString();
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
                                pictBoxOnCheckoutUserControl.Image = new Bitmap(fileStream);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load image. Status code: {response.StatusCode}, Reason: {response.ReasonPhrase}");
                        pictBoxOnCheckoutUserControl.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occurred while loading image: {ex.Message}");
                pictBoxOnCheckoutUserControl.Image = null;
            }
        }
    }
}