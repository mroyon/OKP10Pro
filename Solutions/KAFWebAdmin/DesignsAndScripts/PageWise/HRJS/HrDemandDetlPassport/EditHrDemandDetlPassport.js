

//PN: FILE NAME: "Newhr_demanddetlpassport.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrDemandDetlPassport', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_DemandDetlPassportEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);




            
            if (form.valid()) {

        //        var input = AddAntiForgeryToken({
        //            token: $(".txtUserSTK").val(),
        //            userinfo: $(".txtServerUtilObj").val(),
        //            useripaddress: $(".txtuserip").val(),
        //            sessionid: $(".txtUserSes").val(),
        //            methodname: "HrFamilyInfoCreate",
        //            currenturl: window.location.href,

							 //newdemandpassportid: $('#newdemandpassportid').val(),
							 //newdemanddetlid: $('#newdemanddetlid').val(),
							 //serialno: $('#serialno').val(),
							 //hrbasicid: $('#hrbasicid').val(),
							 //hrsvcid: $('#hrsvcid').val(),
							 //remarks: $('#remarks').val(),
							 //passportrecvdate: GetDateFromTextBox($('#passportrecvdate').val()),
							 //letterno: $('#letterno').val(),
							 //letterdate: GetDateFromTextBox($('#letterdate').val()),


        //        });

                var myData = [];
                var isvalid = true;
                $("#GenRepPassportDt .txtdetailinfo").each(function (index) {

                    if ($(this).parent().parent().find(".txtPassportNo").val().length == 0 && $(this).parent().parent().find(".chkSelect").prop("checked") == true > 0) {
                        $(this).parent().parent().find(".txtPassportNo").css("border", "1px solid red");
                        isvalid = false;
                    };

                    if ($(this).parent().parent().find(".txtFirstName").val().length == 0 && $(this).parent().parent().find(".chkSelect").prop("checked") == true > 0) {
                        $(this).parent().parent().find(".txtFirstName").css("border", "1px solid red");
                        isvalid = false;
                    };

                    if ($(this).parent().parent().find(".txtSurName").val().length == 0 && $(this).parent().parent().find(".chkSelect").prop("checked") == true > 0) {
                        $(this).parent().parent().find(".txtSurName").css("border", "1px solid red");
                        isvalid = false;
                    };


                    if ($(this).parent().parent().find(".txtPassportNo").val().length > 0 && $(this).parent().parent().find(".chkSelect").prop("checked") == true > 0) {

                        //var hrbasicid = 0;
                        //if ($(this).attr("hrbasicid") != null) {
                        //    hrbasicid = $(this).attr("hrbasicid");
                        //}

                        //console.log(hrbasicid);

                        var inputdetl = AddAntiForgeryToken({
                            token: $(".txtUserSTK").val(),
                            userinfo: $(".txtServerUtilObj").val(),
                            useripaddress: $(".txtuserip").val(),
                            sessionid: $(".txtUserSes").val(),
                            methodname: "HrFamilyInfoCreate",
                            currenturl: window.location.href,

                            newdemandpassportid: $(this).attr("newdemandpassportid"),
                            remarks: $('#remarks').val(),
                            passportrecvdate: GetDateFromTextBox($('#passportrecvdate').val()),
                            letterno: $('#letterno').val(),
                            letterdate: GetDateFromTextBox($('#letterdate').val()),
                            newdemanddetlid: $(this).attr("newdemanddetlid"),
                            hrbasicid: $(this).attr("hrbasicid") ,//!= null ? $(this).attr("hrbasicid") : 0,
                            name1: $(this).parent().parent().find(".txtFirstName").val(),
                            name2: $(this).parent().parent().find(".txtSurName").val(),
                            passportno: $(this).parent().parent().find(".txtPassportNo").val(),
                            ex_nvarchar1: $(this).parent().parent().find(".txtFatherName").val(),
                            ex_date1: GetDateFromTextBox($(this).parent().parent().find(".txtBDate").val()),
                            CurrentState: typeof $(this).attr("newdemandpassportid") == "undefined" || $(this).attr("newdemandpassportid") == "null" ? 1 : 2

                        });

                        myData.push(inputdetl);
                    }
                });

                if (!isvalid) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "Input is required.",
                        type: 'red'
                    });
                    return false;
                }

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrDemandDetlPassport/HrDemandDetlPassportInsert",
                            data: {
                                __RequestVerificationToken: $('input[name=__RequestVerificationToken]').val(),
                                input: myData
                            },
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrDemandDetlPassport/HrDemandDetlPassport";
                                            $('#mcHrDemandDetlPassportEdit').html('');
                                            $('#modal-container-HrDemandDetlPassportEdit').modal('hide');
                                            GetAllDataHrDemandDetlPassport();
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
            $('#mcHrDemandDetlPassportEdit').html('');
            $('#modal-container-HrDemandDetlPassportEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






