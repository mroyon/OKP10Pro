var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {


    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnUpdateRPTMReportParameter', function (event) {
        try {

            event.preventDefault();

            var form = $('#frmRPTMReportParameterEdit');
            var validator = $.data(form[0], 'validator');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);


            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "RPTMReportParameterUpdate",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $('#strAdditionalPrimaryKey').val(),

                    reportparamid: $('#reportparamid').val(),
                    reportid: $('#reportid').val(),
                    reportparamname: $('#reportparamname').val(),
                    reportparamdatatype: $('#reportparamdatatype').val(),
                    reportparamoptionalid: $('#reportparamoptionalid').val(),
                    reportparamdescription: $('#reportparamdescription').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"),
                    _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                        if (answer == "true") {

                            $.ajax({
                                url: baseurl + "RPTMAllReportInfo/RPTMReportParameterUpdate",
                                data: input,
                                type: 'POST',
                                success: function (data) {
                                    if (data.status === "success") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            $('#mcRPTMReportParameterEdit').html('');
                                            $('#modal-container-RPTMReportParameterEdit').modal('hide');
                                            LoadRPTMReportParameterData(data.prikey);
                                        });
                                    }
                                    else if (data.status === "failed") {
                                        inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                            $('#mcRPTMReportParameterEdit').html('');
                                            $('#modal-container-RPTMReportParameterEdit').modal('hide');
                                            LoadRPTMReportParameterData(data.prikey);
                                        });
                                    }
                                }
                            });
                        }
                        else {
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
            $('#mcRPTMReportParameterEdit').html('');
            $('#modal-container-RPTMReportParameterEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});

