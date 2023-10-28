

//PN: FILE NAME: "Newhr_basicprofile.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHRBasicProfile', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHR_BasicProfileEdit');
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

							 hrbasicid: $('#hrbasicid').val(),
							 civilid: $('#civilid').val(),
							 civilidexpiredate: GetDateFromTextBox($('#civilidexpiredate').val()),
							 passportno: $('#passportno').val(),
							 nationalid: $('#nationalid').val(),
							 bdsmartcardid: $('#bdsmartcardid').val(),
							 name1: $('#name1').val(),
							 name2: $('#name2').val(),
							 name3: $('#name3').val(),
							 fullname: $('#fullname').val(),
							 name1ar: $('#name1ar').val(),
							 name2ar: $('#name2ar').val(),
							 name3ar: $('#name3ar').val(),
							 fullnamear: $('#fullnamear').val(),
							 dateofbirth: GetDateFromTextBox($('#dateofbirth').val()),
							 joindatebd: GetDateFromTextBox($('#joindatebd').val()),
							 remarks: $('#remarks').val(),
							 profilephoto: $('#profilephoto').val(),
							 profilephotofilepath: $('#profilephotofilepath').val(),
							 profilephotofilename: $('#profilephotofilename').val(),
							 profilephotofiletype: $('#profilephotofiletype').val(),
							 profilephotofileextension: $('#profilephotofileextension').val(),
							 forreview: $('#forreview').val(),
							 status: $('#status').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HRBasicProfile/HRBasicProfileUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HRBasicProfile/HRBasicProfile";
                                            $('#mcHRBasicProfileEdit').html('');
                                            $('#modal-container-HRBasicProfileEdit').modal('hide');
                                            GetAllDataHRBasicProfile();
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
            $('#mcHRBasicProfileEdit').html('');
            $('#modal-container-HRBasicProfileEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






