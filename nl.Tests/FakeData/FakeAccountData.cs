using System.Collections.Generic;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Tests.FakeData
{
    public class FakeAccountData : IAccountData
    {
        private List<Account> Accounts;

        public FakeAccountData()
        {
            Accounts = new List<Account>();
        }
        
        public bool Register(Account account)
        {
            Accounts.Add(account);
            return true;
        }

        /*
        public bool Register(Account account)
        {
            if (account.Email != null && account.Password != null && account.Username != null)
            {
                return true;
            }

            return false;
        }
        */

        public Account GetAccount(string username)
        {
            if (username == "username")
            {
                return new Account("email", "username", "password");
            }

            if (username == "username2")
            {
                return new Account("email", "username2", "password");
            }
            
            return null;
        }
    }
}