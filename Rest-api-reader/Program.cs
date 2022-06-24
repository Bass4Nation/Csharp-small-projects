using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rest_api_reader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("------ REST Api Reader Console ---------- (under construction)");
            Console.WriteLine("For a pokemon API");
            string pokemon = "ditto";
            string URL = "https://pokeapi.co/api/v2/pokemon/" + pokemon;
            using var client = new HttpClient();

            var content = await client.GetStringAsync(URL);
            fromJson
            Console.WriteLine(content);

            Console.WriteLine("----------- END Pokemon API -------------------------");

        }
    }
}
