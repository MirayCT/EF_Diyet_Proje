using _04Project.ViewModel.Abstract;

namespace _04Project.ViewModel.Concrete
{
    public class ResetPasswordViewModel : IViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
