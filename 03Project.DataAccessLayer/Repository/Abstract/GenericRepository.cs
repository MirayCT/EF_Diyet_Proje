using _03Project.DataAccessLayer.Constants;
using _03Project.DataAccessLayer.Context.Abstract;
using _03Project.DataAccessLayer.Context.EF;
using _03Project.DataAccessLayer.UnitOfWorks;
using _05Project.DataTransferObject.Abstract;
using _06Project.Entities.Abstract;
using _06Project.Entities.Common;
using _06Project.Entities.Concrete;
using _08Project.Mapper;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Repository.Abstract
{
    public class GenericRepository<TEntity,TContext> : IGenericRepository<TEntity>
        where TEntity : class, IEntity,new()
        where TContext : DbContext,new()
    {
        DbContext _dbContext;
        DbSet<TEntity> _dbSet;
        
        public GenericRepository()
        {
        }

        public void Add(TEntity entity)
        {
            entity.DataStatus = DataStatus.Inserted;
            entity.Created= DateTime.Now;
            using (TContext context = new TContext())
            {

                var addedEntity = context.Entry<TEntity>(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }

        }
        public void Update(TEntity entity)
        {
            entity.DataStatus = DataStatus.Updated;
            entity.Modified = DateTime.Now;
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
           
        }
        public void Delete(TEntity entity)
        {
            entity.DataStatus = DataStatus.Deleted;
            entity.Deleted = DateTime.Now;
            using (TContext context = new TContext())
            {
                var deletedEntiy = context.Entry(entity);
                deletedEntiy.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Remove(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntiy = context.Entry(entity);
                deletedEntiy.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public ICollection<TEntity> GetAll()
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var entities = context.Set<TEntity>().ToList();

                    return entities;
                }
            }
            catch (ArgumentException)
            {

                throw new Exception(Messages.ArgumentIsNull);
            }
            
        }

        public TEntity GetById(int id)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Set<TEntity>().Find(id);

                if (entity == null)
                    throw new Exception(Messages.IdNotFound);

                return entity;
            }
        }
              
        public ICollection<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var entities = context.Set<TEntity>().Where(predicate).ToList();
                    return entities;
                }
            }
            catch (ArgumentNullException)
            {

                throw new Exception(Messages.ConditionalArgumentIsNull);
            }
        }
    }
}
