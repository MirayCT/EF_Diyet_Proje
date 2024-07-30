using _02Project.BusinessLogicLayer.Abstract;
using _02Project.BusinessLogicLayer.Concrete;
using _04Project.ViewModel.Concrete;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsForm_UI
{
    public partial class Admin : Form
    {
        IFoodManager _foodManager;
        IPortionSizeManager _portionSizeManager;
        IMealTimeManager _mealTimeManager;
        DateTime _createdtime;
        DateTime _updatedtime;
        DateTime _deletedtime;

        byte[] _image;
        public Admin()
        {
            AdminCheck();
            InitializeComponent();
            _foodManager = new FoodManager();
            _portionSizeManager = new PortionSizeManager();
            _mealTimeManager = new MealTimeManager();
            cmbAdminFood.DataSource = _foodManager.GetAll().Data.ToList();
            cmbAdminMealTime.DataSource = _mealTimeManager.GetAll().Data.ToList();
            cmbAdminPortionSize.DataSource = _portionSizeManager.GetAll().Data.ToList();
        }

        private void btnAdminWeeklyReport_Click(object sender, EventArgs e)
        {
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.Show();
        }

        private void btnAdminMonthlyReport_Click(object sender, EventArgs e)
        {
            MonthlyReport monthlyReport = new MonthlyReport();
            monthlyReport.Show();
        }

        private void btnAdminTopFoods_Click(object sender, EventArgs e)
        {
            TopFoods topFoods = new TopFoods();
            topFoods.Show();
        }


        //Food


        private void btnAdminFoodAdd_Click(object sender, EventArgs e)
        {
            if (_image is null)
            {
                MessageBox.Show("Resim yüklenirken bir hata oluştu.Lütfen tekrar deneyiniz.");
                return;
            }
            var result = _foodManager.Add(new()
            {
                Calorie = Convert.ToInt32(txtCalorie.Text),
                Carbs = Convert.ToInt32(txtCarbs.Text),
                Description = txtDescription.Text,
                Fats = Convert.ToInt32(txtFats.Text),
                Name = txtbNewFood.Text,
                Picture = _image,
                Protein = Convert.ToInt32(txtProtein.Text)

            });
            MessageBox.Show(result.Message);
            cmbAdminFood.DataSource = _foodManager.GetAll().Data.ToList();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] imageData = File.ReadAllBytes(filePath);

                    _image = imageData;
                }
            }

        }

        private void btnAdminFoodUpdate_Click(object sender, EventArgs e)
        {
            var food = new FoodViewModel()
            {
                Id = ((FoodViewModel)(cmbAdminFood.SelectedValue)).Id,
                Calorie = Convert.ToInt32(txtCalorie.Text),
                Carbs = Convert.ToInt32(txtCarbs.Text),
                Description = txtDescription.Text,
                Fats = Convert.ToInt32(txtFats.Text),
                Name = txtbNewFood.Text,
                Picture = _image,
                Protein = Convert.ToInt32(txtProtein.Text)
            };
            var result = _foodManager.Update(food);
            MessageBox.Show(result.Message);
            cmbAdminFood.DataSource = _foodManager.GetAll().Data.ToList();
        }

        private void cmbAdminFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Focused)
            {
                var selectedFood = cmbAdminFood.SelectedValue as FoodViewModel;
                txtbNewFood.Text = selectedFood.Name;
                txtCarbs.Text = selectedFood.Carbs.ToString();
                txtCalorie.Text = selectedFood.Calorie.ToString();
                txtDescription.Text = selectedFood.Description;
                txtFats.Text = selectedFood.Fats.ToString();
                txtProtein.Text = selectedFood.Protein.ToString();
                _image = selectedFood.Picture;

            }
        }

        private void btnAdminFoodDelete_Click(object sender, EventArgs e)
        {
            var selectedFood = cmbAdminFood.SelectedValue as FoodViewModel;
            var result = _foodManager.Remove(selectedFood);
            MessageBox.Show(result.Message);
            cmbAdminFood.DataSource = _foodManager.GetAll().Data.ToList();
        }


        //Meal Time


        private void btnAdmindMealTimeAdd_Click(object sender, EventArgs e)
        {
            var result = _mealTimeManager.Add(new()
            {
                MealName = txtbNewMealTime.Text
            });

            MessageBox.Show(result.Message);

            cmbAdminMealTime.DataSource = _mealTimeManager.GetAll().Data.ToList();
        }
        private void cmbAdminMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Focused)
            {
                var selectedMeal = cmbAdminMealTime.SelectedValue as MealTimeViewModel;
                txtbNewMealTime.Text = selectedMeal.MealName;
            }

        }
        private void btnAdminMealTimeUpdate_Click(object sender, EventArgs e)
        {
            var result = _mealTimeManager.Update(new()
            {
                Id = ((MealTimeViewModel)(cmbAdminMealTime.SelectedValue)).Id,
                MealName = txtbNewMealTime.Text
            });
            MessageBox.Show(result.Message);

            cmbAdminMealTime.DataSource = _mealTimeManager.GetAll().Data.ToList();

        }

        private void btnAdminMealTimeDelete_Click(object sender, EventArgs e)
        {
            var selectedMeal = cmbAdminMealTime.SelectedValue as MealTimeViewModel;
            var result = _mealTimeManager.Remove(selectedMeal);
            MessageBox.Show(result.Message);

            cmbAdminMealTime.DataSource = _mealTimeManager.GetAll().Data.ToList();
        }

        //Portion Size

        private void btnAdminPortionSizeAdd_Click(object sender, EventArgs e)
        {
            var result = _portionSizeManager.Add(new()
            {
                PortionInGrams = Convert.ToInt32(txtbNewPortionSize.Text)
            });

            MessageBox.Show(result.Message);

            cmbAdminPortionSize.DataSource = _portionSizeManager.GetAll().Data.ToList();
        }
        private void cmbAdminPortionSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Focused)
            {
                var selectedPortion = cmbAdminPortionSize.SelectedValue as PortionSizeViewModel;
                txtbNewPortionSize.Text = selectedPortion.PortionInGrams.ToString();
            }
        }

        private void btnAdminPortionSizeUpdate_Click(object sender, EventArgs e)
        {
            var result = _portionSizeManager.Update(new()
            {
                Id = ((PortionSizeViewModel)(cmbAdminPortionSize.SelectedValue)).Id,
                PortionInGrams = Convert.ToInt32(txtbNewPortionSize.Text)
            });
            MessageBox.Show(result.Message);

            cmbAdminPortionSize.DataSource = _portionSizeManager.GetAll().Data.ToList();
        }

        private void btnAdminPortionSizeDelete_Click(object sender, EventArgs e)
        {
            var selectedPortion = cmbAdminPortionSize.SelectedValue as PortionSizeViewModel;
            var result = _portionSizeManager.Remove(selectedPortion);
            MessageBox.Show(result.Message);

            cmbAdminPortionSize.DataSource = _portionSizeManager.GetAll().Data.ToList();
        }


        private void AdminCheck()
        {
            if (Program.LoginedUserInformation is null || !Program.LoginedUserInformation.IsAdmin)
            {
                MessageBox.Show("Yetkiniz Yok!");
                new AdminLogin().Show();
                this.Hide();

                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
