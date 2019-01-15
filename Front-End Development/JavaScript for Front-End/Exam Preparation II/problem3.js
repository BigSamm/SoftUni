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

attachEvents(continents);

function attachEvents(continents) {
    renderContinent(continents);
}

function renderContinent(continents) {
    let container = $('.continents');

    for(let continent in continents){
        let continentDiv = $('<div class="continent">');
        container.append(continentDiv);

        let continentTitleDiv = $(`<h5 class="continent-title">`).text(continent);
        continentDiv.append(continentTitleDiv);
    }

    $('.continent').click(function (e) {
        e.preventDefault();

        $('.continent-data').empty();
        $('.continent-country').empty();

        let $this = $(this).text();
        renderContinentData(continents[$this]);
    });
}

function renderContinentData(continent) {
    $('.content').css('justify-content', 'flex-start');

    let container = $('.continent-data');
    container.show();

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

    let continentImage = $('<div class="continent-image">');
    container.append(continentImage);

    let img = $(`<img src="images/${continent['name']}.png">`);
    continentImage.append(img);

    let countries = continent['countries'];
    if(countries == undefined){
        return;
    }

    for(let country in countries){
        let countryOption = $(`<option value="${country}">`).text(country);
        dropdownSelect.append(countryOption);
    }

    $('.dropdown-select').on('change', function () {
        $('.continent-country').empty();

        let $this = $(this).children(':selected').text();
        renderContinentCountry(continents[continent['name']]['countries'][$this]);
    })
}

function renderContinentCountry(country) {
    let container = $('.continent-country');
    container.show();

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
        $(`<div class="country-political-status"><strong>Political Status:</strong><div>${country['politicalStatus']}</div></div>`)
    );

    if(country['politicalStatus'] === 'Republick'){
        countryDataDiv.append($(`<div class="country-president"><strong>President:</strong><div>${country['president']}</div></div>`));
    }
    else if(country['politicalStatus'] === "Monarchy"){
        countryDataDiv.append($(`<div class="country-monarch"><strong>Monarch:</strong><div>${country['monarch']}</div></div>`));
    }

    countryDataDiv.append(
        $(`<div class="country-official-currency"><strong>Official Currency:</strong><div>${country['officialCurrency']}</div></div>`)
    );
}