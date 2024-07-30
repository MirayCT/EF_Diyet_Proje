using _07Project.GenericResult.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Project.GenericResult.Concrete
{
    public class Result : IResult
    {
        private string _message;
        private bool _success;
        public Result(string message, bool success)
        {
            _message = message;
            _success = success;
        }
        public Result(bool success)
        {
            _success = success;
        }
        public string Message
        {
            get
            {
                return _message;
            }
        }

        public bool Success
        {
            get
            {
                return _success;
            }
        }
    }
}
