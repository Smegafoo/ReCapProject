using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal _carDal)
        {
            this._carDal = _carDal;

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarColor()
        {
            return _carDal.GetCarColor();
        }

        public List<CarDetailDto> GetCarModelYear()
        {
            return _carDal.GetCarModelYear();
        }

        public List<CarDetailDto> GetCarNameDetail()
        {
            return _carDal.GetCarNameDetail();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=> p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=> c.ColorId == id);
        }
    }
}
