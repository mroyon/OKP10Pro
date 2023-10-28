

//PN: FILE NAME: "Newhr_documentupload.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrDocumentUpload', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmDocumentUploadNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

    
            if (form.valid()) {



                var frmdata = new FormData();
                frmdata.append("file", $("#fileupload")[0].files[0]);
                var filename = $("#fileupload").val().split("\\").pop();
                frmdata.append("attachment", filename);
                frmdata.append("actualtotalfiles", 1);
                frmdata.append("__RequestVerificationToken", $('input[name=__RequestVerificationToken]').val());
                frmdata.append("token", $(".txtUserSTK").val());
                frmdata.append("userinfo", $(".txtServerUtilObj").val());
                frmdata.append("useripaddress", $(".txtuserip").val());
                frmdata.append("sessionid", $(".txtUserSes").val());
                frmdata.append("methodname", "Update_Profile");
                frmdata.append("currenturl", window.location.href);
                frmdata.append("militarynokw", $("#militarynokw").val());
                
               


        //        var input = AddAntiForgeryToken({
        //            token: $(".txtUserSTK").val(),
        //            userinfo: $(".txtServerUtilObj").val(),
        //            useripaddress: $(".txtuserip").val(),
        //            sessionid: $(".txtUserSes").val(),
        //            methodname: "HrFamilyInfoCreate",
        //            currenturl: window.location.href,

							 //docuploadid: $('#docuploadid').val(),
							 //doctypeid: $('#doctypeid').val(),
							 //filetypeid: $('#filetypeid').val(),
							 //docname: $('#docname').val(),
							 //hrbasicid: $('#hrbasicid').val(),
							 //orderno: $('#orderno').val(),
							 //orderdate: GetDateFromTextBox($('#orderdate').val()),
							 //filedescription: $('#filedescription').val(),
							 //filepath: $('#filepath').val(),
							 //filename: $('#filename').val(),
							 //filetype: $('#filetype').val(),
							 //extension: $('#extension').val(),
							 //remarks: $('#remarks').val()

        //        });
                frmdata.append("doctypeid", $('#doctypeid').val());
                frmdata.append("hrbasicidLanding", $('#hrbasicidLanding').val());
                frmdata.append("remarks", $('#remarks').val());
                //frmdata.append("filedescription", $('#filedescription').val());
                frmdata.append("docname", $('#docname').val());


                //console.log(frmdata)

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrDocumentUpload/HrDocumentUploadInsert",
                            data: frmdata,
                            processData: false,
                            contentType: false,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrDocumentUpload/HrDocumentUpload";
                                            $('#mcHrDocumentUploadNew').html('');
                                            $('#modal-container-HrDocumentUploadNew').modal('hide');
                                            GetAllDataHrDocumentUpload();
                                        }
                                        else
                                        {
                                            $('#mcHrDocumentUploadNew').html('');
                                            $('#modal-container-HrDocumentUploadNew').modal('hide');
                                            GetAllDataHrDocumentUpload();
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
            $('#mcHrDocumentUploadNew').html('');
            $('#modal-container-HrDocumentUploadNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



