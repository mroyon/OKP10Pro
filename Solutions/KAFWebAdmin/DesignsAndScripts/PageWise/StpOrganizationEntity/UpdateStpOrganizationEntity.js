
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnStpOrganizationEntityUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateStpOrganizationEntity');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "StpOrganizationEntityUpdate",
                    currenturl: window.location.href,

                    entitykey: $('#entitykey').val(),
                    organizationkey: $('#organizationkey').val(),
                    parentkey: $('#parentkey').val(),
                    entirytypekey: $('#entirytypekey').val(),
                    entitylevel: $('#entitylevel').val(),
                    seqfirstindex: $('#seqfirstindex').val(),
                    seqfullindex: $('#seqfullindex').val(),
                    entitycpde: $('#entitycpde').val(),
                    entityname: $('#entityname').val(),
                    description: $('#description').val(),
                    isactive: $('#isactive').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "StpOrganizationEntityUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#StpOrganizationEntityDt").DataTable().ajax.reload();
                                        $('#modal-container-StpOrganizationEntityedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#StpOrganizationEntityDt").DataTable().ajax.reload();
                                            $('#modal-container-StpOrganizationEntityedit').modal('hide');
                                        }
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


    $('body').on('click', '#btnStpOrganizationEntityReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "StpOrganizationEntity/StpOrganizationEntity";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

