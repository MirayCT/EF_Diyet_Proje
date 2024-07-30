using _04Project.ViewModel.Concrete;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Repository.Abstract
{
    public interface IUserFoodRepository : IGenericRepository<UserFood>
    {
        List<TopFoodViewModel> GetMostFoods();
        UserDailyReportViewModel GetDailyReportByUserId(int userId);
    }
}
