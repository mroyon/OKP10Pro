

//PN: FILE NAME: "Newstp_organizationentitytype.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveStpOrganizationEntityType', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmStp_OrganizationEntityTypeNew');
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

							 entirytypekey: $('#entirytypekey').val(),
							 organizationkey: $('#organizationkey').val(),
							 entirytypecode: $('#entirytypecode').val(),
							 entirytype: $('#entirytype').val(),
							 description: $('#description').val(),
							 entitylevel: $('#entitylevel').val(),
							 isactive: $('#isactive').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "StpOrganizationEntityType/StpOrganizationEntityTypeInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "StpOrganizationEntityType/StpOrganizationEntityType";
                                            $('#mcStpOrganizationEntityTypeNew').html('');
                                            $('#modal-container-StpOrganizationEntityTypeNew').modal('hide');
                                            GetAllDataStpOrganizationEntityType();
                                        }
                                        else
                                        {
                                            $('#mcStpOrganizationEntityTypeNew').html('');
                                            $('#modal-container-StpOrganizationEntityTypeNew').modal('hide');
                                            GetAllDataStpOrganizationEntityType();
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
            $('#mcStpOrganizationEntityTypeNew').html('');
            $('#modal-container-StpOrganizationEntityTypeNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



