using _05Project.DataTransferObject.Abstract;

namespace _05Project.DataTransferObject.Concrete
{
    public class UserForRegisterDto : BaseDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
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
