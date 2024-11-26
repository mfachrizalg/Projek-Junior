﻿using SISARASA.Class;
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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void picboxExitProfile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtboxChangePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoneChangePassword_Click(object sender, EventArgs e)
        {

            string oldPassword = txtboxOldPassword.Text;
            string newPassword = txtboxChangePassword.Text;
            string confirmNewPassword = txtBoxConfirmNewPassword.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Password tidak sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.id == UserSession.Id);
                if (user != null && user.password == oldPassword)
                {
                    user.password = newPassword;
                    context.SaveChanges();

                    // Update UserSession
                    UserSession.Password = newPassword;

                    MessageBox.Show("Password has been successfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormProfile formProfile = new FormProfile();
                    formProfile.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelChangePassword_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }
    }
}
