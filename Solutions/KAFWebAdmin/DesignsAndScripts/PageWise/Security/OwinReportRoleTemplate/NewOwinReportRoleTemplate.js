

//PN: FILE NAME: "Newowin_reportroletemplate.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinReportRoleTemplate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_ReportRoleTemplateNew');
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

							 reportroletemplateid: $('#reportroletemplateid').val(),
							 reportroleid: $('#reportroleid').val(),
							 reportid: $('#reportid').val(),
							 status: $('#status').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinReportRoleTemplate/OwinReportRoleTemplateInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinReportRoleTemplate/OwinReportRoleTemplate";
                                            $('#mcOwinReportRoleTemplateNew').html('');
                                            $('#modal-container-OwinReportRoleTemplateNew').modal('hide');
                                            GetAllDataOwinReportRoleTemplate();
                                        }
                                        else
                                        {
                                            $('#mcOwinReportRoleTemplateNew').html('');
                                            $('#modal-container-OwinReportRoleTemplateNew').modal('hide');
                                            GetAllDataOwinReportRoleTemplate();
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
            $('#mcOwinReportRoleTemplateNew').html('');
            $('#modal-container-OwinReportRoleTemplateNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



