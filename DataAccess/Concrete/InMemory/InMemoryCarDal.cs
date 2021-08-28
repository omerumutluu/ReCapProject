using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 200000, Description = "Opel Mokka 1.4 Turbo"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2016, DailyPrice = 150000, Description = "Wolkswogen Polo 1.2 TSI"},
                new Car{Id = 3, BrandId = 1, ColorId = 2, ModelYear = 2014, DailyPrice = 160000, Description = "Opel Corsa 1.6 Benzin"},
                new Car{Id = 4, BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 180000, Description = "Fiat Egea 1.4 Benzin"},
            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(carToDelete);
        }

        public List<Car> getAll()
        {
            return cars;
        }

        public Car GetById(int id)
        {
            return cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            var carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
