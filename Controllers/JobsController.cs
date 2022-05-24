

using GregsList.Models;
using GregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _js;

        public JobsController(JobsService js)
        {
            _js = js;
        }

        [HttpGet]
        public ActionResult<List<JobsController>> GetAllJobs()
        {
            try
            {
                List<Job> jobs = _js.GetAllJobs();
                return Ok(jobs);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }











    }
}