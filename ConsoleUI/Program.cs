using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            }

            carManager.Add(new Car { Id = 5, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Opel Grandland 1.4 Turbo" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            }

            carManager.Update(new Car { Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Opel Grandland 1.4 Turbo" });
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            }

            carManager.Delete(new Car { Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Opel Grandland 1.4 Turbo" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            }
        }
    }
}
