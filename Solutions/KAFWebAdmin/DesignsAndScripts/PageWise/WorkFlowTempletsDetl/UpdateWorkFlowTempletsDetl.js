
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowTempletsDetlUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateWorkFlowTempletsDetl');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTempletsDetlUpdate",
                    currenturl: window.location.href,
                    
                                        templetdetlid : $('#templetdetlid').val(),
templetdetlguid : $('#templetdetlguid').val(),
templetid : $('#templetid').val(),
levelid : $('#levelid').val(),
levelno : $('#levelno').val(),
statusid : $('#statusid').val(),
infoprevonly : $('#infoprevonly').val(),
infoprevall : $('#infoprevall').val(),
infooriginator : $('#infooriginator').val(),
approvaltype : $('#approvaltype').val(),
isfinallevel : $('#isfinallevel').val(),
approvebyparent : $('#approvebyparent').val(),
approvebyoriginator : $('#approvebyoriginator').val(),
notifyifpendingforlong : $('#notifyifpendingforlong').val(),
notifyafterdays : $('#notifyafterdays').val(),
notifytouser : $('#notifytouser').val(),
emailtempletsid : $('#emailtempletsid').val(),
emailapprovalonly : $('#emailapprovalonly').val(),
emailtoall : $('#emailtoall').val(),
smstempletsid : $('#smstempletsid').val(),
smstoapprovalonly : $('#smstoapprovalonly').val(),
smstoall : $('#smstoall').val(),
nextlevelid : $('#nextlevelid').val(),
remarks : $('#remarks').val() 
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowTempletsDetlUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowTempletsDetlDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowTempletsDetledit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowTempletsDetlDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowTempletsDetledit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowTempletsDetlReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowTempletsDetl/WorkFlowTempletsDetl";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	