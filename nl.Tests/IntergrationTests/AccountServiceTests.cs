using nl.Commen.Models;
using nl.Commen.Models.ApiModels;
using nl.Logic;
using nl.Tests.FakeData;
using NUnit.Framework;

namespace nl.Tests.IntergrationTests
{
    public class AccountServiceTests : FakeAccountData
    {
        /*
        private readonly AccountService _accountService = new(new FakeAccountData(), new Logic.AuthenticationService());
        private Account account;
        
        public AccountServiceTests()
        {
            ApiAccount apiAccount = new()
            {
                Email = "a@a.nl",
                Username = "User",
                Password = "Password"
            };
            _accountService.Register(apiAccount);
            account = _accountService.GetAccountByUsername(apiAccount);
        }

        [Test]
        public void RegisterAccount_True()
        {
            ApiAccount apiAccount = new()
            {
                Email = account.Email,
                Password = account.Password,
                Username = account.Username
            };
            
            _accountService.Register(apiAccount);
            Assert.IsTrue(_accountService.Register(apiAccount));
            
        }
        */
    }
}