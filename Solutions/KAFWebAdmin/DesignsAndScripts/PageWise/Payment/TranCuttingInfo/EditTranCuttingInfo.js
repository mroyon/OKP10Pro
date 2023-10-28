

//PN: FILE NAME: "Newtran_cuttinginfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateTranCuttingInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmCuttingInfoEdit');
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

							 cuttinginfoid: $('#cuttinginfoid').val(),
							 okpid: $('#okpid').val(),
							 monthid: $('#monthid').val(),
							 year: $('#year').val(),
							 processdate: GetDateFromTextBox($('#processdate').val()),
							 reviewdate: GetDateFromTextBox($('#reviewdate').val()),
							 reviewremarks: $('#reviewremarks').val(),
							 isapproved: $('#isapproved').val(),
							 approvedate: GetDateFromTextBox($('#approvedate').val()),
							 approveby: $('#approveby').val(),
							 approveremarks: $('#approveremarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "TranCuttingInfo/TranCuttingInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "TranCuttingInfo/TranCuttingInfo";
                                            $('#mcTranCuttingInfoEdit').html('');
                                            $('#modal-container-TranCuttingInfoEdit').modal('hide');
                                            GetAllDataTranCuttingInfo();
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
            $('#mcTranCuttingInfoEdit').html('');
            $('#modal-container-TranCuttingInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






