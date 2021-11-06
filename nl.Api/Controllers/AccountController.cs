using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;
using nl.Data;
using nl.Logic;

namespace NieuweLaptopApi.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        
        private readonly AccountService _accountService;

        public AccountController(INlContext nlContext)
        {
            _accountService = new AccountService(new AccountData(nlContext));
        }
        [HttpPost("/account/register")]
        public void Register(ApiAccount account)
        {
            _accountService.Register(account);
        }
        
        [HttpPost("/account/login")]
        public ApiAccount Login(ApiAccount account)
        {
            return account;
        }
    }
}