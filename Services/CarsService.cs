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
    }
}