using __ProjectName__.Application.Interfaces;
using System.Web.Http;

namespace __ProjectName__.API.Controllers
{
    [RoutePrefix("api/health")]
    public class HealthController : ApiController
    {
        private readonly IHealthService _healthService;

        public HealthController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(_healthService.GetHealth());
        }
    }
}