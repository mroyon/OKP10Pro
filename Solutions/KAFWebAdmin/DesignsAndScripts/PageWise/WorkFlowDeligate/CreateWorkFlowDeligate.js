
var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
    $('#fromdate').combodate('clearValue');
    $('#todate').combodate('clearValue');
    $('#forceclosedate').combodate('clearValue');
    $('.combodate select').each(function (index, item) {
        $(item).addClass('form-control');
        $(item).css('display', 'inline');
    });
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };


    $('body').on('click', '#btnCreateWorkFlowDeligate', function (event) {
        try {
            event.preventDefault();

            $('#fromdate').val(GetDateFromTextBox($('#fromdate').val()));

            $('#todate').val(GetDateFromTextBox($('#todate').val()));

            //var forceclosedate = '';
            //var comboforceclosedate = $('#forceclosedate').val();
            //if (comboforceclosedate !== "") {
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


            var form = $('#frmCreateWorkFlowDeligate');
            $(form).data("validator").settings.ignore = ":hidden:not(#fromdate)";
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "WorkFlowDeligateCreate",
                    currenturl: window.location.href,
                    fromusername: fromuserid,
                    tousername: touserid,
                    fromdate: $("#fromdate").val(),
                    todate: $("#todate").val(),
                    reason: $('#reason').val(),
                    //forceclosed: $('#forceclosed').val(),
                    //forceclosedate: $(forceclosedate).val(),
                    //forceclosecomments: $('#forceclosecomments').val(),
                    comment: $('#comment').val(),
                    remarks: $('#remarks').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "WorkFlow/WorkFlowDeligate/WorkFlowDeligateCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateWorkFlowDeligate").reset();
                                            return
                                        }
                                        else if (answer == "false") {
                                            window.location.href = data.redirectUrl;
                                        }
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
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


    $('body').on('click', '#btnReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = $('#txtBaseUrl').val() + "WorkFlow/WorkFlowDeligate/WorkFlowDeligate";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
});


