using _03Project.DataAccessLayer.Repository.Abstract;
using _04Project.ViewModel.Abstract;
using _05Project.DataTransferObject.Abstract;
using _06Project.Entities.Abstract;
using _07Project.GenericResult.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02Project.BusinessLogicLayer.Abstract
{
    public interface IGenericManager<TViewModel,TDto>:IManager
        where TViewModel : IViewModel
        where TDto : IDto
    {
        IResult Add(TViewModel model);
        IResult Update(TViewModel model);
        IResult Delete(TViewModel model);
        IResult Remove(TViewModel model);
        IDataResult<TViewModel> GetById(int id);
        IDataResult<ICollection<TViewModel>> GetAll();
        IDataResult<ICollection<TViewModel>> Search(Expression<Func<TDto, bool>> predicate);
    }
}
