
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


    $('body').on('click', '#btnCreateWorkFlowProcessInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmCreateWorkFlowProcessInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowProcessInfoCreate",
                    currenturl: window.location.href,
                                        processname : $('#processname').val(),
querytoretrivedata : $('#querytoretrivedata').val(),
tablename : $('#tablename').val(),
uniquecolumn : $('#uniquecolumn').val(),
details : $('#details').val(),
remarks : $('#remarks').val() 
                                        
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "WorkFlowProcessInfo/WorkFlowProcessInfoCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateWorkFlowProcessInfo").reset();
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
            window.location.href = $('#txtBaseUrl').val() + "WorkFlowProcessInfo/WorkFlowProcessInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	
	