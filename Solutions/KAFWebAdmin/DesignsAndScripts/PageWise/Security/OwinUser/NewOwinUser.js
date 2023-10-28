

//PN: FILE NAME: "Newowin_user.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinUser', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_UserNew');
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

							 applicationid: $('#applicationid').val(),
							 userid: $('#userid').val(),
							 masteruserid: $('#masteruserid').val(),
							 username: $('#username').val(),
							 emailaddress: $('#emailaddress').val(),
							 loweredusername: $('#loweredusername').val(),
							 mobilenumber: $('#mobilenumber').val(),
							 userprofilephoto: $('#userprofilephoto').val(),
							 isanonymous: $('#isanonymous').val(),
							 ischildenable: $('#ischildenable').val(),
							 masprivatekey: $('#masprivatekey').val(),
							 maspublickey: $('#maspublickey').val(),
							 password: $('#password').val(),
							 passwordsalt: $('#passwordsalt').val(),
							 passwordkey: $('#passwordkey').val(),
							 passwordvector: $('#passwordvector').val(),
							 mobilepin: $('#mobilepin').val(),
							 passwordquestion: $('#passwordquestion').val(),
							 passwordanswer: $('#passwordanswer').val(),
							 approved: $('#approved').val(),
							 locked: $('#locked').val(),
							 lastlogindate: GetDateFromTextBox($('#lastlogindate').val()),
							 lastpasschangeddate: GetDateFromTextBox($('#lastpasschangeddate').val()),
							 lastlockoutdate: GetDateFromTextBox($('#lastlockoutdate').val()),
							 failedpasswordattemptcount: $('#failedpasswordattemptcount').val(),
							 comment: $('#comment').val(),
							 lastactivitydate: GetDateFromTextBox($('#lastactivitydate').val()),
							 isapproved: $('#isapproved').val(),
							 approvedby: $('#approvedby').val(),
							 approvedbyusername: $('#approvedbyusername').val(),
							 approveddate: GetDateFromTextBox($('#approveddate').val()),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinUser/OwinUserInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinUser/OwinUser";
                                            $('#mcOwinUserNew').html('');
                                            $('#modal-container-OwinUserNew').modal('hide');
                                            GetAllDataOwinUser();
                                        }
                                        else
                                        {
                                            $('#mcOwinUserNew').html('');
                                            $('#modal-container-OwinUserNew').modal('hide');
                                            GetAllDataOwinUser();
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
            $('#mcOwinUserNew').html('');
            $('#modal-container-OwinUserNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



