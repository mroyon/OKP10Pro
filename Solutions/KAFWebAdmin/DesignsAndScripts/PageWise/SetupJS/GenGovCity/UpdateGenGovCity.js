
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnGenGovCityUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateGenGovCity');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "GenGovCityUpdate",
                    currenturl: window.location.href,

                    cityid: $('#cityid').val(),
                    parentid: $('#ddl_govcity option:selected').val(),
                    cityname: $('#cityname').val(),
                    area_code_paci: $('#area_code_paci').val(),
                    citynameend: $('#citynameend').val(),
                    isgov: $('#isgov').val(),
                    countryid: $('#ddl_country option:selected').val(),
                    remarks: $('#remarks').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "GenGovCityUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#GenGovCityDt").DataTable().ajax.reload();
                                        $('#modal-container-GenGovCityedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#GenGovCityDt").DataTable().ajax.reload();
                                            $('#modal-container-GenGovCityedit').modal('hide');
                                        }
                                    });
                                }
                            }
                        });
                    }
                });
            }
            else {
                return;
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


    $('body').on('click', '#btnGenGovCityReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "GenGovCity/GenGovCity";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

