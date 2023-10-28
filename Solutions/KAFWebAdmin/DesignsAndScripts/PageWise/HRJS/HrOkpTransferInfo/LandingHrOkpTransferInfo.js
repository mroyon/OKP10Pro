

//PN: FILE NAME: "Loadhr_okptransferinfo.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {

    //$(".modal").on("hidden.bs.modal", function () {
    //    $(".modal-body").html("");
    //});
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
        //$('.modal').modal('dispose');
    });

    $('#btnNewHrOkpTransferInfo').hide();
    $('.btnClearLandingSearch').hide();
    //GetAllDataHrOkpTransferInfo();
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
            url: baseurl + "HrRepatriationInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
            type: 'POST',
            data: null,
            success: function (response) {
                var data = response.data;
                var status = response.status;
                var msg = response.responsetext;
                $("#btnNewHrRepatriationInfo").attr("disabled", "disabled");
                if (data != "" && status == "success") {
                    $("#btnNewHrRepatriationInfo").removeAttr("disabled");
                    $('#hrbasicid').val(data[0].hrbasicid);
                    $('#militarynobd').val(data[0].militarynobd);
                    $('#civilid').val(data[0].civilid);
                    $('#passportno').val(data[0].passportno);
                    $('#fullname').val(data[0].fullname);

                    // GetAllDataHrPassportInfo(data[0].hrbasicid);
                    GetAllDataHrOkpTransferInfo(data[0].hrbasicid);
                    //console.log($('#hrbasicid').val());
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

function GetAllDataHrOkpTransferInfo() {
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
            methodname: "HrOkpTransferInfoTableData",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val(),
            hrbasicid: $('#hrbasicid').val()
        });

        $('#HrOkpTransferInfoDt').DataTable({
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
                "url": baseurl + "HrOkpTransferInfo/HrOkpTransferInfoTableData",
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
                { "data": "fromokp", "searchable": true, "sortable": true, "orderable": true },
                { "data": "tookp", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "transferdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },

                { "data": "reason", "searchable": true, "sortable": true, "orderable": true },                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {
                $('#btnNewHrOkpTransferInfo').show();
                //var rowCount = $('#HrOkpTransferInfoDt').DataTable().rows().count();
                //if (rowCount == 0) $('.btnNewHrOkpTransferInfo').show();
                //else $('.btnNewHrOkpTransferInfo').hide();

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#HrOkpTransferInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrOkpTransferInfoDt_paginate').css("display", "none");
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
            $('#btnNewHrOkpTransferInfo').show();
            $('.btnClearLandingSearch').show();

            GetDataHrBasicProfile();
            //GetAllDataHrOkpTransferInfo();

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
    $('#HrOkpTransferInfoDt').empty();
    $('#militarynokw').prop('disabled', false);
    $('.btnClearLandingSearch').hide();
    $('#btnNewHrOkpTransferInfo').hide();
});


$('body').on('click', '#btnNewHrOkpTransferInfo', function (event) {
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
            methodname: "HrOkpTransferInfoNew",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val()
        });

        $.ajax({
            url: baseurl + "HrOkpTransferInfo/HrOkpTransferInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrOkpTransferInfoNew').html('');
                $('#mcHrOkpTransferInfoNew').html(response);
                $('#modal-container-HrOkpTransferInfoNew').modal({ backdrop: 'static', keyboard: false });
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

$('body').on('click', '#btnDeleteHrOkpTransferInfo', function (event) {
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
                    methodname: "HrOkpTransferInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrOkpTransferInfo/HrOkpTransferInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrOkpTransferInfo/HrOkpTransferInfo";
                                GetAllDataHrOkpTransferInfo();
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



function HrOkpTransferInfoEdit(val) {
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
            methodname: "HrOkpTransferInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val()
        });

        $.ajax({
            url: baseurl + "HrOkpTransferInfo/HrOkpTransferInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrOkpTransferInfoEdit').html('');
                $('#mcHrOkpTransferInfoEdit').html(response);
                $('#modal-container-HrOkpTransferInfoEdit').modal({ backdrop: 'static', keyboard: false });
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

function HrOkpTransferInfoDelete(val) {
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
                    methodname: "HrOkpTransferInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val,
                    militarynokw: $('#militarynokw').val()
                });


                $.ajax({
                    url: baseurl + "HrOkpTransferInfo/HrOkpTransferInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrOkpTransferInfo();
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

function HrOkpTransferInfoDetail(val) {
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
            methodname: "HrOkpTransferInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val()
        });

        $.ajax({
            url: baseurl + "HrOkpTransferInfo/HrOkpTransferInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrOkpTransferInfoDetail').html('');
                $('#mcHrOkpTransferInfoDetail').html(response);
                $('#modal-container-HrOkpTransferInfoDetail').modal({ backdrop: 'static', keyboard: false });
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


