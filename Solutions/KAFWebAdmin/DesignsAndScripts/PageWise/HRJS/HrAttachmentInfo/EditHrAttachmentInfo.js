

//PN: FILE NAME: "Newhr_attachmentinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrAttachmentInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmAttachmentInfoEdit');
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
                    subunitid: $('#subunitid').val()==null ? $('#fromsubunitid').val() : $('#subunitid').val(),
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
                            url: baseurl + "HrAttachmentInfo/HrAttachmentInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrAttachmentInfo/HrAttachmentInfo";
                                            $('#mcHrAttachmentInfoEdit').html('');
                                            $('#modal-container-HrAttachmentInfoEdit').modal('hide');
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

    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcHrAttachmentInfoEdit').html('');
            $('#modal-container-HrAttachmentInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






