

//PN: FILE NAME: "NewHr_LeaveInfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnHrLeaveCancelSave', function (event) {
        try {
            event.preventDefault();

            $("#returnletterno").css("border-color", "#d2d6de");
            $("#returnletterdate").css("border-color", "#d2d6de");
         
            if ($("#returnletterno").val().length > 0 && $("#returnletterdate").val().length > 0 ) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    leaveinfoid: $('#leaveinfoid').val(),
                    hrbasicid: $('#hrbasicid').val(),

                  
                    returnletterno: $('#returnletterno').val(),
                    returnletterdate: GetDateFromTextBox($('#returnletterdate').val()),
                    remarks: $('#remarks').val(),
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrLeaveCancel/HrLeaveCancelInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrLeaveCancel/HrLeaveCancel";
                                            $('#mcHrLeaveCancelNew').html('');
                                            $('#modal-container-HrLeaveCancelNew').modal('hide');
                                            GetAllDataHrLeaveCancel($('#hrbasicid').val());
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

                if ($("#returnletterno").val().length == 0) {
                    $("#returnletterno").css("border-color","red");
                }
                if ($("#returnletterdate").val().length == 0) {
                    $("#returnletterdate").css("border-color", "red");
                }
               
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
            $('#mcHrLeaveCancelNew').html('');
            $('#modal-container-HrLeaveCancelNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






