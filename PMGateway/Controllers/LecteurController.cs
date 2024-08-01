using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PMGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecteurController : ControllerBase
    {
        ServiceLecteur.LecteurServiceClient service = new ServiceLecteur.LecteurServiceClient();

        [HttpPost]
        public bool AddLecteur(ServiceLecteur.Lecteur lecteur)
        {
            return service.AddLecteur(lecteur);
        }

        [HttpGet]
        public ICollection<ServiceLecteur.Lecteur> GetLecteurs()
        {
            return service.GetAllLecteur();
        }
    }
}
