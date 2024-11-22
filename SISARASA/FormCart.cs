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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void lblDashboardonCart_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            Visible = false;
        }

        private void lblProfileonCart_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void picboxExitCart_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut formCheckOut = new FormCheckOut();
            formCheckOut.Show();
            Visible = false;
        }
    }
}
