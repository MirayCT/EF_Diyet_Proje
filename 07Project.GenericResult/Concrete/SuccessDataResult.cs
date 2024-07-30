using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Project.GenericResult.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(message,true,data)
        {
            
        }
        public SuccessDataResult(T data) : base(true, data)
        {

        }
    }
}
