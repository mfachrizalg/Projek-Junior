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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            lblUsernameDashboard.Text = $"Hi, {UserSession.Username}";
            if (UserSession.Alamat != null)
            {
                lblAlamatOnDashboard.Text = UserSession.Alamat;
            }
            else
            {
                lblAlamatOnDashboard.Text = "Alamat belum diatur";
            }
            // Wire up the Click event
            userControlKomponenMakanan1.Click += new EventHandler(userControlKomponenMakanan1_Click);
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            string nama = lblUsernameDashboard.Text
                .Substring(4, lblUsernameDashboard.Text.Length - 4);
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void picboxExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void userControlKomponenMakanan1_Click(object sender, EventArgs e)
        {
            FormInfoMakanan1 formInfoMakanan1 = new FormInfoMakanan1();
            formInfoMakanan1.Show();
            Visible = false;
            this.Hide();
        }
    }
}
