using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Project.GenericResult.Abstract
{
    public interface IResult
    {
        public string Message { get; }
        public bool Success { get;  }
    }
}
