using _02Project.BusinessLogicLayer.Abstract;
using _03Project.DataAccessLayer.Service.Concrete;
using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;

namespace _02Project.BusinessLogicLayer.Concrete
{
    public class FoodManager : GenericManager<FoodService, FoodViewModel, FoodDto>, IFoodManager
    {
        
    }
}
