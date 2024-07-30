using _05Project.DataTransferObject.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Project.DataTransferObject.Concrete
{
    public class MealTimeDto : BaseDto
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
    }
}
