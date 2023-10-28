

//PN: FILE NAME: "Newhr_familyjobinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrFamilyJobInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_FamilyJobInfoNew');
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

							 hrfamilyjobid: $('#hrfamilyjobid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 hrfamilyid: $('#hrfamilyid').val(),
							 jobtype: $('#jobtype').val(),
							 organization: $('#organization').val(),
							 designation: $('#designation').val(),
							 joiningdate: GetDateFromTextBox($('#joiningdate').val()),
							 workplaceaddress: $('#workplaceaddress').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFamilyJobInfo/HrFamilyJobInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrFamilyJobInfo/HrFamilyJobInfo";
                                            $('#mcHrFamilyJobInfoNew').html('');
                                            $('#modal-container-HrFamilyJobInfoNew').modal('hide');
                                            GetAllDataHrFamilyJobInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrFamilyJobInfoNew').html('');
                                            $('#modal-container-HrFamilyJobInfoNew').modal('hide');
                                            GetAllDataHrFamilyJobInfo();
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
            $('#mcHrFamilyJobInfoNew').html('');
            $('#modal-container-HrFamilyJobInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



