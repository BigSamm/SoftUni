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
            }
        }
    }
};

renderDataInHTML(continents);

function renderDataInHTML(continents) {
    renderContinent(continents);
    renderContinentData(continents['Europe']);
    if(continents['Europe']['countries'] != undefined){
        renderContinentCountry(continents['Europe']['countries']['Bulgaria']);
    }
}

function renderContinent(continents) {
    let container = $('.continents');

    let continentDiv = $('<div class="continent">');
    container.append(continentDiv);

    for(let continent in continents){
        let continentTitleDiv = $(`<h5 class="continent-title">`).text(continent);
        continentDiv.append(continentTitleDiv);
    }
}

function renderContinentData(continent) {
    let container = $('.continent-data');

    let continentTitleDiv = $('<h2 class="continent-title">').text(continent['name']);
    container.append(continentTitleDiv);

    let countryTitleDiv = $('<h3 class="countries-title">Countries</h3>');
    container.append(countryTitleDiv);

    let countriesDiv = $('<div class="countries">');
    container.append(countriesDiv);

    let dropdownSelect = $('<select class="dropdown-select">');
    countriesDiv.append(dropdownSelect);

    let defaultOption = $('<option disabled selected value> -- select an option -- </option>');
    dropdownSelect.append(defaultOption);

    let countries = continent['countries'];
    if(countries == undefined){
        return;
    }

    for(let country in countries){
        let countryOption = $(`<option value="${country}">`).text(country);
        dropdownSelect.append(countryOption);
    }

    let continentImage = $('<div class="continent-image">');
    container.append(continentImage);

    let img = $(`<img src="images/${continent['name']}.png">`);
    continentImage.append(img);
}

function renderContinentCountry(country) {
    let container = $('.continent-country');

    let countryTitleDiv = $('<div class="country-title">');
    container.append(countryTitleDiv);

    let countryName = $('<h2>').text(country['name']);
    countryTitleDiv.append(countryName);

    let countryDataDiv = $('<div class="country-data">');
    container.append(countryDataDiv);

    countryDataDiv.append(
        $(`<div class="country-capital"><strong>Capital:</strong> <div>${country['capital']}</div></div>`),
        $(`<div class="country-official-language"><strong>Official Language:</strong><div>${country['officialLanguage']}</div></div>`),
        $(`<div class="country-population"><strong>Population:</strong> <div>${country['population']}</div></div>`),
        $(`<div class="country-area"><strong>Area:</strong> <div>${country['area']} km<sup>2</sup></div></div>`),
        $(`<div class="country-political-status"><strong>Political Status:</strong><div>${country['politicalStatus']}</div></div>`),
        $(`<div class="country-president"><strong>President:</strong><div>${country['president']}</div></div>`),
        $(`<div class="country-official-currency"><strong>Official Currency:</strong><div>${country['officialCurrency']}</div></div>`)
    );
}