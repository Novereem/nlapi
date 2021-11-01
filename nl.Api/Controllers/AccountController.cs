using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;

namespace NieuweLaptopApi.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        [HttpPost("/account/login")]
        public ApiAccount Login(ApiAccount account)
        {
            return account;
        }
    }
}