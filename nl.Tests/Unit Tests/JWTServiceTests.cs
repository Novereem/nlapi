using AuthenticationService.Managers;
using NUnit.Framework;

namespace nl.Tests.Unit_Tests
{
    public class JWTServiceTests
    {
        
        private readonly JWTService _jwtService;

        public JWTServiceTests()
        {
            _jwtService = new JWTService("TW9zaGVFcmV6UHJpdmF0ZUtleQ==");
        }


        [Test]
        public void TestIsTokenValid_ValidToken_True()
        {
        string validToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFVc2VyIiwiZW1haWwiOiJhQGEubmwiLCJuYmYiOjE2NDIxNzE0MTEsImV4cCI6MTY0Mjc3NjIxMSwiaWF0IjoxNjQyMTcxNDExfQ.0Q8ovynsiA3pcFQFOLHOmjm_z9SRevgGql9_bRpAikY";

            Assert.True(_jwtService.IsTokenValid(validToken));
        }
        
        [Test]
        public void TestIsTokenValid_InvalidToken_False()
        {
            string validToken = "yJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFVc2VyIiwiZW1haWwiOiJhQGEubmwiLCJuYmYiOjE2NDIxNzE0MTEsImV4cCI6MTY0Mjc3NjIxMSwiaWF0IjoxNjQyMTcxNDExfQ.0Q8ovynsiA3pcFQFOLHOmjm_z9SRevgGql9_bRpAikY";

            Assert.False(_jwtService.IsTokenValid(validToken));
        }
        
        
    }
}