﻿using _03Project.DataAccessLayer.Repository.Concrete;
using _03Project.DataAccessLayer.Service.Abstract;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;

namespace _03Project.DataAccessLayer.Service.Concrete
{
    public class MealTimeService : GenericService<MealTimeDto, MealTime>, IMealTimeService
    {
        public MealTimeService() : base(new MealTimeRepository())
        {

        }
    }
}