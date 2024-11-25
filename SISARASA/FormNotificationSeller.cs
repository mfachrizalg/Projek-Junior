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
    public partial class FormNotificationSeller : Form
    {
        public FormNotificationSeller()
        {
            InitializeComponent();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProfileSellerOnNotifPage_Click(object sender, EventArgs e)
        {
            FormProfileSeller formProfileSeller = new FormProfileSeller();
            formProfileSeller.Show();
            Visible = false;
        }

        private void lblDashboardSelleronNotifPage_Click(object sender, EventArgs e)
        {
            FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
            formDashboardSeller.Show();
            Visible = false;
        }

        private void lblNotifTotalonNotifPage_Click(object sender, EventArgs e)
        {

        }
    }
}
