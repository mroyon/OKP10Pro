
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
                                                     $('#notificationdate').combodate('clearValue');

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowTransectionUpdate', function (event) {
        try {
            event.preventDefault();
												var notificationdate = '';
												var combonotificationdate = $('#notificationdate').val();
												if (combonotificationdate != "") {
														var dtspl1 = $('#notificationdate').val().split("-");
														notificationdate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														notificationdate = notificationdate.toISOString();
														$('#notificationdate').val(notificationdate);
													}

            var form = $('#frmUpdateWorkFlowTransection');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTransectionUpdate",
                    currenturl: window.location.href,
                    
                                        wftransectionid : $('#wftransectionid').val(),
processid : $('#processid').val(),
pkid : $('#pkid').val(),
templetid : $('#templetid').val(),
templetname : $('#templetname').val(),
levelid : $('#levelid').val(),
levelname : $('#levelname').val(),
userid : $('#userid').val(),
username : $('#username').val(),
notificationid : $('#notificationid').val(),
notificationdate : $(notificationdate).val(),
approvedby : $('#approvedby').val(),
statusid : $('#statusid').val(),
statusname : $('#statusname').val(),
comments : $('#comments').val(),
isviewed : $('#isviewed').val(),
codedtext : $('#codedtext').val(),
remarks : $('#remarks').val() 
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowTransectionUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowTransectionDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowTransectionedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowTransectionDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowTransectionedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowTransectionReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowTransection/WorkFlowTransection";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	