using _04Project.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class UserLoginInformationViewModel:IViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsLogined { get; set; }
        public bool IsAdmin { get; set; }
    }
}
