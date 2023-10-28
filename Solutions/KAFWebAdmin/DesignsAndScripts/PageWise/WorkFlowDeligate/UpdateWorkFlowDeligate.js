
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
    $('#fromdate').combodate('clearValue');
    $('#todate').combodate('clearValue');
    $('#forceclosedate').combodate('clearValue');

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnWorkFlowDeligateUpdate', function (event) {
        try {
            event.preventDefault();
           
            //$('#fromdate').val( ));

            //$('#forceclosedate').val(GetDateFromTextBox($('#forceclosedate').val()));

            //$('#todate').val(GetDateFromTextBox($('#todate').val()));


            //if (combofromdate != "") {
            //    var dtspl1 = $('#fromdate').val().split("-");
            //    fromdate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
            //    fromdate = fromdate.toISOString();
            //    $('#fromdate').val(fromdate);
            //}

            //var todate = '';
            //var combotodate = $('#todate').val();
            //if (combotodate != "") {
            //    var dtspl1 = $('#todate').val().split("-");
            //    todate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
            //    todate = todate.toISOString();
            //    $('#todate').val(todate);
            //}

            //var forceclosedate = '';
            //var comboforceclosedate = $('#forceclosedate').val();
            //if (comboforceclosedate != "") {
            //    var dtspl1 = $('#forceclosedate').val().split("-");
            //    forceclosedate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
            //    forceclosedate = forceclosedate.toISOString();
            //    $('#forceclosedate').val(forceclosedate);
            //}

            var fromuserid = '';

            $($("#txtfromuserid").tokenInput('get')).each(function (index) {
                fromuserid = $(this).attr('id');
            });

            var touserid = '';

            $($("#txttouserid").tokenInput('get')).each(function (index) {
                touserid = $(this).attr('id');
            });

            var form = $('#frmUpdateWorkFlowDeligate');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowDeligateUpdate",
                    currenturl: window.location.href,

                    delegateid: $('#delegateid').val(),
                    //fromuserid: parseInt(fromuserid),
                    fromusername: fromuserid,
                    tousername: touserid,
                    fromdate: GetDateFromTextBox($('#fromdate').val()),
                    todate: GetDateFromTextBox($("#todate").val()),
                    reason: $('#reason').val(),
                    forceclosed: $('#forceclosed').val(),
                    forceclosedate: GetDateFromTextBox($('#forceclosedate').val()),
                    forceclosecomments: $('#forceclosecomments').val(),
                    comment: $('#comment').val(),
                    remarks: $('#remarks').val()
                });

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        $.ajax({
                            url: "WorkFlowDeligateUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {

                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#WorkFlowDeligateDt").DataTable().ajax.reload();
                                        $('#modal-container-WorkFlowDeligateedit').modal('hide');

                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#WorkFlowDeligateDt").DataTable().ajax.reload();
                                            $('#modal-container-WorkFlowDeligateedit').modal('hide');
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


    $('body').on('click', '#btnWorkFlowDeligateReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "WorkFlowDeligate/WorkFlowDeligate";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});

