attachEvents();

function attachEvents() {
    $('.location-form>button').click(function (e) {
        e.preventDefault();

        let data = $('.location-input').val();
        $('.location-input').val('');

        let resultElement = $('<div class="result-element">').text(data);
        $('.result').append(resultElement);
    });
}
