using _02Project.BusinessLogicLayer.Concrete;
using _07Project.GenericResult.Concrete;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            cbxCinsiyet.DataSource = new List<string>() { "Erkek", "Kadın" };
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var authManager = new AuthManager(new UserManager());
            var registeredUser = authManager.Register(new()
            {
                Age = (int)(numYas.Value),
                BirthDate = dateTimePicker1.Value,
                Email = txtEmail.Text,
                Gender = cbxCinsiyet.SelectedItem as string,
                GoalWeight = (int)(numHedefKilo.Value),
                Height = (int)(numBoy.Value),
                Name = txtAd.Text,
                Password = txtPassword.Text,
                Surname = txtSoyad.Text,
                Weight = (int)(numKilo.Value),
                ConfirmPassword = txtConfirmPassword.Text
            });
            MessageBox.Show(registeredUser.Message);
            if (registeredUser.Success)
            {
                Program.LoginedUserInformation = registeredUser.Data;
                if (registeredUser.Data.IsLogined)
                {
                    if (registeredUser.Data.IsAdmin)
                    {
                        Admin adminForm = new Admin();
                        adminForm.Show();
                    }
                    else
                    {
                        UserInformation userInformationForm = new UserInformation();
                        userInformationForm.Show();
                    }

                }

                this.Hide();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
