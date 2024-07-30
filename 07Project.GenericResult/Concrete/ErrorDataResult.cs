namespace _07Project.GenericResult.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(message, false, data)
        {

        }
        public ErrorDataResult(T data) : base(false, data)
        {

        }
    }
}
