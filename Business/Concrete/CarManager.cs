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

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("Araba ekleme işlemi başarılı.");
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Araba silme işlemi başarılı.");
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Araba listeleme işlemi başarılı.");
            return _carDal.getAll();
        }

        public Car GetById(int id)
        {
            Console.WriteLine("Aranan id'ye göre araba getirildi.");
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            Console.WriteLine("Araba güncelleme işlemi başarılı.");
            _carDal.Update(car);
        }
    }
}
