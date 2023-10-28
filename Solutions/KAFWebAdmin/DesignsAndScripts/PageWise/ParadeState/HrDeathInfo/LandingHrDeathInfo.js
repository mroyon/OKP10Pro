

//PN: FILE NAME: "Loadhr_deathinfo_history.js"
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

   // GetAllDataHrDeathInfo();

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
                $('.btnNewHrPassportInfo').show();
                $('.btnClearLandingSearch').show();

                GetDataHrBasicProfile();


            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
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
            url: baseurl + "HrDeathInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
            type: 'POST',
            data: null,
            success: function (response) {
                var data = response.data;
                var status = response.status;
                var msg = response.responsetext;
                $("#btnNewHrDeathInfo").attr("disabled", "disabled");
                if (data != "" && status == "success") {
                    $("#btnNewHrDeathInfo").removeAttr("disabled");
                    $('#hrbasicid').val(data[0].hrbasicid);
                    $('#militarynobd').val(data[0].militarynobd);
                    $('#civilid').val(data[0].civilid);
                    $('#passportno').val(data[0].passportno);
                    $('#fullname').val(data[0].fullname);

                    // GetAllDataHrPassportInfo(data[0].hrbasicid);
                    GetAllDataHrDeathInfo(data[0].hrbasicid);
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
function GetAllDataHrDeathInfo(val) {
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
            methodname: "HrDeathInfoTableData",
            currenturl: window.location.href,
            hrbasicid: val
        });
        
        $('#HrDeathInfoDt').DataTable({
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
                "url": baseurl + "HrDeathInfo/HrDeathInfoTableData",
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
            
               
                {
                    "data": "deathdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                { "data": "deathreason", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#HrDeathInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrDeathInfoDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrDeathInfo', function (event) {
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
            methodname: "HrDeathInfoNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "HrDeathInfo/HrDeathInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrDeathInfoNew').html('');
                $('#mcHrDeathInfoNew').html(response);
                $('#modal-container-HrDeathInfoNew').modal({backdrop: 'static',keyboard: false});
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

$('body').on('click', '.btnClearLandingSearch', function (event) {
    try {
        event.preventDefault();
        //$('#HrSvcInfoDt').DataTable().clear().draw();
        //$('#HrSvcInfoDt').empty();
        $('#HrDeathInfoDt tbody').empty();
        $('#militarynokw').val('');
        $('#militarynobd').val('');
        $('#civilid').val('');
        $('#passportno').val('');
        $('#fullname').val('');
        $('.btnClear').hide();
        $('#militarynokw').prop('disabled', false);

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

$('body').on('click', '#btnDeleteHrDeathInfo', function (event) {
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
                    methodname: "HrDeathInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrDeathInfo/HrDeathInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrDeathInfo/HrDeathInfo";
                                GetAllDataHrDeathInfo();
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



function HrDeathInfoEdit(val) {
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
            methodname: "HrDeathInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "HrDeathInfo/HrDeathInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrDeathInfoEdit').html('');
                $('#mcHrDeathInfoEdit').html(response);
                $('#modal-container-HrDeathInfoEdit').modal({backdrop: 'static',keyboard: false});
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

function HrDeathInfoDelete(val) {
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
                    methodname: "HrDeathInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrDeathInfo/HrDeathInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrDeathInfo();
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

function HrDeathInfoDetail(val) {
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
            methodname: "HrDeathInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrDeathInfo/HrDeathInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrDeathInfoDetail').html('');
                $('#mcHrDeathInfoDetail').html(response);
                $('#modal-container-HrDeathInfoDetail').modal({backdrop: 'static',keyboard: false});
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


