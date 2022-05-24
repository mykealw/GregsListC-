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
    }
}