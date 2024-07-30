namespace WindowsForm_UI
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnForAdminLoginPage_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btnForUserLoginPage_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void btnForRegisterPage_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
