using _04Project.ViewModel.Concrete;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;
using AutoMapper;

namespace _08Project.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<MealTime, MealTimeDto>().ReverseMap();
            CreateMap<PortionSize, PortionSizeDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<FoodViewModel, FoodDto>().ReverseMap();
            CreateMap<MealTimeViewModel, MealTimeDto>().ReverseMap();
            CreateMap<PortionSizeViewModel, PortionSizeDto>().ReverseMap();
            CreateMap<UserViewModel, UserDto>().ReverseMap();
            CreateMap<UserWithPasswordViewModel, UserDto>().ReverseMap();
            CreateMap<UserForRegisterDto, UserDto>().ReverseMap();
            CreateMap<UserFood,UserFoodDto>().ReverseMap();
            CreateMap<UserFoodDto,UserFoodViewModel>().ReverseMap();

        }

    }
}
