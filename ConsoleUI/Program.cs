using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //GetCarNameDetail();
            //GetModelYear();
            GetCarColor();

        }

        private static void GetCarColor()
        {
            CarManager carManager = new CarManager(new efCarDal());
            foreach (var car in carManager.GetCarColor())
            {
                Console.WriteLine(car.BrandName + " \t " + car.CarName + " \t " + car.ColorName);

            }
        }

        private static void GetModelYear()
        {
            CarManager carManager = new CarManager(new efCarDal());
            foreach (var car in carManager.GetCarModelYear())
            {
                Console.WriteLine(car.BrandName + " \t " + car.CarName + " \t " + car.ModelYear);

            }
        }

        private static void GetCarNameDetail()
        {
            CarManager carManager = new CarManager(new efCarDal());
            foreach (var car in carManager.GetCarNameDetail())
            {
                Console.WriteLine(car.BrandName + " \t " + car.CarName);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new efCarDal());
            foreach (Car car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("CarId:" + car.CarId + "\tBrandId:" + car.BrandId + "\tColorId:" + car.ColorId);

            }
        }
    }
}
