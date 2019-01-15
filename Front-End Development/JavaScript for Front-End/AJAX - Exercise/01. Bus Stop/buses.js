function getInfo() {
    const host = 'https://judgetests.firebaseio.com/businfo/';
    const stopId = $('#stopId').val();

    $('#stopName').empty();
    $('#buses').empty();
    $.ajax({
        url: host + stopId + '.json',
        success: displayInfo,
        error: displayError
    });

    function displayInfo(data) {
        console.log(data);
        $('#stopName').text(data.name);

        for(let arrival in data.buses){
            $('#buses').append(`<li>Bus ${arrival} arrives in ${data.buses[arrival]} minutes</li>`);
        }
    }

    function displayError() {
        $('#stopName').text('Error');
    }

}