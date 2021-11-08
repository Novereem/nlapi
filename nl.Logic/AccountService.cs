using System.Security.Claims;
using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;

namespace nl.Logic
{
    public class AccountService
    {
        private readonly IAccountData _accountData;
        private readonly AuthenticationService _authenticationService;
        public AccountService(IAccountData accountData, AuthenticationService authenticationService)
        {
            _accountData = accountData;
            _authenticationService = authenticationService;
        }
        public void Register(ApiAccount apiAccount)
        {
            Account account = new Account(apiAccount.Email,apiAccount.Username,apiAccount.Password);
            //account.Password = Hashed()
            _accountData.Register(account);
        }

        public string Login(ApiAccount apiAccount)
        {
            //getJwtContainerModel(apiAccount.Username,apiAccount.Password);

            /*if (_accountData.Login(account))
            {
                return _authenticationService.GenerateToken(account.Username, account.Email);
            }*/
            Account account = _accountData.GetAccount(apiAccount.Username);
            if (account.Password != apiAccount.Password || account.Username != apiAccount.Username)
            {
                return "wrong password or username";
            }
            return _authenticationService.GenerateToken(account.Username, account.Email);
        }

        public string GetAccountInfo(string token)
        {
            return _authenticationService.GetUsername(token);
        }
    }
}