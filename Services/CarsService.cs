using GregsList.FakeDB;
using GregsList.Models;

namespace GregsList.Services
{
    public class CarsService
    {
        internal List<Car> GetAll()
        {
            return Database.Cars;
        }

        internal Car GetById(string id)
        {
            Car car = Database.Cars.Find(c => c.Id == id);
            if (car == null)
            {
                throw new Exception("This car is not on the grid, bad Id");
            }
            return car;
        }

        internal Car CreateCar(Car carData)
        {
            Database.Cars.Add(carData);
            return carData;
        }

        internal void Delete(string id)
        {
            Car found = GetById(id);
            Database.Cars.Remove(found);
        }

        internal Car EditCar(Car carData)
        {
            Car original = GetById(carData.Id);
            original.Make = carData.Make ?? original.Make;
            original.Model = carData.Model ?? original.Model;
            original.Price = carData.Price != 0 ? carData.Price : original.Price;
            // original.Price = carData.Price != original.Price ? carData.Price : original.Price;
            original.Color = carData.Color ?? original.Color;
            original.Year = carData.Year != 0 ? carData.Year : original.Year;
            original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;

            return original;
        }
    }
}