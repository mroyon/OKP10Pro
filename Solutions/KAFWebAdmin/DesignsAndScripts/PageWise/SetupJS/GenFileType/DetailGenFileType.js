

//PN: FILE NAME: "Newgen_filetype.js"


var baseurl = $('#txtBaseUrl').val();



$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   
    $('body').on('click', '#btnModalCloseDetail', function (event) {
        try {
            event.preventDefault();
            $('#mcGenFileTypeDetail').html('');
            $('#modal-container-GenFileTypeDetail').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});


