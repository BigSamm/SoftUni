let punshes = {
    0: {
        name: "Punsh - The American Pie",
        type: "Strong",
        contents: "Some Apple Pie, Whiskey, Vodka, Orange Juice and some other things...",
        description: "By original recipe from the American Pie franchise, this punsh includes everything you would want in a college/university party."
    },
    1: {
        name: "Brendy Punsh",
        type: "Medium",
        contents: "Brendy, Apple Juice, Ice, Avocado Juice, some other strange fruits...",
        description: "The casual Brendy Punsh, quite expensive, nothing interesting here..."
    },
    2: {
        name: "Just Punsh it",
        type: "Sweet",
        contents: "Very Little Vodka, Orange Juice, Apple Juice, Banana Juice, Ice.",
        description: "A very comfortable taste for the lovers of weakly alchoholic drinks. The Just Pinsh It punsh is a sweet multi-vitamol drink, which cannot drunk you."
    }
};

//renderAllPunshesInHTML(punshes);
renderSinglePunshInHTML(punshes, "Punsh - The American Pie");

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
}