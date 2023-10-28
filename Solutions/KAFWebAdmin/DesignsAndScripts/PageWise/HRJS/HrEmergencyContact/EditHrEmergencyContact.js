

//PN: FILE NAME: "Newhr_emergencycontact.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrEmergencyContact', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_EmergencyContactEdit');
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

							 emergencycontactid: $('#emergencycontactid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 relationshipid: $('#relationshipid').val(),
							 name1: $('#name1').val(),
							 name2: $('#name2').val(),
							 name3: $('#name3').val(),
							 name4: $('#name4').val(),
							 name5: $('#name5').val(),
							 fullname: $('#fullname').val(),
							 curbdaddressflatno: $('#curbdaddressflatno').val(),
							 curbdaddresshouseno: $('#curbdaddresshouseno').val(),
							 curbdaddressstreet: $('#curbdaddressstreet').val(),
							 curbdadrresspo: $('#curbdadrresspo').val(),
							 curbdadrressps: $('#curbdadrressps').val(),
							 curbdaddressdist: $('#curbdaddressdist').val(),
							 curbdaddressdivision: $('#curbdaddressdivision').val(),
							 mobilebd: $('#mobilebd').val(),
							 telephonebd: $('#telephonebd').val(),
							 perbdaddressflatno: $('#perbdaddressflatno').val(),
							 perbdaddresshouseno: $('#perbdaddresshouseno').val(),
							 perbdaddressstreet: $('#perbdaddressstreet').val(),
							 perbdadrresspo: $('#perbdadrresspo').val(),
							 perbdadrressps: $('#perbdadrressps').val(),
							 perbdaddressdivision: $('#perbdaddressdivision').val(),
							 perbdaddressdist: $('#perbdaddressdist').val(),
							 curkwaddressflatno: $('#curkwaddressflatno').val(),
							 curkwaddresshouseno: $('#curkwaddresshouseno').val(),
							 curkwaddressstreet: $('#curkwaddressstreet').val(),
							 curkwadrressblock: $('#curkwadrressblock').val(),
							 curkwadrressavenue: $('#curkwadrressavenue').val(),
							 curkwgovnerid: $('#curkwgovnerid').val(),
							 curkwareaid: $('#curkwareaid').val(),
							 curkwpacino: $('#curkwpacino').val(),
							 mobilekw: $('#mobilekw').val(),
							 telephonekw: $('#telephonekw').val(),
							 remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrEmergencyContact/HrEmergencyContactUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrEmergencyContact/HrEmergencyContact";
                                            $('#mcHrEmergencyContactEdit').html('');
                                            $('#modal-container-HrEmergencyContactEdit').modal('hide');
                                            GetAllDataHrEmergencyContact();
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
            $('#mcHrEmergencyContactEdit').html('');
            $('#modal-container-HrEmergencyContactEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






