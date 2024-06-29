using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PMGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpertController : ControllerBase
    {
        ServiceMetier.Service1Client service = new ServiceMetier.Service1Client();

        [HttpPost]
        public bool AddExpert(ServiceMetier.Expert expert)
        {
            return service.AddExpert(expert);
        }

        [HttpGet]
        public ICollection<ServiceMetier.Expert> GetAllExpert()
        {
            return service.GetAllExpert();
        }

        [HttpDelete]
        public bool DeleteExpert(ServiceMetier.Expert expert)
        {
            return service.DeleteExpert(expert.Id);
        }
    }
}
