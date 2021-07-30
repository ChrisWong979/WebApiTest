using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoordonneeController : ControllerBase
    {
        [Route("BySite/{siteCode}")]
        [HttpGet]
        public string GetDdpCoordonneeBySite(string siteCode)
        {
            return $"Hello, {siteCode}";
        }
    }
}

