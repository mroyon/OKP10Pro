var baseurl = $('#txtBaseUrl').val();

function deleteButProfile() {
    (typeof $("#imgprofile").attr("src") == 'undefined' ? $('#btnRemoveImageProfile').addClass(' hidden ') : ($("#imgprofile").attr("src").indexOf("NoProfileImage") >= 0 ? $('#btnRemoveImageProfile').addClass(' hidden ') : $('#btnRemoveImageProfile').removeClass(' hidden ')));
}



$(document).ready(function () {

    $('#modal-container-profile').on('shown.bs.modal', function () {
        deleteButProfile();
    })

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '.btnprofileshow', function (event) {
        event.preventDefault();
        try {
            // DisplayProgressMessage(this, 'Login...');

            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "ModalFormActionUpdateProfile",
                masteruserid: 2
            });


            $.ajax({
                url: baseurl + "Home/ModalFormActionUpdateProfile",
                data: input,
                type: 'POST',
                success: function (data) {
                    //if (data.status === "success") {
                    //    window.location.href = data.redirectUrl;
                    //}

                    $('#updateprofile-content').html('');
                    $('#updateprofile-content').html(data);
                    $('#updateprofile').modal({ backdrop: 'static', keyboard: false });
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

    $('body').on('click', '#btnupdateprofile', function (event) {
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



                var userimage = $("#imgprofile").attr("src");
                if (userimage == "")
                    userimage = baseurl + "DesignsAndScripts/Images/NoProfileImage.png";

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "Update_Profile",
                    currenturl: window.location.href,

                    userid: $("#userid").val(),
                    masteruserid: $("#masteruserid").val(),
                    UserProfilePhoto: $("#imgprofile").attr("src"),
                    loweredusername: $("#loweredusername").val(),
                    mobilenumber: $("#mobilenumber").val(),
                    passwordquestion: $("#passwordquestion option:selected").val(),
                    passwordanswer: $("#passwordanswer").val(),
                    UserProfilePhoto: userimage,
                    ex_nvarchar1: $('#imgprofileTemp').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: $('#txtBaseUrl').val() + "Home/PostModalUpdateProfile",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(_getCookieForLanguage("_informationTitle"), data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        //$('#modal-container-profile').modal('hide');
                                        $('#updateprofile').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(_getCookieForLanguage("_informationTitle"), data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $('#modal-container-profile').modal('hide');
                                        }
                                    });
                                }
                            }
                        });
                    }
                    else {
                        //$('#modal-container-changepassword').modal('hide');
                        $('#updateprofile').modal('hide');
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            alert(e);
        }
    });

    $('body').on('click', '#btnAttachmentProfileEdit', function (event) {
        try {
            event.preventDefault();
            $("#attachmentProfile").trigger("click");
            return false;
        } catch (e) {
            alert(e);
        }
    });

    $('body').on('change', '#attachmentProfile', function (event) {
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
                frmdata.append("userid", $("#userid").val());
                frmdata.append("masteruserid", $("#masteruserid").val());
                frmdata.append("existingImageURL", $("#imgprofileTemp").val());
            }

            $.ajax({
                url: $("#txtBaseUrl").val() + "Home/UploadProfileImage/",
                contentType: "application/json; charset=utf-8",
                dataType: 'json',
                contentType: false,
                processData: false,
                type: 'POST',
                data: frmdata,
                success: function (response) {
                    if (response.status == "success") {
                        $('#imgprofile').attr('src', response.title);
                        deleteButProfile();
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
            alert(e);
        }
    });

    $('body').on('click', '#btnRemoveImageProfile', function (event) {
        try {
            event.preventDefault();


            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "Role_Delete",
                currenturl: window.location.href,
                UserProfilePhoto: $("#imgprofile").attr("src"),
                mobilepin: "edit"
            });

            confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {
                    $.ajax({
                        url: $('#txtBaseUrl').val() + "Home/DeleteAttachment",
                        data: input,
                        type: 'POST',
                        async: false,
                        success: function (response) {
                            if (response.status === "success") {
                                inforamtionDialog(_getCookieForLanguage("_informationTitle"), response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    $('#imgprofile').attr('src', response.redirectUrl);
                                    deleteButProfile();
                                });
                            }
                        }
                    });
                }
            });
        } catch (e) {
            alert(e);
        }
        deleteButProfile();
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