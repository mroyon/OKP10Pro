

//PN: FILE NAME: "Loadhr_leaveinfo_history.js"
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

   // GetAllDataHrLeaveCancel();
});

function GetAllDataHrLeaveCancel(val) {
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
            methodname: "HrLeaveCancelTableData",
            currenturl: window.location.href,
            hrbasicid: val
        });
        
        $('#HrLeaveCancelDt').DataTable({
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
                "url": baseurl + "HrLeaveCancel/HrLeaveCancelTableData",
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
                
                { "data": "leavetype", "searchable": true, "sortable": true, "orderable": true },
                { "data": "letterno", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "letterdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
               
                {
                    "data": "leavestartdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                {
                    "data": "leaveenddate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                { "data": "leavedays", "searchable": true, "sortable": true, "orderable": true },
               

                { "data": "strcancel", "searchable": true, "sortable": true, "orderable": true },
                { "data": "strreturn", "searchable": true, "sortable": true, "orderable": true },
                { "data": "strmodified", "searchable": true, "sortable": true, "orderable": true },

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
                    $('#HrLeaveCancelDt_paginate').css("display", "block");
                } else {
                    $('#HrLeaveCancelDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrLeaveCancel', function (event) {
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
            methodname: "HrLeaveCancelNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "HrLeaveCancel/HrLeaveCancelNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveCancelNew').html('');
                $('#mcHrLeaveCancelNew').html(response);
                $('#modal-container-HrLeaveCancelNew').modal({backdrop: 'static',keyboard: false});
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



function HrLeaveCancelEdit(val) {
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
            methodname: "HrLeaveCancelEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "HrLeaveCancel/HrLeaveCancelEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveCancelEdit').html('');
                $('#mcHrLeaveCancelEdit').html(response);
                $('#modal-container-HrLeaveCancelEdit').modal({ backdrop: 'static', keyboard: false });
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



function HrLeaveCancelNew(val) {
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
            methodname: "HrLeaveCancelNew",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "HrLeaveCancel/HrLeaveCancelNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveCancelNew').html('');
                $('#mcHrLeaveCancelNew').html(response);
                $('#modal-container-HrLeaveCancelNew').modal({backdrop: 'static',keyboard: false});
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


function HrLeaveCancelDetail(val) {
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
            methodname: "HrLeaveCancelDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrLeaveCancel/HrLeaveCancelDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveCancelDetail').html('');
                $('#mcHrLeaveCancelDetail').html(response);
                $('#modal-container-HrLeaveCancelDetail').modal({backdrop: 'static',keyboard: false});
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


