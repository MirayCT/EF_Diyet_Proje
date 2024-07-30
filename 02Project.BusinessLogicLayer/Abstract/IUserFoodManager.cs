using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _07Project.GenericResult.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Abstract
{
    public interface IUserFoodManager : IGenericManager<UserFoodViewModel, UserFoodDto>
    {
        public IDataResult<List<TopFoodViewModel>> GetMostFoods();
        public IDataResult<UserDailyReportViewModel> GetDailyReportByUserId(int userId);
        public IDataResult<List<UserFoodViewModel>> GetWeeklyReport();
        public IDataResult<List<UserFoodViewModel>> GetMonthlyReport();
    }
}
