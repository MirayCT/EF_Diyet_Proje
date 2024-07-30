using _05Project.DataTransferObject.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Project.DataTransferObject.Concrete
{
    public class UserFoodDto : BaseDto
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
    }
}
