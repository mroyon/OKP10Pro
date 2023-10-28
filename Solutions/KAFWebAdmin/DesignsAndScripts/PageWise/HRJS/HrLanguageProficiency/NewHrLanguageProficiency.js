

//PN: FILE NAME: "Newhr_languageproficiency.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrLanguageProficiency', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_LanguageProficiencyNew');
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

							 languageproficiencyid: $('#languageproficiencyid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 languageid: $('#languageid').val(),
							 readingproficiencyid: $('#readingproficiencyid').val(),
							 writingproficiencyid: $('#writingproficiencyid').val(),
							 speakingproficiencyid: $('#speakingproficiencyid').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrLanguageProficiency/HrLanguageProficiencyInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrLanguageProficiency/HrLanguageProficiency";
                                            $('#mcHrLanguageProficiencyNew').html('');
                                            $('#modal-container-HrLanguageProficiencyNew').modal('hide');
                                            GetAllDataHrLanguageProficiency();
                                        }
                                        else
                                        {
                                            $('#mcHrLanguageProficiencyNew').html('');
                                            $('#modal-container-HrLanguageProficiencyNew').modal('hide');
                                            GetAllDataHrLanguageProficiency();
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
            $('#mcHrLanguageProficiencyNew').html('');
            $('#modal-container-HrLanguageProficiencyNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



