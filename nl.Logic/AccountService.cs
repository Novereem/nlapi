using System;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;
using nl.Commen.Models.FrontEndModels;

namespace nl.Logic
{
    public class AccountService : IAccountService
    {
        private readonly IAccountData _accountData;
        private readonly AuthenticationService _authenticationService;
        public AccountService(IAccountData accountData, AuthenticationService authenticationService)
        {
            _accountData = accountData;
            _authenticationService = authenticationService;
        }


        public bool Register(ApiAccount apiAccount)
        {
            Account account = new Account(apiAccount.Email,apiAccount.Username,EncryptString(apiAccount.Password));
            return _accountData.Register(account);
        }

        public string Login(ApiAccount apiAccount)
        {
            Account account = _accountData.GetAccount(apiAccount.Username);
            if (account == null)
            {
                return "/403";
            }
            return _authenticationService.GenerateToken(account.Username, account.Email);
        }

        public ViewAccount GetAccountInfo(string token)
        {
            return _authenticationService.GetAccountInformation(token);
        }

        public Account GetAccountByUsername(ApiAccount apiAccount)
        {
            return _accountData.GetAccount(apiAccount.Username);
        }

        public string EncryptString(string text)
        {
            string hash = "43&v#94nv"; // moet van local private variable komen
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                    {Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string newText = Convert.ToBase64String(results, 0, results.Length);
                    return newText;
                }
            }
        }
        
        public string DecryptString(string text)
        {
            string hash = "43&v#94nv"; // moet van local private variable komen
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                    {Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}