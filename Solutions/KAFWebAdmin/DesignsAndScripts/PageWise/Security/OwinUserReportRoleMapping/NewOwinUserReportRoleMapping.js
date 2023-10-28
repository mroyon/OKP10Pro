

//PN: FILE NAME: "Newowin_reportrole.js"

var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });
});

$('body').on('change', '#masteruserid', function (event) {
    GetReportRoleByUser();
});

$('body').on('click', '#btnSaveOwinUserReportRole', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwinUserReportRoleMapping');
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

				    reportroleid: $('#reportroleid').val(),
                    masteruserid: $('#masteruserid').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinUserReportRoleMapping/OwinUserReportRoleMappingInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            window.location.href = baseurl + "OwinUserReportRoleMapping/OwinUserReportRoleMapping";
                                            //$('#mcOwinReportRoleNew').html('');
                                            //$('#modal-container-OwinReportRoleNew').modal('hide');
                                           
                                        }
                                        else
                                        {
                                            //$('#mcOwinReportRoleNew').html('');
                                            //$('#modal-container-OwinReportRoleNew').modal('hide');
                                           
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


function GetReportRoleByUser() {
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    var input = AddAntiForgeryToken({
        token: 'uGif4d7lgjD11QVz8IhNKYTzXhBOyzFlicZQ9uIKxKnZ1hTra84eyw==',
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "GetReportRoleByUser",
        currenturl: window.location.href,
        masteruserid: $("#masteruserid").val()
    });
    
    try {
        $.ajax({
            url: $("#txtBaseUrl").val() + "/OwinUserReportRoleMapping/GetReportRoleByUser",
            data: input,
            type: 'POST',
            success: function (data) {
                if (data.status === "success") {
                    var res = data.data;
                    var preloadarray = [];
                    if (res.length != 0) {
                        preloadarray.push(res[0].comId);
                    }
                    $('#reportroleid').val(preloadarray);
                    $('#reportroleid').trigger('change');
                } 
            },
            error: function (er) {
                window.location.href = er.responseJSON.redirectUrl;
            }
        });
    } catch (e) {
    }
}



