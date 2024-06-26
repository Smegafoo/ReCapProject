using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car> { 
                new Car {BrandId=1,CarId=1,ColorId=1,DailyPrice="500",ModelYear="2012",Description="Asddsa"},
                new Car {BrandId=1,CarId=2,ColorId=2,DailyPrice="750",ModelYear="2013",Description="Asddsa"},
                new Car {BrandId=2,CarId=3,ColorId=2,DailyPrice="900",ModelYear="2016",Description="Asddsa"}
       
                };
        }

        public void Add(Car entity)
        {
            cars.Add(entity);

        }

        public void Delete(Car entity)
        {
                Car carToDelete=cars.SingleOrDefault(p=>p.BrandId==entity.BrandId);

                cars.Remove(carToDelete);
        }


        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter)
        {
            return cars;
        }

        public List<CarDetailDto> GetCarColor()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarModelYear()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarNameDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = cars.SingleOrDefault(p => p.BrandId == entity.BrandId);
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.Description = entity.Description;
        }
    }
}
