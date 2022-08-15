using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DescriptionTest();
            //BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void DescriptionTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(),new BrandManager(new EfBrandDal()));

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+"/"+car.BrandName+"/"+car.ColorName);
            }
        }
    }
}
