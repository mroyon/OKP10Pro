

//PN: FILE NAME: "Newstp_organization.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateStpOrganization', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmStp_OrganizationEdit');
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

							 organizationkey: $('#organizationkey').val(),
							 organizationnamear: $('#organizationnamear').val(),
							 addresslineonear: $('#addresslineonear').val(),
							 addresslinetwoar: $('#addresslinetwoar').val(),
							 phonear: $('#phonear').val(),
							 emailar: $('#emailar').val(),
							 websitear: $('#websitear').val(),
							 domainar: $('#domainar').val(),
							 faxar: $('#faxar').val(),
							 organizationname: $('#organizationname').val(),
							 addresslineone: $('#addresslineone').val(),
							 addresslinetwo: $('#addresslinetwo').val(),
							 phone: $('#phone').val(),
							 email: $('#email').val(),
							 website: $('#website').val(),
							 domain: $('#domain').val(),
							 fax: $('#fax').val(),
							 ismailenable: $('#ismailenable').val(),
							 smtphost: $('#smtphost').val(),
							 mailport: $('#mailport').val(),
							 smtpusername: $('#smtpusername').val(),
							 smtppassword: $('#smtppassword').val(),
							 mailssl: $('#mailssl').val(),
							 fromemailaddress: $('#fromemailaddress').val(),
							 maildisplayname: $('#maildisplayname').val(),
							 isftpenable: $('#isftpenable').val(),
							 ftpaddress: $('#ftpaddress').val(),
							 ftpport: $('#ftpport').val(),
							 ftpusername: $('#ftpusername').val(),
							 ftppassword: $('#ftppassword').val(),
							 isssl: $('#isssl').val(),
							 logoimg: $('#logoimg').val(),
							 webheader: $('#webheader').val(),
							 folderpath: $('#folderpath').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "StpOrganization/StpOrganizationUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "StpOrganization/StpOrganization";
                                            $('#mcStpOrganizationEdit').html('');
                                            $('#modal-container-StpOrganizationEdit').modal('hide');
                                            GetAllDataStpOrganization();
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
            $('#mcStpOrganizationEdit').html('');
            $('#modal-container-StpOrganizationEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






