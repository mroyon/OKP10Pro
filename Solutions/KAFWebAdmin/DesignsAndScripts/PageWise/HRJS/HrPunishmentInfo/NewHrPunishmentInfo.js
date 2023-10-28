

//PN: FILE NAME: "Newhr_punishmentinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrPunishmentInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_PunishmentInfoNew');
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

							 punishmentid: $('#punishmentid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 punishmenttype: $('#punishmenttype').val(),
							 punishmentdate: GetDateFromTextBox($('#punishmentdate').val()),
							 offence: $('#offence').val(),
							 punishment: $('#punishment').val(),
							 punishmentdetails: $('#punishmentdetails').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrPunishmentInfo/HrPunishmentInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrPunishmentInfo/HrPunishmentInfo";
                                            $('#mcHrPunishmentInfoNew').html('');
                                            $('#modal-container-HrPunishmentInfoNew').modal('hide');
                                            GetAllDataHrPunishmentInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrPunishmentInfoNew').html('');
                                            $('#modal-container-HrPunishmentInfoNew').modal('hide');
                                            GetAllDataHrPunishmentInfo();
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
            $('#mcHrPunishmentInfoNew').html('');
            $('#modal-container-HrPunishmentInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



