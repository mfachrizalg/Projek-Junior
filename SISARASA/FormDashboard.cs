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
            // Wire up the Click event
            userControlKomponenMakanan1.Click += new EventHandler(userControlKomponenMakanan1_Click);
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
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
