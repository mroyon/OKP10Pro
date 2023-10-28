

//PN: FILE NAME: "Newhr_medicalinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrMedicalInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_MedicalInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 var kaffileUploader = $('#id').kaffileUploader();
			 var fileobjects_tbl_medcommissionfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_medcommissionfiledescription');
			 var fileobjects_tbl_docfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_docfiledescription');
			 var fileobjects = fileobjects_tbl_medcommissionfiledescription.concat(fileobjects_tbl_docfiledescription);

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

							 miltmedicalid: $('#miltmedicalid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 medcommissionno: $('#medcommissionno').val(),
							 medcommsisiondate: GetDateFromTextBox($('#medcommsisiondate').val()),
							 medcommissionfiledescription: $('#medcommissionfiledescription').val(),
							 medcommissionfilepath: $('#medcommissionfilepath').val(),
							 medcommissionfilename: $('#medcommissionfilename').val(),
							 medcommissionfiletype: $('#medcommissionfiletype').val(),
							 medcommissionextension: $('#medcommissionextension').val(),
							 medcommissionfileno: $('#medcommissionfileno').val(),
							 medcommissiondesc: $('#medcommissiondesc').val(),
							 docno: $('#docno').val(),
							 docdate: GetDateFromTextBox($('#docdate').val()),
							 docfiledescription: $('#docfiledescription').val(),
							 docfilepath: $('#docfilepath').val(),
							 docfilename: $('#docfilename').val(),
							 docfiletype: $('#docfiletype').val(),
							 docextension: $('#docextension').val(),
							 docfileno: $('#docfileno').val(),
							 medaction: $('#medaction').val(),
							 remarks: $('#remarks').val(),
							 cor_foldercontentsList: fileobjects

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrMedicalInfo/HrMedicalInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrMedicalInfo/HrMedicalInfo";
                                            $('#mcHrMedicalInfoNew').html('');
                                            $('#modal-container-HrMedicalInfoNew').modal('hide');
                                            GetAllDataHrMedicalInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrMedicalInfoNew').html('');
                                            $('#modal-container-HrMedicalInfoNew').modal('hide');
                                            GetAllDataHrMedicalInfo();
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
            $('#mcHrMedicalInfoNew').html('');
            $('#modal-container-HrMedicalInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



