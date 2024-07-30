using _03Project.DataAccessLayer.Context.EF;
using _03Project.DataAccessLayer.Repository.Abstract;
using _05Project.DataTransferObject.Concrete;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Repository.Concrete
{
    public class UserRepository:GenericRepository<User, EfDbContext>, IUserRepository
    {
    }
}
