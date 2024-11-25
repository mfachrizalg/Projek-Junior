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
    public partial class FormDashboardSeller : Form
    {
        public FormDashboardSeller()
        {
            InitializeComponent();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProfileSeller_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            Visible = false;
        }

        private void lblNotifSeller_Click(object sender, EventArgs e)
        {
            FormNotificationSeller formNotificationSeller = new FormNotificationSeller();
            formNotificationSeller.Show();
            Visible = false;
        }

        private void lblNotifTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMakanan_Click(object sender, EventArgs e)
        {
            FormAddMakanan formAddMakanan = new FormAddMakanan();
            formAddMakanan.Show();
            Visible = false;
        }

        private void btnEditMakanan_Click(object sender, EventArgs e)
        {
            FormInformasiMakananPenjual formInformasiMakananPenjual = new FormInformasiMakananPenjual();
            formInformasiMakananPenjual.Show();
            Visible = false;
        }
    }
}
