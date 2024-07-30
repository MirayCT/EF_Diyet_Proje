using _04Project.ViewModel.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class PortionSizeViewModel:IViewModel
    {
        public int Id { get; set; }
        public int PortionInGrams { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
        public override string ToString()
        {
            return PortionInGrams.ToString();
        }
    }
}
