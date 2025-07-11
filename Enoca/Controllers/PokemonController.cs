using Enoca.Data;
using Enoca.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Enoca.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PokemonController:Controller
    {
        private readonly IPokemonRepository _pokemonrepository;
        private readonly DataContext context;

        public PokemonController(IPokemonRepository pokemonrepository,DataContext context)
        {
            _pokemonrepository = pokemonrepository;
            this.context = context;
        }
        [HttpGet]
        [ProducesResponseType(200 , Type = typeof(IEnumerable<Enoca.Models.Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonrepository.GetPokemons();
            if (!ModelState.IsValid)
            
                return BadRequest(ModelState);
                return Ok(pokemons);
            
        }
    }
}
