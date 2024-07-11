using Core.DataAcces;
using Core.DataAcces.EfEntityRepository;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
