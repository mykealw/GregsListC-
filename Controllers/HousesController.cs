using GregsList.Models;
using GregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;

        public HousesController(HousesService hs)
        {
            _hs = hs;
        }

        [HttpGet]
        public ActionResult<List<House>> GetAllHouses()
        {
            try
            {
                List<House> houses = _hs.GetAllHouses();
                return Ok(houses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<House> GetHouseById(string id)
        {
            try
            {
                House house = _hs.GetHouseById(id);
                return Ok(house);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<House> CreateHouse([FromBody] House houseData)
        {
            try
            {
                House newHouse = _hs.CreateHouse(houseData);
                return Ok(newHouse);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> DeleteHouse(string id)
        {
            try
            {
                _hs.DeleteHouse(id);
                return Ok("well this doesn't help housing prices, deleted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<House> EditHouse(string id, [FromBody] House houseData)
        {
            try
            {
                houseData.Id = id;
                House updated = _hs.EditHouse(houseData);
                return Ok(updated);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}