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

        Pokemon pokemon = await _pokemonService.GetPokemonAsync(1);
        return View(pokemon);
    }
}
