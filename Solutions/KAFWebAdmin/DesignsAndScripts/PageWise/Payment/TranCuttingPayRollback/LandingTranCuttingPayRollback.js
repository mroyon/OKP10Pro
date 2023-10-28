

//PN: FILE NAME: "Loadtran_cuttinginfo.js"
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

    $("#MonthID").change(function () {
        GetAllDataTranCuttingPayRollback();
    });

    $("#okpid").change(function () {
        GetAllDataTranCuttingPayRollback();
    });

    $("#ddlYear").change(function () {
        GetAllDataTranCuttingPayRollback();
    });
    $("#okpid").change(function () {
        GetAllDataTranCuttingPayRollback();
    });
    $("#PayAllceID").change(function () {
        GetAllDataTranCuttingPayRollback();
    });

    GetAllDataTranCuttingPayRollback();
});
function DownloadData(val, reporttype) {
    try {
        var searchText = "&reporttype=" + reporttype + "&primariid=" + val;

        var src = '../Reports/DownloadOtherReports.aspx?';
        //We can add parameters here
        src = src + searchText

        var iframe = '<iframe id="myReportFrame" width="100%" height="600px" scrolling="no" frameborder="0" src="' + src + '" allowfullscreen></iframe>';
        //  $("#divReport").html(iframe);

        $('#mcHrReport').html('');
        $('#mcHrReport').html(iframe);
        $('#modalcontainerReport').modal({ backdrop: 'static', keyboard: false });

    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}
function GetAllDataTranCuttingPayRollback() {
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
            methodname: "TranCuttingPayRollbackTableData",
            currenturl: window.location.href,
            OkpID: $("#okpid").val(),
            MonthID: $("#MonthID").val(),
            Year: $("#ddlYear").val(),
            PayAllceID: $("#PayAllceID").val()
        });
        
        $('#TranCuttingPayRollbackDt').DataTable({
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
                "url": baseurl + "TranCuttingPayRollback/TranCuttingPayRollbackTableData",
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
                { "data": "OkpName", "searchable": true, "sortable": true, "orderable": true },
                { "data": "Year", "searchable": true, "sortable": true, "orderable": true },
                { "data": "month", "searchable": true, "sortable": true, "orderable": true },
                { "data": "ItemName", "searchable": true, "sortable": true, "orderable": true },
               
                //{
                //    "data": "ProcessDate",
                //    "render": function (data, type, full, meta) {
                //        return datetoStr(data);
                //    }
                //},
                { "data": "Total", "searchable": true, "sortable": true, "orderable": true },
                { "data": "TotalPaid", "searchable": true, "sortable": true, "orderable": true },
                { "data": "TotalNotPaid", "searchable": true, "sortable": true, "orderable": true },
                { "data": "TotalPaidAmount", "searchable": true, "sortable": true, "orderable": true },

                //{ "data": "IsReviewed", "searchable": true, "sortable": true, "orderable": true },

                //{ "data": "IsApproved", "searchable": true, "sortable": true, "orderable": true },

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
                    $('#TranCuttingPayRollbackDt_paginate').css("display", "block");
                } else {
                    $('#TranCuttingPayRollbackDt_paginate').css("display", "none");
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


function TranCuttingPayRollbackEdit(val) {
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
            methodname: "TranCuttingPayRollbackEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "TranCuttingPayRollback/TranCuttingPayRollbackEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranTranCuttingInfoPaymentSubmit').html('');
                $('#mcTranTranCuttingInfoPaymentSubmit').html(response);
                $('#modal-container-TranCuttingInfoPaymentSubmit').modal({backdrop: 'static',keyboard: false});
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

function datetoStr(data) {
    if (data != null) {
        var regex = /-?\d+/;
        var match = regex.exec(data);
        var pubdate = new Date(parseInt(match[0]));

        var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
        var yyyy = pubdate.getFullYear(); if (dd < 10) { dd = '0' + dd } if (mm < 10) { mm = '0' + mm }
        var today = dd + '/' + mm + '/' + yyyy;
        return today;
    }
    else {
        return "";
    }
}


