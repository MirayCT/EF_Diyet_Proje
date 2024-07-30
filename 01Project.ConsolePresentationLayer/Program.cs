using _02Project.BusinessLogicLayer.Concrete;

namespace _01Project.ConsolePresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new UserManager();
            var y = x.GetAll().Data.ToList();
            Console.WriteLine();
        }
    }
}
