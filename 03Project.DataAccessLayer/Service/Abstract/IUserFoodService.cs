﻿using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Service.Abstract
{
    public interface IUserFoodService : IGenericService<UserFoodDto>
    {
        public List<TopFoodViewModel> GetMostFoods();
        UserDailyReportViewModel GetDailyReportByUserId(int userId);
    }
}