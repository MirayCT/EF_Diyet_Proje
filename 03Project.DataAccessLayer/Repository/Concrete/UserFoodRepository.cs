using _03Project.DataAccessLayer.Context.EF;
using _03Project.DataAccessLayer.Repository.Abstract;
using _04Project.ViewModel.Concrete;
using _06Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Repository.Concrete
{
    public class UserFoodRepository : GenericRepository<UserFood, EfDbContext>, IUserFoodRepository
    {
        public UserDailyReportViewModel GetDailyReportByUserId(int userId)
        {
            using (var context = new EfDbContext())
            {
                var result = context.UserFoods.Include(u => u.Food).Include(u=>u.PortionSize).ToList();
                var dailyRep = new UserDailyReportViewModel();
                foreach (var item in result)
                {
                    dailyRep.Protein += item.Food.Protein*item.PortionSize.PortionInGrams / 100;
                    dailyRep.Carbs += item.Food.Carbs * item.PortionSize.PortionInGrams / 100;
                    dailyRep.Fats += item.Food.Fats * item.PortionSize.PortionInGrams / 100;
                    dailyRep.Calorie += item.Food.Calorie * item.PortionSize.PortionInGrams / 100;
                }
                return dailyRep;
            }
        }

        public List<TopFoodViewModel> GetMostFoods()
        {
            using (var context = new EfDbContext())
            {
                var result = context.UserFoods.Include(u => u.Food).ToList().GroupBy(u=>u.Food).Select(u=>new TopFoodViewModel { TotalCount=u.Count(),Name = u.Key.Name}).OrderBy(u=>u.TotalCount);
                return result.ToList();
            }
        }
    }
}
