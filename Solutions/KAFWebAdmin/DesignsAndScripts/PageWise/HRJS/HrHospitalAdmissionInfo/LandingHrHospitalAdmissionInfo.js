

//PN: FILE NAME: "Loadhr_hospitaladmissioninfo.js"
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

    $('.btnNewHrHospitalAdmissionInfo').hide();
    $('#btnClearHrHospitalAdmissionInfo').hide();
    $('#militarynokw').keypress(function (e) {
        var key = e.which;
        if (key == 13)  // the enter key code
        {
            $('#btnLandingSearch').trigger('click');
            return false;
        }
    });

});


$('body').on('click', '#btnClearHrHospitalAdmissionInfo', function (event) {
    try {
        $('#HrHospitalAdmissionInfoDt').empty();
        $('#militarynokw').val("");
        $('#hrbasicid').val("");
        $('#militarynobd').val("");
        $('#civiliddisplay').val("");
        $('#fullnamedisplay').val("");
        $('#passportno').val("");
        $('#passportno').val("");
        $('#militarynokw').prop("disabled", false);
        $('#btnClearHrHospitalAdmissionInfo').hide();
        

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
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
            //$('.btnNewHrHospitalAdmissionInfo').show();
            $('#btnClearHrHospitalAdmissionInfo').show();

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
            url: baseurl + "HrHospitalAdmissionInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
            type: 'POST',
            data: null,
            success: function (response) {
                var data = response.data;

                var status = response.status;
                var msg = response.responsetext;
                console.log(data);
                if (data != "" && status == "success") {
                    $('#hrbasicid').val(data[0].hrbasicid);
                    $('#militarynobd').val(data[0].militarynobd);
                    $('#civiliddisplay').val(data[0].civilid);
                    $('#fullnamedisplay').val(data[0].fullname);
                    $('#passportno').val(data[0].passportno);

                    if (data[0].civilid)
                        var trHTML = "";

                    $('#HrHospitalAdmissionInfoDt').append(trHTML);
                    GetAllDataHrHospitalAdmissionInfo($('#militarynokw').val());

                    if ((data[0].hospitaladmissionid > 0) && (data[0].hospitalreleasedate == undefined || data[0].hospitalreleasedate == null)) {
                        $("#btnNewHrHospitalAdmissionInfo").hide();
                    } else {
                        $('#btnNewHrHospitalAdmissionInfo').show();
                    }

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

function GetAllDataHrHospitalAdmissionInfo(val) {
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
            methodname: "HrHospitalAdmissionInfoTableData",
            currenturl: window.location.href,
            militarynokw: val
        });

        $('#HrHospitalAdmissionInfoDt').DataTable({
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
                "url": baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoTableData",
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

                { "data": "hospitalname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "diseasename", "searchable": true, "sortable": true, "orderable": true },
                { "data": "hospitaladmissiondate", "render": function (data, type, full, meta) { return datetoStr(data); } },
                { "data": "hospitalreleasedate", "render": function (data, type, full, meta) { return datetoStr(data); } },
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
                    $('#HrHospitalAdmissionInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrHospitalAdmissionInfoDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrHospitalAdmissionInfo', function (event) {
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
            methodname: "HrHospitalAdmissionInfoNew",
            currenturl: window.location.href
        });

        $.ajax({
            url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrHospitalAdmissionInfoNew').html('');
                $('#mcHrHospitalAdmissionInfoNew').html(response);
                $('#modal-container-HrHospitalAdmissionInfoNew').modal({ backdrop: 'static', keyboard: false });
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



$('body').on('click', '#btnDeleteHrHospitalAdmissionInfo', function (event) {
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
                    methodname: "HrHospitalAdmissionInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfo";
                                GetAllDataHrHospitalAdmissionInfo($('#militarynokw').val());

                                if ((data[0].hospitaladmissionid > 0) && (data[0].hospitalreleasedate == undefined || data[0].hospitalreleasedate == null)) {
                                    $("#btnNewHrHospitalAdmissionInfo").hide();
                                } else {
                                    $('#btnNewHrHospitalAdmissionInfo').show();
                                }
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



function HrHospitalAdmissionInfoEdit(val) {
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
            methodname: "HrHospitalAdmissionInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            pageInfo: "admit"
        });

        $.ajax({
            url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrHospitalAdmissionInfoEdit').html('');
                $('#mcHrHospitalAdmissionInfoEdit').html(response);
                $('#modal-container-HrHospitalAdmissionInfoEdit').modal({ backdrop: 'static', keyboard: false });
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

function HrHospitalAdmissionInfoDelete(val) {
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
                    methodname: "HrHospitalAdmissionInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrHospitalAdmissionInfo();
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

function HrHospitalAdmissionInfoDetail(val) {
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
            methodname: "HrHospitalAdmissionInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrHospitalAdmissionInfoDetail').html('');
                $('#mcHrHospitalAdmissionInfoDetail').html(response);
                $('#modal-container-HrHospitalAdmissionInfoDetail').modal({ backdrop: 'static', keyboard: false });
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


