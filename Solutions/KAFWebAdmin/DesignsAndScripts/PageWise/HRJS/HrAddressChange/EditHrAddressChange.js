

//PN: FILE NAME: "Newhr_addresschange.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrAddressChange', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_AddressChangeEdit');
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

							 addresschangeid: $('#addresschangeid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 buildingid: $('#buildingid').val(),
							 kwgovid: $('#kwgovid').val(),
							 kwareaid: $('#kwareaid').val(),
							 kwblockno: $('#kwblockno').val(),
							 kwstreet: $('#kwstreet').val(),
							 kwhouseno: $('#kwhouseno').val(),
							 kwflatno: $('#kwflatno').val(),
							 kwmobile: $('#kwmobile').val(),
							 kwviber: $('#kwviber').val(),
							 personalemail: $('#personalemail').val(),
							 officialemail: $('#officialemail').val(),
							 bdcurdivid: $('#bdcurdivid').val(),
							 bdcurcityid: $('#bdcurcityid').val(),
							 bdcurthanaid: $('#bdcurthanaid').val(),
							 bdcurpostoffice: $('#bdcurpostoffice').val(),
							 bdcurroad: $('#bdcurroad').val(),
							 bdcurhouse: $('#bdcurhouse').val(),
							 bdcurflatno: $('#bdcurflatno').val(),
							 bdmob1: $('#bdmob1').val(),
							 bdmob2: $('#bdmob2').val(),
							 bdhomephone: $('#bdhomephone').val(),
							 bdperdivid: $('#bdperdivid').val(),
							 bdpercityid: $('#bdpercityid').val(),
							 bdperthanaid: $('#bdperthanaid').val(),
							 bdperpostoffice: $('#bdperpostoffice').val(),
							 bdperroad: $('#bdperroad').val(),
							 bdperhouse: $('#bdperhouse').val(),
							 bdperflatno: $('#bdperflatno').val(),
							 remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrAddressChange/HrAddressChangeUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrAddressChange/HrAddressChange";
                                            $('#mcHrAddressChangeEdit').html('');
                                            $('#modal-container-HrAddressChangeEdit').modal('hide');
                                            GetAllDataHrAddressChange();
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
            $('#mcHrAddressChangeEdit').html('');
            $('#modal-container-HrAddressChangeEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






