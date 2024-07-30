using _06Project.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Project.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
