using SISARASA.Class;
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
            using (var context = new AppDbContext())
            {  
                var user = context.Users.SingleOrDefault(u => u.username == txtUsername.Text && u.password == txtPass.Text);

                if (user != null)
                {
                    UserSession.Id = user.id;
                    UserSession.Password = user.password;
                    UserSession.Username = user.username;
                    UserSession.Email = user.email;
                    UserSession.Role = user.role;
                    UserSession.Alamat = user.alamat ?? null;
                    UserSession.Image = user.image ?? null;
                    UserSession.NoTelephone = user.telephone ?? null;
                    if (UserSession.Role == "Pembeli")
                    {
                        FormDashboard formPembeli = new();
                        formPembeli.Show();
                        Visible = false;
                    }
                    else if (UserSession.Role == "Penjual")
                    {
                        SellerDashboard formPenjual = new();
                        formPenjual.Show();
                        Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
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
