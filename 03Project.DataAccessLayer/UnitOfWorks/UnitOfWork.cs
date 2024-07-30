using _03Project.DataAccessLayer.Context.EF;
using _03Project.DataAccessLayer.Repository.Abstract;
using _03Project.DataAccessLayer.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _03Project.DataAccessLayer.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        public UnitOfWork()
        {
            _dbContext = new EfDbContext();
            PortionSizeRepository = new PortionSizeRepository();
            MealTimeRepository = new MealTimeRepository();
            UserRepository = new UserRepository();
            PortionSizeRepository = new PortionSizeRepository();
        }
        public IFoodRepository FoodRepository { get; private set; }

        public IMealTimeRepository MealTimeRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public IPortionSizeRepository PortionSizeRepository { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
