var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
    //GetAllUserRoleData();
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
});

$('body').on('click', '#btnSearch', function (event) {
    event.preventDefault();
    $('#list-panel-email').empty();

    var form = $('#userEmailResetForm');
    jQuery.validator.unobtrusive.parse();
    jQuery.validator.unobtrusive.parse(form);

    if (form.valid()) {
        // alert("got data table");
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GetUserByName",
            currenturl: window.location.href,
            username: $('#txtUsername').val()
        });
        try {
            event.preventDefault();
            var divtext = "";
            $.ajax({
                url: "GetUserByName",
                data: input,
                type: 'POST',
                success: function (response) {
                    if (response.status === "success") {
                        divtext = "<div class='row'>"
                        divtext += "<div class='col-md-12'>"
                        divtext += "<div class='panel panel-default bootcards-file'>"
                        divtext += "<div class='panel-heading'>"
                        divtext += "<h3 class='panel-title'>Search Status: Found with " + $('#txtUsername').val() + "</h3>"
                        divtext += "</div>"
                        divtext += "<div class='list-group'>"

                        if (response.responsetext.UserProfilePhoto != '') {
                            divtext += "<div class='list-group-item text-center'>"
                            divtext += "<img id='imgprofileStatusApproved' src='" + response.responsetext.UserProfilePhoto + "' style='width: 20%;height:20%;'/>"
                            divtext += "</div>"
                        }

                        divtext += "<h4 class='list-group-item-text'  style='padding: 2px;'>Name: " + response.responsetext.loweredusername + ", " + response.responsetext.username + "</h4>"
                        divtext += "<p class='list-group-item-text'  style='padding: 2px;'><strong>Email: " + response.responsetext.emailaddress + "</strong></p>"
                        divtext += "<p class='list-group-item-text' style='padding: 2px;'><strong>Mobile: " + response.responsetext.mobilenumber + "</strong></p>"
                        divtext += "<p class='list-group-item-text' style='padding: 2px;'>Is Reviewed: " + response.responsetext.isreviewed + "</p>"
                        divtext += "<p class='list-group-item-text' style='padding: 2px;'>Is Locked: " + response.responsetext.locked + "</p>"
                        divtext += "<p class='list-group-item-text' style='padding: 2px;'>Is Approved: " + response.responsetext.approved + "</p>"


                        divtext += "<input id='oldemailaddress' name='oldemailaddress' type='hidden' value='" + response.responsetext.emailaddress + "' />"
                        divtext += "<input id='masteruserid' name='masteruserid' type='hidden' value='" + response.responsetext.masteruserid + "' />"
                        divtext += "<input id='userid' name='userid' type='hidden' value='" + response.responsetext.userid + "' />"

                        divtext += "<div class='list-group-item'>"
                        divtext += "<p class='list-group-item-text'>Comment: </p>"
                        divtext += "<p class='list-group-item-text'><input type='text' id='txtComment' class='form-control txtComment' value='" + response.responsetext.comment + "'></p>"
                        divtext += "</div>"

                        divtext += "<br/>"
                        divtext += "<div class='list-group-item'>"

                        divtext += "<p class='list-group-item-text'><input class='form-control text-box single-line' placeholder='Please enter email address' data-val='true' data-val-email='' data-val-required='' id='emailaddress' name='emailaddress' type='email' value=''></p>"
                        divtext += "<p class='list-group-item-text'><span class='text-danger field-validation-valid' data-valmsg-for='emailaddress' data-valmsg-replace='true'></span></p>"
                        divtext += "<p class='list-group-item-text'><div id='divnewpasswordtext'></div></p>"
                        divtext += "</div>"

                        divtext += "</div>"
                        divtext += "<div class='panel-footer text-center'>"
                        divtext += "<div class='btn-group text-center'>"
                        divtext += "<div class='btn-group'>"
                        divtext += response.responsetext.ex_nvarchar1
                        divtext += "</div>"
                        divtext += "<div class='btn-group'>"
                        divtext += response.responsetext.ex_nvarchar2
                        divtext += "</div>"
                        divtext += "</div>"
                        divtext += "</div>"
                        divtext += "</div>"
                        divtext += "</div>"
                        divtext += "</div>"

                    } else {
                        divtext = "<div class='row'>"
                        divtext += "<div class='col-md-12'>"
                        divtext += "<div class='panel panel-default bootcards-file'>"
                        divtext += "<div class='panel-heading'>"
                        divtext += "<h3 class='panel-title'>Search Status: Not Found with " + $('#txtUsername').val() + "</h3>"
                        divtext += "</div>"
                        divtext += "</div>"
                        divtext += "</div>"
                        divtext += "</div>"
                    }
                    $('#list-panel-email').append(divtext);
                }
            });
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    }
    else {
        return;
    }
});

$('body').on('click', '#btnProcessCancel', function (event) {
    event.preventDefault();

    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_cancelConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {
                $('#list-panel-email').empty();
                $('#txtUsername').val('');
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

$('body').on('click', '#btnProcess', function (event) {
    event.preventDefault();

    var form = $('#userEmailResetFormPartTwo');
    jQuery.validator.unobtrusive.parse();
    jQuery.validator.unobtrusive.parse(form);

    if (form.valid()) {
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "ResetUserEmail",
            currenturl: window.location.href,

            username: $('#txtUsername').val(),
            masteruserid: $('#masteruserid').val(),
            userid: $('#userid').val(),
            ex_nvarchar1: $('#txtComment').val(),
            emailaddress: $('#emailaddress').val(),
            ex_nvarchar2: $('#oldemailaddress').val()
        });

        try {
            confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_processConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {
                    $.ajax({
                        url: "ResetUserEmail",
                        data: input,
                        type: 'POST',
                        success: function (response) {
                            if (response.status === "success") {
                                inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    //if (answer == "true") {
                                    //     $("#divnewpasswordtext").append("New Password: " + response.newpass);
                                    //}
                                });
                                //$('#list-panel').empty();
                                $('#emailaddress').val('');
                            }
                        }
                    });
                }
            });

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    }
});

$('body').on('blur', '#emailaddress', function (event) {
    try {

        var form = $('#userEmailResetFormPartTwo');
        jQuery.validator.unobtrusive.parse();
        jQuery.validator.unobtrusive.parse(form);

        if (form.valid()) {


            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "UpdateLockStatus",
                currenturl: window.location.href,
                emailaddress: $('#emailaddress').val()
            });

            $.ajax({
                url: "GetEmailVerfication",
                data: input,
                type: 'POST',
                success: function (response) {
                    if (response.responsetext === "failed") {
                        $.alert({
                            title: _getCookieForLanguage("_informationTitle"),
                            content: _getCookieForLanguage("emailAlreadyExist"),
                            type: 'red'
                        });
                        $('#emailaddress').val('');
                        $("#emailaddress").focus();
                    }
                    else {
                        $("#btnProcess").focus();
                    }
                }
            });
        }
    } catch (e) {
        $.alert({
            title: 'information!',
            content: e.message,
            type: 'red'
        });
    }
});

