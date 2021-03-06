using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        //GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
