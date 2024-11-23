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
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void picboxExitProfile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDashboardonProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            FormConfirmPasswordAfterEdit formConfirmPasswordAfterEdit = new FormConfirmPasswordAfterEdit();
            formConfirmPasswordAfterEdit.Show();
            Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
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

                    // Load the image into a picture box or handle it as needed
                    // Example: pictureBoxProfile.Image = Image.FromFile(filePath);
                }
            }
        }
    }
}
