using _04Project.ViewModel.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class UserFoodViewModel : IViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FoodId { get; set; }
        public int PortionSizeId { get; set; }
        public int MealTimeId { get; set; }
        public DateTime Time { get; set; }
        public virtual MealTime MealTime { get; set; }
        public virtual User User { get; set; }
        public virtual Food Food { get; set; }
        public virtual PortionSize PortionSize { get; set; }
        public override string ToString()
        {
            return User.Name + " " + User.Surname +MealTime.MealName + " " +Food.Name + " " +PortionSize.PortionInGrams;
        }
    }
}
