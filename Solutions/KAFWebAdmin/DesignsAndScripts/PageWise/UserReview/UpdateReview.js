$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnRoleEdit', function (event) {
        try {
            event.preventDefault();

            var form = $('#roleForm');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: 'uGif4d7lgjD11QVz8IhNKYTzXhBOyzFlicZQ9uIKxKnZ1hTra84eyw==',// $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "Role_Update",
                    currenturl: window.location.href,
                    roleid: $('#roleid').val(),
                    rolename: $('#txtRolename').val(),
                    description: $('#txtdescription').val()

                });

                //console.log(JSON.stringify(input));
                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "Role_Update",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                
                                if (data.status === "success") {
                                    confirmationDialog(data.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("roleForm").reset();
                                            window.location.href = data.redirectUrl;
                                        }
                                    });
                                }
                                else {
                                    // show the error message to user
                                }
                            },
                            error: function (er) {
                                
                                //window.location.href = er.responseJSON.redirectUrl;
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
            //alert("WPCMS_CurrentActivityDetails.js: " + e.message)
        }
    });
});
