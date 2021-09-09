using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach(var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            //}

            //carManager.Add(new Car { Id = 5, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Opel Grandland 1.4 Turbo" });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            //}

            //carManager.Update(new Car { Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Opel Grandland 1.4 Turbo" });

            //foreach (var car in carManager.GetAll())
            //{
                //Console.WriteLine(car.Id + " // " + car.BrandId + " // " + car.ColorId + " // " + car.ModelYear + " // " + car.DailyPrice + " // " + car.Description);
            //}

            //carManager.Delete(new Car { Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Opel Grandland 1.4 Turbo" });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + "- " + car.BrandId + "- " + car.ColorId + "- " + car.ModelYear + "- " + car.DailyPrice + "- " + car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { Id = 4, BrandId = 8, ColorId = 3, DailyPrice = 800, ModelYear = 2004, Description = "Fiat Grande Punto 1.2 TSİ Otomatik Turbo" });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Id = 15, Name = "Volvo" });

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { Id = 6, Name = "Sarı" });

        }
    }
}
