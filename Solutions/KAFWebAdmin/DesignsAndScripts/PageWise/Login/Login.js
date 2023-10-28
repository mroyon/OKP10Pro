var baseurl = "";
$(document).ready(function () {

    baseurl = $('#txtBaseUrl').val();
    $(".reveal").on('click', function () {

        if ($(".pwd").attr('type') === 'password') {
            $(".pwd").attr('type', 'text');
        } else {
            $(".pwd").attr('type', 'password');
        }
    });
});

$(document).ready(function () {
    //$.getJSON('https://api.ipify.org/?format=json', function (data) {
    //    $('.txtuserip').val(data.ip);
    //   // $('.LoginForm').captcha();
    //    LoadQuestionCombo();
    //});

    //$.getJSON('https://ipapi.co/json/', function (data) {
    //    $('.txtuserip').val(data.ip);
    //    $('.LoginForm').captcha();
    //    LoadQuestionCombo();
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
    //LoadQuestionCombo();

    LoadAllStrength();

});


$('body').on('click', '#forgotlink', function (event) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "ForgetPasswordLoad",
            currenturl: window.location.href
        });

        $.ajax({
            url: baseurl + "Login/ForgetPasswordLoad",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcforgetpassword').html('');
                $('#mcforgetpassword').html(response);
                $('#modal-container-forgetpassword').modal({ backdrop: 'static', keyboard: false });
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



function LoadQuestionCombo() {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        //alert($(".txtuserip").val());        
        //event.preventDefault();
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "LoadQuestionCombo",
            currenturl: window.location.href
        });

        $.ajax({
            type: "POST",
            data: input,
            async: false,
            url: baseurl + "Login/LoadQuestionCombo",
            success: function (response) {
                if (response.status != "failed") {
                    var val = $.parseJSON(response);
                    var ddlQuestion = $("#ddlQuestion");
                    $.each(val, function (index, item) {
                        ddlQuestion.append($("<option></option>").val(item.Value).html(item.Text));
                    });
                }
            }
        });
    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function LoadAllStrength() {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "LoadAllStrngth",
            currenturl: window.location.href
        });

        $.ajax({
            type: "POST",
            data: input,
            async: false,
            url: baseurl + "Login/LoadAllStrngth",
            success: function (response) {
                if (response.status != "failed") {

                    var index = 1; var total = 0;

                    $.each(response, function (index, value) {
                        //console.log(value.OkpName);
                        $("#dvskill").append("<div id='dvskill" + index +"' class='col-xs-2 col-sm-2 col-md-2 text-center' style='width:14%;float:left!important;' >" +
                            " <div class='single-skill'>" +
                            "<div class='progress-circular'>" +
                            "<input type='text' class='knob'  data-min='0' data-max='" + value.PresentStrength + "' value='" + value.PresentStrength + "' data-rel='" + value.PresentStrength + "' data-linecap='round' data-width='86' data-bgcolor='#fff' data-fgcolor='#3EC1D5' data-thickness='.20' data-readonly='true' disabled>" +
                            "<h4 class='progress-h4'>" + value.OkpName + "</h4>" +
                            "</div>" +
                            "</div>" +
                            "</div>");

                        total += value.PresentStrength;
                    });

                    $(".knob").knob();
                    $("#h1hrd").text("Present BMC Strength (" + total+")");
                   
                }
            }
        });
    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnlogin', function (event) {
        try {
            event.preventDefault();
            $("#divProgressBar").show();

            var form = $('#frmLogin');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var txtUserName = $("#txtusername").val().trim();
                var txtpassword = $("#txtpassword").val().trim();

                //$("#txtusername").val('***********');
                //$("#txtpassword").val('***********');


                var key = CryptoJS.enc.Utf8.parse('8080808080808080');
                var iv = CryptoJS.enc.Utf8.parse('8080808080808080');

                var encryptedlogin = CryptoJS.AES.encrypt(CryptoJS.enc.Utf8.parse(txtUserName), key,
                    {
                        keySize: 128 / 8,
                        iv: iv,
                        mode: CryptoJS.mode.CBC,
                        padding: CryptoJS.pad.Pkcs7
                    });

                var encryptedpassword = CryptoJS.AES.encrypt(CryptoJS.enc.Utf8.parse(txtpassword), key,
                    {
                        keySize: 128 / 8,
                        iv: iv,
                        mode: CryptoJS.mode.CBC,
                        padding: CryptoJS.pad.Pkcs7
                    });

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "DoLogin",
                    currenturl: window.location.href,
                    username: encryptedlogin.toString(),
                    password: encryptedpassword.toString()
                });


                $.ajax({
                    url: baseurl + "Login/DoLogin",
                    data: input,
                    type: 'POST',
                    async: false,
                    success: function (data) {
                        if (data.status === "success") {
                            window.location.href = data.redirectUrl;
                        }
                        else {

                            $.alert({
                                title: data.title,
                                content: data.responsetext,
                                type: 'red'
                            });
                        }
                    }
                });
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_errorTitle"),
                content: e.message,
                type: 'red'
            });
        }

        $("#divProgressBar").hide();
    });

    $('body').on('click', '#btnchangepassword', function (event) {
        try {

            event.preventDefault();

            var form = $('#frmUChangePassword');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);
            $.validator.unobtrusive.parse(form);

            if (form.valid()) {

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
                    passwordquestion: $("#passwordquestion option:selected").val(),
                    passwordanswer: $("#passwordanswer").val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: baseurl + "Login/ForgetPassword",
                            data: input,
                            type: 'POST',
                            success: function (response) {
                                if (response.status === "success") {
                                    inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $('#modal-container-forgetpass').modal('hide');
                                        window.location.href = response.redirectUrl;
                                    });
                                }
                                else if (response.status === "failed") {
                                    inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $('#modal-container-forgetpass').modal('hide');
                                    });
                                }
                            }
                        });
                    }
                    else {
                        $("#username").val('');
                        $("#emailaddress").val('');
                        $("#mobilenumber").val('');
                        $("#passwordanswer").val('');
                        $('#modal-container-changepassword').modal('hide');
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_errorTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnLoginOpen', function (event) {
        try {

            $("#modal-container-Login").modal("show");


        } catch (e) {

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