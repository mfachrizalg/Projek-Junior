using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void lbltoSignIn_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsernameSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var user = new Pengguna();
            var response = user.Register(txtUsernameSignUp.Text, txtEmail.Text, txtPasswordSignUp.Text, comboBoxRole.SelectedItem.ToString());
            if (response == "Register sukses!")
            {
                MessageBox.Show("Register sukses!");
                Form1 Form1 = new ();
                this.Dispose();
                Form1.Show();
            }
            else
            {
                MessageBox.Show("Pengguna sudah ada!");
            }

        }
    }
}
