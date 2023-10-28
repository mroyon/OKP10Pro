
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowEmailTempletsUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateWorkFlowEmailTemplets');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowEmailTempletsUpdate",
                    currenturl: window.location.href,

                    emailtempletsid: $('#emailtempletsid').val(),
                    templetname: $('#templetname').val(),
                    emailcontent: CKEDITOR.instances['emailcontent'].getData(),
                    emailsubject: $('#emailsubject').val(),
                    comments: $('#comments').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowEmailTempletsUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowEmailTempletsDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowEmailTempletsedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowEmailTempletsDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowEmailTempletsedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowEmailTempletsReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowEmailTemplets/WorkFlowEmailTemplets";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

