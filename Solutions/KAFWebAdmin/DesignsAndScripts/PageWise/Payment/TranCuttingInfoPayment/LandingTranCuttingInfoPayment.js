

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

    //if ($("#OkpID").val() == 16) {
    //    $("#DrpPAyType option[value=3]").remove();
    //}
    //else {
    //    $("#DrpPAyType option[value=5]").remove();
    //}

    $("#MonthID").change(function () {
        GetAllDataTranCuttingInfoPayment();
    });

    $("#ddlYear").change(function () {
        GetAllDataTranCuttingInfoPayment();
    });
    $("#okpid").change(function () {
        GetAllDataTranCuttingInfoPayment();
    });

    GetAllDataTranCuttingInfoPayment();
});

function GetAllDataTranCuttingInfoPayment() {
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
            methodname: "TranCuttingInfoPaymentTableData",
            currenturl: window.location.href,
            OkpID: $("#okpid").val(),
            MonthID: $("#MonthID").val(),
            Year: $("#ddlYear").val()
        });
        
        $('#TranCuttingInfoPaymentDt').DataTable({
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
                "url": baseurl + "TranCuttingInfoPayment/TranCuttingInfoPaymentTableData",
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
                
                { "data": "strIsApproved", "searchable": true, "sortable": true, "orderable": true },
               

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
                    $('#TranCuttingInfoPaymentDt_paginate').css("display", "block");
                } else {
                    $('#TranCuttingInfoPaymentDt_paginate').css("display", "none");
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

function TranCuttingInfoPaymentEdit(val,btn) {
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
            methodname: "TranCuttingInfoPaymentEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "TranCuttingInfoPayment/TranCuttingInfoPaymentEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranCuttingInfoPaymentEdit').html('');
                $('#mcTranCuttingInfoPaymentEdit').html(response);

                $("#TranCuttingInfoPaymentDetailDt tr").css("border-color", "green");
                $(btn).parent().parent().parent().css("border-color", "green");

                $('#modal-container-TranCuttingInfoPaymentEdit').modal({backdrop: 'static',keyboard: false});
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

function TranCuttingInfoPaymentSubmitNew(val) {
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
            methodname: "TranCuttingInfoPaymentSubmitNew",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "TranCuttingInfoPayment/TranCuttingInfoPaymentSubmitNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranCuttingInfoPaymentSubmitNew').html('');
                $('#mcTranCuttingInfoPaymentSubmitNew').html(response);
                $('#modal-container-TranCuttingInfoPaymentSubmitNew').modal({ backdrop: 'static', keyboard: false });
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

function TranCuttingInfoPaymentDetail(val) {
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
            methodname: "TranCuttingInfoPaymentDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "TranCuttingInfoPayment/TranCuttingInfoPaymentDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranCuttingInfoPaymentDetail').html('');
                $('#mcTranCuttingInfoPaymentDetail').html(response);
                $('#modal-container-TranCuttingInfoPaymentDetail').modal({backdrop: 'static',keyboard: false});
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

