using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult add(Customer customer);  
        IResult delete(int id);
        IResult update(Customer customer);

        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> Get(int id);
    }
}
