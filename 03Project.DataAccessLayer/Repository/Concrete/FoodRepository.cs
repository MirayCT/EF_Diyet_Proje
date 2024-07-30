using _03Project.DataAccessLayer.Context.EF;
using _03Project.DataAccessLayer.Repository.Abstract;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;

namespace _03Project.DataAccessLayer.Repository.Concrete
{
    public class FoodRepository : GenericRepository<Food,EfDbContext>, IFoodRepository
    {
    }   
}
