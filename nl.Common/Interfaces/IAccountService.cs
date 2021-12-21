using System;
using System.Security.Cryptography;
using System.Text;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;
using nl.Commen.Models.FrontEndModels;

namespace nl.Commen.Interfaces
{
    public interface IAccountService
    {
        public bool Register(ApiAccount apiAccount);

        public string Login(ApiAccount apiAccount);

        public ViewAccount GetAccountInfo(string token);

        public string EncryptString(string text);

        public string DecryptString(string text);
    }
}