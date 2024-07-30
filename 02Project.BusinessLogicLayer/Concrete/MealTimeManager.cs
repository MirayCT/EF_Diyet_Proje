using _02Project.BusinessLogicLayer.Abstract;
using _03Project.DataAccessLayer.Service.Concrete;
using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;

namespace _02Project.BusinessLogicLayer.Concrete
{
    public class MealTimeManager : GenericManager<MealTimeService, MealTimeViewModel, MealTimeDto>, IMealTimeManager
    {
    }
}
