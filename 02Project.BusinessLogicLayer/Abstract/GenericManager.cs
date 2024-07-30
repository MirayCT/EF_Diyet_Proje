using _02Project.BusinessLogicLayer.Constants;
using _03Project.DataAccessLayer.Repository.Abstract;
using _03Project.DataAccessLayer.Service.Abstract;
using _04Project.ViewModel.Abstract;
using _05Project.DataTransferObject.Abstract;
using _06Project.Entities.Abstract;
using _07Project.GenericResult.Abstract;
using _07Project.GenericResult.Concrete;
using _08Project;
using _08Project.Mapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Abstract
{
    public class GenericManager<TService, TViewModel, TDto> : IGenericManager<TViewModel, TDto>
        where TViewModel : class,IViewModel, new()
        where TDto : class,IDto, new()
        where TService : class,IGenericService<TDto>, new()
    {
        protected TService _service;
        protected IMapper _mapper;
        public GenericManager()
        {
            _service =  new TService();
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });
            _mapper= new Mapper(mapConfig);
        }

        public virtual IResult Add(TViewModel model)
        {
            var dto = _mapper.Map<TDto>(model);
            _service.Add(dto);
            return new SuccessResult(Messages.Added);
        }
        public virtual IResult Update(TViewModel model)
        {
            var dto = _mapper.Map<TDto>(model);
            _service.Update(dto);
            return new SuccessResult(Messages.Updated);
        }

        public virtual IResult Delete(TViewModel model)
        {
            var dto = _mapper.Map<TDto>(model);
            _service.Delete(dto);
            return new SuccessResult(Messages.Deleted);
        }

        public virtual IDataResult<ICollection<TViewModel>> GetAll()
        {
            var dtos = _service.GetAll();
            List<TViewModel> viewModels = new();
            foreach (var item in dtos)
            {
                var viewModel = _mapper.Map<TViewModel>(item);
                viewModels.Add(viewModel);
            }           
            return new SuccessDataResult<ICollection<TViewModel>>(viewModels, Messages.Listed);
        }

        public virtual IDataResult<TViewModel> GetById(int id)
        {
            var dto = _service.GetById(id);
            var viewModel = _mapper.Map<TViewModel>(dto);            
            return new SuccessDataResult<TViewModel>(viewModel, Messages.GotById);
        }

        public virtual IResult Remove(TViewModel model)
        {
            var dto = _mapper.Map<TDto>(model);
            _service.Remove(dto);
            return new SuccessResult(Messages.Removed);
        }

        public virtual IDataResult<ICollection<TViewModel>> Search(Expression<Func<TDto, bool>> predicate)
        {
            var dtos = _service.Search(predicate);
            List<TViewModel> viewModels = new();
            foreach (var item in dtos)
            {
                var viewModel = _mapper.Map<TViewModel>(item);
                viewModels.Add(viewModel);
            }
            return new SuccessDataResult<ICollection<TViewModel>>(viewModels, Messages.Listed);
        }

       
    }
}
