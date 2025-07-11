using Enoca.Data;
using Enoca.Interfaces;
using Enoca.Models;

namespace Enoca.Repository
{
    public class PokemonRepository:IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext Context) 
        {
            _context = Context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
           return _context.Pokemons.OrderBy(p => p.Name).ToList();
        }
    }
}
