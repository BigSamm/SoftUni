let punshes = {
    0: {
        name: "One Punsh Man",
        type: "Strong",
        contents: "Very little Vodka, Very little Brendy, Very little Wine, Very little Whiskey, Very little Tequila and a lot of Watermelon Juice.",
        description: "This punsh was discovered in an unknown house party, when there was almost no alcohol left, and the people had to combine a little from every alchohol. One Punsh of this is enough to knock you down for good, hence the name."
    },
    1: {
        name: "Wine Punsh",
        type: "Sweet",
        contents: "Wine, Apple Juice, Ice.",
        description: "Casual Wine Punsh, for the ladies that love wine. It is not very strong, it is actually sweet. Sweet enough to make them sweetly drunk and playful."
    },
    2: {
        name: "Punsh Out",
        type: "Sweet",
        contents: "Champagne, Watermellon Juice, Ice.",
        description: "This is a very sweet, almost non-alchoholic, punsh. Very suitable for ladies, which want to keep their manners but have a little fun at a party."
    }
};

renderAllPunshesInHTML(punshes);

function attachPunshesEvents(punshes) {
    $('.navbar-item').click(function (e) {
        e.preventDefault();

        $('.content').empty();
        $('.navbar-items').remove();

        let punshName = $(this).text();
        renderSinglePunshInHTML(punshes, punshName);
    });
}

function attachBackEvents(punshes) {
    $('.content-heading').click(function (e) {
        e.preventDefault();

        $('.content').empty();
        renderAllPunshesInHTML(punshes);
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

function renderSinglePunshInHTML(punshes, punshName) {
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