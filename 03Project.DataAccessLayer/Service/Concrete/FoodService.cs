using _03Project.DataAccessLayer.Repository.Concrete;
using _03Project.DataAccessLayer.Service.Abstract;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Service.Concrete
{

    public class FoodService : GenericService<FoodDto, Food>, IFoodService
    {
        public FoodService() : base(new FoodRepository())
        {

        }
    }
    
}
