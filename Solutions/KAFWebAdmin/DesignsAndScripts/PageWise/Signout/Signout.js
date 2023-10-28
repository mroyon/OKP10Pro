var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $(".signout").on("click", function (e) {

        e.preventDefault();
        console.log(baseurl);
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_signoutConfirmation"), _getCookieForLanguage("_btnSignOut"), _getCookieForLanguage("_btnCancel")).then(function (answer) {
            if (answer == "true") {
                try {

                    // DisplayProgressMessage(this, 'Login...');

                    var input = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "DoLogin",
                        currenturl: window.location.href
                    });

                    
                    $.ajax({
                        url: baseurl + "Login/SignOut",
                        data: input,
                        type: 'POST',
                        success: function (data) {
                            if (data.status === "success") {
                                window.location.href = data.redirectUrl;
                            }
                            else {
                                window.location.href = $("#txtdomain").val();
                            }
                        },
                        failure: function (data) {
                            //$.alert({
                            //    title: _getCookieForLanguage("_informationTitle"),
                            //    content: data.responseText,
                            //    type: 'red'
                            //});
                            window.location.href = $("#txtdomain").val();
                        },
                        error: function (data) {
                            window.location.href = $("#txtdomain").val();
                        }
                    });
                } catch (e) {
                    alert(e);
                }
            }
        });
    });
});


