

//PN: FILE NAME: "Newhr_visaissueinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrVisaIssueInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_VisaIssueInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var myData = [];
            $("#GenvisaissueDt .txtdetailinfo").each(function (index) {
                if (($(this).parent().parent().find(".chkSelect").prop("checked") == true > 0)
                    && (typeof $(this).attr("detailid") == "undefined" || $(this).attr("detailid") == "null")) {
                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        visaissuedetlid: $(this).attr("detailid"),
                        visaissueid: $("#visaissueid").val(),
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        visademanddetlid: $(this).attr("visademanddetlid"),

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

                        visaissuedetlid: $(this).attr("detailid"),
                        visaissueid: $("#visaissueid").val(),
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        visademanddetlid: $(this).attr("visademanddetlid"),

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

                    visaissueid: $('#visaissueid').val(),
                    visademandid: $('#visademandid').val(),
                    visaissuedate: GetDateFromTextBox($('#visaissuedate').val()),
                    visaissueletterdate: GetDateFromTextBox($('#visaissueletterdate').val()),
                    visaissueletterno: $('#visaissueletterno').val(),
                    remarks: $('#remarks').val(),

                    hr_visaissueList: myData,
                    CurrentState: 2 //$("#existingreppassportid").val() == null ? 1 : 2,

                });

                //if ($("#GenvisaissueDt .chkSelect:checked").length == 0) {
                //    inforamtionDialog("Alert", "No Detail Provided", _getCookieForLanguage("_btnOK")).then(function (answer) {
                //        if (answer == "true") {

                //        }

                //    });
                //}
                //else {
                    confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                        if (answer == "true") {

                            $.ajax({
                                url: baseurl + "HrVisaIssueInfo/HrVisaIssueInfoUpdate",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrVisaIssueInfo/HrVisaIssueInfo";
                                                $('#mcHrVisaIssueInfoEdit').html('');
                                                $('#modal-container-HrVisaIssueInfoEdit').modal('hide');
                                                GetAllDataHrVisaIssueInfo();
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
               // }
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
            $('#mcHrVisaIssueInfoEdit').html('');
            $('#modal-container-HrVisaIssueInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






