// Ernest B. Shongwe
// Generates & validates JWT tokens
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BankingMicroservice.Utilities
{
    public static class JwtUtils
    {
        private static readonly string SecretKey = "secret_key"; // Will replace with generated secret key
        private static readonly SymmetricSecurityKey SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        private static readonly SigningCredentials SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);

        public static string GenerateJwtToken(string username)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username)
                // Will add additional claims
            };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1), // Token expiration time
                signingCredentials: SigningCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static ClaimsPrincipal ValidateJwtToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = SecurityKey,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out var validatedToken);

                return principal;
            }
            catch (Exception)
            {
                // When token validation fails
                return null;
            }
        }
    }
}
