
var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
	$('.combodate select').each(function (index, item) {
        $(item).addClass('form-control');
        $(item).css('display', 'inline');
    });
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };


    $('body').on('click', '#btnCreateWorkFlowTempletsDetl', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmCreateWorkFlowTempletsDetl');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTempletsDetlCreate",
                    currenturl: window.location.href,
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


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "WorkFlowTempletsDetl/WorkFlowTempletsDetlCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateWorkFlowTempletsDetl").reset();
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
            window.location.href = $('#txtBaseUrl').val() + "WorkFlowTempletsDetl/WorkFlowTempletsDetl";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	
	