using DiplomReview.Core.Authorization.Exceptions;
using System.Linq;
using System.Security.Claims;

namespace DiplomReview.Core.Authorization.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        private const string IdClaimType = "http://schemas.microsoft.com/identity/claims/objectidentifier";

        public static string GetUserId(this ClaimsPrincipal claimsPrincipal)
        {
            var claim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == IdClaimType);

            if (claim == null)
            {
                throw new UserNotFoundException($"Unable to find claim of type '{IdClaimType}'.");
            }

            return claim.Value;
        }
    }
}
