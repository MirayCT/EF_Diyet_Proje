using _02Project.BusinessLogicLayer.Concrete;
using _04Project.ViewModel.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_UI
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLoginAsUser_Click(object sender, EventArgs e)
        {
            //şifreler doğru ise if i yaz
            var authManager = new AuthManager(new UserManager());
            var loginInformation = new UserForLoginViewModel();
            loginInformation.Email = txtbUserEmail.Text;
            loginInformation.Password = txtbUserPassword.Text;
            var result = authManager.Login(loginInformation);
            MessageBox.Show(result.Message);
            if (!result.Success)
            {

                return;
            }
            Program.LoginedUserInformation = result.Data;
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
