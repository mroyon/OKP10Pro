

//PN: FILE NAME: "Newowin_reportpermission.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinReportPermission', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_ReportPermissionNew');
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

							 reportpersmissionid: $('#reportpersmissionid').val(),
							 masteruserid: $('#masteruserid').val(),
							 userid: $('#userid').val(),
							 reportroleid: $('#reportroleid').val(),
							 reportid: $('#reportid').val(),
							 isaccessible: $('#isaccessible').val(),
							 isprintable: $('#isprintable').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinReportPermission/OwinReportPermissionInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinReportPermission/OwinReportPermission";
                                            $('#mcOwinReportPermissionNew').html('');
                                            $('#modal-container-OwinReportPermissionNew').modal('hide');
                                            GetAllDataOwinReportPermission();
                                        }
                                        else
                                        {
                                            $('#mcOwinReportPermissionNew').html('');
                                            $('#modal-container-OwinReportPermissionNew').modal('hide');
                                            GetAllDataOwinReportPermission();
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
            $('#mcOwinReportPermissionNew').html('');
            $('#modal-container-OwinReportPermissionNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



