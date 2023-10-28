

//PN: FILE NAME: "Newarms_disbursementinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateArmsDisbursementInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmArms_DisbursementInfoEdit');
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
                            url: baseurl + "ArmsDisbursementInfo/ArmsDisbursementInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "ArmsDisbursementInfo/ArmsDisbursementInfo";
                                            $('#mcArmsDisbursementInfoEdit').html('');
                                            $('#modal-container-ArmsDisbursementInfoEdit').modal('hide');
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
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcArmsDisbursementInfoEdit').html('');
            $('#modal-container-ArmsDisbursementInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






