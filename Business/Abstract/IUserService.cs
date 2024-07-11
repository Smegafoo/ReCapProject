using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult add(User user);
        IResult delete(int id);
        IResult update(User user);

        IDataResult<List<User>> GetAll();

        IDataResult<List<User>> Get(int id);
    }
}
