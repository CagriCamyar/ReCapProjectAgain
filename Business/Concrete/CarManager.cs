using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarNameExist(car.CarName), CheckIfCarCountOfBrandCorrect(car.BrandId));

            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }



        public IResult DailyPriceMoreThanZero(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                return new ErrorResult(Messages.InvalidPrice);
            }
            return new SuccessResult(Messages.CarAdded);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(Messages.CarsListed);
        }

        public IDataResult<Car> GetByBrandId(int brandId)
        {
            if (brandId < 0)
            {
                return new ErrorDataResult<Car>(Messages.InvalidBrandId);
            }
            return new SuccessDataResult<Car>(_carDal.Get(c => c.BrandId == brandId), Messages.GetBrand);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Car> GetByCarId(int carId)
        {
            if (carId == 3)
            {
                return new ErrorDataResult<Car>(Messages.CarRented);
            }
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId), Messages.GetCar);
        }

        public IDataResult<Car> GetByColourId(int colourId)
        {
            if (colourId < 0)
            {
                return new ErrorDataResult<Car>(Messages.InvalidColourId);
            }
            return new SuccessDataResult<Car>(Messages.GetColour);
        }

        public IDataResult<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.DailyPrice > 0), Messages.GetCar);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult NameMinTwoChars(Car car)
        {
            if (car.Description.Length <= 2)
            {
                return new ErrorResult(Messages.InvalidName);
            }
            return new SuccessResult(Messages.CarAdded);
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }

        private IResult CheckIfCarCountOfBrandCorrect(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandId == brandId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.CarCountOfBrandError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarNameExist(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}

