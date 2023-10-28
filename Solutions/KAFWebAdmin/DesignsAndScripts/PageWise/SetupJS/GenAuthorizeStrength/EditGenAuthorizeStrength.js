

//PN: FILE NAME: "Newgen_authorizestrength.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnUpdateGenAuthorizeStrength', function (event) {

        try {
            event.preventDefault();
            var form = $('#frmGen_AuthorizeStrengthEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var indexes = 1;
            var strValue = "";
            var isvalid = true;

            var trAuthorizeStrength = $('#GenAuthorizeStrengthDtNew').parent().parent();
            $("#GenAuthorizeStrengthDtNew tbody tr").each(function (index) {

                trAuthorizeStrength.find('#authstrength' + indexes).css("border", "1px solid #aaa");

                if (!$(this).hasClass('hidden') && (trAuthorizeStrength.find('#authstrength' + indexes).val().length == 0 || parseInt(trAuthorizeStrength.find('#authstrength' + indexes).val()) <= 0)) {
                    trAuthorizeStrength.find('#authstrength' + indexes).css("border", "1px solid red");
                    isvalid = false;
                };

                if (!$(this).hasClass('hidden')) {
                    var rankidkw = trAuthorizeStrength.find('#rankidkw' + indexes).val();
                    var groupid = trAuthorizeStrength.find('#groupid' + indexes).val();
                    var authstrength = trAuthorizeStrength.find('#authstrength' + indexes).val();
                    strValue += rankidkw + "|" + groupid + "|" + authstrength + ",";
                }
                indexes++;
            });

            if (form.valid()) {

                if (!isvalid) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "Authorized strength must be greater than 0",
                        type: 'red'
                    });
                    return;
                }

                if (strValue == "") {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "No data found",
                        type: 'red'
                    });
                    return;
                }

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    okpid: $('#okpid').val(),
                    rankid: $('#rankid').val(),
                    groupid: $('#groupid').val(),
                    remarks: $('#remarks').val(),
                    strValue1: strValue

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $('#mcGenAuthorizeStrengthEdit').html('');
                                            $('#modal-container-GenAuthorizeStrengthEdit').modal('hide');
                                            GetAllDataGenAuthorizeStrength();
                                        }
                                        else {
                                            $('#mcGenAuthorizeStrengthEdit').html('');
                                            $('#modal-container-GenAuthorizeStrengthEdit').modal('hide');
                                            GetAllDataGenAuthorizeStrength();
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
        //try {
        //    event.preventDefault();

        //    var form = $('#frmGen_AuthorizeStrengthEdit');
        //    jQuery.validator.unobtrusive.parse();
        //    jQuery.validator.unobtrusive.parse(form);




            
        //    if (form.valid()) {

        //        var input = AddAntiForgeryToken({
        //            token: $(".txtUserSTK").val(),
        //            userinfo: $(".txtServerUtilObj").val(),
        //            useripaddress: $(".txtuserip").val(),
        //            sessionid: $(".txtUserSes").val(),
        //            methodname: "HrFamilyInfoCreate",
        //            currenturl: window.location.href,

							 //okpid: $('#okpid').val(),
							 //rankid: $('#rankid').val(),
							 //groupid: $('#groupid').val(),
							 //remarks: $('#remarks').val(),


        //        });


        //        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
        //            if (answer == "true") {

        //                $.ajax({
        //                    url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthUpdate",
        //                    data: input,
        //                    type: 'POST',
        //                    success: function (data) {
        //                        if (data.status === "success") {
        //                            inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
        //                                if (answer == "true") {
        //                                   //window.location.href =  baseurl + "GenAuthorizeStrength/GenAuthorizeStrength";
        //                                    $('#mcGenAuthorizeStrengthEdit').html('');
        //                                    $('#modal-container-GenAuthorizeStrengthEdit').modal('hide');
        //                                    GetAllDataGenAuthorizeStrength();
        //                                }

        //                            });

        //                        }

        //                        else {
        //                            return;
        //                        }
        //                    }
        //                });
        //            }
        //        });
        //    }
        //    else {
        //        return;
        //    }

        //} catch (e) {
        //    $.alert({
        //        title: _getCookieForLanguage("_informationTitle"),
        //        content: e.message,
        //        type: 'red'
        //    });
        //}
    });
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcGenAuthorizeStrengthEdit').html('');
            $('#modal-container-GenAuthorizeStrengthEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






