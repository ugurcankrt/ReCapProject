using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;

        public CarManager(ICarDal carDal, IBrandDal brandDal)
        {
            _carDal = carDal;
            _brandDal = brandDal;
        }

        public void Add(Car car)
        {
            Brand brand = _brandDal.Get(x => x.Id == car.Id);
            if (brand.BrandName.Length < 2)
            {
                Console.WriteLine("minimum 2 karajker");
                return;
            }
            if (car.DailyPrice< 0)
            {
                Console.WriteLine("0dan büyük olmalı");
                return;
            }
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}
