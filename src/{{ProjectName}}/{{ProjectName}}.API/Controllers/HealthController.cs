using System.Web.Http;

namespace __ProjectName__.API.Controllers
{
    [RoutePrefix("api/health")]
    public class HealthController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("WDP API Host is running.");
        }
    }
}