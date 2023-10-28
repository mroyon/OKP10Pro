

//PN: FILE NAME: "Newstp_passpolicy.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveStpPassPolicy', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmStp_PassPolicyNew');
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

							 serialnopolicykey: $('#serialnopolicykey').val(),
							 categoryid: $('#categoryid').val(),
							 passexpiredays: $('#passexpiredays').val(),
							 passexpiredaysis: $('#passexpiredaysis').val(),
							 passmcontainchar: $('#passmcontainchar').val(),
							 passmcontainuchar: $('#passmcontainuchar').val(),
							 passmcontainnum: $('#passmcontainnum').val(),
							 passmcontainspchar: $('#passmcontainspchar').val(),
							 oldpasscom: $('#oldpasscom').val(),
							 newpasscomoldpass: $('#newpasscomoldpass').val(),
							 regpasscontainchar: $('#regpasscontainchar').val(),
							 regpasscontainuchar: $('#regpasscontainuchar').val(),
							 regpasscontainnum: $('#regpasscontainnum').val(),
							 regpasscontainspchar: $('#regpasscontainspchar').val(),
							 organizationkey: $('#organizationkey').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "StpPassPolicy/StpPassPolicyInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "StpPassPolicy/StpPassPolicy";
                                            $('#mcStpPassPolicyNew').html('');
                                            $('#modal-container-StpPassPolicyNew').modal('hide');
                                            GetAllDataStpPassPolicy();
                                        }
                                        else
                                        {
                                            $('#mcStpPassPolicyNew').html('');
                                            $('#modal-container-StpPassPolicyNew').modal('hide');
                                            GetAllDataStpPassPolicy();
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
            $('#mcStpPassPolicyNew').html('');
            $('#modal-container-StpPassPolicyNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



