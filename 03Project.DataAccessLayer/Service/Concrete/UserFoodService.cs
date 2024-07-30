using _03Project.DataAccessLayer.Repository.Abstract;
using _03Project.DataAccessLayer.Repository.Concrete;
using _03Project.DataAccessLayer.Service.Abstract;
using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Service.Concrete
{
    public class UserFoodService : GenericService<UserFoodDto, UserFood>, IUserFoodService
    {
        public UserFoodService() : base(new UserFoodRepository())
        {
            
        }

        public UserDailyReportViewModel GetDailyReportByUserId(int userId)
        {
            var result = ((IUserFoodRepository)_repository).GetDailyReportByUserId(userId);
            return result;
        }

        public List<TopFoodViewModel> GetMostFoods()
        {
            
            var result = ((IUserFoodRepository)_repository).GetMostFoods();
            return result;
            
        }
    }
}
