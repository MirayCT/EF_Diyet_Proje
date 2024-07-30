using _02Project.BusinessLogicLayer.Abstract;
using _02Project.BusinessLogicLayer.Constants;
using _03Project.DataAccessLayer.Service.Concrete;
using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _07Project.GenericResult.Abstract;
using _07Project.GenericResult.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Concrete
{
    public class UserFoodManager : GenericManager<UserFoodService, UserFoodViewModel, UserFoodDto>, IUserFoodManager
    {
        public override IResult Add(UserFoodViewModel model)
        {
            return base.Add(model);
        }
        public IDataResult<UserDailyReportViewModel> GetDailyReportByUserId(int userId)
        {
            var mostFoods = _service.GetDailyReportByUserId(userId);

            return new SuccessDataResult<UserDailyReportViewModel>(mostFoods, Messages.Listed);
        }


        public IDataResult<List<UserFoodViewModel>> GetMonthlyReport()
        {
           var monthlyReportDto = _service.Search(u=>u.Time.Month==DateTime.Now.Month).ToList();
            var monthlyReport = new List<UserFoodViewModel>();
            foreach (var item in monthlyReportDto)
            {
                monthlyReport.Add(_mapper.Map<UserFoodViewModel>(item));
            }
            return new SuccessDataResult<List<UserFoodViewModel>>(monthlyReport,Messages.Listed);
        }

        public IDataResult<List<TopFoodViewModel>> GetMostFoods()
        {
            var mostFoods = _service.GetMostFoods();
            
            return new SuccessDataResult<List<TopFoodViewModel>>(mostFoods, Messages.Listed);
        }

        public IDataResult<List<UserFoodViewModel>> GetWeeklyReport()
        {
            var x = DateTime.Now.AddDays(-7);
            var monthlyReportDto = _service.Search(u => u.Time >= DateTime.Now.AddDays(-7)).ToList();
            var monthlyReport = new List<UserFoodViewModel>();
            foreach (var item in monthlyReportDto)
            {
                monthlyReport.Add(_mapper.Map<UserFoodViewModel>(item));
            }
            return new SuccessDataResult<List<UserFoodViewModel>>(monthlyReport, Messages.Listed);

        }
    }
}
