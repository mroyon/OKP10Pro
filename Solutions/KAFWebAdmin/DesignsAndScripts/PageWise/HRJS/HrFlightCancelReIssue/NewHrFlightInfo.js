

//PN: FILE NAME: "Newhr_flightinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrFlightCencelReissueInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_FlightInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

           
            var myData = [];

            $("#GenflightDt .txtdetailinfo").each(function (index) {
               
                if (
                    (typeof $(this).attr("detailid") != "undefined" && $(this).attr("detailid") != "null")
                    && ($(this).parent().parent().find(".chkSelect").prop("checked") == true > 0)
                ) {

                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        flightdetlid: null,
                        flightid: null,
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        ptidetlid: $(this).attr("ptidetlid"),
                        ptademandid: $(this).attr("ptademandid"),
                        prevflightdetlid: $(this).attr("detailid"),
                       

                        CurrentState:1

                    });

                    myData.push(inputdetl);
                }
            });


            if (form.valid()) {

                

                if (myData.length == 0) {
                    inforamtionDialog("Alert", "No Detail Provided", _getCookieForLanguage("_btnOK")).then(function (answer) {
                        if (answer == "true") {

                        }

                    });
                }
                else {
                    confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                        if (answer == "true") {

                            var input = AddAntiForgeryToken({
                                token: $(".txtUserSTK").val(),
                                userinfo: $(".txtServerUtilObj").val(),
                                useripaddress: $(".txtuserip").val(),
                                sessionid: $(".txtUserSes").val(),
                                methodname: "HrFamilyInfoCreate",
                                currenturl: window.location.href,

                                iscancel: false,
                                reissued: true,
                                flightid: null,//$('#existingflightid').val(),
                                ptademandid: myData[0].ptademandid,
                                flightdate: GetDateFromTextBox($('#flightdate').val()),
                                flightletterdate: GetDateFromTextBox($('#flightletterdate').val()),
                                flightletterno: $('#flightletterno').val(),
                                airlinesid: $('#airlinesid').val(),
                                remarks: $('#remarks').val(),
                                hr_flightList: myData,

                                CurrentState: 1 //$("#existingreppassportid").val() == null ? 1 : 2,

                            });

                            $.ajax({
                                url: baseurl + "HrFlightCancelReIssue/HrFlightCancelReIssueInsert",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrFlightInfo/HrFlightInfo";
                                                $('#mcHrFlightInfoNew').html('');
                                                $('#modal-container-HrFlightInfoNew').modal('hide');
                                                GetAllDataHrFlightInfo();
                                            }
                                            else {
                                                $('#mcHrFlightInfoNew').html('');
                                                $('#modal-container-HrFlightInfoNew').modal('hide');
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
            $('#mcHrFlightInfoNew').html('');
            $('#modal-container-HrFlightInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



