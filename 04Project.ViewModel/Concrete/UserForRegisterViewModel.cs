using _04Project.ViewModel.Abstract;

namespace _04Project.ViewModel.Concrete
{
    public class UserForRegisterViewModel : IViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int GoalWeight { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
