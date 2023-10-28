

//PN: FILE NAME: "Loadhr_attachmentinfo.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {

    //$(".modal").on("hidden.bs.modal", function () {
    //    $(".modal-body").html("");
    //});
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });

    $('#btnNewHrAttachmentInfo').hide();
    $('.btnClearLandingSearch').hide();
    //GetAllDataHrAttachmentInfo();
});
function GetDataHrBasicProfile() {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrPersonalInfoTableData",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val()
        });
        $.ajax({
            url: baseurl + "HrAttachmentInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
            type: 'POST',
            data: null,
            success: function (response) {
                var data = response.data;
                var status = response.status;
                var msg = response.responsetext;
                $("#btnNewHrRepatriationInfo").attr("disabled", "disabled");
                if (data != "" && status == "success") {
                    $("#btnNewHrRepatriationInfo").removeAttr("disabled");
                    $('#okpid').val(data[0].okpid);
                    $('#hrbasicid').val(data[0].hrbasicid);
                    $('#militarynobd').val(data[0].militarynobd);
                    $('#civilid').val(data[0].civilid);
                    $('#passportno').val(data[0].passportno);
                    $('#fullname').val(data[0].fullname);

                    GetAllDataHrAttachmentInfo(data[0].hrbasicid);

                }
                else {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: msg,
                        type: 'red'
                    });
                }
            }
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function GetAllDataHrAttachmentInfo() {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrAttachmentInfoTableData",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val(),
            hrbasicid: $('#hrbasicid').val()
        });

        $('#HrAttachmentInfoDt').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true
            }],
            "language":
            {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "ajax": {
                "url": baseurl + "HrAttachmentInfo/HrAttachmentInfoTableData",
                "type": "POST",
                "data": input
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: jqXHR.responseJSON.Error,
                    type: 'red'
                });
            },
            "columns": [
                { "data": "fromsubunit", "searchable": true, "sortable": true, "orderable": true },
                { "data": "subunit", "searchable": true, "sortable": true, "orderable": true },
                { "data": "fromcamp", "searchable": true, "sortable": true, "orderable": true },
                { "data": "camp", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "fromdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#HrAttachmentInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrAttachmentInfoDt_paginate').css("display", "none");
                }

            }
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}



$('body').on('click', '#btnLandingSearch', function (event) {
    try {


        //var isValid = true;

        if ($.trim($("#militarynokw").val()) == '') {
            isValid = false;

            $('#militarynokw').each(function () {
                $(this).css({
                    "border": "1px solid red"
                });
            });

            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: "Please enter Military No (KW).",
                type: 'red'
            });
            return;
        }
        else {
            isValid = true;
            $('#militarynokw').each(function () {
                $(this).css({
                    "border": ""
                });
            });

            $('#militarynokw').attr('disabled', 'disabled');
            $('#btnNewHrAttachmentInfo').show();
            $('.btnClearLandingSearch').show();

            GetDataHrBasicProfile();
            //GetAllDataHrAttachmentInfo();

        }
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

$('body').on('click', '#btnClearLandingSearch', function (event) {
    $('#militarynokw').val('');
    $('#militarynobd').val('');
    $('#civilid').val('');
    $('#passportno').val('');
    $('#fullname').val('');
    $('#HrAttachmentInfoDt').empty();
    $('#militarynokw').prop('disabled', false);
    $('.btnClearLandingSearch').hide();
    $('#btnNewHrAttachmentInfo').hide();
});


$('body').on('click', '#btnNewHrAttachmentInfo', function (event) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrAttachmentInfoNew",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val(),
            okpid: $('#okpid').val(),
            hrbasicid: $('#hrbasicid').val()
        });

        $.ajax({
            url: baseurl + "HrAttachmentInfo/HrAttachmentInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                if (response.status == "failed") {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: response.responsetext,
                        type: 'red'
                    });
                }
                else {
                    $('#mcHrAttachmentInfoNew').html('');
                    $('#mcHrAttachmentInfoNew').html(response);
                    $('#modal-container-HrAttachmentInfoNew').modal({ backdrop: 'static', keyboard: false });
                }
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

$('body').on('click', '#btnDeleteHrAttachmentInfo', function (event) {
    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {

                AddAntiForgeryToken = function (data) {
                    data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                    return data;
                };

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrAttachmentInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                    militarynokw: $('#militarynokw').val()
                });


                $.ajax({
                    url: baseurl + "HrAttachmentInfo/HrAttachmentInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrAttachmentInfo/HrAttachmentInfo";
                                GetAllDataHrAttachmentInfo();
                            });
                        }
                        else {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                            });
                        }
                    }
                });
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});



function HrAttachmentInfoEdit(val) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrAttachmentInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val(),
            okpid: $('#okpid').val()
        });

        $.ajax({
            url: baseurl + "HrAttachmentInfo/HrAttachmentInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrAttachmentInfoEdit').html('');
                $('#mcHrAttachmentInfoEdit').html(response);
                $('#modal-container-HrAttachmentInfoEdit').modal({ backdrop: 'static', keyboard: false });
            }
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function HrAttachmentInfoDelete(val) {
    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {

                AddAntiForgeryToken = function (data) {
                    data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                    return data;
                };

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrAttachmentInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val,
                    militarynokw: $('#militarynokw').val(),
                    okpid: $('#okpid').val()
                });


                $.ajax({
                    url: baseurl + "HrAttachmentInfo/HrAttachmentInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrAttachmentInfo();
                            });
                        }
                        else {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                            });
                        }
                    }
                });
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function HrAttachmentInfoDetail(val) {
    try {

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrAttachmentInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val(),
            okpid: $('#okpid').val()
        });

        $.ajax({
            url: baseurl + "HrAttachmentInfo/HrAttachmentInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrAttachmentInfoDetail').html('');
                $('#mcHrAttachmentInfoDetail').html(response);
                $('#modal-container-HrAttachmentInfoDetail').modal({ backdrop: 'static', keyboard: false });
            }
        });
    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}


