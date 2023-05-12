using Microsoft.AspNetCore.Mvc;
using PokedexApp.Models;
using Newtonsoft.Json;

namespace PokedexApp.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {
        HttpResponseMessage response = await _httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/1");

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = await response.Content.ReadAsStringAsync();
            Pokemon? pokemon = JsonConvert.DeserializeObject<Pokemon>(jsonContent);
            return View(pokemon);
        }
        else
        {
            return View("Error");
        }
    }
}
