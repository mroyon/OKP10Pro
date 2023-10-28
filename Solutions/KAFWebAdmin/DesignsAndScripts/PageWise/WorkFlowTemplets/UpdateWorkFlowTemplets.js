
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
    $('#startdate').combodate('clearValue');
    $('#enddate').combodate('clearValue');

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowTempletsUpdate', function (event) {
        try {
            event.preventDefault();
            var startdate = '';
            var combostartdate = $('#startdate').val();

            if ($('#startdate').val().indexOf('T') > -1)
                combostartdate = $('#startdate').val().substring(0, $('#startdate').val().indexOf('T'));

            if (combostartdate != "") {
                var dtspl1 = $('#startdate').val().split("-");
                startdate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
                startdate = startdate.toISOString();
                $('#startdate').val(startdate);
            }

            var enddate = '';
            var comboenddate = $('#enddate').val();

            if ($('#enddate').val().indexOf('T') > -1)
                comboenddate = $('#enddate').val().substring(0, $('#enddate').val().indexOf('T'));

            if (comboenddate != "") {
                var dtspl1 = $('#enddate').val().split("-");
                enddate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
                enddate = enddate.toISOString();
                $('#enddate').val(enddate);
            }

            var form = $('#frmUpdateWorkFlowTemplets');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowTempletsUpdate",
                    currenturl: window.location.href,

                    templetid: $('#templetid').val(),
                    templateguiid: $('#templateguiid').val(),

                    templetname: $('#templetname').val(),
                    nooflevel: $('#nooflevel').val(),
                    startdate: startdate,
                    enddate: enddate,

                    processid: $('#ddl_process').val(),
                    remarks: $('#remarks').val(),
                    querytoexecution: $('#querytoexecution').val(),

                    ismailenable: $('#ismailenable[type="checkbox"]').is(":checked"),
                    issmsenable: $('#issmsenable[type="checkbox"]').is(":checked")

                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowTempletsUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowTempletsDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowTempletsedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowTempletsDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowTempletsedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowTempletsReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowTemplets/WorkFlowTemplets";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

