using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.Security.Src
{
    public static class JwtToken
    {
        //#region Crear Token
        public static string Create(JwtOptions configuration, string[] datos)
        {

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(configuration.Issuer,
                configuration.Audience, 
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(configuration.Expiration)),
                signingCredentials: creds);

            string _token = new JwtSecurityTokenHandler().WriteToken(token);

            return _token;
        }

        #region Validaciones
        private static TokenValidationParameters GetValidationParameters(JwtOptions configuration)
        {
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration.Key));

            return new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration.Issuer,
                ValidAudience = configuration.Audience,
                IssuerSigningKey = signingKey,
                ClockSkew = TimeSpan.Zero
            };
        }
        #endregion
    }
}
