using APIFliter.Fliter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFliter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet("Time")]
        [MyLogging("Time")]
        public DateTime GetDate() { return DateTime.Now; }
        [HttpGet("Get")]
        [MyLogging("Get")]
        public string Get()
        {
            return "This is example API";
        }
    }
}
