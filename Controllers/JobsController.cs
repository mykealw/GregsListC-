

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

        [HttpGet("{id}")]
        public ActionResult<Job> GetJobById(string id)
        {
            try
            {
                Job job = _js.GetJobById(id);
                return Ok(job);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Job> PostJob([FromBody] Job jobData)
        {
            try
            {
                Job newJob = _js.PostJob(jobData);
                return Ok(jobData);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> DeleteJob(string id)
        {
            try
            {
                _js.DeleteJob(id);
                return Ok("I hope they work out for you, deleted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Job> EditJob(string id, [FromBody] Job jobData)
        {
            try
            {
                jobData.Id = id;
                Job updated = _js.EditJob(jobData);
                return Ok(updated);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}