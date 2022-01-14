using System;
using System.Collections.Generic;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Tests.FakeData
{
    public class FakeAccountData : IAccountData
    {
        public bool Register(Account account)
        {
            if (account.Username == "aUser" && account.Email == "a@a.nl" && account.Password != "a")
            {
                return true;
            }

            return false;
        }

        public Account GetAccount(string username)
        {
            if (username == "aUser")
            {
                return new Account("a@a.nl", "aUser", "a");
            }

            return null;
        }
    }
}