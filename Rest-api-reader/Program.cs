using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rest_api_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ REST Api Reader Console ---------- (under construction)");
            Console.WriteLine("For a pokemon API");
            string ditto = "ditto";
            List<Task<Pokemon>> list = new List<Task<Pokemon>>();
            list.Add(GetAllDataAsync(ditto));

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Result.Name.ToString();
            }


            Console.WriteLine("----------- END Pokemon API -------------------------");

        }

        private static async Task<Pokemon> GetAllDataAsync(string pokemon)
        {
            Pokemon pokemonData = new Pokemon();
            try
            {
                string URL = "https://pokeapi.co/api/v2/pokemon/" + pokemon;
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage httpResponse = await client.GetAsync(URL);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        Debug.WriteLine("Status: " + httpResponse.StatusCode);
                        var content = await client.GetStringAsync(URL);

                        pokemonData = Pokemon.FromJson(content);
                        Console.WriteLine(pokemonData.Name);
                    }
                    else
                    {
                        Debug.WriteLine("Status Error Code: " + httpResponse.StatusCode);
                    }
                }
            } catch( Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
            return pokemonData;
        }
    }
}
