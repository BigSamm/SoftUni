let dianabad = {
    name: 'Dianabad',
    longitude: '95.242',
    latitude: '94.123',
    pokemons: {
        0: {
            name: 'Pikachu',
            power: 2000,
            evolvedFrom: 'none',
            evolvesTo: 'Raichu'
        },
        1: {
            name: 'Bulbasaur',
            power: 1000,
            evolvedFrom: 'Something',
            evolvesTo: 'Something else'
        }
    }
};

renderDataInHTML(dianabad);

function renderDataInHTML(dianabad) {
    let container = $('<div class="container">');
    $('body').append(container);

    let result = $('<div class="result">');
    container.append(result);

    let location = $('<div class="location">');
    result.append(location);

    let locationName = $(`<h1 class="location-name">`);
    locationName.text('Location: ' + dianabad['name']);
    location.append(locationName);

    let locationCoordinates = $('<div class="location-coordinates">');
    location.append(locationCoordinates);

    locationCoordinates.append(
        $(`<h2 class="location-longitude">`).text('Longitude: ' + dianabad['longitude']),
        $(`<h2 class="location-latitude">`).text('Latitude: ' + dianabad['latitude']),
    );

    let allPokemons = dianabad['pokemons'];
    if(allPokemons) {
        let pokemons = $('<div class="pokemons">');
        result.append(pokemons);

        for (let pok in allPokemons) {
            let currentPok = allPokemons[pok];

            let pokemon = $('<div class="pokemon">');
            let pokemonTitle = $('<div class="pokemon-title">').text(currentPok['name']);
            pokemon.append(pokemonTitle);
            let pokemonStats = $('<div class="pokemon-stats">');
            pokemon.append(pokemonStats);

            pokemonStats.append(
                $(`<div class="pokemon-name">`).text('Name: ' + currentPok['name']),
                $(`<div class="pokemon-power">`).text('Power: ' + currentPok['power']),
                $(`<div class="pokemon-evolved-from">`).text('Evolved From: ' + currentPok['evolvedFrom']),
                $(`<div class="pokemon-evolves-to">`).text('Evolves To: ' + currentPok['evolvesTo']),
            );

            pokemons.append(pokemon);
        }
    }
}