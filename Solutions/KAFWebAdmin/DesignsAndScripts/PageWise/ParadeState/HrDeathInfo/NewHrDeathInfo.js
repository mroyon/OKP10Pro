

//PN: FILE NAME: "Newhr_deathinfo_history.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrDeathInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_DeathInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);


            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    deathinfoid: $('#deathinfoid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    deathdate: GetDateFromTextBox($('#deathdate').val()),
                    deathreason: $('#deathreason').val(),
                    remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrDeathInfo/HrDeathInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrDeathInfo/HrDeathInfo";
                                            $('#mcHrDeathInfoNew').html('');
                                            $('#modal-container-HrDeathInfoNew').modal('hide');
                                            GetAllDataHrDeathInfo($('#hrbasicid').val());
                                        }
                                        else {
                                            $('#mcHrDeathInfoNew').html('');
                                            $('#modal-container-HrDeathInfoNew').modal('hide');
                                            GetAllDataHrDeathInfo($('#hrbasicid').val());
                                        }
                                    });
                                }

                                else {
                                    return;
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



    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcHrDeathInfoNew').html('');
            $('#modal-container-HrDeathInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



