
using _05Project.DataTransferObject.Abstract;
using _06Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Repository.Abstract
{
    public interface IGenericRepository<TEntity>:IEntityRepository
        where TEntity : IEntity
    {
        void Add(TEntity dto);
        void Update(TEntity dto);
        void Delete(TEntity dto);
        void Remove(TEntity dto);
        TEntity GetById(int id);
        ICollection<TEntity> GetAll();
        ICollection<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    }
}
