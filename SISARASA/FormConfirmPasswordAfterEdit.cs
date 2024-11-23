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
            // Logika validasi password

            // Jika validasi sukses
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            // Tutup FormEditProfile
            this.Close(); // Tutup FormConfirmPasswordAfterEdit
        }
    }
}
