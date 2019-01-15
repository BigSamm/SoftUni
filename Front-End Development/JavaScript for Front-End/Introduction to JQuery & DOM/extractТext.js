function extractText() {
    let result = $('ul#items li')
        .toArray()
        .map(li => li.textContent)
        .join(', ');
    $('div#result').text(result);
}