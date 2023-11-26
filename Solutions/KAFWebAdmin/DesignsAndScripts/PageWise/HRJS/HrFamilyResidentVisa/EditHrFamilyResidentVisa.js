

//PN: FILE NAME: "Newhr_familyresidentvisa.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrFamilyResidentVisa', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_FamilyResidentVisaEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 var kaffileUploader = $('#id').kaffileUploader();
			 var fileobjects_tbl_filedescription = $('#id').kaffileUploader.GetFilesForActions('tbl_filedescription');
			 var fileobjects = fileobjects_tbl_filedescription;

			  $.each(fileobjects, function (key, valueObj) {
					  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
			   });



            
            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 familyresidentid: $('#familyresidentid').val(),
							 hrfamilyid: $('#hrfamilyid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 familypassportid: $('#familypassportid').val(),
							 residencynumber: $('#residencynumber').val(),
							 issuedate: GetDateFromTextBox($('#issuedate').val()),
							 expirydate: GetDateFromTextBox($('#expirydate').val()),
							 isfamilyvisa: $('#isfamilyvisa').val(),
							 filedescription: $('#filedescription').val(),
							 filepath: $('#filepath').val(),
							 filename: $('#filename').val(),
							 filetype: $('#filetype').val(),
							 extension: $('#extension').val(),
							 fileno: $('#fileno').val(),
							 remarks: $('#remarks').val(),
							 cor_foldercontentsList: fileobjects


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFamilyResidentVisa/HrFamilyResidentVisaUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrFamilyResidentVisa/HrFamilyResidentVisa";
                                            $('#mcHrFamilyResidentVisaEdit').html('');
                                            $('#modal-container-HrFamilyResidentVisaEdit').modal('hide');
                                            GetAllDataHrFamilyResidentVisa();
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
            $('#mcHrFamilyResidentVisaEdit').html('');
            $('#modal-container-HrFamilyResidentVisaEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






