using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            using var client = new HttpClient();
            var uri = "https://localhost:5001/Coordonnee/BySite";
            var id = "TT+T";

            var response = client.GetAsync($"{uri}/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
