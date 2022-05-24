

using GregsList.Models;

namespace GregsList.FakeDB
{
    public static class Database
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car("RB-18", "RedBull", 2022, "Black", 3500000, "http://thiscatdoesnotexist.com"),
            new Car("F1-75", "Ferrari", 2022, "Red", 3500001, "http://thiscatdoesnotexist.com"),
            new Car("W13", "Mercedes", 2022, "Teal", 3333000, "http://thiscatdoesnotexist.com")

        };
    }
}