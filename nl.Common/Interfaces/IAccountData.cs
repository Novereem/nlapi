using nl.Commen.Models;

namespace nl.Commen.Interfaces
{
    public interface IAccountData
    {
        bool Register(Account account);
        Account GetAccount(string username);
    }
}