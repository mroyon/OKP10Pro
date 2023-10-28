

//PN: FILE NAME: "Newhr_visademandinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrVisaDemandInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_VisaDemandInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var myData = [];
            $("#GenVisaDemandDt .txtdetailinfo").each(function (index) {
                if (($(this).parent().parent().find(".chkSelect").prop("checked") == true > 0)
                    && (typeof $(this).attr("detailid") == "undefined" || $(this).attr("detailid") == "null")) {
                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        visademanddetlid: $(this).attr("detailid"),
                        visademandid: $("#visademandid").val(),
                        demandtype: $("#demandtype").val(), //1-replacement,2-new demand
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        passportdetlid: $(this).attr("reppassportdetlid"),

                        CurrentState: 1

                    });

                    myData.push(inputdetl);
                }
                if (($(this).parent().parent().find(".chkSelect").prop("checked") == false > 0) &&
                    (typeof $(this).attr("detailid") != "undefined" && $(this).attr("detailid") != "null")) {

                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        visademanddetlid: $(this).attr("detailid"),
                        visademandid: $("#visademandid").val(),
                        demandtype: $("#demandtype").val(), //1-replacement,2-new demand
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        passportdetlid: $(this).attr("reppassportdetlid"),

                        CurrentState: 3

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

                    visademandid: $('#visademandid').val(),
                    demandtype: $("#demandtype").val(),
                    passportinfoid: $('#passportinfoid').val(),
                    visademanddate: GetDateFromTextBox($('#visademanddate').val()),
                    visademandletterdate: GetDateFromTextBox($('#visademandletterdate').val()),
                    visademandletterno: $('#visademandletterno').val(),
                    remarks: $('#remarks').val(),

                    hr_visademandList: myData,

                    CurrentState: 2 //$("#existingreppassportid").val() == null ? 1 : 2,

                });

                //if ($("#GenVisaDemandDt .chkSelect:checked").length == 0) {
                //    inforamtionDialog("Alert", "No Detail Provided", _getCookieForLanguage("_btnOK")).then(function (answer) {
                //        if (answer == "true") {

                //        }

                //    });
                //}
                //else {

                    confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                        if (answer == "true") {

                            $.ajax({
                                url: baseurl + "HrVisaDemandInfo/HrVisaDemandInfoUpdate",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrVisaDemandInfo/HrVisaDemandInfo";
                                                $('#mcHrVisaDemandInfoEdit').html('');
                                                $('#modal-container-HrVisaDemandInfoEdit').modal('hide');
                                                GetAllDataHrVisaDemandInfo();
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
             //   }
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
            $('#mcHrVisaDemandInfoEdit').html('');
            $('#modal-container-HrVisaDemandInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






