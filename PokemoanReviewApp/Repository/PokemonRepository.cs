using PokemoanReviewApp.Data;
using PokemoanReviewApp.Interfaces;
using PokemoanReviewApp.Models;


namespace PokemoanReviewApp.Repository
{
    public class PokemonRepository:IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public bool DeletePokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemons.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int PokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == PokeId);

            if (review.Count() <= 0) 
                return 0;
            return ((decimal) review.Sum(r=>r.Rating)/  review.Count());

        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemons.Any(p => p.Id == pokeId);
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
