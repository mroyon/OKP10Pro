
var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
                                                     $('#notificationdate').combodate('clearValue');
	$('.combodate select').each(function (index, item) {
        $(item).addClass('form-control');
        $(item).css('display', 'inline');
    });
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };


    $('body').on('click', '#btnCreateWorkFlowTransection', function (event) {
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


            var form = $('#frmCreateWorkFlowTransection');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTransectionCreate",
                    currenturl: window.location.href,
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


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "WorkFlowTransection/WorkFlowTransectionCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateWorkFlowTransection").reset();
                                            return
                                        }
                                        else if (answer == "false") {
                                            window.location.href = data.redirectUrl;
                                        }
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
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


    $('body').on('click', '#btnReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = $('#txtBaseUrl').val() + "WorkFlowTransection/WorkFlowTransection";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	
	