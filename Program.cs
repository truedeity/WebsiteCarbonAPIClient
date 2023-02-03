using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebsiteCarbonModel;

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
                    var json = await response.Content.ReadAsStringAsync();
                    CarbonFootprint carbonFootprint = JsonConvert.DeserializeObject<CarbonFootprint>(json);
                    if (carbonFootprint != null && carbonFootprint.Green)
                        Console.WriteLine($"Pass. Cleaner than {carbonFootprint.CleanerThan}");
                    else
                        Console.WriteLine($"Fail. Cleaner than {carbonFootprint.CleanerThan}");
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
        }
    }
}
