using Microsoft.AspNetCore.Mvc;

namespace MyReverseProxy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateController : ControllerBase
    {
        [HttpPost(Name = "Create")]
        public string Create(string url)
        {
            return ReverseProxyBL.GenerateKey(url);
        }
    }
}
