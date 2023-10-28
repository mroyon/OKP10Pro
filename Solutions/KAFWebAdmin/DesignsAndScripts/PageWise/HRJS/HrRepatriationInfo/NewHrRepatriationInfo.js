

//PN: FILE NAME: "Newhr_repatriationinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrRepatriationInfo', function (event) {

        $("#btnNewHrRepatriationInfo").attr("disabled", "disabled");
        try {
            event.preventDefault();
            var form = $('#frmHr_RepatriationInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);





            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                   // repatriationid: $('#repatriationid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                   // hrsvcid: $('#hrsvcid').val(),
                    soddate: GetDateFromTextBox($('#soddate').val()),
                    flightdate: GetDateFromTextBox($('#flightdate').val()),
                    salaryreceivedtilldate: GetDateFromTextBox($('#salaryreceivedtilldate').val()),
                    rewardavaildate: GetDateFromTextBox($('#rewardavaildate').val()),
                    letterdate: GetDateFromTextBox($('#letterdate').val()),
                    letterno: $('#letterno').val(),
                    remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrRepatriationInfo/HrRepatriationInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrRepatriationInfo/HrRepatriationInfo";
                                            $('#mcHrRepatriationInfoNew').html('');
                                            $('#modal-container-HrRepatriationInfoNew').modal('hide');
                                            GetAllDataHrRepatriationInfo();
                                        }
                                        else {
                                            $('#mcHrRepatriationInfoNew').html('');
                                            $('#modal-container-HrRepatriationInfoNew').modal('hide');
                                            GetAllDataHrRepatriationInfo();
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
            $('#mcHrRepatriationInfoNew').html('');
            $('#modal-container-HrRepatriationInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



