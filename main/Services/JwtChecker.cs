using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace main.Services
{
    public static class JwtChecker
    {
        public static bool IsJwtTokenValid(HttpContext httpContext, string cookieName)
        {
            var cookies = httpContext.Request.Cookies;

            if (cookies.ContainsKey(cookieName))
            {
                string jwtToken = cookies[cookieName];
                if (!string.IsNullOrEmpty(jwtToken))
                {
                    var handler = new JwtSecurityTokenHandler();
                    var jwtTokenObject = handler.ReadJwtToken(jwtToken);

                    return jwtTokenObject.ValidTo > DateTime.UtcNow;
                }
            }

            return false;
        }
    }
}
