attachEvents();

function attachEvents(){
    $('.location-form>button').click(function (e) {
        e.preventDefault();

        locationName = $('.location-input').val();
        renderData(locationName);
    });
}

function renderData(locationName) {
    const host = 'https://pokemoncodex.firebaseio.com/locations/';

    $.ajax({
       url: host + locationName + '.json',
       success: renderDataInHTML
    });

    function renderDataInHTML(data) {
        let result = $('.result').empty().css('display', 'block');

        let location = $('<div class="location">');
        result.append(location);

        let locationName = $(`<h1 class="location-name">`);
        locationName.text('Location: ' + data['name']);
        location.append(locationName);

        let locationCoordinates = $('<div class="location-coordinates">');
        location.append(locationCoordinates);

        locationCoordinates.append(
            $(`<h2 class="location-longitude">`).text('Longitude: ' + data['longitude']),
            $(`<h2 class="location-latitude">`).text('Latitude: ' + data['latitude']),
        );

        let allPokemons = data['pokemons'];
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

        attachAccordeonEvents();
    }
}

function attachAccordeonEvents() {
    $('.pokemon-title').click(function(e) {
        e.preventDefault();

        let $this = $(this);

        if ($this.next().hasClass('show')) {
            $this.next().removeClass('show');
            $this.next().slideUp(350);
        }
        else {
            $this.parent().parent().find('.pokemon-stats').removeClass('show');
            $this.parent().parent().find('.pokemon-stats').slideUp(350);
            $this.next().toggleClass('show');
            $this.next().slideToggle(350);
        }
    });
}