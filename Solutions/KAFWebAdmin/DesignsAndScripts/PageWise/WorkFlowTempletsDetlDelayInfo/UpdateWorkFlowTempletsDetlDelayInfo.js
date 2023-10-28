
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowTempletsDetlDelayInfoUpdate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUpdateWorkFlowTempletsDetlDelayInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTempletsDetlDelayInfoUpdate",
                    currenturl: window.location.href,
                    
                                        templetdetdelayid : $('#templetdetdelayid').val(),
templetdetdelayguid : $('#templetdetdelayguid').val(),
templetdetlid : $('#templetdetlid').val(),
notifytouser : $('#notifytouser').val(),
noofdays : $('#noofdays').val(),
remarks : $('#remarks').val() 
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowTempletsDetlDelayInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowTempletsDetlDelayInfoDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowTempletsDetlDelayInfoedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowTempletsDetlDelayInfoDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowTempletsDetlDelayInfoedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowTempletsDetlDelayInfoReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowTempletsDetlDelayInfo/WorkFlowTempletsDetlDelayInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

	