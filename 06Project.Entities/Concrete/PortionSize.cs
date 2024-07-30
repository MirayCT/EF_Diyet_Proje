using _06Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Project.Entities.Concrete
{
    public class PortionSize : BaseEntity
    {
        public int PortionInGrams { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
    }
}
