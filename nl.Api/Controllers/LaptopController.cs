using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace NieuweLaptopApi.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class LaptopController : Controller
    {
        [HttpGet]
        public string Laptop()
        {
            return "bruh";
        }
    }
}