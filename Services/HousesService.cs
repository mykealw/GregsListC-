

using GregsList.FakeDB;
using GregsList.Models;

namespace GregsList.Services
{
    public class HousesService
    {
        internal List<House> GetAllHouses()
        {
            return Database.Houses;
        }

        internal House GetHouseById(string id)
        {
            House house = Database.Houses.Find(h => h.Id == id);
            if (house == null)
            {
                throw new Exception("this house has already been sold, bad id");
            }
            return house;
        }

        internal House CreateHouse(House houseData)
        {
            Database.Houses.Add(houseData);
            return houseData;
        }

        internal void DeleteHouse(string id)
        {
            House found = GetHouseById(id);
            Database.Houses.Remove(found);
        }

        internal House EditHouse(House houseData)
        {
            House original = GetHouseById(houseData.Id);
            original.Description = houseData.Description ?? original.Description;
            original.Bedroom = houseData.Bedroom != 0 ? houseData.Bedroom : original.Bedroom;
            original.Bathroom = houseData.Bathroom != 0 ? houseData.Bathroom : original.Bathroom;
            original.Price = houseData.Price != 0 ? houseData.Price : original.Price;
            original.ImgUrl = houseData.Description ?? original.Description;

            return original;
        }
    }
}