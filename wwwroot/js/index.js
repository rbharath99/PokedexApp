function searchPokemon(query) {
    var gridItems = document.querySelectorAll('.grid-item');
    for (var i = 0; i < gridItems.length; i++) {
        var pokemonName = gridItems[i].querySelector('h2').textContent.toLowerCase();
        if (pokemonName.includes(query.toLowerCase())) {
            gridItems[i].style.display = "block";
        } else {
            gridItems[i].style.display = "none";
        }
    }
}