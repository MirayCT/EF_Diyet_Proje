namespace _07Project.GenericResult.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(message, false)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
