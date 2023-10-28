

//PN: FILE NAME: "Newarms_disbursementinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveArmsDisbursementInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmArms_DisbursementInfoNew');
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

							 armsdisbursementid: $('#armsdisbursementid').val(),
							 basicinfoid: $('#basicinfoid').val(),
							 armsid: $('#armsid').val(),
							 issuedate: GetDateFromTextBox($('#issuedate').val()),
							 issuedby: $('#issuedby').val(),
							 returndate: GetDateFromTextBox($('#returndate').val()),
							 returnby: $('#returnby').val(),
							 issuenote: $('#issuenote').val(),
							 receivenote: $('#receivenote').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "ArmsDisbursementInfo/ArmsDisbursementInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "ArmsDisbursementInfo/ArmsDisbursementInfo";
                                            $('#mcArmsDisbursementInfoNew').html('');
                                            $('#modal-container-ArmsDisbursementInfoNew').modal('hide');
                                            GetAllDataArmsDisbursementInfo();
                                        }
                                        else
                                        {
                                            $('#mcArmsDisbursementInfoNew').html('');
                                            $('#modal-container-ArmsDisbursementInfoNew').modal('hide');
                                            GetAllDataArmsDisbursementInfo();
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
            $('#mcArmsDisbursementInfoNew').html('');
            $('#modal-container-ArmsDisbursementInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



