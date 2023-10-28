﻿

//PN: FILE NAME: "Newhr_bankloaninfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrBankLoanInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_BankLoanInfoNew');
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

							 hrbankloanid: $('#hrbankloanid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 bankid: $('#bankid').val(),
							 branchid: $('#branchid').val(),
							 loanamount: $('#loanamount').val(),
							 lastpaiddate: GetDateFromTextBox($('#lastpaiddate').val()),
							 islastinstallmentpaid: $('#islastinstallmentpaid').val(),
							 description: $('#description').val(),
							 remarks: $('#remarks').val(),
							 forreview: $('#forreview').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrBankLoanInfo/HrBankLoanInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrBankLoanInfo/HrBankLoanInfo";
                                            $('#mcHrBankLoanInfoNew').html('');
                                            $('#modal-container-HrBankLoanInfoNew').modal('hide');
                                            GetAllDataHrBankLoanInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrBankLoanInfoNew').html('');
                                            $('#modal-container-HrBankLoanInfoNew').modal('hide');
                                            GetAllDataHrBankLoanInfo();
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
            $('#mcHrBankLoanInfoNew').html('');
            $('#modal-container-HrBankLoanInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



