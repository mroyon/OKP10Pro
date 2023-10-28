
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
                                                     $('#transdate').combodate('clearValue');
                                                     $('#closeddate').combodate('clearValue');

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowTransectionInfoUpdate', function (event) {
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

            var form = $('#frmUpdateWorkFlowTransectionInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTransectionInfoUpdate",
                    currenturl: window.location.href,
                    
                                        apptransectionid : $('#apptransectionid').val(),
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

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowTransectionInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowTransectionInfoDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowTransectionInfoedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowTransectionInfoDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowTransectionInfoedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowTransectionInfoReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowTransectionInfo/WorkFlowTransectionInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	