function search() {
    let searchText = $('#searchText').val();
    let matches = 0;
    $('ul#towns li').each((index, item) => {
        if(item.textContent.includes(searchText)){
            $(item).css('font-weight', 'bold');
            matches++;
        }
        else
            $(item).css('font-weight', '');
    });
    $('div#result').text(matches + ' matches found.');
}