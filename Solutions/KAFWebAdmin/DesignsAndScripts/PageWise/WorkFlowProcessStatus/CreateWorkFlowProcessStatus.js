
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


    $('body').on('click', '#btnCreateWorkFlowProcessStatus', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmCreateWorkFlowProcessStatus');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowProcessStatusCreate",
                    currenturl: window.location.href,
                    statusname: $('#statusname').val(),
                    priority: $('#priority').val(),
                    descrioption: $('#descrioption').val(),
                    type: $('#type').val(),
                    applyforapproval: $('#applyforapproval').val(),
                    proceedtonextlevel: $('#proceedtonextlevel').val(),
                    rollbacktocreator: $('#rollbacktocreator').val(),
                    closedtheprocess: $('#closedtheprocess').val(),
                    //applyforapproval: $('#chkapplyforapproval[type="checkbox"]').is(":checked"),
                    //proceedtonextlevel: $('#chkproceedtonextlevel[type="checkbox"]').is(":checked"),
                    //rollbacktocreator: $('#chkrollbacktocreator[type="checkbox"]').is(":checked"),
                    //closedtheprocess: $('#chkclosedtheprocess[type="checkbox"]').is(":checked"),
                    remarks: $('#remarks').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "WorkFlowProcessStatus/WorkFlowProcessStatusCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateWorkFlowProcessStatus").reset();
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
            window.location.href = $('#txtBaseUrl').val() + "WorkFlowProcessStatus/WorkFlowProcessStatus";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});


