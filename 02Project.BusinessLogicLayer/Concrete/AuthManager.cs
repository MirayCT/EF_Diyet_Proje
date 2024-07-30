using _02Project.BusinessLogicLayer.Abstract;
using _02Project.BusinessLogicLayer.Constants;
using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _07Project.GenericResult.Abstract;
using _07Project.GenericResult.Concrete;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Concrete
{
    public class AuthManager : IAuthManager
    {
        IUserManager _userManager;
        IMapper _mapper;
        public AuthManager(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public IDataResult<UserLoginInformationViewModel> AdminLogin(UserForLoginViewModel userForLogin)
        {
            var checkedPassword = CheckEmailAndPassword(userForLogin.Email, userForLogin.Password);
            if (!checkedPassword)
            {
                return new ErrorDataResult<UserLoginInformationViewModel>(null, Messages.MailPasswordInvalid);
            }
            var user = _userManager.GetDetailByEmail(userForLogin.Email, "bmFtZSI6Ikpva,");
            if (!user.Success)
            {
                return new ErrorDataResult<UserLoginInformationViewModel>(null, user.Message);
            }
            if (!user.Data.IsAdmin)
            {
                return new ErrorDataResult<UserLoginInformationViewModel>(null, Messages.NotAuthorized);
            }
            if (HashPassword(userForLogin.Password) == user.Data.PasswordHash)
            {
                var loginedUser = new UserLoginInformationViewModel { Email = user.Data.Email, IsAdmin = user.Data.IsAdmin, IsLogined = true };
                return new SuccessDataResult<UserLoginInformationViewModel>(loginedUser, Messages.Logged);
            }

            return new ErrorDataResult<UserLoginInformationViewModel>(null, Messages.PasswordInvalid);
        }


        public IDataResult<UserLoginInformationViewModel> Login(UserForLoginViewModel userForLogin)
        {
            var checkedPassword = CheckEmailAndPassword(userForLogin.Email, userForLogin.Password);
            if (!checkedPassword)
            {
                return new ErrorDataResult<UserLoginInformationViewModel>(null, Messages.MailPasswordInvalid);
            }
            var user = _userManager.GetDetailByEmail(userForLogin.Email, "bmFtZSI6Ikpva,");
            if (!user.Success)
            {
                return new ErrorDataResult<UserLoginInformationViewModel>(null, user.Message);
            }

            if (HashPassword(userForLogin.Password) == user.Data.PasswordHash)
            {
                var loginedUser = new UserLoginInformationViewModel { Id = user.Data.Id, Email =user.Data.Email,IsAdmin=user.Data.IsAdmin,IsLogined=true };
                return new SuccessDataResult<UserLoginInformationViewModel>(loginedUser, Messages.Logged);
            }

            return new ErrorDataResult<UserLoginInformationViewModel>(null, Messages.PasswordInvalid);
        }

        public IDataResult<UserLoginInformationViewModel> Register(UserForRegisterViewModel userForRegister)
        {
           
            var checkedPassword = CheckEmailAndPassword(userForRegister.Email,userForRegister.Password, userForRegister.ConfirmPassword);
            if (!checkedPassword)
            {
                return new ErrorDataResult<UserLoginInformationViewModel>(null, Messages.MailPasswordInvalid);
            }

            var user = _userManager.GetDetailByEmail(userForRegister.Email, "bmFtZSI6Ikpva,");
            if (!user.Success)
            {
                var passwordHash = HashPassword(userForRegister.Password);
                var userViewModel = new UserWithPasswordViewModel
                {
                    BirthDate = userForRegister.BirthDate,
                    Email = userForRegister.Email,
                    Name = userForRegister.Name,
                    Surname = userForRegister.Surname,
                    IsAdmin = false,
                    Gender = userForRegister.Gender,
                    GoalWeight = userForRegister.GoalWeight,
                    Height = userForRegister.Height,
                    PasswordHash = passwordHash,
                    Weight = userForRegister.Weight,
                    Age = userForRegister.Age
                };
                var addedUser = _userManager.Add(userViewModel);
                var userGet = _userManager.GetByEmail(userForRegister.Email);
                if (addedUser.Success && userGet.Success)
                {
                    
                    return new SuccessDataResult<UserLoginInformationViewModel>(new() {Id = userGet.Data.Id, Email=userViewModel.Email,IsAdmin=userViewModel.IsAdmin,IsLogined=true}, Messages.Logged);
                }
            }
            return new ErrorDataResult<UserLoginInformationViewModel>(new() { IsLogined=false}, Messages.UserExist);

        }

        public IResult ChangeRole(string modifierEmail,string email,bool isAdmin)
        {
            var user = _userManager.GetDetailByEmail(email);
            var modifierUser = _userManager.GetByEmail(modifierEmail);

            if (user.Success && modifierUser.Success && modifierUser.Data.IsAdmin)
            {
                user.Data.IsAdmin = isAdmin;
                var updatedUser = _userManager.Update(user.Data);
                if (updatedUser.Success)
                {
                    return new SuccessResult(Messages.Updated);
                }
            }
            return new SuccessResult(Messages.UserNotFound);

        }

        public IResult ResetPassword(ResetPasswordViewModel resetPasswordView)
        {
            var checkedMailPassword = CheckEmailAndPassword(resetPasswordView.Email,resetPasswordView.Password,resetPasswordView.ConfirmPassword);
            if(!checkedMailPassword)
                return new ErrorResult(Messages.MailPasswordInvalid);
            var user = _userManager.GetDetailByEmail(resetPasswordView.Email, "bmFtZSI6Ikpva,");            
            if (user.Success)
            {
                var passwordHash = HashPassword(resetPasswordView.Password);
                var userviewModel = new UserWithPasswordViewModel()
                {
                    BirthDate = user.Data.BirthDate,
                    Email = user.Data.Email,
                    Id = user.Data.Id,
                    IsAdmin = user.Data.IsAdmin,
                    Name = user.Data.Name,
                    Surname = user.Data.Surname,
                    PasswordHash=passwordHash,
                    Weight = user.Data.Weight,
                    Gender = user.Data.Gender,
                    GoalWeight = user.Data.GoalWeight,
                    Height = user.Data.Height
                };
                var updatedUser = _userManager.Update(user.Data);
                if (updatedUser.Success)
                {
                    return new SuccessResult( Messages.Logged);
                }
            }
            return new ErrorResult(Messages.UserNotFound);

        }
        private bool CheckEmailAndPassword(string email,string password,string confirmPassword=null)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidate = hasNumber.IsMatch(password) && hasMinimum8Chars.IsMatch(password) && hasUpperChar.IsMatch(password);
            
            if (!isValidate || (password != confirmPassword && confirmPassword is not null)||(!email.Contains("@") || !email.Contains(".")))
            {
                return false;
            }            
            return true;
        }
        private string HashPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

    }
}
