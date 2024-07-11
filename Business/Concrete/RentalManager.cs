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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal _rentalDal)
        {
            this._rentalDal = _rentalDal;
        }


        //CUD Operations
        public IResult add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccesResult(Messages.AddedRental);
        }

        public IResult delete(int id)
        {
            var deletedRental=_rentalDal.Get(r=> r.RentalId == id);
            if(deletedRental != null)
            {
                _rentalDal.Delete(deletedRental);
                return new SuccesResult(Messages.DeletedCustomer);
            }
            else
            {
                return new ErrorResult(Messages.RentalNotFound);
            }
        }

        public IResult update(Rental rental)
        {
            var rentalId = rental.RentalId;
            var updatedRental=_rentalDal.Get(r=> r.RentalId==rentalId);
            if ((updatedRental!=null))
            {
                updatedRental.CarId = rental.CarId;
                updatedRental.CustomerId = rental.CustomerId;
                updatedRental.CustomerId= rental.CustomerId;
                updatedRental.RentDate= rental.RentDate;
                updatedRental.ReturnDate= rental.ReturnDate;
                _rentalDal.Update(updatedRental);
                return new SuccesResult(Messages.UpdatedRental);
                
            }
            else
            {
                return new ErrorResult(Messages.RentalNotFound);
            }
        }
        //****************************************************


        //Read Operations
        public IDataResult<List<Rental>> Get(int id)
        {
            var getById = _rentalDal.Get(r => r.RentalId == id);
            if (getById != null)
            {
                return new SuccesDataResult<List<Rental>>(new List<Rental> { getById},Messages.RentalListed);
            }
            else
            {
                return new ErrorDataResult<List<Rental>>(Messages.RentalNotFound);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var rentals=_rentalDal.GetAll();
            if(rentals != null && rentals.Count>0)
            {
                return new SuccesDataResult<List<Rental>>(rentals,Messages.RentalListed);
            }
            else
            {
                return new ErrorDataResult<List<Rental>>(Messages.EmptyRentalList);
            }
        }
        //******************************************************

        
    }
}
