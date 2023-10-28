

//PN: FILE NAME: "Newowin_lastworkingpage.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinLastWorkingPage', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_LastWorkingPageNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);




    
            if (form.valid()) {

               
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 lastpageid: $('#lastpageid').val(),
							 appformid: $('#appformid').val(),
							 userid: $('#userid').val(),
							 masteruserid: $('#masteruserid').val(),
							 lastentrydate: GetDateFromTextBox($('#lastentrydate').val()),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinLastWorkingPage/OwinLastWorkingPageInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinLastWorkingPage/OwinLastWorkingPage";
                                            $('#mcOwinLastWorkingPageNew').html('');
                                            $('#modal-container-OwinLastWorkingPageNew').modal('hide');
                                            GetAllDataOwinLastWorkingPage();
                                        }
                                        else
                                        {
                                            $('#mcOwinLastWorkingPageNew').html('');
                                            $('#modal-container-OwinLastWorkingPageNew').modal('hide');
                                            GetAllDataOwinLastWorkingPage();
                                        }
                                    });
                                }

                                else {
                                    return;
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
    
    
    
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcOwinLastWorkingPageNew').html('');
            $('#modal-container-OwinLastWorkingPageNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



