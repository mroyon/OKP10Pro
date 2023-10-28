

//PN: FILE NAME: "Newowin_tsv.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinTSV', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_TSVNew');
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

							 serail: $('#serail').val(),
							 userid: $('#userid').val(),
							 tsvtokenrequestdate: GetDateFromTextBox($('#tsvtokenrequestdate').val()),
							 tsvtoken: $('#tsvtoken').val(),
							 isvalid: $('#isvalid').val(),
							 varificationtried: $('#varificationtried').val(),
							 validdate: GetDateFromTextBox($('#validdate').val()),
							 usersessionid: $('#usersessionid').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinTSV/OwinTSVInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinTSV/OwinTSV";
                                            $('#mcOwinTSVNew').html('');
                                            $('#modal-container-OwinTSVNew').modal('hide');
                                            GetAllDataOwinTSV();
                                        }
                                        else
                                        {
                                            $('#mcOwinTSVNew').html('');
                                            $('#modal-container-OwinTSVNew').modal('hide');
                                            GetAllDataOwinTSV();
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
            $('#mcOwinTSVNew').html('');
            $('#modal-container-OwinTSVNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



