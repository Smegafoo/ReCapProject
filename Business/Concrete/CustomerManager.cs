using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal _customerDal)
        {
            this._customerDal = _customerDal;
        }
        //CUD Operations
        public IResult add(Customer customer)
        {
            if (customer.CompanyName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerNameInvalid);
            }
            else
            {
                _customerDal.Add(customer);
                return new SuccesResult(Messages.AddedCustomer);
            }
        }

        public IResult delete(int id)
        {
            var deletedCustomer=_customerDal.Get(p=> p.CustomerId == id);
            if (deletedCustomer != null) 
            {
                _customerDal.Delete(deletedCustomer);
                return new SuccesResult(Messages.DeletedCustomer);

            }
            else
            {
                return new ErrorResult(Messages.CustomerNotFound);
            }
        }

        public IResult update(Customer customer)
        {
            var customerId = customer.CustomerId;
            var updatedCustomer=_customerDal.Get(p=>p.CustomerId == customerId);
            if (updatedCustomer != null)
            {
                updatedCustomer.UserId = customer.UserId;
                updatedCustomer.CompanyName = customer.CompanyName;
                _customerDal.Update(updatedCustomer);
                return new SuccesResult(Messages.UpdatedCustomer);
            }
            else
            {
                return new ErrorResult(Messages.CustomerNotFound);
            }
        }
        //*****************************************************************


        //Read Operations
        public IDataResult<List<Customer>> Get(int id)
        {
            var getById=_customerDal.Get(p=> p.CustomerId==id);
            if (getById != null)
            {
                return new SuccesDataResult<List<Customer>>(new List<Customer> { getById},Messages.CustomerListed);
            }
            else
            {
                return new ErrorDataResult<List<Customer>>(Messages.CustomerNotFound);
            }
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var customers = _customerDal.GetAll();
            if (customers != null && customers.Count > 0)
            {
                return new SuccesDataResult<List<Customer>>(customers, Messages.CustomerListed);
            }
            else
            {
                return new ErrorDataResult<List<Customer>>(Messages.EmptyCustomerList);
            }
        }
        //******************************************************

        
    }
}
