using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _07Project.GenericResult.Abstract;

namespace _02Project.BusinessLogicLayer.Abstract
{
    public interface IAuthManager:IManager
    {
        IDataResult<UserLoginInformationViewModel> AdminLogin(UserForLoginViewModel userForLogin);
        IDataResult<UserLoginInformationViewModel> Login(UserForLoginViewModel userForLogin);
        IDataResult<UserLoginInformationViewModel> Register(UserForRegisterViewModel userForRegister);
        IResult ChangeRole(string modifierEmail, string email, bool isAdmin);

        IResult ResetPassword(ResetPasswordViewModel resetPasswordView);
    }
}
