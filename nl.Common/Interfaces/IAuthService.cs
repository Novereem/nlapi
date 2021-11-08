using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationService.Models
{
    public interface IAuthService
    {
        string SecretKey { get; set; }

        bool IsTokenValid(string token);
        string GenerateToken(IAuthContainerModel model);
        IEnumerable<Claim> GetTokenClaims(string token);
    }
}