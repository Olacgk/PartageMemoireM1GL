using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PMGateway.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class ExpertController : ControllerBase
    {
        //ServiceMetier.Service1Client service = new ServiceMetier.Service1Client();
        ServiceExpert.ExpertServiceClient service = new ServiceExpert.ExpertServiceClient();

        [HttpPost]
        public bool AddExpert(ServiceExpert.Expert expert)
        {
            return service.AddExpert(expert);
        }

        [HttpGet]
        public ICollection<ServiceExpert.Expert> GetExperts()
        {
            return service.GetAllExpert();
        }

        [HttpDelete("{id}")]
        public bool DeleteExpert (int id)
        {
            return service.DeleteExpert(id);
        }

        [HttpPut]
        public bool UpdateExpert (ServiceExpert.Expert expert)
        {
            return service.UpdateExpert(expert);
        }

        [HttpGet("{id}")]
        public IActionResult GetExpert (int id)
        {
            ServiceExpert.Expert expert = service.GetExpert(id);

            return Ok(expert);
        }

        //[HttpGet("item")]
        //public IActionResult GetExpertByStr(string str)
        //{
        //    List<ServiceExpert.Expert> expert = service.GetExperts(str);
        //    return Ok(expert);
        //}
    }
}
