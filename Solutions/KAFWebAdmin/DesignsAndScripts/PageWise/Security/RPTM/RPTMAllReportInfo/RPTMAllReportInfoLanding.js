
var dt = new Date();
var currYear = dt.getFullYear();
var nextYear = eval(currYear) + 10;
var baseurl = $('#txtBaseUrl').val();

function changeBtnState() {
    try {
        var st = $("#strValue2").val();
        if (st == "New") {
            $("#btnSaveRPTMAllReportInfo").removeClass("hidden");
            $("#btnUpdateRPTMAllReportInfo").addClass("hidden");
            $("#btnDeleteRPTMAllReportInfo").addClass("hidden");
        }
        else {
            $("#btnSaveRPTMAllReportInfo").addClass("hidden");
            $("#btnUpdateRPTMAllReportInfo").removeClass("hidden");
            $("#btnDeleteRPTMAllReportInfo").removeClass("hidden");
        }


    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

$(document).ready(function () {
    changeBtnState();

    GetAllDataRPTMAllReportInfo();
    //DONE

    $('body').on('click', '#btnCancelRPTMAllReportInfo', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "RPTMAllReportInfo/RPTMAllReportInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    //btnSave
    $('body').on('click', '#btnSaveRPTMAllReportInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmRPTMAllReportInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
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
                            methodname: "RPTMAllReportInfoInsert",
                            currenturl: window.location.href,
                            strModelPrimaryKey: $("#strModelPrimaryKey").val(),

                            reportid: -99,

                            modulename: $("#modulename option:selected").text(),
                            reportname: $('#reportname').val(),
                            reportnameeng: $('#reportnameeng').val(),
                            reporturl: $('#reporturl').val(),
                            reportspname: $('#reportspname').val(),
                            reportspnameeng: $('#reportspnameeng').val(),
                            reportdescription: $('#reportdescription').val(),

                        });


                        $.ajax({
                            url: baseurl + "RPTMAllReportInfo/RPTMAllReportInfoInsert",
                            type: 'POST',
                            data: input,
                            success: function (response) {
                                if (response.status == "success") {
                                    inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        window.location.href = baseurl + "RPTMAllReportInfo/RPTMAllReportInfo";
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
            }
            else {
                return;
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    //btnUpdate
    $('body').on('click', '#btnUpdateRPTMAllReportInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmRPTMAllReportInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
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
                            methodname: "RPTMAllReportInfoUpdate",
                            currenturl: window.location.href,
                            strModelPrimaryKey: $("#strModelPrimaryKey").val(),


                            reportid: $('#reportid').val(),
                            modulename: $("#modulename option:selected").text(),
                            reportname: $('#reportname').val(),
                            reportnameeng: $('#reportnameeng').val(),
                            reporturl: $('#reporturl').val(),
                            reportspname: $('#reportspname').val(),
                            reportspnameeng: $('#reportspnameeng').val(),
                            reportdescription: $('#reportdescription').val(),

                        });


                        $.ajax({
                            url: baseurl + "RPTMAllReportInfo/RPTMAllReportInfoUpdate",
                            type: 'POST',
                            data: input,
                            success: function (response) {
                                if (response.status == "success") {
                                    inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        window.location.href = baseurl + "RPTMAllReportInfo/RPTMAllReportInfo";
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
            }
            else {
                return;
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    //btnDelete
    $('body').on('click', '#btnDeleteRPTMAllReportInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmRPTMAllReportInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {
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
                            methodname: "RPTMAllReportInfoDelete",
                            currenturl: window.location.href,
                            strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                            reportid: $('#reportid ').val()
                        });


                        $.ajax({
                            url: baseurl + "RPTMAllReportInfo/RPTMAllReportInfoDelete",
                            data: input,
                            type: 'POST',
                            success: function (response) {
                                if (response.status == "success") {
                                    inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        window.location.href = baseurl + "RPTMAllReportInfo/RPTMAllReportInfo";
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
            }
            else {
                return;
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


    //DETAIL PART
    $('body').on('click', '#btnNewRPTMReportDataSource', function (event) {
        try {
            event.preventDefault();
            AddAntiForgeryToken = function (data) {
                data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                return data;
            };
            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "RPTMReportDataSourceNew",
                currenturl: window.location.href,
                strModelPrimaryKey: $("#strModelPrimaryKey").val() //sending primary key of master table.
            });

            $.ajax({
                url: baseurl + "RPTMAllReportInfo/RPTMReportDataSourceNew",
                type: 'POST',
                data: input,
                success: function (response) {
                    $('#mcRPTMReportDataSourceNew').html('');
                    $('#mcRPTMReportDataSourceNew').html(response);
                    $('#modal-container-RPTMReportDataSourceNew').modal({
                        backdrop: 'static',
                        keyboard: false
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

    //DETAIL PART
    $('body').on('click', '#btnNewRPTMReportParameter', function (event) {
        try {
            event.preventDefault();
            AddAntiForgeryToken = function (data) {
                data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                return data;
            };
            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "RPTMReportParameterNew",
                currenturl: window.location.href,
                strModelPrimaryKey: $("#strModelPrimaryKey").val() //sending primary key of master table.
            });

            $.ajax({
                url: baseurl + "RPTMAllReportInfo/RPTMReportParameterNew",
                type: 'POST',
                data: input,
                success: function (response) {
                    $('#mcRPTMReportParameterNew').html('');
                    $('#mcRPTMReportParameterNew').html(response);
                    $('#modal-container-RPTMReportParameterNew').modal({
                        backdrop: 'static',
                        keyboard: false
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
});

//LOAD MASTER DATA
function GetAllDataRPTMAllReportInfo() {

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
            methodname: "RPTMAllReportInfoData",
            currenturl: window.location.href
        });

        $('#RPTMAllReportInfoDt').DataTable({
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true,
            }],
            "language": {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "ajax": {
                "url": baseurl + "RPTMAllReportInfo/RPTMAllReportInfoTableData",
                "type": "POST",
                "data": input

            },


            "columns": [
                //{ "data": "reportid", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportname", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "reportnameeng", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reporturl", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportspname", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "reportspnameeng", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportdescription", "searchable": true, "sortable": true, "orderable": true },

                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ]
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

//Select from MASTER TABLE
function EditRPTMAllReportInfo(val) {
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
            methodname: "RPTMAllReportInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "RPTMAllReportInfo/RPTMAllReportInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {

                var res = response.data;
                if (res != null) {

                    Cleardata();
                    $("#strModelPrimaryKey").val(res.strModelPrimaryKey);

                    $("#reportid").val(res.reportid);

                    //console.log(res.modulename);
                    $("#modulename option:contains(" + res.modulename + ")").attr('selected', 'selected');


                    $("#reportname").val(res.reportname);
                    $("#reportnameeng").val(res.reportnameeng);
                    $("#reporturl").val(res.reporturl);
                    $("#reportspname").val(res.reportspname);
                    $("#reportspnameeng").val(res.reportspnameeng);
                    $("#reportdescription").val(res.reportdescription);

                    LoadDetailData(res.strModelPrimaryKey);
                    LoadRPTMReportParameterData(res.strModelPrimaryKey);
                    $("#strValue2").val("Old");
                    changeBtnState();
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
// Delete from Master Table
function DeleteRPTMAllReportInfo(val) {
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
                    methodname: "RPTMAllReportInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val,
                    reportid: -99
                });


                $.ajax({
                    url: baseurl + "RPTMAllReportInfo/RPTMAllReportInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                window.location.href = baseurl + "RPTMAllReportInfo/RPTMAllReportInfo";
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

//Clear Master Form
function Cleardata() {

    //$("#modulename").html("");

    $("#reportid").val('');
    $("#reportname").val('');
    $("#reportnameeng").val('');
    $("#reporturl").val('');
    $("#reportspname").val('');
    $("#reportspnameeng").val('');
    $("#reportdescription").val('');

}


// Load Detail Data by Master key
function LoadDetailData(val) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        $('#RPTMReportDataSourceDt').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true,
            }],
            "language": {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "ajax": {
                "url": baseurl + "RPTMAllReportInfo/RPTMReportDataSourceTableData",
                "type": "POST",
                "data": {
                    __RequestVerificationToken: $('input[name=__RequestVerificationToken]').val(),
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "RPTMReportDataSourceTableData",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val()
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: jqXHR.responseJSON.Error,
                    type: 'red'
                });
            },
            "columns": [
                //{ "data": "reportdatasourceid", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "reportid", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportdatasourcename", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportdatasourcespname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportdatasourcedescription", "searchable": true, "sortable": true, "orderable": true },

                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ]
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

// Edit Detail data by detail key
function RPTMReportDataSourceEdit(val) {
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
            methodname: "RPTMReportDataSourceEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val // sending detail primary key

        });

        $.ajax({
            url: baseurl + "RPTMAllReportInfo/RPTMReportDataSourceEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcRPTMReportDataSourceEdit').html('');
                $('#mcRPTMReportDataSourceEdit').html(response);
                $('#modal-container-RPTMReportDataSourceEdit').modal({
                    backdrop: 'static',
                    keyboard: false
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

// delete Detail data by detail key
function RPTMReportDataSourceDelete(val) {
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
            methodname: "GenLeaveBalanceDetlNew",
            currenturl: window.location.href,
            strModelPrimaryKey: val // sending detail primary key

        });

        confirmationDialog(_getCookieForLanguage("_confirmationTitle"),
            _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {

                    $.ajax({
                        url: baseurl + "RPTMAllReportInfo/RPTMReportDataSourceDelete",
                        data: input,
                        type: 'POST',
                        success: function (data) {
                            if (data.status === "success") {
                                inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    $('#mcRPTMReportDataSourceEdit').html('');
                                    $('#modal-container-RPTMReportDataSourceEdit').modal('hide');
                                    LoadDetailData(data.prikey);
                                });
                            }
                        }
                    });
                }
                else {
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



// Load Detail Data by Master key
function LoadRPTMReportParameterData(val) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        $('#RPTMReportParameterDt').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true
            }],
            "language": {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "ajax": {
                "url": baseurl + "RPTMAllReportInfo/RPTMReportParameterTableData",
                "type": "POST",
                "data": {
                    __RequestVerificationToken: $('input[name=__RequestVerificationToken]').val(),
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "RPTMReportParameterTableData",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val()
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: jqXHR.responseJSON.Error,
                    type: 'red'
                });
            },
            "columns": [
                //{ "data": "reportdatasourceid", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "reportid", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportparamname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportparamdatatype", "searchable": true, "sortable": true, "orderable": true },
                { "data": "reportparamdescription", "searchable": true, "sortable": true, "orderable": true },

                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ]
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}
// Edit Detail data by detail key
function RPTMReportParameterEdit(val) {
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
            methodname: "RPTMReportParameterEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val // sending detail primary key

        });

        $.ajax({
            url: baseurl + "RPTMAllReportInfo/RPTMReportParameterEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcRPTMReportParameterEdit').html('');
                $('#mcRPTMReportParameterEdit').html(response);
                $('#modal-container-RPTMReportParameterEdit').modal({
                    backdrop: 'static',
                    keyboard: false
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
// delete Detail data by detail key
function RPTMReportParameterDelete(val) {
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
            methodname: "RPTMReportParameterDelete",
            currenturl: window.location.href,
            strModelPrimaryKey: val // sending detail primary key

        });

        confirmationDialog(_getCookieForLanguage("_confirmationTitle"),
            _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {

                    $.ajax({
                        url: baseurl + "RPTMAllReportInfo/RPTMReportParameterDelete",
                        data: input,
                        type: 'POST',
                        success: function (data) {
                            if (data.status === "success") {
                                inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                    $('#mcRPTMReportParameterEdit').html('');
                                    $('#modal-container-RPTMReportParameterEdit').modal('hide');
                                    LoadRPTMReportParameterData(data.prikey);
                                });
                            }
                        }
                    });
                }
                else {
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
    var regex = /-?\d+/;
    var match = regex.exec(data);
    var pubdate = new Date(parseInt(match[0]));

    var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
    var yyyy = pubdate.getFullYear(); if (dd < 10) { dd = '0' + dd } if (mm < 10) { mm = '0' + mm }
    var today = dd + '/' + mm + '/' + yyyy;
    return today;
}

