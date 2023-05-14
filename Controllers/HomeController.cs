using Microsoft.AspNetCore.Mvc;
using PokedexApp.Models;
using PokedexApp.Service;

namespace PokedexApp.Controllers;

public class HomeController : Controller
{
    private readonly IPokemonService _pokemonService;

    public HomeController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    public async Task<IActionResult> Index()
    {
        var pokemonList = new List<Pokemon>();
        for (int i = 1; i <= 10; i++)
        {
            Pokemon pokemon = await _pokemonService.GetPokemonAsync(i);
            pokemonList.Add(pokemon);
        }

        return View(pokemonList);
    }

    public async Task<IActionResult> Details(int id)
    {
        var pokemon = await _pokemonService.GetPokemonAsync(id);
        return View(pokemon);
    }
}
