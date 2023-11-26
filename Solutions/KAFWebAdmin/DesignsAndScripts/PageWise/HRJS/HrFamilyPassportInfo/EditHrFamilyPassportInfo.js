

//PN: FILE NAME: "Newhr_familypassportinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrFamilyPassportInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_FamilyPassportInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 var kaffileUploader = $('#id').kaffileUploader();
			 var fileobjects_tbl_familypassportfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_familypassportfiledescription');
			 var fileobjects = fileobjects_tbl_familypassportfiledescription;

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

							 familypassportid: $('#familypassportid').val(),
							 hrfamilyid: $('#hrfamilyid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 familypassportno: $('#familypassportno').val(),
							 familypassportissuedate: GetDateFromTextBox($('#familypassportissuedate').val()),
							 familypassportexpirydate: GetDateFromTextBox($('#familypassportexpirydate').val()),
							 familypassportissuecountryid: $('#familypassportissuecountryid').val(),
							 isfamilyfamilypassport: $('#isfamilyfamilypassport').val(),
							 familypassportfiledescription: $('#familypassportfiledescription').val(),
							 familypassportfilepath: $('#familypassportfilepath').val(),
							 familypassportfilename: $('#familypassportfilename').val(),
							 familypassportfiletype: $('#familypassportfiletype').val(),
							 familypassportextension: $('#familypassportextension').val(),
							 familypassportfileid: $('#familypassportfileid').val(),
							 remarks: $('#remarks').val(),
							 forreview: $('#forreview').val(),
							 iscurrent: $('#iscurrent').val(),
							 cor_foldercontentsList: fileobjects


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfo";
                                            $('#mcHrFamilyPassportInfoEdit').html('');
                                            $('#modal-container-HrFamilyPassportInfoEdit').modal('hide');
                                            GetAllDataHrFamilyPassportInfo();
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
            $('#mcHrFamilyPassportInfoEdit').html('');
            $('#modal-container-HrFamilyPassportInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






