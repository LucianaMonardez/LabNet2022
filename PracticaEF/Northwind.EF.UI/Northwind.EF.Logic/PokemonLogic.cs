using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.EF.Logic
{
    public class PokemonLogic
    {
        public async Task<string> PokemonEevee()
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon/eevee");
        }
    }
}
