using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult add(Rental rental);
        IResult delete(int id);
        IResult update(Rental rental);

        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> Get(int id);
    }
}
