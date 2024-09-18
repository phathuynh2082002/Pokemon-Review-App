using PokemonReivewApp.Models;

namespace PokemonReivewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
        bool CreatePokemon(Pokemon pokemon, int pokemonId, int ownerId);
        bool UpdatePokemon(Pokemon pokemon, int pokemonId, int ownerId);
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}
