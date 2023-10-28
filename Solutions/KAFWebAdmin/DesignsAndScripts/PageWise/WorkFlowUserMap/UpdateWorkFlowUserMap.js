
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowUserMapUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateWorkFlowUserMap');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var userids = '';

                $($("#txtUser").tokenInput('get')).each(function (index) {
                    userids += $(this).attr('id') + ',';
                });


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowUserMapUpdate",
                    currenturl: window.location.href,

                    // usermapid: $('#usermapid').val(),
                    userids: userids,
                    entitykey: $('#entitykey').val(),
                    usertype: $('#usertype').val(),
                    remarks: $('#remarks').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowUserMapUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowUserMapDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowUserMapedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowUserMapDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowUserMapedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowUserMapReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowUserMap/WorkFlowUserMap";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

