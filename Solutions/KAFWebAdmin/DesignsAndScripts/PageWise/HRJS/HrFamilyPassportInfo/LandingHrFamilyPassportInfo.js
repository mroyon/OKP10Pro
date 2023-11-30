

//PN: FILE NAME: "Loadhr_familypassportinfo.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });
    $('#HrFamilyPassportInfoDt tbody').empty();
    $('#militarynokw').val('');
    $('#militarynobd').val('');
    $('#civilid').val('');
    $('#passportno').val('');
    $('#fullname').val('');
    $('.btnClear').hide();
    $('#militarynokw').prop('disabled', false);

    $('#militarynokw').keypress(function (e) {
        var key = e.which;
        if (key == 13)  // the enter key code
        {
            $('#btnLandingSearch').trigger('click');
            return false;
        }
    });
    $('body').on('click', '#btnLandingSearch', function (event) {
        try {
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
    $('body').on('click', '.btnClearLandingSearch', function (event) {
        try {
            event.preventDefault();
            //$('#HrSvcInfoDt').DataTable().clear().draw();
            //$('#HrSvcInfoDt').empty();
            $('#HrFamilyPassportInfoDt tbody').empty();
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
    $('body').on('click', '#btnNewHrFamilyPassportInfo', function (event) {
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
                methodname: "HrFamilyPassportInfoNew",
                currenturl: window.location.href,
                militarynokw: $('#militarynokw').val()
            });

            $.ajax({
                url: baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfoNew",
                type: 'POST',
                data: input,
                success: function (response) {
                    $('#mcHrFamilyPassportInfoNew').html('');
                    $('#mcHrFamilyPassportInfoNew').html(response);
                    $('#modal-container-HrFamilyPassportInfoNew').modal({ backdrop: 'static', keyboard: false });
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
    $('body').on('click', '#btnDeleteHrFamilyPassportInfo', function (event) {
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
                        methodname: "HrFamilyPassportInfoDelete",
                        currenturl: window.location.href,
                        strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                    });


                    $.ajax({
                        url: baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfoDelete",
                        data: input,
                        type: 'POST',
                        success: function (response) {
                            if (response.status == "success") {
                                inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    //window.location.href = baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfo";
                                    GetAllDataHrFamilyPassportInfo();
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
});

function GetAllDataHrFamilyPassportInfo(hrbasicid) {
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
            methodname: "HrFamilyPassportInfoTableData",
            currenturl: window.location.href
        });
        
        $('#HrFamilyPassportInfoDt').DataTable({
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
                "url": baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfoTableData",
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
            
				 { "data": "familypassportno", "searchable": true, "sortable": true, "orderable": true },                {
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
                    $('#HrFamilyPassportInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrFamilyPassportInfoDt_paginate').css("display", "none");
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
function HrFamilyPassportInfoEdit(val) {
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
            methodname: "HrFamilyPassportInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val()
        });
        
        $.ajax({
            url: baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrFamilyPassportInfoEdit').html('');
                $('#mcHrFamilyPassportInfoEdit').html(response);
                $('#modal-container-HrFamilyPassportInfoEdit').modal({backdrop: 'static',keyboard: false});
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
function HrFamilyPassportInfoDelete(val) {
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
                    methodname: "HrFamilyPassportInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrFamilyPassportInfo/HrFamilyPassportInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrFamilyPassportInfo();
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
function HrFamilyPassportInfoDetail(val) {
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
            methodname: "HrFamilyPassportInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrFamilyPassportInfo/HrFamilyPassportInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrFamilyPassportInfoDetail').html('');
                $('#mcHrFamilyPassportInfoDetail').html(response);
                $('#modal-container-HrFamilyPassportInfoDetail').modal({backdrop: 'static',keyboard: false});
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
            url: baseurl + "HrFamilyPassportInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
            type: 'POST',
            data: null,
            success: function (response) {
                var data = response.data;
                var status = response.status;
                var msg = response.responsetext;

                if (data != "" && status == "success") {
                    $('#hrbasicid').val(data[0].hrbasicid);
                    $('#militarynobd').val(data[0].militarynobd);
                    $('#civilid').val(data[0].civilid);
                    $('#passportno').val(data[0].passportno);
                    $('#fullname').val(data[0].fullname);

                    GetAllDataHrFamilyPassportInfo(data[0].hrbasicid);
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