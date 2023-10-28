var baseurl = $('#txtBaseUrl').val();


history.pushState(null, null, location.href);
window.onpopstate = function (event) {
    history.go(1);
};

var BM = 2; // button middle
var BR = 3; // button right
var msg = "MOUSE RIGHT CLICK IS NOT SUPPORTED ON THIS PAGE";

function mouseDown(e) {
    try { if (event.button == BM || event.button == BR) { return false; } }
    catch (e) { if (e.which == BR) { return false; } }
}
//document.oncontextmenu = function () { alert(msg); return false; }
//document.ondragstart = function () { alert(msg); return false; }
document.onmousedown = mouseDown;
//******************************************************************************

$(document).click(function (e) {
    //if (e.shiftKey) {
    //    //Shift-Click
    //}
    //if (e.ctrlKey) {
    //    alert(msg); return false;
    //}
    //if (e.altKey) {
    //    alert(msg); return false;
    //}
});

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
function OnSuccessChangePass(data) {
    $('#modal-container-profile').modal('hide');
    alert('HTTP Status Code: ' + data.param1 + "  " + data.param2);
}
function OnFailureChangePass(data) {
    alert('HTTP Status Code: ' + data.param1 + '  Error Message: ' + data.param2);
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


function checkpassword() {
    try {
        var password = $("#password").val();
        var passwordsalt = $("#passwordsalt").val();
        var passwordvector = $("#passwordvector").val();

        if (password == '') {
            $("#password").val()
        }
        if (passwordsalt == '') {

        }
        if (passwordvector == '') {

        }
        $.alert({
            title: _getCookieForLanguage("_alertTitle"),
            content: password,
        });
    } catch (e) {
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

    $('body').on('click', '.lnkchangepassword', function (event) {
        event.preventDefault();
        try {
            // DisplayProgressMessage(this, 'Login...');

            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "ModalFormActionChangePassword",
                masteruserid: 2
            });


            $.ajax({
                url: baseurl + "Home/ModalFormActionChangePassword",
                data: input,
                type: 'POST',
                success: function (data) {
                    //if (data.status === "success") {
                    //    window.location.href = data.redirectUrl;
                    //}

                    $('#passchange-content').html('');
                    $('#passchange-content').html(data);
                    $('#passchange').modal({backdrop: 'static',keyboard: false});
                },
                failure: function (data) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: data.responseText,
                        type: 'red'
                    });
                },
                error: function (data) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: data.responseText,
                        type: 'red'
                    });
                }
            });
        } catch (e) {
            alert(e);
        }
    });

    $('body').on('click', '#btnchangepassword', function (event) {
        try {
            event.preventDefault();

            var $this = $(this);
            var form = $this.closest("form")
                .removeData("validator")
                .removeData("unobtrusiveValidation");

            $.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var _password = $("#password").val();
                var _passwordsalt = $("#passwordsalt").val();
                var _passwordvector = $("#passwordvector").val();

                if (_passwordsalt != _passwordvector) {
                    $.alert({
                        content: _getCookieForLanguage("_passdonotmatch"),
                        type: 'red'
                    });
                    return;
                }

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "Role_Delete",
                    currenturl: window.location.href,
                    password: _password,
                    passwordsalt: _passwordsalt,
                    passwordvector: _passwordvector
                });




                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: $('#txtBaseUrl').val() + "Home/PostModalChangePassword",
                            data: input,
                            type: 'POST',
                            async: false,
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        //$('#modal-container-changepassword').modal('hide');
                                        $('#passchange').modal("hide");
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //$('#modal-container-changepassword').modal('hide');
                                            $('#passchange').modal("hide");
                                        }
                                    });
                                }
                            }
                        });
                    }
                    else {
                        //$('#modal-container-changepassword').modal('hide');
                        $('#passchange').modal("hide");
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

});

