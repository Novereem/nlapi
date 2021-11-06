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
        
        public void Register(Account account)
        {
            _nlContext.Accounts.Add(account);
            _nlContext.SaveChanges();
        }
    }
}