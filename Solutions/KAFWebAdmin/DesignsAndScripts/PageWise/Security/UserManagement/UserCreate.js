var baseurl = $('#txtBaseUrl').val();
var role_values = '', mname = 'SaveUser';

function deleteButUSer() {
    var s = $("#imgprofile").attr("src");
    if (s == "undefined")
        $('#btnRemoveImage').addClass(' hidden ');
    else {
        if (s.indexOf("NoProfileImage") >= 0)
            $('#btnRemoveImage').addClass(' hidden ');
        else
            $('#btnRemoveImage').removeClass(' hidden ');
    }
}


$(document).ready(function () {
    $('input[type="checkbox"]').on('change', function () {
        $('input[type="checkbox"]').not(this).prop('checked', false);
    });
    deleteButUSer();
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    //$('body').on('click', '.chkclass', function (event) {
    //    role_values = role_values + $(this).val() + ',';
    //});

    $('body').on('click', '#btnAttachment', function (event) {
        try {
            event.preventDefault();
            $("#attachment").trigger("click");
            return false;

        } catch (e) {
            alert(e);
        }
    });

    $('body').on('change', '#attachment', function (event) {
        try {
            var $fileElement = $(this);
            var frmdata = new FormData();
            var totalFiles = $fileElement[0].files.length;
            for (var i = 0; i < totalFiles; i++) {
                var file = $fileElement[0].files[i];
                frmdata.append("attachment", file);
                frmdata.append("actualtotalfiles", 1);
                frmdata.append("__RequestVerificationToken", $('input[name=__RequestVerificationToken]').val());

                frmdata.append("token", $(".txtUserSTK").val());
                frmdata.append("userinfo", $(".txtServerUtilObj").val());
                frmdata.append("useripaddress", $(".txtuserip").val());
                frmdata.append("sessionid", $(".txtUserSes").val());
                frmdata.append("methodname", "Update_Profile");
                frmdata.append("currenturl", window.location.href);
            }
            $.ajax({
                url: baseurl + "UserManagement/UploadAttachment/",
                cache: false,
                processData: false,
                contentType: false,
                type: 'POST',
                data: frmdata,
                success: function (response) {
                    if (response.status == "success") {
                        $('#imgprofile').attr('src', response.title);
                        deleteButUSer();
                    }
                },
                xhr: function () {  // Custom XMLHttpRequest
                    var myXhr = $.ajaxSettings.xhr();
                    if (myXhr.upload) { // Check if upload property exists
                        myXhr.upload.addEventListener('progress', progressHandlingFunction, false); // For handling the progress of the upload
                    }
                    return myXhr;
                },
            });

        } catch (e) {

        }
    });

    $('body').on('click', '#btnRemoveImage', function (event) {
        try {
            event.preventDefault();


            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "Role_Delete",
                currenturl: window.location.href,
                UserProfilePhoto: $("#imgprofile").attr("src")
            });

            confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {
                    $.ajax({
                        url: baseurl + "UserManagement/DeleteAttachment",
                        data: input,
                        type: 'POST',
                        async: false,
                        success: function (response) {
                            if (response.status === "success") {
                                inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    $('#imgprofile').attr('src', response.redirectUrl); deleteButUSer();
                                });
                            }
                        }
                    });
                }
            });
        } catch (e) {
            alert(e);
        }
        deleteButUSer();
    });

    $('body').on('click', '.btnSaveUser', function (event) {
        try {

            event.preventDefault();

            var roleval = '';
            var strinput = '';
            userrole = $('#roleid').val();
            $.each(userrole, function (key, value) {
                // Create a hidden element 
                strinput += value + ",";
            });
            if (strinput.length > 0) {
                roleval = strinput.substr(0, strinput.length - 1);
            }
            //console.log(roleval)
            var userimage = $("#imgprofile").attr("src");
            if (userimage == "")
                userimage = baseurl + "DesignsAndScripts/Images/NoProfileImage.png";


            var form = $('#frmCreateUser');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                //if (role_values == '') {
                //    $.alert({
                //        title: _getCookieForLanguage("_informationTitle"),
                //        content: _getCookieForLanguage("usercreateRoleVal"),
                //        type: 'red'
                //    });
                //    return false;
                //}
                if ($("#passwordkey").val() != $("#password").val()) {
                    $("#password").focus();
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: _getCookieForLanguage("_passdonotmatch"),
                        type: 'red'
                    });
                    return false;
                }
                if ($("#loweredusername").val() == "") {
                    $("#loweredusername").focus();
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: _getCookieForLanguage("usercreateFullNameVal"),
                        type: 'red'
                    });
                    return false;
                }

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "Create User",
                    currenturl: window.location.href,

                    username: $('#username').val(),
                    loweredusername: $('#loweredusername').val(),
                    password: $('#password').val(),
                    emailaddress: $('#emailaddress').val(),
                    mobilenumber: $('#mobilenumber').val(),
                    passwordquestion: $('#passwordquestion').val(),
                    passwordanswer: $('#passwordanswer').val(),
                    roleid: roleval,
                    locked: 1,
                    approved: 1,
                    UserProfilePhoto: userimage,

                    ex_bigint1: $('#okpid').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: baseurl + "UserManagement/SaveUser",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateUser").reset();
                                            $('#imgprofile').attr('src', "");
                                            deleteButUSer();
                                        }
                                        else {
                                            window.location.href = data.redirectUrl;
                                        }
                                    });
                                }
                                else {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {

                                        }
                                        else {
                                            window.location.href = data.redirectUrl;
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
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e, message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnUserReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "UserManagement/CreateUser";
        } catch (e) {
            alert(e);
        }
    });

});


function progressHandlingFunction(e) {
    if (e.lengthComputable) {
        var percentComplete = Math.round(e.loaded * 100 / e.total);
        $("#FileProgress").css("width", percentComplete + '%').attr('aria-valuenow', percentComplete);
        $('#FileProgress span').text(percentComplete + "%");
    }
    else {
        $('#FileProgress span').text('unable to compute');
    }
}
