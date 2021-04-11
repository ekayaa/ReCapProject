using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //RentalTest(); 
           CarTest();


        }
      



        private static void RentalTest()
        { 
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rental in rentalManager.GetRentalDetails().Data)
                {
                    Console.WriteLine(rental.RentDate + " --- " + rental.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }


        private static void CarTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Fiyatı 0'dan büyük olan araçlar listelendi.");
                    Console.WriteLine( car.Id   + car.ColorName + car.BrandName + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}