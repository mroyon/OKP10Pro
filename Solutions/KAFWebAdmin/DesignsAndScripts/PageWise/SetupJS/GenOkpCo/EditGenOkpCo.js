

//PN: FILE NAME: "Newgen_okpco.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateGenOkpCo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmGen_OkpCoEdit');
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

							 okpcoid: $('#okpcoid').val(),
							 okpid: $('#okpid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 fromdate: GetDateFromTextBox($('#fromdate').val()),
							 todate: GetDateFromTextBox($('#todate').val()),
							 iscurrent: $('#iscurrent').val(),
							 remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenOkpCo/GenOkpCoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenOkpCo/GenOkpCo";
                                            $('#mcGenOkpCoEdit').html('');
                                            $('#modal-container-GenOkpCoEdit').modal('hide');
                                            GetAllDataGenOkpCo();
                                        }

                                    });

                                }

                                else {
                                    $.alert({
                                        title: _getCookieForLanguage("_informationTitle"),
                                        content: "Data already exists",
                                        type: 'red'
                                    });
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
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcGenOkpCoEdit').html('');
            $('#modal-container-GenOkpCoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






