using _02Project.BusinessLogicLayer.Concrete;
using _03Project.DataAccessLayer.Context.EF;
using _04Project.ViewModel.Concrete;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualBasic.ApplicationServices;
using _02Project.BusinessLogicLayer.Abstract;

namespace WindowsForm_UI
{
    public partial class UserFoodLog : Form
    {
        private readonly EfDbContext _db;
        Food food = new Food();
        private FoodManager foodManager;
        private MealTimeManager mealTimeManager;
        private PortionSizeManager portionSizeManager;
        private UserFoodManager userFoodManager;
        UserFoodViewModel selectedUserFood;
        public UserFoodLog()
        {
            InitializeComponent();
            foodManager = new FoodManager();
            cmbUserSelectedFood.DataSource = foodManager.GetAll().Data;

            mealTimeManager = new MealTimeManager();
            cmbUserSelectedMealTime.DataSource = mealTimeManager.GetAll().Data;

            portionSizeManager = new PortionSizeManager();
            cmbUserSelectedPortionSize.DataSource = portionSizeManager.GetAll().Data;

            userFoodManager = new UserFoodManager();
            dataGridView1.DataSource = userFoodManager.GetAll().Data.ToList();
        }

        private void btnShowFoodPicture_Click(object sender, EventArgs e)
        {
            selectedUserFood = (UserFoodViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
            var food = foodManager.GetById(selectedUserFood.FoodId);
            try
            {
                using (MemoryStream ms = new MemoryStream(food.Data.Picture))
                {
                    pbFoodPics.SizeMode = PictureBoxSizeMode.Zoom;
                    pbFoodPics.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fotoğraf yok");
            }
           
            
        }

        private void btnUserAddMeal_Click(object sender, EventArgs e)
        {
            UserFoodViewModel userFood = new UserFoodViewModel();
            userFood.UserId = Program.LoginedUserInformation.Id;
            userFood.FoodId = (cmbUserSelectedFood.SelectedItem as FoodViewModel).Id;
            userFood.MealTimeId = (cmbUserSelectedMealTime.SelectedItem as MealTimeViewModel).Id;
            userFood.PortionSizeId = (cmbUserSelectedPortionSize.SelectedItem as PortionSizeViewModel).Id;
            userFood.Time = dtpUserFoodDay.Value;
            var result = userFoodManager.Add(userFood);
            dataGridView1.DataSource = userFoodManager.GetAll().Data.ToList();
            MessageBox.Show(result.Message);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserFood = (UserFoodViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
            cmbUserSelectedFood.SelectedItem = selectedUserFood.FoodId;
            cmbUserSelectedMealTime.SelectedItem = selectedUserFood.MealTimeId;
            cmbUserSelectedPortionSize.SelectedItem = selectedUserFood.PortionSizeId;
        }

        private void btnUserDeleteMeal_Click(object sender, EventArgs e)
        {
            selectedUserFood = (UserFoodViewModel)dataGridView1.SelectedRows[0].DataBoundItem;

            var result = userFoodManager.Delete(selectedUserFood);
            dataGridView1.DataSource = userFoodManager.GetAll().Data.ToList();
            MessageBox.Show(result.Message);
        }

        private void btnUserUpdateMeal_Click(object sender, EventArgs e)
        {
            UserFoodViewModel userFood = new UserFoodViewModel();
            userFood.Id = ((UserFoodViewModel)dataGridView1.SelectedRows[0].DataBoundItem).Id;
            userFood.UserId = Program.LoginedUserInformation.Id;
            userFood.FoodId = (cmbUserSelectedFood.SelectedItem as FoodViewModel).Id;
            userFood.MealTimeId = (cmbUserSelectedMealTime.SelectedItem as MealTimeViewModel).Id;
            userFood.PortionSizeId = (cmbUserSelectedPortionSize.SelectedItem as PortionSizeViewModel).Id;
            userFood.Time = dtpUserFoodDay.Value;

            var result = userFoodManager.Update(userFood);
            dataGridView1.DataSource = userFoodManager.GetAll().Data.ToList();
            MessageBox.Show(result.Message);
        }

        private void UserFoodLog_Load(object sender, EventArgs e)
        {

        }

        private void btnUserDailyReport_Click(object sender, EventArgs e)
        {
            var dailyReport =userFoodManager.GetDailyReportByUserId(Program.LoginedUserInformation.Id).Data;
            MessageBox.Show("Günlük toplam besin değerleri:\n "+"Kalori: " + dailyReport.Calorie + " cal  Karbonhidrat : " + dailyReport.Carbs + " gr  Protein: " + dailyReport.Protein + "gr  Yağ : " + dailyReport.Fats+" gr");
        }
    }
}
