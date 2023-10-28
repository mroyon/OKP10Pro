

//PN: FILE NAME: "Newhr_attachmentinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrAttachmentInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmAttachmentInfoNew');
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

                    attachmentid: $('#attachmentid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    fromsubunitid: $('#fromsubunitid').val(),
                    fromcampid: $('#fromcampid').val(),
                    subunitid: $('#subunitid').val().length == 0 ? $('#fromsubunitid').val() : $('#subunitid').val(),
                    campid: $('#campid').val(),
                    fromdate: GetDateFromTextBox($('#fromdate').val()),
                    todate: GetDateFromTextBox($('#todate').val()),
                    reason: $('#reason').val(),
                    letterno: $('#letterno').val(),
                    letterdate: GetDateFromTextBox($('#letterdate').val()),
                    returndate: GetDateFromTextBox($('#returndate').val()),
                    returnletterno: $('#returnletterno').val(),
                    returnletterdate: GetDateFromTextBox($('#returnletterdate').val()),
                    countryid: $('#countryid').val(),
                    remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrAttachmentInfo/HrAttachmentInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrAttachmentInfo/HrAttachmentInfo";
                                            $('#mcHrAttachmentInfoNew').html('');
                                            $('#modal-container-HrAttachmentInfoNew').modal('hide');
                                            GetAllDataHrAttachmentInfo();
                                        }
                                        else {
                                            $('#mcHrAttachmentInfoNew').html('');
                                            $('#modal-container-HrAttachmentInfoNew').modal('hide');
                                            GetAllDataHrAttachmentInfo();
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
            $('#mcHrAttachmentInfoNew').html('');
            $('#modal-container-HrAttachmentInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



