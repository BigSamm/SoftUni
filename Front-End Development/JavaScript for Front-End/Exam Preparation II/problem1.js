let continents = {
    Europe: {
        name: "Europe",
        countries: {
            Bulgaria: {
                name: "Bulgaria",
                capital: "Sofia",
                officialLanguage: "Bulgarian",
                population: 7000000,
                area: 111000,
                politicalStatus: "Republic",
                president: "Rumen Radev",
                officialCurrency: "LEV(BGN)"
            },
            Vatican: {
                name: "Vatican",
                capital: "Vatican City",
                officialLanguage: "Italian",
                population: 1000,
                area: 0.44,
                politicalStatus: "Monarchy",
                monarch: "Francis",
                officialCurrency: "Euro(EUR)"
            }
        }
    },
    Asia: {
        name: "Asia",
        countries: {
            Russia: {
                name: "Russia",
                capital: "Moscow",
                officialLanguage: "Russian",
                population: 144463451,
                area: 17075200,
                politicalStatus: "Republic",
                president: "Vladimir Putin",
                officialCurrency: "Russian ruble(RUB)"
            },
            China: {
                name: "China",
                capital: "Beijing",
                officialLanguage: "Chinese",
                population: 1403500365,
                area: 9596961,
                politicalStatus: "Republic",
                president: "Xi Jinping",
                officialCurrency: "Renminbi(CNY)"
            }
        }
    }
};

renderAllContinents(continents);
renderSingleContinent(continents['Europe']);
if(continents['Europe']['countries'] != undefined){
    renderSingleCountry(continents['Europe']['countries']['Bulgaria']);
}

function renderAllContinents(continents) {
    for(let continent in continents){
        console.log(continent);
    }

    console.log();
}


function renderSingleContinent(continent) {
    console.log(continent['name']);
    console.log('Countries:');

    let countries = (continent['countries']);
    if(countries == undefined){
        return;
    }

    for (let country in countries){
        console.log('$$$' + country);
    }

    console.log();
}

function renderSingleCountry(country) {
    console.log(country['name']);
    console.log('Capital: ' + country['capital']);
    console.log('Officia Language: ' + country['officialLanguage']);
    console.log('Population: ' + country['population']);
    console.log('Area: ' + country['area'] + ' km2');
    console.log('Political Status: ' + country['politicalStatus']);

    if(country['politicalStatus'] === "Republic") {
        console.log('President: ' + country['president']);
    }
    else if(country['politicalStatus'] === "Monarchy"){
        console.log('Monarch: ' + country['monarch']);
    }

    console.log('Official Currency: ' + country['officialCurrency']);
}