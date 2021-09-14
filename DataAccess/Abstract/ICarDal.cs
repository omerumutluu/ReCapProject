using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //Car GetById(int id);
        //List<Car> getAll();
        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);
        List<CarDetailDto> GetCarDetails();

    }
}
