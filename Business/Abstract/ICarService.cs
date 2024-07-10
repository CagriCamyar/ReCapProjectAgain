using Core.Utilities.Result;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByCarId(int carId);
        IDataResult<Car> GetByBrandId(int brandId);
        IDataResult<Car> GetByColourId(int colourId);
        IDataResult<Car> GetByDailyPrice(decimal min, decimal max);
        IResult NameMinTwoChars(Car car);
        IResult DailyPriceMoreThanZero(Car car);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult AddTransactionalTest(Car car);

    }
}
