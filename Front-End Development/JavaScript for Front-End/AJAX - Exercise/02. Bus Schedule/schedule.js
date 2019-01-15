function solve() {
    const host = 'https://judgetests.firebaseio.com/schedule/';
    let currentId = 'depot';

    function depart() {
        $.ajax({
            url: host + currentId + '.json',
            success: departSuccess,
            error: errorFunc
        });

        function departSuccess(data) {
            $('.info').text(`Next stop ${data.name}`);

            $('#depart').attr('disabled', 'true');
            $('#arrive').removeAttr('disabled');
        }
    }

    function arrive() {
        $.ajax({
            url: host + currentId + '.json',
            success: arriveSuccess,
            error: errorFunc
        });

        function arriveSuccess(data) {
            $('.info').text(`Arriving at ${data.name}`);

            currentId = data.next;

            $('#depart').removeAttr('disabled');
            $('#arrive').attr('disabled', 'true');
        }
    }

    function errorFunc() {
        $('.info').text(`Error`);

        $('#depart').attr('disabled', 'true');
        $('#arrive').attr('disabled', 'true');
    }
    
    return {
        depart,
        arrive
    };
}
let result = solve();