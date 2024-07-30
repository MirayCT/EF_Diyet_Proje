using _03Project.DataAccessLayer.Constants;
using _03Project.DataAccessLayer.Context.EF;
using _03Project.DataAccessLayer.Repository.Abstract;
using _05Project.DataTransferObject.Abstract;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Abstract;
using _08Project.Mapper;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Service.Abstract
{
    public class GenericService<TDto,TEntity> : IGenericService<TDto>
        where TDto : class, IDto, new()
        where TEntity : class, IEntity, new()
    {
        protected IMapper _mapper;
        protected IGenericRepository<TEntity> _repository;
        public GenericService(IGenericRepository<TEntity> entityRepository)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
                cfg.AddExpressionMapping();
            });
            _mapper = new Mapper(config);
            _repository = entityRepository;
        }

        public void Add(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _repository.Add(entity);
        }

        public void Delete(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _repository.Remove(entity);
        }

        public ICollection<TDto> GetAll()
        {
            var entities = _repository.GetAll();
            List<TDto> dtos = new();
            foreach (var entity in entities)
            {
                var dto = _mapper.Map<TDto>(entity);
                dtos.Add(dto);
            }
            return dtos;
        }

        public TDto GetById(int id)
        {

            var entity = _repository.GetById(id);

            if (entity == null)
                throw new Exception(Messages.ArgumentIsNull);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public void Remove(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _repository.Remove(entity);
        }

        public ICollection<TDto> Search(Expression<Func<TDto, bool>> predicate)
        {
            try
            {
                Expression < Func<TEntity, bool> >entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
                var entities = _repository.Search(entityPredicate);
                List<TDto> dtos = new();
                foreach (var entity in entities)
                {
                    var dto = _mapper.Map<TDto>(entity);
                    dtos.Add(dto);
                }
                return dtos;
            }
            catch (ArgumentNullException e)
            {

                throw new Exception(Messages.ArgumentIsNull);
            }
        }

        public void Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _repository.Update(entity);
        }

    }
}
