

//PN: FILE NAME: "Newhr_visasentinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnSaveHrVisaSentInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_VisaSentInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var myData = [];

            $("#GenvisasentDt .txtdetailinfo").each(function (index) {
                //console.log(index + ": " + $(this).val() + " " + $(this).attr("hrbasicid"));
                if (($(this).parent().parent().find(".chkSelect").prop("checked") == true > 0)
                    && (typeof $(this).attr("detailid") == "undefined" || $(this).attr("detailid") == "null")) {
                    var inputdetl = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        visasentdetlid: $(this).attr("detailid"),
                        visasentid: $("#existingvisasentid").val(),
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        visaissuedetlid: $(this).attr("visaissuedetlid"),

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

                        visasentdetlid: $(this).attr("detailid"),
                        visasentid: $("#existingvisasentid").val(),
                        hrbasicid: $(this).attr("hrbasicid"),
                        hrsvcid: $(this).attr("hrsvcid"),
                        visaissuedetlid: $(this).attr("visaissuedetlid"),

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

                    visaissueid: $("#VisaIssueID").val(),
                    visasentid: $('#existingvisasentid').val(),
                    visasentdate: GetDateFromTextBox($('#visasentdate').val()),
                    visasentletterdate: GetDateFromTextBox($('#visasentletterdate').val()),
                    visasentletterno: $('#visasentletterno').val(),
                    remarks: $('#remarks').val(),
                    hr_visasentList: myData,

                    CurrentState: $("#chknewassign").prop("checked") == true ? 1 : 2 //$("#existingreppassportid").val() == null ? 1 : 2,

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
                                url: baseurl + "HrVisaSentInfo/HrVisaSentInfoInsert",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            if (answer == "true") {
                                                //window.location.href =  baseurl + "HrVisaSentInfo/HrVisaSentInfo";
                                                $('#mcHrVisaSentInfoNew').html('');
                                                $('#modal-container-HrVisaSentInfoNew').modal('hide');
                                                GetAllDataHrVisaSentInfo();
                                            }
                                            else {
                                                $('#mcHrVisaSentInfoNew').html('');
                                                $('#modal-container-HrVisaSentInfoNew').modal('hide');
                                                GetAllDataHrVisaSentInfo();
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
            $('#mcHrVisaSentInfoNew').html('');
            $('#modal-container-HrVisaSentInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



