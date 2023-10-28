

//PN: FILE NAME: "Newhr_replacementinfo.js"


var baseurl = $('#txtBaseUrl').val();



$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('keyup', '.txtMilNo', function (e) {
        e.preventDefault();
        if (e.keyCode === 13) {
            getMilPersonalInfo(this);
            return false;
        }
    });


    $('body').on('click', '#btnSaveHrReplacementInfoAll', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_ReplacementInfoNewCustom');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var myData = [];
            $("#GenReplacementDt .txtMilNo").each(function (index) {
                //console.log(index + ": " + $(this).val() + " " + $(this).attr("hrbasicid"));
                if ($(this).val().length > 0) {
                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        replacementid: -99,
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        CurrentState: $(this).attr("operation") == "delete" ? 3 : 1

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

                    replacementid: $('#replacementid').val(),
                    letterno: $('#letterno').val(),
                    letterdate: GetDateFromTextBox($('#letterdate').val()),
                    remarks: $('#remarks').val(),
                    hr_replacementList: myData

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
                                url: baseurl + "HrReplacementInfo/HrReplacementInfoInsert",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrReplacementInfo/HrReplacementInfo";
                                                $('#mcHrReplacementInfoNew').html('');
                                                $('#modal-container-HrReplacementInfoNew').modal('hide');
                                                GetAllDataHrReplacementInfo();
                                            }
                                            else {
                                                $('#mcHrReplacementInfoNew').html('');
                                                $('#modal-container-HrReplacementInfoNew').modal('hide');
                                                GetAllDataHrReplacementInfo();
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
            $('#mcHrReplacementInfoNew').html('');
            $('#modal-container-HrReplacementInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



