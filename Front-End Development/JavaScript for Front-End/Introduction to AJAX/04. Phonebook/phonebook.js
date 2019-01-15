$(() => {
    const host = 'https://phonebook-nakov-292bf.firebaseio.com/phonebook/';
    const list = $('#phonebook');
    const personInput = $('#person');
    const phoneInput = $('#phone');
    $('#btnLoad').click(loadPhonebook);
    $('#btnCreate').click(createContact);

    function loadPhonebook() {
        $('#phonebook').empty();
        $.ajax({
            url: host + '.json',
            success: displayPhonebook
        });

        function displayPhonebook(data) {
            for(let key in data){
                let entry = data[key];
                appendContact(entry, key);
            }
        }
    }

    function appendContact(entry, key) {
        const contact = $(`<li data-id="${key}">${entry.person}: ${entry.phone}</li>`);
        let deleteBtn = $(' <button>Delete</button>');

        deleteBtn.click(deleteContact);
        function deleteContact() {
            const item = $(this).parent();
            $.ajax({
                url: host + item.attr('data-id') + '.json',
                method: 'DELETE',
                success: deleteSuccess
            });

            function deleteSuccess() {
                item.remove();
            }
        }

        contact.append(deleteBtn);
        list.append(contact);
    }

    function createContact() {
        const person = personInput.val();
        const phone = phoneInput.val();

        if(person.length < 1 || phone.length < 1){
            return;
        }

        $.ajax({
           url: host + '.json',
            method: 'POST',
            data: JSON.stringify({person, phone}),
           success: createSuccess
        });
        
        function createSuccess(data) {
            let person = personInput.val();
            let phone = phoneInput.val();
            personInput.val('');
            phoneInput.val('');
            appendContact({person, phone});
        }
    }
});