

//PN: FILE NAME: "Newhr_basicfile.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrBasicFile', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_BasicFileNew');
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

							 fileuploadid: $('#fileuploadid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 filetypeid: $('#filetypeid').val(),
							 filedescription: $('#filedescription').val(),
							 filepath: $('#filepath').val(),
							 filename: $('#filename').val(),
							 filetype: $('#filetype').val(),
							 extension: $('#extension').val(),
							 remarks: $('#remarks').val(),
							 cor_foldercontentsList: fileobjects

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrBasicFile/HrBasicFileInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrBasicFile/HrBasicFile";
                                            $('#mcHrBasicFileNew').html('');
                                            $('#modal-container-HrBasicFileNew').modal('hide');
                                            GetAllDataHrBasicFile();
                                        }
                                        else
                                        {
                                            $('#mcHrBasicFileNew').html('');
                                            $('#modal-container-HrBasicFileNew').modal('hide');
                                            GetAllDataHrBasicFile();
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
            $('#mcHrBasicFileNew').html('');
            $('#modal-container-HrBasicFileNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



