

//PN: FILE NAME: "Newowin_forminfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateOwinFormInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmOwin_FormInfoEdit');
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

							 appformid: $('#appformid').val(),
							 formname: $('#formname').val(),
							 parentid: $('#parentid').val(),
							 levelid: $('#levelid').val(),
							 menulevel: $('#menulevel').val(),
							 formnamear: $('#formnamear').val(),
							 hasdirectchild: $('#hasdirectchild').val(),
							 icon: $('#icon').val(),
							 classicon: $('#classicon').val(),
							 sequence: $('#sequence').val(),
							 url: $('#url').val(),
							 isview: $('#isview').val(),
							 isdynamic: $('#isdynamic').val(),
							 issuperadmin: $('#issuperadmin').val(),
							 isvisibleinmenu: $('#isvisibleinmenu').val(),
							 organizationkey: $('#organizationkey').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinFormInfo/OwinFormInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinFormInfo/OwinFormInfo";
                                            $('#mcOwinFormInfoEdit').html('');
                                            $('#modal-container-OwinFormInfoEdit').modal('hide');
                                            GetAllDataOwinFormInfo();
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
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcOwinFormInfoEdit').html('');
            $('#modal-container-OwinFormInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






