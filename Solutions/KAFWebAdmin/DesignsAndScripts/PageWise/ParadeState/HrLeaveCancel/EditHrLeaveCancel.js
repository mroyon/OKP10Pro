﻿

//PN: FILE NAME: "NewHr_LeaveInfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrLeaveCancel', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_LeaveCancelEdit');
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

                    leavemodificationid: $('#leavemodificationid').val(),
                    //leaveinfoid: $('#leaveinfoid').val(),
                    //hrbasicid: $('#hrbasicid').val(),
                    //leavetypeid: $('#leavetypeid').val(),
                    //modificationdate: GetDateFromTextBox($('#modificationdate').val()),
                    //startdate: GetDateFromTextBox($('#startdate').val()),
                    //enddate: GetDateFromTextBox($('#enddate').val()),
                    ////noofdays: $('#noofdays').val(),
                    //leavestartdate: GetDateFromTextBox($('#leavestartdate').val()),
                    //leaveenddate: GetDateFromTextBox($('#leaveenddate').val()),
                    //leavedays:$('#leavedays').val(),
                    letterno: $('#letterno').val(),
                    letterdate: GetDateFromTextBox($('#letterdate').val()),
                    //withgovtticket: $('#withgovtticket').val(),
                    //modificationtype: $('#modificationtype').val(),
                    remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrLeaveCancel/HrLeaveCancelUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrLeaveModification/HrLeaveModification";
                                            $('#mcHrLeaveCancelEdit').html('');
                                            $('#modal-container-HrLeaveCancelEdit').modal('hide');
                                            GetAllDataHrLeaveCancel($('#hrbasicid').val());
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

    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcHrLeaveCancelEdit').html('');
            $('#modal-container-HrLeaveCancelEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






