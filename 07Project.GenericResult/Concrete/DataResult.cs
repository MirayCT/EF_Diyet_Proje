using _07Project.GenericResult.Abstract;

namespace _07Project.GenericResult.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        private string _message;
        private bool _success;
        private T _data;
        public DataResult(string message, bool success, T data)
        {
            _message = message;
            _success = success;
            _data = data;
        }
        public DataResult(bool success, T data)
        {
            _success = success;
            _data = data;
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

        public T Data
        {
            get
            {
                return _data;
            }
        }
    }
}
