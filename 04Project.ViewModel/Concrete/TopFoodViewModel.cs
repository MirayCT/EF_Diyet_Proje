using _04Project.ViewModel.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class TopFoodViewModel:IViewModel
    {
        public string Name { get; set; }
        public int TotalCount { get; set; }
    }
}
