const host = 'https://continental-drift.firebaseio.com/continents/';

attachEvents();

function attachEvents() {
    $.ajax({
       url: host + '.json',
        success: renderContinent
    });
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

        if($(this).hasClass('showed')){
            $('.continent-data').hide();
            $('.continent-country').hide();

            $(this).removeClass('showed');

            $('.content').css('justify-content', 'space-around');

            return;
        }
        else {
            $(this).addClass('showed');
        }

        $('.continent-data').empty();
        $('.continent-country').empty();

        let continentName = $(this).text();
        $.ajax({
           url: host + continentName + '.json',
            success: renderContinentData
        });
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

    let countries = continent['countries'];
    for(let country in countries){
        let countryOption = $(`<option value="${country}">`).text(country);
        dropdownSelect.append(countryOption);
    }

    let continentImage = $('<div class="continent-image">');
    container.append(continentImage);

    let img = $(`<img src="images/${continent['name']}.png">`);
    continentImage.append(img);

    $('.dropdown-select').on('change', function () {
        $('.continent-country').empty();

        let continentName = continent['name'];
        let countryName = $(this).children(':selected').text();

        $.ajax({
            url: host + continentName + '/countries/' + countryName + '.json',
            success: renderContinentCountry
        });
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