

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


    if ($("#hddokpid").val() != "") {
        $("#okpid").val($("#hddokpid").val()).trigger('change');
        $("#okpid").prop("disabled", true);
    }
    $("#ddlYear").change(function () {
        GetAllDataTranCuttingPayExecute();
    });
    $("#okpid").change(function () {
        GetAllDataTranCuttingPayExecute();
    });
    $("#MonthID").change(function () {
        GetAllDataTranCuttingPayExecute();
    });

    GetAllDataTranCuttingPayExecute();
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

function GetAllDataTranCuttingPayExecute() {
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
            methodname: "TranCuttingPayExecuteTableData",
            currenturl: window.location.href,
            OkpID: $("#okpid").val(),
            MonthID: $("#MonthID").val(),
            Year: $("#ddlYear").val(),
        });
        
        $('#TranCuttingPayExecuteDt').DataTable({
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
                "url": baseurl + "TranCuttingPayExecute/TranCuttingPayExecuteTableData",
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
            
                { "data": "Year", "searchable": true, "sortable": true, "orderable": true },
                { "data": "month", "searchable": true, "sortable": true, "orderable": true },
                { "data": "ItemName", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "OkpName", "searchable": true, "sortable": true, "orderable": true },
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

               

                { "data": "IsApproved", "searchable": true, "sortable": true, "orderable": true },
                { "data": "strIsRollback", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#TranCuttingPayExecuteDt_paginate').css("display", "block");
                } else {
                    $('#TranCuttingPayExecuteDt_paginate').css("display", "none");
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


function TranCuttingPayExecuteEdit(val) {
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
            methodname: "TranCuttingPayExecuteEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "TranCuttingPayExecute/TranCuttingPayExecuteEdit",
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


