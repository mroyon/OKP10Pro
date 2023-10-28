


//PN: FILE NAME: "Newgen_leavebalancedetl.js"



var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {



    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnSaveRPTMReportDataSource', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmRPTMReportDataSourceNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "RPTMReportDataSourceInsert",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $('#strModelPrimaryKey').val(),
                    reportdatasourceid: $('#reportdatasourceid').val(),
                    reportid: $('#reportid').val(),
                    reportdatasourcename: $('#reportdatasourcename').val(),
                    reportdatasourcespname: $('#reportdatasourcespname').val(),
                    reportdatasourcedescription: $('#reportdatasourcedescription').val()
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "RPTMAllReportInfo/RPTMReportDataSourceInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $('#mcRPTMReportDataSourceNew').html('');
                                            $('#modal-container-RPTMReportDataSourceNew').modal('hide');
                                            LoadDetailData(data.prikey);
                                        }
                                    });

                                }
                                else if (data.status === "failed") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $('#mcRPTMReportDataSourceNew').html('');
                                        $('#modal-container-RPTMReportDataSourceNew').modal('hide');
                                        LoadDetailData(data.prikey);
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
            $('#mcRPTMReportDataSourceNew').html('');
            $('#modal-container-RPTMReportDataSourceNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});



