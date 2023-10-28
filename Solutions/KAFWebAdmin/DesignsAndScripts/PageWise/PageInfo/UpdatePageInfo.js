
$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();
   
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnEditPageInfo', function (event) {
        try {
          
            event.preventDefault();

            var form = $('#frmUpdatePageInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "CreatePageInfo",
                    currenturl: window.location.href
                    ,pageid:  $('#pageid').val()
                    ,pageguid:  $('#pageguid').val()
                    ,pagetitle:  $('#pagetitle').val()
                    ,pagedescription:  $('#pagedescription').val()
                    , pagecontent: CKEDITOR.instances['pagecontent'].getData()
                    ,pagetitlear:  $('#pagetitlear').val()
                    ,pagedescriptionar:  $('#pagedescriptionar').val()
                    ,pagecontentar: CKEDITOR.instances['pagecontentar'].getData()


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: $('#txtBaseUrl').val() + "PageInfo/PageInfo_Update",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#PageInfoDt").DataTable().ajax.reload();
                                        $('#modal-container-pageinfoedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#PageInfoDt").DataTable().ajax.reload();
                                            $('#modal-container-pageinfoedit').modal('hide');
                                        }
                                    });
                                }
                            },
                            error: function (data) {
                                var tst = '';
                            }

                        });
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            alert(e);
        }
    });


    $('body').on('click', '#btnReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = $('#txtBaseUrl').val() + "PageInfo/PageInfoList";
        } catch (e) {

        }
    });
});

