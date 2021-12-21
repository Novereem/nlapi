using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Logic;
using nl.Tests.FakeData;
using NUnit.Framework;

namespace nl.Tests.Unit_Tests
{
    public class AccountTests : FakeAccountData
    {
        private readonly IAccountData _accountData = new FakeAccountData();

        [Test]
        public void Register_FullAccountTrue()
        {
            Account account = new Account("email", "username", "password");
            Assert.IsTrue(_accountData.Register(account));
        }
        
        [Test]
        public void Register_PartialAccountFalse()
        {
            Account account = new Account("email", "username", null);
            Assert.IsFalse(_accountData.Register(account));
        }

        [Test]
        public void GetAccount_KnownUsername()
        {
            bool accountExists = false;
            Account account = _accountData.GetAccount("username");
            if (account != null)
            {
                accountExists = true;
            }

            Assert.IsTrue(accountExists);
        }
        
        [Test]
        public void GetAccount_UnknownUsername()
        {
            bool accountExists = false;
            Account account = _accountData.GetAccount("anotherusername");
            if (account != null)
            {
                accountExists = true;
            }

            Assert.IsFalse(accountExists);
        }
    }
}