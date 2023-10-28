

//PN: FILE NAME: "Loadhr_repatriationinfo.js"
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

    $('body').on('click', '.btnClearLandingSearch', function (event) {
        try {
            event.preventDefault();
            //$('#HrSvcInfoDt').DataTable().clear().draw();
            //$('#HrSvcInfoDt').empty();
            $('#HrRepatriationInfoDt tbody').empty();
            $('#militarynokw').val('');
            $('#militarynobd').val('');
            $('#civilid').val('');
            $('#passportno').val(''); 
            $('#hrbasicid').val('');
            $('#fullname').val('');
            $('.btnClearLandingSearch').hide();
            $('#militarynokw').removeAttr('disabled');

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    //GetAllDataHrRepatriationInfo();
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
                    $('#repat_hrbasicid').val(data[0].hrbasicid);
                   // GetAllDataHrPassportInfo(data[0].hrbasicid);
                    GetAllDataHrRepatriationInfo();
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
function GetAllDataHrRepatriationInfo() {
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
            methodname: "HrRepatriationInfoTableData",
            currenturl: window.location.href ,
            militarynokw: $('#militarynokw').val(),
            hrbasicid: $('#hrbasicid').val()
        });
        
        $('#HrRepatriationInfoDt').DataTable({
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
                "url": baseurl + "HrRepatriationInfo/HrRepatriationInfoTableData",
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
            
                { "data": "strflightdate", "searchable": true, "sortable": true, "orderable": true },
                { "data": "strsoddate", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#HrRepatriationInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrRepatriationInfoDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrRepatriationInfo', function (event) {
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
            methodname: "HrRepatriationInfoNew",
            currenturl: window.location.href,
            hrbasicid: $("#hrbasicid").val()
        });
        
        $.ajax({
            url: baseurl + "HrRepatriationInfo/HrRepatriationInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrRepatriationInfoNew').html('');
                $('#mcHrRepatriationInfoNew').html(response);
                $('#modal-container-HrRepatriationInfoNew').modal({backdrop: 'static',keyboard: false});
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



$('body').on('click', '#btnDeleteHrRepatriationInfo', function (event) {
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
                    methodname: "HrRepatriationInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrRepatriationInfo/HrRepatriationInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrRepatriationInfo/HrRepatriationInfo";
                                GetAllDataHrRepatriationInfo();
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



function HrRepatriationInfoEdit(val) {
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
            methodname: "HrRepatriationInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "HrRepatriationInfo/HrRepatriationInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrRepatriationInfoEdit').html('');
                $('#mcHrRepatriationInfoEdit').html(response);
                $('#modal-container-HrRepatriationInfoEdit').modal({backdrop: 'static',keyboard: false});
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

function HrRepatriationInfoDelete(val) {
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
                    methodname: "HrRepatriationInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrRepatriationInfo/HrRepatriationInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrRepatriationInfo();
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

function HrRepatriationInfoDetail(val) {
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
            methodname: "HrRepatriationInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrRepatriationInfo/HrRepatriationInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrRepatriationInfoDetail').html('');
                $('#mcHrRepatriationInfoDetail').html(response);
                $('#modal-container-HrRepatriationInfoDetail').modal({backdrop: 'static',keyboard: false});
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


