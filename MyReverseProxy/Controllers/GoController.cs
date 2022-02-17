using Microsoft.AspNetCore.Mvc;

namespace MyReverseProxy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoController : ControllerBase
    {
        public Dictionary<int, string> map { get; private set; }

        


        [HttpGet(Name = "go")]
        public void Get(string key)
        {
            Response.Redirect("Https://"+ReverseProxyBL.proxiesMap[key]);
        }
        
    }
}
