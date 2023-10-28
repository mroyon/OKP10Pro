

//PN: FILE NAME: "Newhr_reppassportinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrRepPassportInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_RepPassportInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var isblank = 0;

            $("#GenRepPassportDt .chkSelect").each(function (index) {

                if (($(this).prop("checked") == true > 0)) {

                    if (($(this).val().length == 0)) {
                        $(this).css("border-color", "red");
                        isblank = 1;
                    }
                    if (($(this).parent().parent().find(".txtPassportNo").val().length == 0)) {
                        $(this).parent().parent().find(".txtPassportNo").css("border-color", "red");
                        isblank = 1;
                    }
                    if (($(this).parent().parent().find(".txtFirstName").val().length == 0)) {
                        $(this).parent().parent().find(".txtFirstName").css("border-color", "red");
                        isblank = 1;
                    }
                    if (($(this).parent().parent().find(".txtSurName").val().length == 0)) {
                        $(this).parent().parent().find(".txtSurName").css("border-color", "red");
                        isblank = 1;
                    }
                }
            });

            if (isblank == 1)
                return;


            var myData = [];
            $("#GenRepPassportDt .txtdetailinfo").each(function (index) {
                //console.log(index + ": " + $(this).val() + " " + $(this).attr("hrbasicid"));
                if ($(this).parent().parent().find(".txtPassportNo").val().length > 0 && $(this).parent().parent().find(".chkSelect").prop("checked") == true > 0) {
                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        reppassportdetlid: $(this).attr("detailid"),
                        reppassportid: $("#existingreppassportid").val(),
                        replacementdetlid: $(this).attr("replacementdetlid"),
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        newhrbasicid: $(this).attr("newhrbasicid"),
                        newhrsvcid: $(this).attr("newhrsvcid"),
                        firstname: $(this).parent().parent().find(".txtFirstName").val(),
                        surname: $(this).parent().parent().find(".txtSurName").val(),
                        ex_nvarchar1: $(this).parent().parent().find(".txtFatherName").val(),
                        ex_date1: GetDateFromTextBox($(this).parent().parent().find(".txtBDate").val()),
                        newpassportno: $(this).parent().parent().find(".txtPassportNo").val(),
                        CurrentState: typeof $(this).attr("detailid") == "undefined" || $(this).attr("detailid") == "null" ? 1 : 2

                    });

                    myData.push(inputdetl);
                }
            });

            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    reppassportid: $("#existingreppassportid").val(),
                    replacementid: $('#replacementid').val(),
                    passportrecvdate: GetDateFromTextBox($('#passportrecvdate').val()),
                    passportletterno: $('#passportletterno').val(),
                    passportletterdate: GetDateFromTextBox($('#passportletterdate').val()),
                    remarks: $('#remarks').val(),
                    CurrentState: $("#existingreppassportid").val() == null ? 1 : 2,
                    hr_passportList: myData

                });

                if (myData.length == 0) {
                    inforamtionDialog("Alert", "No Detail Provided", _getCookieForLanguage("_btnOK")).then(function (answer) {
                        if (answer == "true") {

                        }

                    });
                }
                else {
                    confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                        if (answer == "true") {

                            $.ajax({
                                url: baseurl + "HrRepPassportInfo/HrRepPassportInfoInsert",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrReplacementInfo/HrReplacementInfo";
                                                $('#mcHrRepPassportInfoNew').html('');
                                                $('#modal-container-HrRepPassportInfoNew').modal('hide');
                                                GetAllDataHrRepPassportInfo();
                                            }
                                            else {
                                                $('#mcHrRepPassportInfoNew').html('');
                                                $('modal-container-HrRepPassportInfoNew').modal('hide');
                                                GetAllDataHrRepPassportInfo();
                                            }
                                        });
                                    }

                                    else {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrReplacementInfo/HrReplacementInfo";
                                                //$('#mcHrReplacementInfoNew').html('');
                                                //$('#modal-container-HrReplacementInfoNew').modal('hide');

                                            }
                                        });
                                    }
                                }
                            });
                        }
                    });

                }
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
            $('#mcHrRepPassportInfoNew').html('');
            $('#modal-container-HrRepPassportInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



