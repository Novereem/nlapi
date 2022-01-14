using nl.Commen.Models.ApiModels;
using nl.Logic;
using nl.Tests.FakeData;
using NUnit.Framework;
using AuthenticationService = nl.Logic.AuthenticationService;

namespace nl.Tests.IntergrationTests
{
    public class AccountServiceTests
    {
        private readonly AccountService _accountService;
        private readonly Logic.AuthenticationService _authentication;

        public AccountServiceTests()
        {
            Logic.AuthenticationService authentication = new Logic.AuthenticationService();
            _accountService = new AccountService(new FakeAccountData(), authentication);
        }

        [Test]
        public void TestRegister_True()
        {
            ApiAccount apiAccount = new ApiAccount()
            {
                Email = "a@a.nl",
                Password = "a",
                Username = "aUser"
            };

            Assert.True(_accountService.Register(apiAccount));
        }
        
        [Test]
        public void TestRegister_NoUsername_False()
        {
            ApiAccount apiAccount = new ApiAccount()
            {
                Email = "a@a.nl",
                Password = "a"
            };

            Assert.False(_accountService.Register(apiAccount));
        }

        [Test]
        public void TestLogin_True()
        {
            ApiAccount apiAccount = new ApiAccount()
            {
                Email = "a@a.nl",
                Password = "a",
                Username = "aUser"
            };

            string account = _accountService.Login(apiAccount);
            
            Assert.True(account.Length > 6);
        }
        
        [Test]
        public void TestLogin_NullAccount_True()
        {
            ApiAccount apiAccount = new ApiAccount();

            string account = _accountService.Login(apiAccount);
            
            Assert.True(account == "/403");
        }

        [Test]
        public void TestGetAccountInfo_True()
        {
            ApiAccount apiAccount = new ApiAccount()
            {
                Email = "a@a.nl",
                Password = "a",
                Username = "aUser"
            };

            string account = _accountService.Login(apiAccount);

            Assert.True(_accountService.GetAccountInfo(account).Username == apiAccount.Username);
        }
        
        [Test]
        public void TestGetAccountInfo_OtherUsername_False()
        {
            ApiAccount apiAccount = new ApiAccount()
            {
                Email = "a@a.nl",
                Password = "a",
                Username = "aUser"
            };

            string account = _accountService.Login(apiAccount);

            Assert.False(_accountService.GetAccountInfo(account).Username == "b");
        }
    }
}