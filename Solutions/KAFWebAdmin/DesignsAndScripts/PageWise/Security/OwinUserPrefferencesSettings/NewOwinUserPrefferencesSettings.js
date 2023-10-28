

//PN: FILE NAME: "Newowin_userprefferencessettings.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinUserPrefferencesSettings', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_UserPrefferencesSettingsNew');
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

							 serialno: $('#serialno').val(),
							 userid: $('#userid').val(),
							 masteruserid: $('#masteruserid').val(),
							 appformid: $('#appformid').val(),
							 prepagesize: $('#prepagesize').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinUserPrefferencesSettings/OwinUserPrefferencesSettingsInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinUserPrefferencesSettings/OwinUserPrefferencesSettings";
                                            $('#mcOwinUserPrefferencesSettingsNew').html('');
                                            $('#modal-container-OwinUserPrefferencesSettingsNew').modal('hide');
                                            GetAllDataOwinUserPrefferencesSettings();
                                        }
                                        else
                                        {
                                            $('#mcOwinUserPrefferencesSettingsNew').html('');
                                            $('#modal-container-OwinUserPrefferencesSettingsNew').modal('hide');
                                            GetAllDataOwinUserPrefferencesSettings();
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
            $('#mcOwinUserPrefferencesSettingsNew').html('');
            $('#modal-container-OwinUserPrefferencesSettingsNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



