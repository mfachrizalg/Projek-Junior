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
    public partial class FormProfileSeller : Form
    {
        public FormProfileSeller()
        {
            InitializeComponent();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNotifSelleronProfilePage_Click(object sender, EventArgs e)
        {
            FormNotificationSeller formNotificationSeller = new FormNotificationSeller();
            formNotificationSeller.Show();
            Visible = false;
        }

        private void lblDashboardSelleronProfilePage_Click(object sender, EventArgs e)
        {
            FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
            formDashboardSeller.Show();
            Visible = false;
        }

        private void lblNotifTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfilePenjual_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePasswordPenjual_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaPenjualOnProfilePenjual_Click(object sender, EventArgs e)
        {

        }
    }
}
