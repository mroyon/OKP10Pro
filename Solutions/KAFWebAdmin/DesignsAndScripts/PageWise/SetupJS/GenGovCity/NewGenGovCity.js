

//PN: FILE NAME: "Newgen_govcity.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveGenGovCity', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmGen_GovCityNew');
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

							 cityid: $('#cityid').val(),
							 parentid: $('#parentid').val(),
							 cityname: $('#cityname').val(),
							 citynamear: $('#citynamear').val(),
							 isgov: $('#isgov').val(),
							 countryid: $('#countryid').val(),
                    remarks: $('#remarks').val(),
                    area_code_paci : $('#area_code_paci').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenGovCity/GenGovCityInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenGovCity/GenGovCity";
                                            $('#mcGenGovCityNew').html('');
                                            $('#modal-container-GenGovCityNew').modal('hide');
                                            GetAllDataGenGovCity();
                                        }
                                        else
                                        {
                                            $('#mcGenGovCityNew').html('');
                                            $('#modal-container-GenGovCityNew').modal('hide');
                                            GetAllDataGenGovCity();
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
            $('#mcGenGovCityNew').html('');
            $('#modal-container-GenGovCityNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



