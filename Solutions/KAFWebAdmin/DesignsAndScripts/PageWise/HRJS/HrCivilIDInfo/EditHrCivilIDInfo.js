

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

            var form = $('#frmCivilIDInfoEdit');
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

							 civilid: $('#civilid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 civilidno: $('#civilidno').val(),
							 serialno: $('#serialno').val(),
							 civilidissuedate: GetDateFromTextBox($('#civilidissuedate').val()),
							 civilidexpirydate: GetDateFromTextBox($('#civilidexpirydate').val()),
							 civilidfiledescription: $('#civilidfiledescription').val(),
							 civilidfilepath: $('#civilidfilepath').val(),
							 civilidfilename: $('#civilidfilename').val(),
							 civilidfiletype: $('#civilidfiletype').val(),
							 civilidextension: $('#civilidextension').val(),
							 civilidfileid: $('#civilidfileid').val(),
							 remarks: $('#remarks').val(),
							 forreview: $('#forreview').val(),
							 iscurrent: $('#iscurrent').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrCivilIDInfo/HrCivilIDInfoUpdate",
                            data: input,
                            type: 'POST',
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






