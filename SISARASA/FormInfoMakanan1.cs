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
    public partial class FormInfoMakanan1 : Form
    {
        public FormInfoMakanan1()
        {
            InitializeComponent();
        }

        private void picboxExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
            this.Dispose();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            Visible = false;
            this.Dispose();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
            this.Dispose();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
            this.Dispose();
        }
    }
}
