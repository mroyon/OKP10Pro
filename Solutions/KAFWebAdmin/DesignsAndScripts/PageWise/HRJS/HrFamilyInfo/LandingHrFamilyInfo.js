

//PN: FILE NAME: "Loadhr_familyinfo.js"
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
    $('#HrCivilIDInfoDt tbody').empty();
    $('#militarynokw').val('');
    $('#militarynobd').val('');
    $('#civilid').val('');
    $('#passportno').val('');
    $('#fullname').val('');
    $('.btnClear').hide();
    $('#militarynokw').prop('disabled', false);
    //GetAllDataHrCivilIDInfo();

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
            $('#HrCivilIDInfoDt tbody').empty();
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

    $('body').on('click', '#btnNewHrFamilyInfo', function (event) {
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
                methodname: "HrFamilyInfoNew",
                currenturl: window.location.href,
                militarynokw: $('#militarynokw').val()
            });

            $.ajax({
                url: baseurl + "HrFamilyInfo/HrFamilyInfoNew",
                type: 'POST',
                data: input,
                success: function (response) {
                    $('#mcHrFamilyInfoNew').html('');
                    $('#mcHrFamilyInfoNew').html(response);
                    $('#modal-container-HrFamilyInfoNew').modal({ backdrop: 'static', keyboard: false });
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
    $('body').on('click', '#btnDeleteHrFamilyInfo', function (event) {
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
                        methodname: "HrFamilyInfoDelete",
                        currenturl: window.location.href,
                        strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                    });


                    $.ajax({
                        url: baseurl + "HrFamilyInfo/HrFamilyInfoDelete",
                        data: input,
                        type: 'POST',
                        success: function (response) {
                            if (response.status == "success") {
                                inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    //window.location.href = baseurl + "HrFamilyInfo/HrFamilyInfo";
                                    GetAllDataHrFamilyInfo();
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
    //GetAllDataHrFamilyInfo();
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
            url: baseurl + "HrFamilyInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
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

                    GetAllDataHrFamilyInfo(data[0].hrbasicid);
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
function GetAllDataHrFamilyInfo(hrbasicid) {
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
            methodname: "HrFamilyInfoTableData",
            currenturl: window.location.href,
            hrbasicid: hrbasicid
        });
        
        $('#HrFamilyInfoDt').DataTable({
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
                "url": baseurl + "HrFamilyInfo/HrFamilyInfoTableData",
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
            
				 { "data": "familynationalid", "searchable": true, "sortable": true, "orderable": true },                {
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
                    $('#HrFamilyInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrFamilyInfoDt_paginate').css("display", "none");
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
function HrFamilyInfoEdit(val) {
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
            methodname: "HrFamilyInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val()
        });
        
        $.ajax({
            url: baseurl + "HrFamilyInfo/HrFamilyInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrFamilyInfoEdit').html('');
                $('#mcHrFamilyInfoEdit').html(response);
                $('#modal-container-HrFamilyInfoEdit').modal({backdrop: 'static',keyboard: false});
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
function HrFamilyInfoDelete(val) {
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
                    methodname: "HrFamilyInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrFamilyInfo/HrFamilyInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrFamilyInfo();
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
function HrFamilyInfoDetail(val) {
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
            methodname: "HrFamilyInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrFamilyInfo/HrFamilyInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrFamilyInfoDetail').html('');
                $('#mcHrFamilyInfoDetail').html(response);
                $('#modal-container-HrFamilyInfoDetail').modal({backdrop: 'static',keyboard: false});
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


