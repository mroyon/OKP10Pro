

//PN: FILE NAME: "Newhr_svcinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

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
                frmdata.append("methodname", "Create_Profile");
                frmdata.append("currenturl", window.location.href);
                frmdata.append("imagesrc", $('#imgprofile').attr('src'));
            }
            $.ajax({
                url: baseurl + "HrSvcInfo/UploadAttachment/",
                cache: false,
                processData: false,
                contentType: false,
                type: 'POST',
                data: frmdata,
                success: function (response) {
                    if (response.status == "success") {

                        $('#imgprofile').attr('src', response.title);
                        $('#btnRemoveImage').show();
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
                profilephotofilepath: $("#imgprofile").attr("src")
            });

            confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {
                    $.ajax({
                        url: baseurl + "HrSvcInfo/DeleteAttachment",
                        data: input,
                        type: 'POST',
                        async: false,
                        success: function (response) {
                            if (response.status === "success") {
                                inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    $('#imgprofile').attr('src', response.redirectUrl); //deleteButUSer();
                                });
                            }
                        }
                    });
                }
            });
        } catch (e) {
            alert(e);
        }
        //deleteButUSer();
    });
    function deleteButUSer() {
        //var s = $("#imgprofile").attr("src");
        //if (s == "undefined")
        //    $('#btnRemoveImage').addClass(' hidden ');
        //else {
        //    if (s.indexOf("NoProfileImage") >= 0)
        //        $('#btnRemoveImage').addClass(' hidden ');
        //    else
        //        $('#btnRemoveImage').removeClass(' hidden ');
        //}
    }
    $('body').on('click', '#btnSaveHrSvcInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_SvcInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);
            var dob = new Date(GetDateFromTextBox($('#dateofbirth').val()));

            var today = new Date();
            today = today.setDate(today.getDate() + 1);
            var age = Math.floor((today - dob) / (365.25 * 24 * 60 * 60 * 1000));
            if (age < 18) {
                $('#dateofbirth').css("border", "1px solid red");
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Current age must be equal or greater than 18",
                    type: 'red'
                });
                return false;
            }

           
            if (form.valid()) {

               

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

					hrsvcid: $('#hrsvcid').val(),
                    hrbasicid: $('#hrbasicid').val(),

                    //Basic Profile Start
                    militarynokw: $('.militarynokw').val(),
                    militarynobd: $('.militarynobd').val(),
                    civilid: $('.civilid').val(),
                    name1: $('#name1').val(),
                    name2: $('#name2').val(),
                    name3: $('#name3').val(),
                    fullname: $('.fullname').val(),
                    dateofbirth: GetDateFromTextBox($('#dateofbirth').val()),
                    //joindatebd: GetDateFromTextBox($('#joindatebd').val()),
                    // End

					passportno: $('.passportno').val(),
					joindatekw: GetDateFromTextBox($('#joindatekw').val()),
					expectedretiredatekw: GetDateFromTextBox($('#expectedretiredatekw').val()),
					//userid: $('#userid').val(),
                    organizationkey: $('#organizationkey').val(),
					entitykey: $('#entitykey').val(),
					armsid: $('#armsid').val(),
					okpid: $('#okpid').val(),
					rankidkw: $('#rankidkw').val(),
					rankidbd: $('#rankidbd').val(),
					tradeidbd: $('#tradeidbd').val(),
					tradeidkw: $('#tradeidkw').val(),
					groupid: $('#groupid').val(),
                    status: ($('#status').val() == 5 ? 3 : $('#status').val()),
					//remarks: $('#remarks').val(),

                    profilephotofilepath: $("#imgprofile").attr("src")

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrSvcInfo/HrSvcInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           window.location.href =  baseurl + "HrSvcInfo/HrSvcInfo";
                                            $('#mcHrSvcInfoNew').html('');
                                            $('#modal-container-HrSvcInfoNew').modal('hide');
                                            //GetAllDataHrSvcInfo();
                                        }
                                        else
                                        {
                                            window.location.href = baseurl + "HrSvcInfo/HrSvcInfo";
                                            $('#mcHrSvcInfoNew').html('');
                                            $('#modal-container-HrSvcInfoNew').modal('hide');
                                            //GetAllDataHrSvcInfo();
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
    });
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcHrSvcInfoNew').html('');
            $('#modal-container-HrSvcInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});



