

//PN: FILE NAME: "Newuseraccountsprof.js"


var baseurl = $('#txtBaseUrl').val();



$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   
    $('body').on('click', '#btnModalCloseDetail', function (event) {
        try {
            event.preventDefault();
            $('#mcUserAccountsProfDetail').html('');
            $('#modal-container-UserAccountsProfDetail').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});


