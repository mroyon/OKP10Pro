

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
        //if ($("#hddokpid").val() == "16") {
        //    $("#btngovtcutting").html("Service Charge");
        //    $("#btnnewsc").attr("paymenttype", "5")
        //}
    }

    $("#MonthID").change(function () {
        GetAllDataTranCuttingInfo();
    });

    $("#ddlYear").change(function () {
        GetAllDataTranCuttingInfo();
    });
    $("#okpid").change(function () {
        GetAllDataTranCuttingInfo();
    });
    GetAllDataTranCuttingInfo();
});

function GetAllDataTranCuttingInfo() {
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
            methodname: "TranCuttingInfoTableData",
            currenturl: window.location.href,
            OkpID: $("#okpid").val(),
            MonthID: $("#MonthID").val(),
            Year: $("#ddlYear").val()

        });
        
        $('#TranCuttingInfoDt').DataTable({
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
                "url": baseurl + "TranCuttingInfo/TranCuttingInfoTableData",
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
                { "data": "OkpName", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "ProcessDate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                { "data": "ItemName", "searchable": true, "sortable": true, "orderable": true },

                { "data": "Total", "searchable": true, "sortable": true, "orderable": true },
               
                { "data": "strisreviewed", "searchable": true, "sortable": true, "orderable": true },
               

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
                    $('#TranCuttingInfoDt_paginate').css("display", "block");
                } else {
                    $('#TranCuttingInfoDt_paginate').css("display", "none");
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

$('body').on('click', '.btnNewTranCuttingInfo', function (event) {
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
            methodname: "TranCuttingInfoNew",
            currenturl: window.location.href,
            OkpID: $("#okpid").val(),
            MonthID: $("#MonthID").val(),
            Year: $("#ddlYear").val(),
            PayAllceID: $(this).attr("paymenttype")
        });
        
        $.ajax({
            url: baseurl + "TranCuttingInfo/TranCuttingInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranCuttingInfoNew').html('');
                $('#mcTranCuttingInfoNew').html(response);
                $('#modal-container-TranCuttingInfoNew').modal({backdrop: 'static',keyboard: false});
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



$('body').on('click', '#btnDeleteTranCuttingInfo', function (event) {
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
                    methodname: "TranCuttingInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "TranCuttingInfo/TranCuttingInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "TranCuttingInfo/TranCuttingInfo";
                                GetAllDataTranCuttingInfo();
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

function TranCuttingInfoEdit(val) {
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
            methodname: "TranCuttingInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "TranCuttingInfo/TranCuttingInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranCuttingInfoEdit').html('');
                $('#mcTranCuttingInfoEdit').html(response);
                $('#modal-container-TranCuttingInfoEdit').modal({backdrop: 'static',keyboard: false});
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

function TranCuttingInfoDelete(val) {
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
                    methodname: "TranCuttingInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "TranCuttingInfo/TranCuttingInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataTranCuttingInfo();
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

function TranCuttingInfoDetail(val) {
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
            methodname: "TranCuttingInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "TranCuttingInfo/TranCuttingInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcTranCuttingInfoDetail').html('');
                $('#mcTranCuttingInfoDetail').html(response);
                $('#modal-container-TranCuttingInfoDetail').modal({backdrop: 'static',keyboard: false});
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

