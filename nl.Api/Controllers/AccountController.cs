using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using nl.Commen.Interfaces;
using nl.Commen.Models.ApiModels;
using nl.Commen.Models.FrontEndModels;
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
            _accountService = new AccountService(new AccountData(nlContext), new nl.Logic.AuthenticationService());
        }
        
        [HttpPost("/account/register")]
        public void Register(ApiAccount account)
        {
            _accountService.Register(account);
        }
        
        [HttpPost("/account/login")]
        public string Login(ApiAccount account)
        {
            string hurb = _accountService.Login(account);
            return hurb;
        }
        
        
        
        [HttpGet("/account/info/{token}")]
        public ViewAccount GetAccountInfo(string token)
        {
            return _accountService.GetAccountInfo(token);
        }
    }
}