

//PN: FILE NAME: "Newhr_flightinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrFlightInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_FlightInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var isblank = 0;

            $("#GenflightDt .txtreason").each(function (index) {

                if (($(this).parent().parent().find(".chkSelect").prop("checked") == true > 0)) {

                    if (($(this).val().length == 0)) {
                        $(this).css("border-color", "red");
                        isblank = 1;
                    }
                    if (($(this).parent().parent().find(".txtcanceldate").val().length == 0)) {
                        $(this).parent().parent().find(".txtcanceldate").css("border-color", "red");
                        isblank = 1;
                    }
                    //if (($(this).parent().parent().find(".txtcancelletterdate").val().length == 0)) {
                    //    $(this).parent().parent().find(".txtcancelletterdate").css("border-color", "red");
                    //    isblank = 1;
                    //}
                    //if (($(this).parent().parent().find(".txtcancelletterno").val().length == 0)) {
                    //    $(this).parent().parent().find(".txtcancelletterno").css("border-color", "red");
                    //    isblank = 1;
                    //}
                }
            });

            if (isblank == 1)
                return;

            var myData = [];

            $("#GenflightDt .txtdetailinfo").each(function (index) {

                if (
                    (typeof $(this).attr("detailid") != "undefined" && $(this).attr("detailid") != "null")) {

                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        iscancel: true,
                        flightdetlid: $(this).attr("detailid"),
                        flightid: $("#flightid").val(),
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        ptidetlid: $(this).attr("ptidetlid"),

                        canceldate: GetDateFromTextBox($(this).parent().parent().find(".txtcanceldate").val()),
                        //cancelletterdate: GetDateFromTextBox($(this).parent().parent().find(".txtcancelletterdate").val()),
                        //cancelletterno: $(this).parent().parent().find(".txtcancelletterno").val(),
                        reason: $(this).parent().parent().find(".txtreason").val(),
                        iscancel: $(this).parent().parent().find(".chkSelect").prop("checked"),

                        CurrentState: 2

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

                    flightid: $('#flightid').val(),
                    ptademandid: $('#ptademandid').val(),
                    flightdate: GetDateFromTextBox($('#flightdate').val()),
                    flightletterdate: GetDateFromTextBox($('#flightletterdate').val()),
                    flightletterno: $('#flightletterno').val(),
                    airlinesid: $('#airlinesid').val(),
                    remarks: $('#remarks').val(),
                    hr_flightList: myData,

                    CurrentState: 2 //$("#existingreppassportid").val() == null ? 1 : 2,

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFlightCancelInfo/HrFlightCancelInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrFlightInfo/HrFlightInfo";
                                            $('#mcHrFlightInfoEdit').html('');
                                            $('#modal-container-HrFlightInfoEdit').modal('hide');
                                            GetAllDataHrFlightInfo();
                                        }
                                        else {
                                            $('#mcHrFlightInfoEdit').html('');
                                            $('#modal-container-HrFlightInfoEdit').modal('hide');
                                            GetAllDataHrFlightInfo();
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
            $('#mcHrFlightInfoEdit').html('');
            $('#modal-container-HrFlightInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






