using Newtonsoft.Json;

namespace PokedexApp.Models;

public class Pokemon
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; } = "";

    [JsonProperty("weight")]
    public int Weight { get; set; }

    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("base_experience")]
    public int BaseExperience { get; set; }

    [JsonProperty("types")]
    public List<PokemonType> Types { get; set; } = new List<PokemonType>();

    [JsonProperty("sprites")]
    public Sprites Sprite { get; set; } = new Sprites();
}

public class PokemonType
{
    [JsonProperty("slot")]
    public int Slot { get; set; }

    [JsonProperty("type")]
    public PokemonType2 pokemonType2 { get; set; } = new PokemonType2();
}

public class PokemonType2
{
    [JsonProperty("name")]
    public string Name { get; set; } = "";

    [JsonProperty("url")]
    public string Url { get; set; } = "";
}

public class Sprites
{
    [JsonProperty("back_default")]
    public string BackDefault { get; set; } = "";

    [JsonProperty("back_shiny")]
    public string BackShiny { get; set; } = "";

    [JsonProperty("front_default")]
    public string FrontDefault { get; set; } = "";

    [JsonProperty("front_shiny")]
    public string FrontShiny { get; set; } = "";
}