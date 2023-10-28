

//PN: FILE NAME: "Newhr_newdemanddetl.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrNewDemandDetl', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_NewDemandDetlNew');
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

							 newdemanddetlid: $('#newdemanddetlid').val(),
							 newdemandid: $('#newdemandid').val(),
							 rankid: $('#rankid').val(),
							 tradeid: $('#tradeid').val(),
							 groupid: $('#groupid').val(),
							 okpid: $('#okpid').val(),
							 noofvacancies: $('#noofvacancies').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrNewDemandDetl/HrNewDemandDetlInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrNewDemandDetl/HrNewDemandDetl";
                                            $('#mcHrNewDemandDetlNew').html('');
                                            $('#modal-container-HrNewDemandDetlNew').modal('hide');
                                            GetAllDataHrNewDemandDetl();
                                        }
                                        else
                                        {
                                            $('#mcHrNewDemandDetlNew').html('');
                                            $('#modal-container-HrNewDemandDetlNew').modal('hide');
                                            GetAllDataHrNewDemandDetl();
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
            $('#mcHrNewDemandDetlNew').html('');
            $('#modal-container-HrNewDemandDetlNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



