using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISARASA
{
    public partial class FormAddFood : Form
    {
        public FormAddFood()
        {
            InitializeComponent();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|.jpg;.jpeg;.png;.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Load the image into a picture box or handle it as needed
                    // Example: pictureBoxProfile.Image = Image.FromFile(filePath);
                }
            }
        }

        private void tb_FoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Deskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Kirim_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            // Membuka form SellerDashboard
            SellerDashboard dashboardForm = new SellerDashboard();
            dashboardForm.Show();

            // Menutup form saat ini jika diperlukan
            this.Close();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_Notif_Click(object sender, EventArgs e)
        {
            // Membuka FormNotif
            FormNotif notifForm = new FormNotif();
            notifForm.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {

        }
    }
}
