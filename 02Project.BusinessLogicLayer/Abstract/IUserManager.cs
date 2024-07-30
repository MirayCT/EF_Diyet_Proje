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

namespace _02Project.BusinessLogicLayer.Abstract
{
    public interface IUserManager : IGenericManager<UserViewModel, UserDto>
    {        
        IResult Add(UserWithPasswordViewModel user);
        IResult Update(UserWithPasswordViewModel user);
        IDataResult<UserViewModel> GetByEmail(string email);
        IDataResult<UserWithPasswordViewModel> GetDetailByEmail(string email, string key = "");
    }
}
