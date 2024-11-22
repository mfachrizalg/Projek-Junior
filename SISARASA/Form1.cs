using System.Diagnostics.Eventing.Reader;

namespace SISARASA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '●';
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "admin" && txtUsername.Text == "admin")
            {
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void picboxExitSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
