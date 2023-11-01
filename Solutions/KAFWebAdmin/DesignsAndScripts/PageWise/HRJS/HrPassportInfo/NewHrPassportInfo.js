

//PN: FILE NAME: "Newhr_passportinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrPassportInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_PassportInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);


            if (form.valid()) {
                var model = new FormData();

                model.append("file1", $("#fileupload1")[0].files[0]);
                model.append("file2", $("#fileupload2")[0].files[0]);
                model.append("__RequestVerificationToken", $('input[name=__RequestVerificationToken]').val());
                model.append("token", $(".txtUserSTK").val());
                model.append("userinfo", $(".txtServerUtilObj").val());
                model.append("useripaddress", $(".txtuserip").val());
                model.append("sessionid", $(".txtUserSes").val());
                model.append("methodname", "passportcreate");
                model.append("currenturl", window.location.href);

                model.append("passportid", $('#passportid').val());
                model.append("hrbasicid", $('#hrbasicid').val());
                model.append("passportno", $('.passportno').val());
                model.append("passportissuedate", GetDateFromTextBox($('#passportissuedate').val()));
                model.append("passportexpirydate", GetDateFromTextBox($('#passportexpirydate').val()));
                model.append("iscurrent", true);

                //jQuery.each($("#fileupload")[0].files, function (i, file) {
                //    frmdata.append('photo[' + i + ']', file);
                //});

                console.log(model);

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    passportid: $('#passportid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    passportno: $('.passportno').val(),
                    passportissuedate: GetDateFromTextBox($('#passportissuedate').val()),
                    passportexpirydate: GetDateFromTextBox($('#passportexpirydate').val()),
                    iscurrent: true
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: baseurl + "HrPassportInfo/HrPassportInfoInsert",
                            data: model,
                            type: 'POST',
                            cache: false,
                            contentType: false,
                            processData: false,
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            window.location.href = baseurl + "HrPassportInfo/HrPassportInfo";
                                            $('#mcHrPassportInfoNew').html('');
                                            $('#modal-container-HrPassportInfoNew').modal('hide');
                                            //GetAllDataHrPassportInfo();
                                        }
                                        else {
                                            $('#mcHrPassportInfoNew').html('');
                                            $('#modal-container-HrPassportInfoNew').modal('hide');
                                            // GetAllDataHrPassportInfo();
                                        }
                                    });
                                }

                                else {
                                    $.alert({
                                        title: _getCookieForLanguage("_informationTitle"),
                                        content: "Passport number already exists",
                                        type: 'red'
                                    });
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
            $('#mcHrPassportInfoNew').html('');
            $('#modal-container-HrPassportInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



