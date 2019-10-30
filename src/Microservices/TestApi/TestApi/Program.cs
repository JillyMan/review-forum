using System;
using System.Threading.Tasks;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        static async Task MainAsync(string[] args)
        {
            using var client = new System.Net.Http.HttpClient();
            var request = new System.Net.Http.HttpRequestMessage
            {
                RequestUri = new Uri("http://localhost:32769/WeatherForecast")
            };
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}