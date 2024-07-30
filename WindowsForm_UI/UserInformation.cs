using _02Project.BusinessLogicLayer.Abstract;
using _02Project.BusinessLogicLayer.Concrete;
using _04Project.ViewModel.Concrete;
using _06Project.Entities.Concrete;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = _06Project.Entities.Concrete.User;

namespace WindowsForm_UI
{
    public partial class UserInformation : Form
    {
        private IUserManager _userManager;
        public UserInformation()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private void btnUserStartLoginFood_Click(object sender, EventArgs e)
        {
            UserFoodLog userFoodLog = new UserFoodLog();
            userFoodLog.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userViewModel = Program.LoginedUserInformation;
            var userDetail = _userManager.GetById(userViewModel.Id);
            if (!userDetail.Success)
            {
                MessageBox.Show(userDetail.Message);
            }
            userDetail.Data.Age = Convert.ToInt32(txtbUserAge.Text);
            userDetail.Data.Height = Convert.ToInt32(txtbUserHeight.Text);
            userDetail.Data.Weight = Convert.ToInt32(txtbUserWeight.Text);
            userDetail.Data.GoalWeight = Convert.ToInt32(txtbUserGoalWeight.Text);
            var updatedUser = _userManager.Update(userDetail.Data);
            MessageBox.Show(updatedUser.Message);
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            var userViewModel = Program.LoginedUserInformation;
               var userDetail = _userManager.GetById(userViewModel.Id);
            if (userDetail.Success)
            {
                txtbUserAge.Text = userDetail.Data.Age.ToString();
                txtbUserHeight.Text = userDetail.Data.Height.ToString();
                txtbUserWeight.Text = userDetail.Data.Weight.ToString();
                txtbUserGoalWeight.Text = userDetail.Data.GoalWeight.ToString();
            }
            
        }
    }
}
