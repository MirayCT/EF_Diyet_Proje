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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLoginAsUser_Click(object sender, EventArgs e)
        { //şifreler doğru ise if i yaz
            var authManager = new AuthManager(new UserManager());
            var loginInformation = new UserForLoginViewModel();
            loginInformation.Email = txtbUserEmail.Text;
            loginInformation.Password = txtbUserPassword.Text;
            var result = authManager.AdminLogin(loginInformation);
            MessageBox.Show(result.Message);            
            if (result.Success && result.Data.IsAdmin && result.Data.IsLogined)
            {
                Program.LoginedUserInformation = result.Data;
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }           
            
        }
    }
}
