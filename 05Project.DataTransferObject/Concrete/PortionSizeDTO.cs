using _05Project.DataTransferObject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Project.DataTransferObject.Concrete
{
    public class PortionSizeDto : BaseDto
    {
        public int Id { get; set; }
        public int PortionInGrams { get; set; }
    }
}
