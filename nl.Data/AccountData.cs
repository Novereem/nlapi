using System.Linq;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class AccountData : IAccountData
    {
        private readonly INlContext _nlContext;
        public AccountData(INlContext nlContext)
        {
            _nlContext = nlContext;
        }
        
        public bool Register(Account account)
        {
            if (account.Email != null || account.Password != null || account.Username != null)
            {
                _nlContext.Accounts.Add(account);
                _nlContext.SaveChanges();
                return true;
            }

            return false;
        }

        public Account GetAccount(string username)
        {
            return _nlContext.Accounts.FirstOrDefault(u => u.Username == username);
        }
    }
}