const host = 'https://punsh-master.firebaseio.com/data/punshes.json';

firstAJAXrequest();

function firstAJAXrequest() {
    $.ajax({
        url: host,
        success: renderAllPunshesInHTML
    });
}

function renderAllPunshesInHTML(punshes) {
    let container = $('.navbar');

    let navbarItemsDiv = $('<div class="navbar-items">');
    container.append(navbarItemsDiv);

    for(let key in punshes){
        let navbarItem = $('<div class="navbar-item">');
        navbarItemsDiv.append(navbarItem);

        let punsh = punshes[key];

        let punshNameHeader = $('<h4>' + punsh['name'] + '</h4>');
        navbarItem.append(punshNameHeader);
    }

    attachPunshesEvents(punshes);
}

let punshName;
function attachPunshesEvents(punshes) {
    $('.navbar-item').click(function (e) {
        e.preventDefault();

        $('.content').empty();
        $('.navbar-items').remove();

        punshName = $(this).text();
        $.ajax({
            url: host,
            success: renderSinglePunshInHTML
        });
    });
}

function renderSinglePunshInHTML(punshes) {
    let container = $('.content');

    let contentHeaderDiv = $('<div class="content-header">');
    container.append(contentHeaderDiv);

    let contentHeading = $('<div class="content-heading">' + punshName + '</div>');
    contentHeading.css('cursor', 'pointer');
    contentHeaderDiv.append(contentHeading);

    let punshDataDiv = $('<div class="punsh-data">');
    container.append(punshDataDiv);

    for(let key in punshes){
        let punsh = punshes[key];

        if(punsh['name'] === punshName){
            let punshTypeDiv = $('<div class="punsh-type">');
            punshDataDiv.append(punshTypeDiv);
            let punshTypeLabel = $('<label>Type: </label>');
            punshTypeDiv.append(punshTypeLabel);
            let punshType = $('<h6>' + punsh['type'] + '</h6>');
            punshTypeDiv.append(punshType);

            let punshContentsDiv = $('<div class="punsh-contents">');
            punshDataDiv.append(punshContentsDiv);
            let punshContentsLabel = $('<label>Contents: </label>');
            punshContentsDiv.append(punshContentsLabel);
            let punshContents = $('<p>' + punsh['contents'] + '</p>');
            punshContentsDiv.append(punshContents);

            let punshDescriptionDiv = $('<div class="punsh-description">');
            punshDataDiv.append(punshDescriptionDiv);
            let punshDescriptionLabel = $('<label>Description: </label>');
            punshDescriptionDiv.append(punshDescriptionLabel);
            let punshDescription = $('<p>' + punsh['description'] + '</p>');
            punshDescriptionDiv.append(punshDescription);
        }
    }

    attachBackEvents(punshes);
}

function attachBackEvents(punshes) {
    $('.content-heading').click(function (e) {
        e.preventDefault();

        $('.content').empty();
        renderAllPunshesInHTML(punshes);
    });
}