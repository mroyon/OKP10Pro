

//PN: FILE NAME: "Newhr_replacementinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {


    $('body').on('keyup', '.txtMilNo', function (e) {
        e.preventDefault();
        if (e.keyCode === 13) {
            getMilPersonalInfo(this);
            return false;
        }
    });

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrReplacementInfoAll', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_ReplacementInfoUpdateCustom');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var myData = [];
            $("#GenReplacementDt .txtMilNo").each(function (index) {

                if ($(this).val().length > 0) {

                    if ($(this).attr("operation") == "delete") {
                        if (typeof $(this).attr("detailid") != 'undefined') {
                            var inputdetl = AddAntiForgeryToken({
                                token: $(".txtUserSTK").val(),
                                userinfo: $(".txtServerUtilObj").val(),
                                useripaddress: $(".txtuserip").val(),
                                sessionid: $(".txtUserSes").val(),
                                methodname: "HrFamilyInfoCreate",
                                currenturl: window.location.href,

                                replacementdetlid: $(this).attr("detailid"),
                                replacementid: $('#replacementid').val(),
                                hrbasicid: $(this).attr("hrbasicid_prev"),
                                hrsvcid: $(this).attr("hrsvcid_prev"),
                                CurrentState: 3

                            });

                            myData.push(inputdetl);
                        }
                    }
                    else {
                        if (typeof $(this).attr("hrsvcid_prev") == 'undefined') {

                            var inputdetl = AddAntiForgeryToken({
                                token: $(".txtUserSTK").val(),
                                userinfo: $(".txtServerUtilObj").val(),
                                useripaddress: $(".txtuserip").val(),
                                sessionid: $(".txtUserSes").val(),
                                methodname: "HrFamilyInfoCreate",
                                currenturl: window.location.href,

                                replacementid: $('#replacementid').val(),
                                hrbasicid: $(this).attr("hrbasicid"),
                                hrsvcid: $(this).attr("hrsvcid"),
                                CurrentState: 1

                            });

                            myData.push(inputdetl);
                        }

                        else if (typeof $(this).attr("hrsvcid_prev") != 'undefined' && typeof $(this).attr("detailid") != 'undefined' && $(this).attr("hrsvcid_prev") == $(this).attr("hrsvcid")) {
                            var inputdetl = AddAntiForgeryToken({
                                token: $(".txtUserSTK").val(),
                                userinfo: $(".txtServerUtilObj").val(),
                                useripaddress: $(".txtuserip").val(),
                                sessionid: $(".txtUserSes").val(),
                                methodname: "HrFamilyInfoCreate",
                                currenturl: window.location.href,

                                replacementdetlid: $(this).attr("detailid"),
                                replacementid: $('#replacementid').val(),
                                hrbasicid: $(this).attr("hrbasicid_prev"),
                                hrsvcid: $(this).attr("hrsvcid_prev"),
                                CurrentState: 2

                            });

                            myData.push(inputdetl);
                        }
                        else if (typeof $(this).attr("hrsvcid_prev") != 'undefined' && typeof $(this).attr("detailid") != 'undefined' && $(this).attr("hrsvcid_prev") != $(this).attr("hrsvcid")) {

                            //delete the previous one
                            var inputdetl = AddAntiForgeryToken({
                                token: $(".txtUserSTK").val(),
                                userinfo: $(".txtServerUtilObj").val(),
                                useripaddress: $(".txtuserip").val(),
                                sessionid: $(".txtUserSes").val(),
                                methodname: "HrFamilyInfoCreate",
                                currenturl: window.location.href,

                                replacementdetlid: $(this).attr("detailid"),
                                replacementid: $('#replacementid').val(),
                                hrbasicid: $(this).attr("hrbasicid_prev"),
                                hrsvcid: $(this).attr("hrsvcid_prev"),
                                CurrentState: 3

                            });

                            myData.push(inputdetl);

                            //add the new one
                            var inputdetl = AddAntiForgeryToken({
                                token: $(".txtUserSTK").val(),
                                userinfo: $(".txtServerUtilObj").val(),
                                useripaddress: $(".txtuserip").val(),
                                sessionid: $(".txtUserSes").val(),
                                methodname: "HrFamilyInfoCreate",
                                currenturl: window.location.href,

                                replacementid: $('#replacementid').val(),
                                hrbasicid: $(this).attr("hrbasicid"),
                                hrsvcid: $(this).attr("hrsvcid"),
                                CurrentState: 1

                            });

                            myData.push(inputdetl);
                        }

                    }
                   
                    
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
                if ($("#GenReplacementDt tr:visible").length == 2) {
                    inforamtionDialog("Alert", "No Detail Provided", _getCookieForLanguage("_btnOK")).then(function (answer) {
                        if (answer == "true") {

                        }

                    });
                }
                else {

                    confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                        if (answer == "true") {

                            $.ajax({
                                url: baseurl + "HrReplacementInfo/HrReplacementInfoUpdate",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrReplacementInfo/HrReplacementInfo";
                                                $('#mcHrReplacementInfoEdit').html('');
                                                $('#modal-container-HrReplacementInfoEdit').modal('hide');
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

    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcHrReplacementInfoEdit').html('');
            $('#modal-container-HrReplacementInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






