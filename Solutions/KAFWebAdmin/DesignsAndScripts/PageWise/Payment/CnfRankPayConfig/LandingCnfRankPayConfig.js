

//PN: FILE NAME: "Loadcnf_rankpayconfig.js"
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

    $("#drpPayAllceID").change(function () {
        GetAllDataCnfRankPayConfig();
    });

   
});

function GetAllDataCnfRankPayConfig() {
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
            methodname: "CnfRankPayConfigTableData",
            currenturl: window.location.href,
            payallceid: $("#drpPayAllceID").val()
        });

        $('#CnfRankPayConfigDt').DataTable({
            "destroy": true,
            "bPaginate": false,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": false,
                "orderable": false
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
                "url": baseurl + "CnfRankPayConfig/CnfRankPayConfigTableData",
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

                { "data": "strpaymentitem", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "strdrpgroup",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                },
                { "data": "strrank", "searchable": true, "sortable": true, "orderable": true },
               
               
                {
                    "data": "txtgovtcutting",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                },
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
                    $('#CnfRankPayConfigDt_paginate').css("display", "block");
                } else {
                    $('#CnfRankPayConfigDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewCnfRankPayConfig', function (event) {

    if ($("#drpPayAllceID").val() == "") {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: "Please Select Payment Type",
            type: 'red'
        });
        return;
    }

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
            methodname: "CnfRankPayConfigNew",
            currenturl: window.location.href,
            payallceid: $("#drpPayAllceID").val()
        });

        $.ajax({
            url: baseurl + "CnfRankPayConfig/CnfRankPayConfigNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcCnfRankPayConfigNew').html('');
                $('#mcCnfRankPayConfigNew').html(response);
                $('#modal-container-CnfRankPayConfigNew').modal({ backdrop: 'static', keyboard: false });
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



$('body').on('click', '#btnDeleteCnfRankPayConfig', function (event) {
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
                    methodname: "CnfRankPayConfigDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "CnfRankPayConfig/CnfRankPayConfigDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "CnfRankPayConfig/CnfRankPayConfig";
                                GetAllDataCnfRankPayConfig();
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



function CnfRankPayConfigEdit(val, cntl) {
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
            methodname: "CnfRankPayConfigEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,

            //basicsalary: $(cntl).parent().parent().parent().find('.txtbasicsalary').val(),
            //regimentalcutting: $(cntl).parent().parent().parent().find('.txtregcutting').val(),
            payconfigid: $(cntl).parent().parent().parent().find('.txtgovtcutting').attr('payconfigid'),
            groupid: $(cntl).parent().parent().parent().find('.groupid').val(),
            govtcutting: $(cntl).parent().parent().parent().find('.txtgovtcutting').val(),
        });

        $.ajax({
            url: baseurl + "CnfRankPayConfig/CnfRankPayConfigUpdate",
            type: 'POST',
            data: input,
            success: function (data) {


                if (data.status === "success") {
                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                        if (answer == "true") {

                            GetAllDataCnfRankPayConfig();
                        }

                    });

                }

                else {
                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                        if (answer == "true") {


                        }

                    });
                }
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

function CnfRankPayConfigDelete(val) {
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
                    methodname: "CnfRankPayConfigDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "CnfRankPayConfig/CnfRankPayConfigDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataCnfRankPayConfig();
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

function CnfRankPayConfigDetail(val) {
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
            methodname: "CnfRankPayConfigDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "CnfRankPayConfig/CnfRankPayConfigDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcCnfRankPayConfigDetail').html('');
                $('#mcCnfRankPayConfigDetail').html(response);
                $('#modal-container-CnfRankPayConfigDetail').modal({ backdrop: 'static', keyboard: false });
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


