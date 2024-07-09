using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult add(Brand brand);
        IResult delete(int id);
        IResult update(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> Get(int id);
    }
}
