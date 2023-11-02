

//PN: FILE NAME: "Newhr_civilidinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnUpdateHrCivilIDInfo', function (event) {
        try {
            event.preventDefault();

            //var form = $('#frmCivilIDInfoEdit');
            //jQuery.validator.unobtrusive.parse();
            //jQuery.validator.unobtrusive.parse(form);
            
            //if (form.valid()) {

                var form = new FormData();

                form.append("token", $(".txtUserSTK").val());
                form.append("userinfo", $(".txtServerUtilObj").val());
                form.append("useripaddress", $(".txtuserip").val());
                form.append("sessionid", $(".txtUserSes").val());
                form.append("methodname", "HrFamilyInfoCreate");
                form.append("currenturl", window.location.href);
                form.append("__RequestVerificationToken", $('input[name=__RequestVerificationToken]').val());

                form.append("strModelPrimaryKey", $('#strModelPrimaryKey').val());
                form.append("civilid", $('#civilid').val());
                form.append("hrbasicid", $('#hrbasicid').val());
                form.append("civilidno", $('#civilidno').val());
                form.append("serialno", $('#serialno').val());
                form.append("civilidissuedate", GetDateFromTextBox($('#civilidissuedate').val()));
                form.append("civilidexpirydate", GetDateFromTextBox($('#civilidexpirydate').val()));
                //form.append("civilidfiledescription", $('#civilidfiledescription').val());
                //form.append("civilidfilepath", $('#civilidfilepath').val());
                //form.append("civilidfilename", $('#civilidfilename').val());
                //form.append("civilidfiletype", $('#civilidfiletype').val());
                //form.append("civilidextension", $('#civilidextension').val());
                form.append("civilidfileid", $('#civilidfileid').val());
                form.append("civilidfileid_2", $('#civilidfileid_2').val());
                form.append("remarks", $('#remarks').val());
                form.append("forreview", $('#forreview').val());
                form.append("iscurrent", $('#iscurrent').val());

                form.append("file1", $("#fileInput")[0].files[0]);
                form.append("file2", $("#fileInput2")[0].files[0]);
                console.log(form)
                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrCivilIDInfo/HrCivilIDInfoUpdate",
                            data: form,
                            type: 'POST',
                            cache: false,
                            contentType: false,
                            processData: false,
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrCivilIDInfo/HrCivilIDInfo";
                                            $('#mcHrCivilIDInfoEdit').html('');
                                            $('#modal-container-HrCivilIDInfoEdit').modal('hide');
                                            GetAllDataHrCivilIDInfo();
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
            //}
            //else {
            //    return;
            //}

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
            $('#mcHrCivilIDInfoEdit').html('');
            $('#modal-container-HrCivilIDInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
});

function DeleteFile(Fileid) {
    alert(Fileid)
    $("#" + Fileid).remove();
}




