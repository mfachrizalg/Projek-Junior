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
    public partial class SellerDashboard : Form
    {
        public SellerDashboard()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Home page!");
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_Notif_Click(object sender, EventArgs e)
        {
            // Membuka FormNotif
            FormNotif notifForm = new FormNotif();
            notifForm.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {

        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Membuka FormAddFood
            FormAddFood addFoodForm = new FormAddFood();
            addFoodForm.Show();
        }

        private void picboxExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
