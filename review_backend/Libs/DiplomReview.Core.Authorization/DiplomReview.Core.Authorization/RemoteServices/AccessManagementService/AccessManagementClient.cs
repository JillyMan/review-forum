using DiplomReview.Core.Authorization.Exceptions;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiplomReview.Core.Authorization.RemoteServices.AccessManagementService
{
    public class AccessManagementClient
    {
        private readonly HttpClient _httpClient;

        public AccessManagementClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<UserInfo> GetUserAsync(string id)
        {
            return GetUserData<UserInfo>(
                $"/api/users('{id}')", 
                (statusCode, message) => ThrowExceptionOnFailedResponse(statusCode, message)
            );
        }

        private async Task<TType> GetUserData<TType>(string url, Action<HttpStatusCode, string> notFoundBehaviour)
            where TType : class
        {
            var response = await _httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var userInfo = await response.Content.ReadAsAsync<TType>();
                return userInfo;
            }

            notFoundBehaviour.Invoke(response.StatusCode, response.ReasonPhrase);
            return null;
        }

        private static void ThrowExceptionOnFailedResponse(HttpStatusCode statusCode, string message)
        {
            switch (statusCode)
            {
                case HttpStatusCode.NotFound:
                case HttpStatusCode.Unauthorized:
                    throw new UserNotFoundException();
                case HttpStatusCode.Forbidden:
                    throw new ReviewUnaithorizedAccessException();
                default: throw new Exception(message);
            }
        }
    }
}
