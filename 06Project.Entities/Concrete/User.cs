using _06Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Project.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int GoalWeight { get; set; }
        public string Gender { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
    }
}
