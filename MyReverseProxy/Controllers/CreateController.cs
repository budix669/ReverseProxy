using Microsoft.AspNetCore.Mvc;

namespace MyReverseProxy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateController : ControllerBase
    {
        [HttpPost(Name = "create")]
        public string Create(string url)
        {
            return ReverseProxy.GenerateKey(url);
        }
    }
}
