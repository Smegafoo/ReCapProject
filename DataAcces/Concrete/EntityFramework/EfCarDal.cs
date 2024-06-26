using Core.DataAcces.EfEntityRepository;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class efCarDal : EfEntityRepositoryBase<Car, MySQlContext>, ICarDal

    {
        public List<CarDetailDto> GetCarColor()
        {
            using (MySQlContext context=new MySQlContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join r in context.Color
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorName = r.ColorName
                             };

                return result.ToList();

            }
        }

        public List<CarDetailDto> GetCarModelYear()
        {
            using (MySQlContext context=new MySQlContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();

            }
        }

        public List<CarDetailDto> GetCarNameDetail()
        { 
            
                using (MySQlContext context = new MySQlContext())
                {
                    var result = from c in context.Car
                                 join b in context.Brand
                                 on c.BrandId equals b.BrandId
                                 select new CarDetailDto
                                 {
                                     CarName = c.CarName,
                                     BrandName = b.BrandName

                                 };
                    return result.ToList();
                }
            
        }

        
    }
}

