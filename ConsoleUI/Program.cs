using Business.Concrete;
using DataAccess.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
