var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {

});

$(document).ready(function () {

    //$.getJSON('https://api.ipify.org/?format=json', function (data) {
    //    $('.txtuserip').val(data.ip);
    //});

    //$.getJSON('https://ipapi.co/json/', function (data) {
    //    $('.txtuserip').val(data.ip);
    //});

    //$.ajax({
    //    url: baseurl + "home/GetClientIPAddress",
    //    //data: input,
    //    type: 'POST',
    //    async: false,
    //    success: function (data) {
    //        //console.log(data);
    //        $('.txtuserip').val(data.data);
    //    }
    //});    
});


$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnchangepasswordrequest', function (event) {
        try {

            event.preventDefault();

            var form = $('#frmUChangePasswordRequest');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);
            $.validator.unobtrusive.parse(form);

            if (form.valid()) {

                if ($("#passwordanswer").val() == '') {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: _getCookieForLanguage("_provideAuthCode"),
                        type: 'red'
                    });
                    return false;
                }

                if ($("#passwordsalt").val() == '') {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: _getCookieForLanguage("_confirmNewPassword"),
                        type: 'red'
                    });
                    return false;
                }

                if ($("#passwordsalt").val() != $("#password").val()) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: _getCookieForLanguage("_passwordMissmatch"),
                        type: 'red'
                    });
                    return false;
                }


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "Update_Profile",
                    currenturl: window.location.href,

                    username: $("#username").val(),
                    emailaddress: $("#emailaddress").val(),
                    mobilenumber: $("#mobilenumber").val(),
                    passwordanswer: $("#passwordanswer").val(),
                    password: $("#password").val(),
                    passwordsalt: $("#passwordsalt").val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_resetPasswordConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: baseurl + "ForgetPassword/ForgetPasswordRequest",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {

                                        window.location.href = data.redirectUrl;
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                        }
                                    });
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
            $("#divjobapply_loader").hide();
        }
    });
});



function CallLanguageShifter(lan) {
    try {
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "CallLanguageShifter",
            currenturl: window.location.href,
            username: lan,
            password: lan
        });


        $.ajax({
            url: baseurl + "Login/CallLanguageShifter",
            data: input,
            type: 'POST',
            async: false,
            success: function (data) {
                if (data.status === "success") {

                }
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
    $("#divProgressBar").hide();
}

function readCookieForLanguage(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}
function _getCookieForLanguage(str) {
    try {
        var whichlang = readCookieForLanguage("_culture");
        if (whichlang == '')
            whichlang = 'en-us';

        var data = JSON.parse($("#txtCommonLanguages").val());
        if (data != "") {

            var searchText = '';
            var i = null;
            for (i = 0; data.resource.length > i; i += 1) {
                if (data.resource[i].culture === whichlang && data.resource[i].name === str) {
                    searchText = data.resource[i].value;
                    break;
                }
            }
            return searchText;
        }
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}