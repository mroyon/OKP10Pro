﻿

//PN: FILE NAME: "Newowin_userroledetl.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveOwinUserRoleDetl', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmOwin_UserRoleDetlNew');
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

							 userroledetlid: $('#userroledetlid').val(),
							 userroleid: $('#userroleid').val(),
							 userid: $('#userid').val(),
							 roleid: $('#roleid').val(),
							 fromdate: GetDateFromTextBox($('#fromdate').val()),
							 todate: GetDateFromTextBox($('#todate').val()),
							 iscurrent: $('#iscurrent').val(),
							 iscentraladmin: $('#iscentraladmin').val(),
							 allchild: $('#allchild').val(),
							 isunitadmin: $('#isunitadmin').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinUserRoleDetl/OwinUserRoleDetlInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinUserRoleDetl/OwinUserRoleDetl";
                                            $('#mcOwinUserRoleDetlNew').html('');
                                            $('#modal-container-OwinUserRoleDetlNew').modal('hide');
                                            GetAllDataOwinUserRoleDetl();
                                        }
                                        else
                                        {
                                            $('#mcOwinUserRoleDetlNew').html('');
                                            $('#modal-container-OwinUserRoleDetlNew').modal('hide');
                                            GetAllDataOwinUserRoleDetl();
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
            $('#mcOwinUserRoleDetlNew').html('');
            $('#modal-container-OwinUserRoleDetlNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



