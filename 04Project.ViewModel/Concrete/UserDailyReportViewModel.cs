using _04Project.ViewModel.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class UserDailyReportViewModel:IViewModel
    {
        public int Calorie { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
        public int Protein { get; set; }
    }
}
