var baseurl = $('#txtBaseUrl').val();
var role_values = '', mname = 'SaveUser';

function deleteButUSerEdit() {
    (typeof $("#imgprofile").attr("src") == 'undefined' ? $('#btnRemoveImageEdit').addClass(' hidden ') : ($("#imgprofile").attr("src").indexOf("NoProfileImage") >= 0 ? $('#btnRemoveImageEdit').addClass(' hidden ') : $('#btnRemoveImageEdit').removeClass(' hidden ')));
}



$(document).ready(function () {
    $('#modal-container-useredit').on('shown.bs.modal', function () {
        deleteButUSerEdit();
    })
    deleteButUSerEdit();

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    //if (typeof $("#hddroles").val() != 'undefined') {
    //    if ($("#hddroles").val().length > 0)
    //        role_values = $("#hddroles").val() + ',';
    //}

    $('body').on('click', '.chkclass', function (event) {
        role_values = role_values + $(this).val() + ',';
    });

    $('body').on('click', '#btnAttachmentEdit', function (event) {
        try {
            event.preventDefault();
            $("#attachmentEdit").trigger("click");
            return false;

        } catch (e) {
            alert(e);
        }
        deleteButUSerEdit();
    });

    $('body').on('change', '#attachmentEdit', function (event) {
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
            }
            $.ajax({
                url: baseurl + "UserManagement/UploadAttachmentEdit/",
                cache: false,
                processData: false,
                contentType: false,
                type: 'POST',
                data: frmdata,
                success: function (response) {
                    if (response.status == "success") {
                        $('#imgprofile').attr('src', response.title);
                        deleteButUSerEdit();
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

    $('body').on('click', '#btnRemoveImageEdit', function (event) {
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
                        url: baseurl + "UserManagement/DeleteAttachment",
                        data: input,
                        type: 'POST',
                        async: false,
                        success: function (response) {
                            if (response.status === "success") {
                                inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    $('#imgprofile').attr('src', response.redirectUrl); deleteButUSerEdit();
                                });
                            }
                        }
                    });
                }
            });
        } catch (e) {
            alert(e);
        }
        deleteButUSerEdit();
    });

    $('body').on('click', '#btnUpdateUser', function (event) {
        try {

            event.preventDefault();
            var selectCheckBox = 0;
            selectCheckBox = $('input.chkclass:checked').length;



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
            //role_values = "";
            //$("input.chkclass:checked").each(function () {
            //    role_values = role_values + $(this).val() + ',';
            //});


            //var roleval = '';
            //if (role_values.length > 0) {
            //    roleval = role_values.substr(0, role_values.length - 1);
            //}

            var userimage = $("#imgprofile").attr("src");
            if (userimage == "")
                userimage = baseurl + "DesignsAndScripts/Images/NoProfileImage.png";


            var form = $('#frmEditUser');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                //if (selectCheckBox <= 0) {
                //    $.alert({
                //        title: _getCookieForLanguage("_informationTitle"),
                //        content: "Please select at least one role to continue",
                //        type: 'red'
                //    });
                //    return false;
                //}

                if ($("#loweredusername").val() == "") {
                    $("#loweredusername").focus();
                    $.alert({
                        title: "Error!",
                        content: "User Full name is required.",
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

                    mobilepin: $('#mobilepin').val(),


                    masteruserid: $("#masteruserid").val(),
                    userid: $("#userid").val(),
                    username: $("#username").val(),
                    loweredusername: $("#loweredusername").val(),
                    emailaddress: $('#emailaddress').val(),
                    mobilenumber: $('#mobilenumber').val(),
                    passwordquestion: $('#passwordquestion').val(),
                    passwordanswer: $('#passwordanswer').val(),
                    roleid: roleval,
                    UserProfilePhoto: userimage,
                    ex_nvarchar1: $('#imgprofileTemp').val(),
                    ex_bigint1: $('#okpid').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: baseurl + "UserManagement/EditUser",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#TableId").DataTable().ajax.reload();
                                        $('#modal-container-useredit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#TableId").DataTable().ajax.reload();
                                            $('#modal-container-useredit').modal('hide');
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
                content: e.message,
                type: 'red'
            });
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
