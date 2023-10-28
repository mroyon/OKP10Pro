

//PN: FILE NAME: "Newhr_replacementinfodetl.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrReplacementInfoDetl', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_ReplacementInfoDetlNew');
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

							 replacementdetlid: $('#replacementdetlid').val(),
							 replacementid: $('#replacementid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 hrsvcid: $('#hrsvcid').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrReplacementInfoDetl/HrReplacementInfoDetlInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrReplacementInfoDetl/HrReplacementInfoDetl";
                                            $('#mcHrReplacementInfoDetlNew').html('');
                                            $('#modal-container-HrReplacementInfoDetlNew').modal('hide');
                                            GetAllDataHrReplacementInfoDetl();
                                        }
                                        else
                                        {
                                            $('#mcHrReplacementInfoDetlNew').html('');
                                            $('#modal-container-HrReplacementInfoDetlNew').modal('hide');
                                            GetAllDataHrReplacementInfoDetl();
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
            $('#mcHrReplacementInfoDetlNew').html('');
            $('#modal-container-HrReplacementInfoDetlNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



