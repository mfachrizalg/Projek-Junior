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
            MessageBox.Show("Password has been successfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void btnCancelChangePassword_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }
    }
}
