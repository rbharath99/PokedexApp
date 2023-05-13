using PokedexApp.Models;

namespace PokedexApp.Service;

public interface IPokemonService
{
    public abstract Task<Pokemon> GetPokemonAsync(int id);
}