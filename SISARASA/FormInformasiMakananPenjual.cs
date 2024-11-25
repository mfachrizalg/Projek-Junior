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
    public partial class FormInformasiMakananPenjual : Form
    {
        public FormInformasiMakananPenjual()
        {
            InitializeComponent();
        }

        private void picboxExitDashboardSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProfileSelleronInformasiMakanan_Click(object sender, EventArgs e)
        {
            FormProfileSeller formProfileSeller = new FormProfileSeller();
            formProfileSeller.Show();
            Visible = false;
        }

        private void lblNotifSellerOnInformasiMakanan_Click(object sender, EventArgs e)
        {
            FormNotificationSeller formNotificationSeller = new FormNotificationSeller();
            formNotificationSeller.Show();
            Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
            formDashboardSeller.Show();
            Visible = false;
        }

        private void btnDoneOnEditMakanan_Click(object sender, EventArgs e)
        {
            // Logika untuk mengedit informasi makanan

            // Tampilkan pesan konfirmasi
            MessageBox.Show("Makanan telah berhasil diedit.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kembali ke FormDashboardSeller
            FormDashboardSeller formDashboardSeller = new FormDashboardSeller();
            formDashboardSeller.Show();
            this.Close();
        }
    }
}
