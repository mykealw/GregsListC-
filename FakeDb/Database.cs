

using GregsList.Models;

namespace GregsList.FakeDB
{
    public static class Database
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car("RB-18", "RedBull", 2022, 3500000),
            new Car("F1-75", "Ferrari", 2022, 3500001),
            new Car("W13", "Mercedes", 2022, 3333000)

        };
    }
}