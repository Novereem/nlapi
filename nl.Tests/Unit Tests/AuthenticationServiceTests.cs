using NUnit.Framework;
using NUnit.Framework.Internal;

namespace nl.Tests.Unit_Tests
{
    public class AuthenticationService
    {
        private readonly Logic.AuthenticationService _authenticationService;

        public AuthenticationService()
        {
            _authenticationService = new Logic.AuthenticationService();
        }

        [Test]
        public void TestGenerateToken_True()
        {
            string username = "a";
            string email = "a@a.nl";

            string token = _authenticationService.GenerateToken(username, email);
            Assert.True(token.Length > 6);
        }
    }
}