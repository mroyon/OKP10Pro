

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

   // GetAllDataHrLeaveModification();
});

function GetAllDataHrLeaveModification(val) {
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
            methodname: "HrLeaveModificationTableData",
            currenturl: window.location.href,
            hrbasicid: val
        });
        
        $('#HrLeaveModificationDt').DataTable({
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
                "url": baseurl + "HrLeaveModification/HrLeaveModificationTableData",
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
                { "data": "modifiedleavedays", "searchable": true, "sortable": true, "orderable": true },

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
                    $('#HrLeaveModificationDt_paginate').css("display", "block");
                } else {
                    $('#HrLeaveModificationDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrLeaveModification', function (event) {
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
            methodname: "HrLeaveModificationNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "HrLeaveModification/HrLeaveModificationNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveModificationNew').html('');
                $('#mcHrLeaveModificationNew').html(response);
                $('#modal-container-HrLeaveModificationNew').modal({backdrop: 'static',keyboard: false});
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



function HrLeaveModificationEdit(val) {
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
            methodname: "HrLeaveModificationEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "HrLeaveModification/HrLeaveModificationEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveModificationEdit').html('');
                $('#mcHrLeaveModificationEdit').html(response);
                $('#modal-container-HrLeaveModificationEdit').modal({ backdrop: 'static', keyboard: false });
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



function HrLeaveModificationNew(val) {
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
            methodname: "HrLeaveModificationNew",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "HrLeaveModification/HrLeaveModificationNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveModificationNew').html('');
                $('#mcHrLeaveModificationNew').html(response);
                $('#modal-container-HrLeaveModificationNew').modal({backdrop: 'static',keyboard: false});
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


function HrLeaveModificationDetail(val) {
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
            methodname: "HrLeaveModificationDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrLeaveModification/HrLeaveModificationDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrLeaveModificationDetail').html('');
                $('#mcHrLeaveModificationDetail').html(response);
                $('#modal-container-HrLeaveModificationDetail').modal({backdrop: 'static',keyboard: false});
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


