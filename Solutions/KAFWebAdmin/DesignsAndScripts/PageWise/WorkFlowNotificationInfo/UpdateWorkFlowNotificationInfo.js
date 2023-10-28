
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
                                                     $('#dateoftransection').combodate('clearValue');
                                                     $('#vieweddate').combodate('clearValue');
                                                     $('#mailshootdatetime').combodate('clearValue');
                                                     $('#smssentdatetime').combodate('clearValue');

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowNotificationInfoUpdate', function (event) {
        try {
            event.preventDefault();
												var dateoftransection = '';
												var combodateoftransection = $('#dateoftransection').val();
												if (combodateoftransection != "") {
														var dtspl1 = $('#dateoftransection').val().split("-");
														dateoftransection = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														dateoftransection = dateoftransection.toISOString();
														$('#dateoftransection').val(dateoftransection);
													}

												var vieweddate = '';
												var combovieweddate = $('#vieweddate').val();
												if (combovieweddate != "") {
														var dtspl1 = $('#vieweddate').val().split("-");
														vieweddate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														vieweddate = vieweddate.toISOString();
														$('#vieweddate').val(vieweddate);
													}

												var mailshootdatetime = '';
												var combomailshootdatetime = $('#mailshootdatetime').val();
												if (combomailshootdatetime != "") {
														var dtspl1 = $('#mailshootdatetime').val().split("-");
														mailshootdatetime = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														mailshootdatetime = mailshootdatetime.toISOString();
														$('#mailshootdatetime').val(mailshootdatetime);
													}

												var smssentdatetime = '';
												var combosmssentdatetime = $('#smssentdatetime').val();
												if (combosmssentdatetime != "") {
														var dtspl1 = $('#smssentdatetime').val().split("-");
														smssentdatetime = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														smssentdatetime = smssentdatetime.toISOString();
														$('#smssentdatetime').val(smssentdatetime);
													}

            var form = $('#frmUpdateWorkFlowNotificationInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowNotificationInfoUpdate",
                    currenturl: window.location.href,
                    
                                        notificationid : $('#notificationid').val(),
processid : $('#processid').val(),
pkid : $('#pkid').val(),
templetid : $('#templetid').val(),
templetname : $('#templetname').val(),
levelid : $('#levelid').val(),
levelname : $('#levelname').val(),
statusid : $('#statusid').val(),
statusname : $('#statusname').val(),
transectionid : $('#transectionid').val(),
notificationforuserid : $('#notificationforuserid').val(),
username : $('#username').val(),
notificationtype : $('#notificationtype').val(),
approvaltype : $('#approvaltype').val(),
description : $('#description').val(),
codedtext : $('#codedtext').val(),
isviewed : $('#isviewed').val(),
dateoftransection : $(dateoftransection).val(),
vieweddate : $(vieweddate).val(),
viewedby : $('#viewedby').val(),
viewedbyusername : $('#viewedbyusername').val(),
remarks : $('#remarks').val(),
emailtempletsid : $('#emailtempletsid').val(),
mailsent : $('#mailsent').val(),
mailshootdatetime : $(mailshootdatetime).val(),
smstempletsid : $('#smstempletsid').val(),
smssent : $('#smssent').val(),
smssentdatetime : $(smssentdatetime).val() 
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowNotificationInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowNotificationInfoDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowNotificationInfoedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowNotificationInfoDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowNotificationInfoedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowNotificationInfoReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowNotificationInfo/WorkFlowNotificationInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	