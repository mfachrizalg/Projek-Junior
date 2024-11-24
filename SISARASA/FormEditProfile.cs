using SISARASA.Class;
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
            lblUsernameOnProfile.Text = UserSession.Username;
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
                        context.SaveChanges();

                        // Update UserSession
                        UserSession.Username = user.username;
                        UserSession.Alamat = user.alamat;
                        UserSession.NoTelephone = user.telephone;

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
