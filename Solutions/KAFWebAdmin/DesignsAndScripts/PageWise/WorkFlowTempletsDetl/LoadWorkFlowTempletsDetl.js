
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    GetAllWorkFlowTempletsDetlData();
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

function GetAllWorkFlowTempletsDetlData() {
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
            methodname: "WorkFlowTempletsDetlTableData",
            currenturl: window.location.href
        });
        $('#WorkFlowTempletsDetlDt').DataTable({

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
                "url": baseurl + "WorkFlowTempletsDetl/WorkFlowTempletsDetlTableData",
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
                                                      { "data": "templetdetlguid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "templetid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "levelid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "levelno", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "statusid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "infoprevonly", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "infoprevall", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "infooriginator", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "approvaltype", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "isfinallevel", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "approvebyparent", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "approvebyoriginator", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "notifyifpendingforlong", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "notifyafterdays", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "notifytouser", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "emailtempletsid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "emailapprovalonly", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "emailtoall", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "smstempletsid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "smstoapprovalonly", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "smstoall", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "nextlevelid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "remarks", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#WorkFlowTempletsDetldt_paginate').css("display", "block");
                } else {
                    $('#WorkFlowTempletsDetldt_paginate').css("display", "none");
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
function EditWorkFlowTempletsDetl(val) {
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
            methodname: "WorkFlowTempletsDetlGet",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        $.ajax({
            url: baseurl + "WorkFlowTempletsDetl/WorkFlowTempletsDetlUpdateGet",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTempletsDetleditdatacontainer').html('');
                $('#WorkFlowTempletsDetleditdatacontainer').html(response);
                $('#modal-container-WorkFlowTempletsDetledit').modal("show");
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
function DeleteWorkFlowTempletsDetl(val) {
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
                    methodname: "WorkFlowTempletsDetlDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "WorkFlowTempletsDetl/WorkFlowTempletsDetlDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#WorkFlowTempletsDetlDt").DataTable().ajax.reload();
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
function WorkFlowTempletsDetlDetails(val) {
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
            methodname: "WorkFlowTempletsDetlDetails",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/WorkFlowTempletsDetl/WorkFlowTempletsDetlDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTempletsDetlviewdatacontainer').html('');
                $('#WorkFlowTempletsDetlviewdatacontainer').html(response);

                $('#modal-container-WorkFlowTempletsDetlview').modal('show');
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

$('body').on('click', '#btnCreateWorkFlowTempletsDetl', function (event) {
    try {
        event.preventDefault();
        window.location.href = baseurl + "WorkFlowTempletsDetl/WorkFlowTempletsDetlCreate";
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
	
	