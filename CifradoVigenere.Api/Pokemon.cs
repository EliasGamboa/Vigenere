using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CifradoVigenere.Api
{
    public class Pokemon
    {
        public string Keys()
        {
            var pokemons = new List<string>();
            pokemons.Add("BULBASAUR");
            pokemons.Add("PARASECT");
            pokemons.Add("PSYDUCK");
            pokemons.Add("MAGIKARP");
            pokemons.Add("MACHOP");
            Random random = new Random();
            int index = random.Next(pokemons.Count);
            return (pokemons[index]);
        }
    }
}
    


