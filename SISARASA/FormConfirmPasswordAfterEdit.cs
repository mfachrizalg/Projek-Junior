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
    public partial class FormConfirmPasswordAfterEdit : Form
    {
        public FormConfirmPasswordAfterEdit()
        {
            InitializeComponent();
        }

        private void picboxExitProfile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoneOnConfirmPassword_Click(object sender, EventArgs e)
        {
            // Validate the entered password
            if (txtboxConfirmPasswordEditProfile.Text == UserSession.Password)
            {
                // If validation is successful, close the form with DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // If validation fails, show an error message
                MessageBox.Show("Password tidak sesuai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
