namespace FirstPage
{
    public partial class LoginForm : Form
    {
        private string validUsername = "admin";
        private string validPassword = "1234";
        private GunaComboBox gunaComboBox;

        public LoginForm()
        {
            InitializeComponent();
            InitializeGunaComboBox();
        }

        private void InitializeGunaComboBox()
        {
            gunaComboBox = new GunaComboBox();
            gunaComboBox.Items.AddRange(new object[] {
                    "Penjual",
                    "Pembeli"});
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

            if (gunaComboBox.SelectedItem != null)
            {
                string selectedRole = gunaComboBox.SelectedItem.ToString();

                // Cek kecocokan dengan username dan password valid
                if ((username == validUsername && password == validPassword) ||
                    (username == RegisterForm.RegisteredUsername && password == RegisterForm.RegisteredPassword))
                {
                    if (selectedRole == "Pembeli")
                    {
                        new FormHomePage().Show();
                    }
                    else if (selectedRole == "Penjual")
                    {
                        new FormHomePenjual().Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    internal class GunaComboBox
    {
        public List<object> Items { get; internal set; } = new List<object>();
        public object SelectedItem { get; internal set; }
    }
}
