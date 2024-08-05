using PMGateway.Helpers;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PMGateway.Service
{
    public class AuthService
    {
        //public string GenerateToken(ServiceUser.User user)
        public string GenerateToken(string email)
        {
            var handler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(AuthSettings.PrivateKey);
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //Subject = GenerateClaims(user),
                Subject = GenerateClaims(email),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = credentials,
            };

            var token = handler.CreateToken(tokenDescriptor);
            return handler.WriteToken(token);
        }

        //private static ClaimsIdentity GenerateClaims(ServiceUser.User user)
        private static ClaimsIdentity GenerateClaims(string email)
        {
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.Name, email));
            //claims.AddClaim(new Claim(ClaimTypes.Role, user.Role));
            //foreach (var role in user.Roles)
            //    claims.AddClaim(new Claim(ClaimTypes.Role, role));


            return claims;
        }
    }
}
