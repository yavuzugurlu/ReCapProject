using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,ColorId=1,BrandId=1,DailyPrice=500,Description="Ilk ürün",ModelYear=2017},
                new Car{CarId=2,ColorId=1,BrandId=1,DailyPrice=700,Description="Ikinci ürün",ModelYear=2018},
                new Car{CarId=3,ColorId=2,BrandId=2,DailyPrice=900,Description="Üçüncü ürün",ModelYear=2019},
                new Car{CarId=4,ColorId=3,BrandId=3,DailyPrice=1200,Description="Dördüncü ürün",ModelYear=2021},
                new Car{CarId=5,ColorId=4,BrandId=4,DailyPrice=300,Description="Beşinci ürün",ModelYear=2011}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteCar= _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(DeleteCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }


        public List<Car> GetByColorId(int ColorId)
        {
            return _cars.Where(c => c.ColorId == ColorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car UpdateCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            UpdateCar.BrandId = car.BrandId;
            UpdateCar.ColorId = car.ColorId;
            UpdateCar.DailyPrice = car.DailyPrice;
            UpdateCar.Description = car.Description;
            UpdateCar.ModelYear = car.ModelYear;
        }
    }
}
