using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ElectricianAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricJobController : ControllerBase
    {
 
        private readonly IElectricJobRepository _repo;

        public ElectricJobController(IElectricJobRepository repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public async Task<ActionResult<List<ElectricJob>>> GetElectricJobs()
        {
            var jobs =  await _repo.GetElectricJobsAsync();

            return Ok(jobs);    
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ElectricJob>> GetElectricJob(int id)
        {
            var job = await _repo.GetElectricJobAsync(id);

            return Ok(job);
        }
    }
}
