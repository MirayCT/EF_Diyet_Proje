using _03Project.DataAccessLayer.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IFoodRepository FoodRepository { get; }
        IMealTimeRepository MealTimeRepository { get; }
        IUserRepository UserRepository { get; }
        IPortionSizeRepository PortionSizeRepository { get; }
        int Complete();
        void Dispose();
        
    }
}
