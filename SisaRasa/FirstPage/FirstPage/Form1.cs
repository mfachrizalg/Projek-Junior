namespace FirstPage
{
    public partial class LoginForm : Form
    {
        private string validUsername = "admin";
        private string validPassword = "1234";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Mengambil nilai input dari textbox
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // Cek kecocokan dengan username dan password valid
            if ((username == validUsername && password == validPassword) ||
                (username == RegisterForm.RegisteredUsername && password == RegisterForm.RegisteredPassword))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            // Membuat instance dari RegisterForm
            RegisterForm registerForm = new RegisterForm();

            // Menampilkan register form dan menyembunyikan login form saat ini
            this.Hide(); // Menyembunyikan login form
            registerForm.ShowDialog(); // Menampilkan register form sebagai modal dialog

            // Menampilkan login form kembali setelah register form ditutup
            this.Show(); // Menampilkan login form lagi setelah register form ditutup
        }
    }
}
