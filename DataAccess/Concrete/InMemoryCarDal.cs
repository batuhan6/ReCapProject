using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1,BrandId=1,ModelYear=1960,DailyPrice=100000,Description="klasik"},
                new Car{CarId=2,BrandId=1,ModelYear=2000,DailyPrice=5000,Description="ax değişmiş"},
                new Car{CarId=3,BrandId=1,ModelYear=1970,DailyPrice=50000,Description="fren bozuk"},
                new Car{CarId=4,BrandId=2,ModelYear=1980,DailyPrice=10000,Description="komple boyalı"},
                new Car{CarId=5,BrandId=2,ModelYear=2001,DailyPrice=1000,Description="tampon değismis"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car _carToDelete = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            _cars.Remove(_carToDelete);
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
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
