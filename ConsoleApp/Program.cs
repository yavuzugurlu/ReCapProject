using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //fun1();
            //CarTest();
           //arabaekle();
        }

        private static void arabaekle()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 4, ColorId = 3, ModelYear = 2020, DailyPrice = 1000, Description = "Varki biniyoz" });
        }

        private static void fun1()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.CarId +" / "+car.CarName +" / "+ car.ColorName + " / " + car.DailyPrice);
            }
        }
    }
}
