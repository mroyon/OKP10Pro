


//PN: FILE NAME: "Newgen_leavebalancedetl.js"



var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {



    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnSaveRPTMReportParameter', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmRPTMReportParameterNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "RPTMReportParameterInsert",
                    currenturl: window.location.href,

                    strModelPrimaryKey: $('#strModelPrimaryKey').val(),
                    reportparamid: $('#reportparamid').val(),
                    reportid: $('#reportid').val(),
                    reportparamname: $('#reportparamname').val(),
                    reportparamdatatype: $('#reportparamdatatype').val(),
                    reportparamoptionalid: $('#reportparamoptionalid').val(),
                    reportparamdescription: $('#reportparamdescription').val()
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "RPTMAllReportInfo/RPTMReportParameterInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $('#mcRPTMReportParameterNew').html('');
                                            $('#modal-container-RPTMReportParameterNew').modal('hide');
                                            LoadRPTMReportParameterData(data.prikey);
                                        }
                                    });

                                }
                                else if (data.status === "failed") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $('#mcRPTMReportParameterNew').html('');
                                        $('#modal-container-RPTMReportParameterNew').modal('hide');
                                        LoadRPTMReportParameterData(data.prikey);
                                    });
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
            $('#mcRPTMReportParameterNew').html('');
            $('#modal-container-RPTMReportParameterNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});



