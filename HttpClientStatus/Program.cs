using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientStatus
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync("https://localhost:5001/Coordonnee/BySite/TT+T");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
