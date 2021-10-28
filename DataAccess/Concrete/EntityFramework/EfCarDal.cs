using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join col in context.Colors on c.ColorId equals col.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId = c.CarId, CarName = b.BrandName, ColorName = col.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
