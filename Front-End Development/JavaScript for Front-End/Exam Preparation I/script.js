let location = {
    name: 'Izgrev',
    longitude: '95.243',
    latitude: '94.231',
    pokemons: {
        0: {
            name: 'Pikachu',
            power: 2000,
            evolvedFrom: 'none',
            evolvesTo: 'Raichu'
        },
        1: {
            name: 'Wartortle',
            power: 500,
            evolvedFrom: 'Squirtle',
            evolvesTo: 'Blastoise'
        },
        2: {
            name: 'CherryBerry',
            power: 9999,
            evolvedFrom: 'Cherry',
            evolvesTo: 'Berry'
        }
    }
};

renderData(location);

function renderData(location) {
    console.log('Location: ' + location['name']);
    console.log('Longitude: ' + location['longitude'] + ' Latitude: ' + location['latitude']);

    let pokemons = location['pokemons'];
    if(pokemons){
        console.log('Pokemons:');
        for (let pok in pokemons) {
            let currentPok = pokemons[pok];
            console.log('###Name: ' + currentPok['name']);
            console.log('###Power: ' + currentPok['power'] + 'pp');
            console.log('###Evolved From: ' + currentPok['evolvedFrom']);
            console.log('###Evolves To: ' + currentPok['evolvesTo']);
        }
    }
}