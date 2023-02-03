using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebsiteCarbonAPIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.websitecarbon.com/site?url=https%3A%2F%2Fwww.google.com");

                if (response.IsSuccessStatusCode)
                {
                    var carbonFootprint = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(carbonFootprint);
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
        }
    }
}
