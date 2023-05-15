using Newtonsoft.Json;
using PokedexApp.Models;

namespace PokedexApp.Service;

public class PokemonService : IPokemonService
{
    private readonly HttpClient _httpClient;

    public PokemonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Pokemon> GetPokemonAsync(int id)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = await response.Content.ReadAsStringAsync();
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(jsonContent);
            Console.WriteLine(pokemon.BaseExperience);
            return pokemon;
        }
        else
        {
            return await Task.FromResult<Pokemon>(new Pokemon());
        }
    }
}