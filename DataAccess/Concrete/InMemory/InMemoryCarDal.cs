using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, CarName = "Ford", ColourId = 1, DailyPrice = 800, ModelYear = 2016, Description = "Ford Focus Black 2016" },
                new Car {CarId = 2, BrandId = 2, CarName = "Fiat", ColourId = 2, DailyPrice = 1000, ModelYear = 2018, Description = "Fiat Egea White 2018 " },
             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            
            _cars.Remove(carToDelete);
        }

        public Car Get(int carId)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.CarName = car.CarName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
