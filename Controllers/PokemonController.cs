using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ny_mapp.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strength = 67},
            new Pokemon() {Name = "Bulbasaur", Strength = 200},
            new Pokemon() {Name = "Eva-Lena", Strength = 9001}
        };

        [HttpGet] //Svarar på get requests
        public ActionResult MyPerfectGet()
        {
            /*Pokemon p = new Pokemon();
            p.Name = "Ekans";
            p.Strength = 67;*/

            return Ok(pokemons);
        }

        [HttpPost] //Svarar på get posts

        public ActionResult AddNewPokemon(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine("Created pokemon");

            return Created("", newPokemon);
        }

    }

    public class Pokemon
    {
        private string _name;
        private int _strength;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                _strength = value;
            }
        }

    }
}