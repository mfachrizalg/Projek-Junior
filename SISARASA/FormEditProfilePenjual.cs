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
    public partial class FormEditProfilePenjual : Form
    {
        public FormEditProfilePenjual()
        {
            InitializeComponent();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUploadImageOnEditProfilPenjual_Click(object sender, EventArgs e)
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

        private void btnCancelOnEditProfilPenjual_Click(object sender, EventArgs e)
        {
            FormProfileSeller formProfileSeller = new FormProfileSeller();
            formProfileSeller.Show();
            Visible = false;
        }

        private void btnDoneOnEditProfilPenjual_Click(object sender, EventArgs e)
        {
            FormConfirmPasswordAfterEdit formConfirmPasswordAfterEdit = new FormConfirmPasswordAfterEdit();
            formConfirmPasswordAfterEdit.Show();
            Visible = false;
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
