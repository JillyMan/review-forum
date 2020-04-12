using DiplomReview.Core.Authorization.RemoteServices.AccessManagementService;
using DiplomReview.Core.Authorization.Exceptions;
using DiplomReview.Core.Authorization.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace DiplomReview.Core.Authorization.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class ReviewAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userId = context.HttpContext.User.GetUserId();
            var accessManagementClient = (IAccessManagementClient)context.HttpContext.RequestServices.GetService(typeof(IAccessManagementClient));

            if (!accessManagementClient.GetUserAsync(userId).Result.IsActive)
            {
                throw new ReviewUnaithorizedAccessException();
            }
        }
    }
}