using _06Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Service.Abstract
{
    public interface IGenericService<TDto>
    {
        void Add(TDto model);
        void Update(TDto model);
        void Delete(TDto model);
        void Remove(TDto model);
        TDto GetById(int id);
        ICollection<TDto> GetAll();
        ICollection<TDto> Search(Expression<Func<TDto, bool>> predicate);
    }
}
