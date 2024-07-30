using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06Project.Entities.Common;

namespace _06Project.Entities.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
