using GregsList.Models;
using GregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<List<Car>> GetAll()
        {
            try
            {
                List<Car> cars = _cs.GetAll();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetById(string id)
        {
            try
            {
                Car car = _cs.GetById(id);
                return Ok(car);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

  [HttpPost]
  public ActionResult<Car> CreateCar([FromBody] Car carData)
{
  try
  {
    Car newCar = _cs.CreateCar(carData);
    return Ok(newCar);
  }
  catch (Exception e)
  {
    return BadRequest(e.Message);
  }
}


    }
}