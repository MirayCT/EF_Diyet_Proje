using _04Project.ViewModel.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class UserViewModel: IViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int GoalWeight { get; set; }
        public string Gender { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname + "  " + Email;
        }
    }    
}
