
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    GetAllWorkFlowProcessStatusData();
});

function datetoStr(data) {
    var regex = /-?\d+/;
    var match = regex.exec(data);
    var pubdate = new Date(parseInt(match[0]));

    var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
    var yyyy = pubdate.getFullYear(); if (dd < 10) { dd = '0' + dd } if (mm < 10) { mm = '0' + mm }
    var today = dd + '/' + mm + '/' + yyyy;
    return today;
}

function GetAllWorkFlowProcessStatusData() {
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
            methodname: "WorkFlowProcessStatusTableData",
            currenturl: window.location.href
        });
        $('#WorkFlowProcessStatusDt').DataTable({

            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true,
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
                "url": baseurl + "WorkFlow/WorkFlowProcessStatus/WorkFlowProcessStatusTableData",
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
                { "data": "statusname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "priority", "searchable": true, "sortable": true, "orderable": true },

                { "data": "type", "searchable": true, "sortable": true, "orderable": true },
                { "data": "applyforapproval", "searchable": true, "sortable": true, "orderable": true },
                { "data": "proceedtonextlevel", "searchable": true, "sortable": true, "orderable": true },
                { "data": "rollbacktocreator", "searchable": true, "sortable": true, "orderable": true },
                { "data": "closedtheprocess", "searchable": true, "sortable": true, "orderable": true },

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
                    $('#WorkFlowProcessStatusdt_paginate').css("display", "block");
                } else {
                    $('#WorkFlowProcessStatusdt_paginate').css("display", "none");
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
function EditWorkFlowProcessStatus(val) {
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
            methodname: "WorkFlowProcessStatusGet",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        $.ajax({
            url: baseurl + "WorkFlow/WorkFlowProcessStatus/WorkFlowProcessStatusUpdateGet",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowProcessStatuseditdatacontainer').html('');
                $('#WorkFlowProcessStatuseditdatacontainer').html(response);
                $('#modal-container-WorkFlowProcessStatusedit').modal("show");
            }
        });
        //window.location.href = baseurl + "CurrentActivity/CurrentActivityUpdate?input=" + val;

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}
function DeleteWorkFlowProcessStatus(val) {
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
                    methodname: "WorkFlowProcessStatusDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "WorkFlow/WorkFlowProcessStatus/WorkFlowProcessStatusDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#WorkFlowProcessStatusDt").DataTable().ajax.reload();
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
function WorkFlowProcessStatusDetails(val) {
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
            methodname: "WorkFlowProcessStatusDetails",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "WorkFlow/WorkFlowProcessStatus/WorkFlowProcessStatusDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowProcessStatusviewdatacontainer').html('');
                $('#WorkFlowProcessStatusviewdatacontainer').html(response);

                $('#modal-container-WorkFlowProcessStatusview').modal('show');
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

$('body').on('click', '#btnCreateWorkFlowProcessStatus', function (event) {
    try {
        event.preventDefault();
        window.location.href = baseurl + "WorkFlow/WorkFlowProcessStatus/WorkFlowProcessStatusCreate";
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

