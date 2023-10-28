
var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
                                                     $('#transdate').combodate('clearValue');
                                                     $('#closeddate').combodate('clearValue');
	$('.combodate select').each(function (index, item) {
        $(item).addClass('form-control');
        $(item).css('display', 'inline');
    });
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };


    $('body').on('click', '#btnCreateWorkFlowTransectionInfo', function (event) {
        try {
            event.preventDefault();
												var transdate = '';
												var combotransdate = $('#transdate').val();
												if (combotransdate != "") {
														var dtspl1 = $('#transdate').val().split("-");
														transdate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														transdate = transdate.toISOString();
														$('#transdate').val(transdate);
													}

												var closeddate = '';
												var combocloseddate = $('#closeddate').val();
												if (combocloseddate != "") {
														var dtspl1 = $('#closeddate').val().split("-");
														closeddate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
														closeddate = closeddate.toISOString();
														$('#closeddate').val(closeddate);
													}


            var form = $('#frmCreateWorkFlowTransectionInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTransectionInfoCreate",
                    currenturl: window.location.href,
                                        pkid : $('#pkid').val(),
tablename : $('#tablename').val(),
pkcolumnname : $('#pkcolumnname').val(),
status : $('#status').val(),
isclosed : $('#isclosed').val(),
isnew : $('#isnew').val(),
description : $('#description').val(),
transdate : $(transdate).val(),
closeddate : $(closeddate).val(),
remarks : $('#remarks').val() 
                                        
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "WorkFlowTransectionInfo/WorkFlowTransectionInfoCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateWorkFlowTransectionInfo").reset();
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
            window.location.href = $('#txtBaseUrl').val() + "WorkFlowTransectionInfo/WorkFlowTransectionInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	
	