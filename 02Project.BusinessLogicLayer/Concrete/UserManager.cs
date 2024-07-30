using _02Project.BusinessLogicLayer.Abstract;
using _02Project.BusinessLogicLayer.Constants;
using _03Project.DataAccessLayer.Service.Concrete;
using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;
using _07Project.GenericResult.Abstract;
using _07Project.GenericResult.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Concrete
{
    public class UserManager : GenericManager<UserService, UserViewModel, UserDto>, IUserManager
    {
        public IResult Add(UserWithPasswordViewModel user)
        {
           var dto =  _mapper.Map<UserDto>(user);
            _service.Add(dto);
            return new SuccessResult(Messages.Added);
        }
        public IResult Update(UserWithPasswordViewModel user)
        {
            var dto = _mapper.Map<UserDto>(user);
            _service.Update(dto);
            return new SuccessResult(Messages.Updated);
        }
        public IDataResult<UserViewModel> GetByEmail(string email)
        {
            var viewModel = Search(u => u.Email == email);
            if (viewModel.Data.Count==1)
            {
                return new SuccessDataResult<UserViewModel>(viewModel.Data.ToList()[0]);               
            }
            return new ErrorDataResult<UserViewModel>(null,Messages.UserNotFound);

        }

        public IDataResult<UserWithPasswordViewModel> GetDetailByEmail(string email,string key = "")
        {
            if (key== "bmFtZSI6Ikpva,")
            {
                var viewModel = _service.Search(u => u.Email == email);
                if (viewModel.Count == 1)
                {
                    var dto = viewModel.ToList()[0];
                    return new SuccessDataResult<UserWithPasswordViewModel>(new()
                    {
                        Id = dto.Id,
                        IsAdmin = dto.IsAdmin,
                        Email = dto.Email,
                        PasswordHash = dto.PasswordHash,
                        BirthDate = dto.BirthDate,
                        Gender = dto.Gender,
                        GoalWeight = dto.GoalWeight,
                        Height = dto.Height,
                        Name = dto.Name,
                        Surname = dto.Surname,
                        Weight = dto.Weight
                    });;
                }
                return new ErrorDataResult<UserWithPasswordViewModel>(null, Messages.UserNotFound);
            }
            return new ErrorDataResult<UserWithPasswordViewModel>(null);
        }

       
    }
}
