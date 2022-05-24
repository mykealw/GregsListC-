using GregsList.FakeDB;
using GregsList.Models;

namespace GregsList.Services
{
    public class CarsService
    {
        internal List<Car> GetAll()
        {
return Database.Cars  ;      }
    }
}