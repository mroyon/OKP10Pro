

//PN: FILE NAME: ""


var baseurl = $('#txtBaseUrl').val();



$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    $('body').on('change', '#masteruserid', function (event) {
        GetRoleByUser();
    });
    $('body').on('change', '#allprofile', function (event) {
        if ($(this).is(':checked')) {
            //var t = $(this).parent().parent().parent().parent().parent();
            $(this).parent().parent().parent().parent().parent().find('input[name="allProfile"]').each(function () {
                $(this).prop('checked', true);
            })
        }
        else {
            $(this).parent().parent().parent().parent().parent().find('input[name="allProfile"]').each(function () {
                $(this).prop('checked', false);
            })
        }
    });
    $('body').on('click', '#btnModalClose', function (event) {
        try {
            event.preventDefault();
            $('#mcUserwiseUnitMappingDetail').html('');
            $('#modal-container-UserwiseUnitMappingDetail').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});


