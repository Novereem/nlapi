using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;

namespace nl.Logic
{
    public class AccountService
    {
        private readonly IAccountData _accountData;
        public AccountService(IAccountData accountData)
        {
            _accountData = accountData;
        }

        public void Register(ApiAccount apiAccount)
        {
            Account account = new Account(apiAccount.Email,apiAccount.Username,apiAccount.Password);
            //account.Password = Hashed()
            _accountData.Register(account);
        }
    }
}