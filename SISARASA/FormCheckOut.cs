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
    public partial class FormCheckOut : Form
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void picboxExitCartCheckOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxDelivery_Click(object sender, EventArgs e)
        {
            if (checkBoxDelivery.Checked)
            {
                checkBoxPickUp.Checked = false;
            }
        }

        private void checkBoxPickUp_Click(object sender, EventArgs e)
        {
            if (checkBoxPickUp.Checked)
            {
                checkBoxDelivery.Checked = false;
            }
        }

        private void btnCancelOnCheckOut_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
        }
    }
}
