
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowProcessStatusUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateWorkFlowProcessStatus');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowProcessStatusUpdate",
                    currenturl: window.location.href,

                    statusid: $('#statusid').val(),
                    statusname: $('#statusname').val(),
                    priority: $('#priority').val(),
                    descrioption: $('#descrioption').val(),
                    type: $('#type').val(),
                    applyforapproval: $('#applyforapproval').val(),
                    proceedtonextlevel: $('#proceedtonextlevel').val(),
                    rollbacktocreator: $('#rollbacktocreator').val(),
                    closedtheprocess: $('#closedtheprocess').val(),
                    remarks: $('#remarks').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowProcessStatusUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowProcessStatusDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowProcessStatusedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowProcessStatusDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowProcessStatusedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowProcessStatusReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowProcessStatus/WorkFlowProcessStatus";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

