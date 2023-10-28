

//PN: FILE NAME: "Newgen_subunitext.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveGenSubUnit', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmGen_SubUnitNew');
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

							 subunitid: $('#subunitid').val(),
							 subunit: $('#subunit').val(),
							 okpid: $('#okpid').val(),
                    remarks: $('#remarks').val(),
                    outsidekuwait: $('#outsidekuwait').is(':checked') ? true : false,

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenSubUnit/GenSubUnitInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenSubUnit/GenSubUnit";
                                            $('#mcGenSubUnitNew').html('');
                                            $('#modal-container-GenSubUnitNew').modal('hide');
                                            GetAllDataGenSubUnit();
                                        }
                                        else
                                        {
                                            $('#mcGenSubUnitNew').html('');
                                            $('#modal-container-GenSubUnitNew').modal('hide');
                                            GetAllDataGenSubUnit();
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
            $('#mcGenSubUnitNew').html('');
            $('#modal-container-GenSubUnitNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



